using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DRGSS
{
    public class SubFile
    {
        public UInt32 filename_size;
        public string filename;
        public long offset;
        public UInt32 file_size;
        public UInt32 magickey;
    }

    public class Decrypter
    {
        [DllImport("kernel32.dll")]
        private static extern int MultiByteToWideChar(
            uint CodePage,
            uint dwFlags,
            [MarshalAs(UnmanagedType.LPArray)] Byte[] lpMultiByteStr,
            int cbMultiByte,
            [Out, MarshalAs(UnmanagedType.LPArray)] Byte[] lpWideCharStr,
            int cchWideChar
        );
        [DllImport("kernel32.dll")]
        private static extern int WideCharToMultiByte(
            uint CodePage,
            uint dwFlags,
            byte[] lpWideCharStr,
            int cchWideChar,
            byte[] lpMultiByteStr,
            int cbMultiByte,
            string lpDefaultChar,
            bool lpUsedDefaultChar
        );


        public string file;
        public string destpath;
        public UInt32 magickey;
        public bool not_overwrite;
        private BinaryReader rgssfile;
        private List<SubFile> subfiles;
        private int file_index;

        private string Slasher(string istr)
        {
            string ostr = "";
            for (int i = 0; i < istr.Length; i++)
            {
                if (istr[i] == '/')
                    ostr += '\\';
                else
                    ostr += istr[i];
            }
            return ostr;
        }

        public Decrypter(string ifile, string idestpath) {
            file = Slasher(ifile);
            destpath = Slasher(idestpath);
            if (!destpath.EndsWith("\\"))
            {
                destpath += '\\';
            }
            magickey = 0xDEADCAFE;
            subfiles = new List<SubFile>();
            file_index = 0;
            not_overwrite = false;
        }

        public int Start() {
            rgssfile = new BinaryReader(File.Open(file, FileMode.Open));

            if (rgssfile.ReadInt32() != 0x53534752 || rgssfile.ReadInt32() != 0x01004441)
                return -1;

            while (rgssfile.BaseStream.Position < rgssfile.BaseStream.Length)
	        {
                SubFile temp_subfile;
                temp_subfile = new SubFile();
                temp_subfile.filename_size = rgssfile.ReadUInt32();
		        temp_subfile.filename_size ^= magickey;
		        magickey = magickey * 7 + 3;
		        byte[] filename = rgssfile.ReadBytes((int)temp_subfile.filename_size);
                int i;
                for (i = 0; i < temp_subfile.filename_size; i++)
		        {
                    filename[i] ^= (byte)(magickey & 0xFF);
			        magickey = magickey * 7 + 3;
                }
                byte[] tmp_filename = new byte[256];
                MultiByteToWideChar(65001, 0, filename, -1, tmp_filename, 256);

                temp_subfile.filename = System.Text.Encoding.Unicode.GetString(tmp_filename).TrimEnd('\0');
		        temp_subfile.file_size = rgssfile.ReadUInt32();
		        temp_subfile.file_size ^= magickey;
		        magickey = magickey * 7 + 3;
		        temp_subfile.offset = rgssfile.BaseStream.Position;
		        temp_subfile.magickey = magickey;

		        subfiles.Add(temp_subfile);
                rgssfile.BaseStream.Seek((Int64)temp_subfile.file_size, SeekOrigin.Current);
	        }

            return subfiles.Count;
        }

        private void MakePath(string path)
        {
            string dir = "";
            for (int i = 0; i < path.Length; i++)
            {
                dir += path[i];
                if (path[i] == '\\')
                    Directory.CreateDirectory(dir);
            }
        }

        public string Advance()
        {
            SubFile subfile = subfiles[file_index++];

            MakePath(destpath + subfile.filename);

            if (not_overwrite && File.Exists(destpath + subfile.filename)) return "";

            BinaryWriter file = new BinaryWriter(File.Create(destpath + subfile.filename));

            rgssfile.BaseStream.Seek(subfile.offset, SeekOrigin.Begin);
            magickey = subfile.magickey;
            long leftsize = subfile.file_size;
            int i = 0;
            int bufsize;

            byte[] buffer;
            while (leftsize > 0)
            {
                bufsize = leftsize > 1023 ? 1024 : (int)leftsize;
                buffer = rgssfile.ReadBytes(bufsize);
                for(i = 0; i < bufsize; i += 4)
                {
                    byte[] keybytes = BitConverter.GetBytes(magickey);
                    buffer[i] ^= keybytes[0];
                    if (i + 1 < bufsize) buffer[i + 1] ^= keybytes[1];
                    if (i + 2 < bufsize) buffer[i + 2] ^= keybytes[2];
                    if (i + 3 < bufsize) buffer[i + 3] ^= keybytes[3];
                    magickey = magickey * 7 + 3;
                }
                file.Write(buffer, 0, bufsize);
                leftsize -= bufsize;
            }

            file.Close();

            return "File " + subfile.filename + " extracted";
        }

        public void End()
        {
            rgssfile.Close();
        }
    }
}
