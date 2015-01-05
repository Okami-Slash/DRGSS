using System;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace DRGSS
{
    class Encrypter
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
        public string projfolder;
        public UInt32 magickey;
        public bool not_overwrite;
        private BinaryWriter rgssfile;
        private List<string> files;
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

        // Source for this function from: http://mrpmorris.blogspot.com/2007/05/convert-absolute-path-to-relative-path.html
        private string RelativePath(string absolutePath, string relativeTo)
        {
            string[] absoluteDirectories = absolutePath.Split('\\');
            string[] relativeDirectories = relativeTo.Split('\\');

            int length = absoluteDirectories.Length < relativeDirectories.Length ? absoluteDirectories.Length : relativeDirectories.Length;

            int lastCommonRoot = -1;
            int index;

            for (index = 0; index < length; index++)
                if (absoluteDirectories[index] == relativeDirectories[index])
                    lastCommonRoot = index;
                else
                    break;

            if (lastCommonRoot == -1)
                throw new ArgumentException("Paths do not have a common base");

            StringBuilder relativePath = new StringBuilder();

            for (index = lastCommonRoot + 1; index < absoluteDirectories.Length; index++)
                if (absoluteDirectories[index].Length > 0)
                    relativePath.Append("..\\");

            for (index = lastCommonRoot + 1; index < relativeDirectories.Length - 1; index++)
                relativePath.Append(relativeDirectories[index] + "\\");
            relativePath.Append(relativeDirectories[relativeDirectories.Length - 1]);

            return relativePath.ToString();
        }

        public Encrypter(string ifile, string iprojfolder, List<string> ifiles)
        {
            file = Slasher(ifile);
            files = ifiles;
            magickey = 0xDEADCAFE;
            projfolder = iprojfolder;
            file_index = 0;
        }

        public void Start()
        {
            rgssfile = new BinaryWriter(File.OpenWrite(file));

            rgssfile.Write((int)0x53534752);
            rgssfile.Write((int)0x01004441);
        }

        public string Advance()
        {
            string subfile = RelativePath(projfolder, files[file_index]);
            byte[] subfile_bytes = System.Text.Encoding.UTF8.GetBytes(subfile);

            rgssfile.Write((UInt32)subfile_bytes.Length ^ magickey);
            magickey = magickey * 7 + 3;
            int i = 0;
            for (i = 0; i < subfile_bytes.Length; i++)
            {
                rgssfile.Write((byte)(subfile_bytes[i] ^ (magickey & 0xFF)));
                magickey = magickey * 7 + 3;
            }
            BinaryReader rfile = new BinaryReader(File.Open(files[file_index], FileMode.Open));

            rgssfile.Write((UInt32)rfile.BaseStream.Length ^ magickey);
            magickey = magickey * 7 + 3;

            UInt32 temp_magickey = magickey;

            long leftsize = rfile.BaseStream.Length;
            int bufsize;
            i = 0;

            byte[] buffer;
            while (leftsize > 0)
            {
                bufsize = leftsize > 1023 ? 1024 : (int)leftsize;
                buffer = rfile.ReadBytes(bufsize);
                for (i = 0; i < bufsize; i += 4)
                {
                    byte[] keybytes = BitConverter.GetBytes(magickey);
                    buffer[i] ^= keybytes[0];
                    if (i + 1 < bufsize) buffer[i + 1] ^= keybytes[1];
                    if (i + 2 < bufsize) buffer[i + 2] ^= keybytes[2];
                    if (i + 3 < bufsize) buffer[i + 3] ^= keybytes[3];
                    magickey = magickey * 7 + 3;
                }
                rgssfile.Write(buffer, 0, bufsize);
                leftsize -= bufsize;
            }

            magickey = temp_magickey;

            rfile.Close();

            file_index += 1;

            return "File " + subfile + " encrypted";
        }

        public void End()
        {
            rgssfile.Close();
        }
    }
}
