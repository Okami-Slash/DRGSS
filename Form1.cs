using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DRGSS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private bool CheckHex(string hex)
        {
            UInt32 output;
            return UInt32.TryParse(hex, System.Globalization.NumberStyles.HexNumber, null, out output);
        }

        private UInt32 GetHex(string hex)
        {
            return UInt32.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }

        private void textBoxMagicKey_TextChanged(object sender, EventArgs e)
        {
            CheckStartEnabled();
            CheckBatchStartEnabled();
        }

        ///////////////////////////////////////////////////////////////////////
        /// Normal Decrypt
        ///////////////////////////////////////////////////////////////////////

        private void AddLog(string txt)
        {
            textBoxLog.AppendText(txt + Environment.NewLine);
        }

        private void ClearLog()
        {
            textBoxLog.ResetText();
        }

        private void CheckStartEnabled()
        {
            buttonStart.Enabled = File.Exists(textBoxFile.Text) && Directory.Exists(textBoxFolder.Text) && CheckHex(textBoxMagicKey.Text);
        }

        private void buttonBrowseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "RGSSAD/2A files(*.rgssad; *.rgss2a)|*.rgssad; *.rgss2a";
            dialog.Title = "Sélectionner un fichier";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFile.Text = dialog.FileName;
                textBoxFolder.Text = Path.GetDirectoryName(dialog.FileName);
            }
        }

        private void buttonBrowseFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxFolder.Text = dialog.SelectedPath;
            }
        }

        private void textBoxFile_TextChanged(object sender, EventArgs e)
        {
            CheckStartEnabled();
        }

        private void textBoxFolder_TextChanged(object sender, EventArgs e)
        {
            CheckStartEnabled();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Decrypter decrypter = new Decrypter(textBoxFile.Text, textBoxFolder.Text);
            decrypter.magickey = GetHex(textBoxMagicKey.Text);
            decrypter.not_overwrite = !checkBoxOverwrite.Checked;

            progressBarFile.Value = 0;
            ClearLog();
            AddLog("Vérification");
            int files = decrypter.Start();

            if (files == -1)
            {
                decrypter.End();
                MessageBox.Show("RGSSAD/2A Invalide");
                AddLog("RGSSAD/2A Invalide");
                AddLog("Décryptage stopper");
                buttonStart.Enabled = false;
                return;
            }

            AddLog("Fichier Correcte. Total:" + files.ToString());

            progressBarFile.Maximum = files;

            string str;

            for (int i = 0; i < files; i++)
            {
                str = decrypter.Advance();
                if (str.Length > 0) AddLog(str);
                progressBarFile.Increment(1);
            }

            decrypter.End();

            if (checkBoxProject.Checked)
            {
                string project_name = "Game.";
                string project_cont;
                if (textBoxFile.Text.EndsWith(".rgssad"))
                {
                    project_name += "rxproj";
                    project_cont = "RPGXP 1.00";
                }
                else
                {
                    project_name += "rvproj";
                    project_cont = "RPGVX 1.00";
                }

                BinaryWriter file = new BinaryWriter(File.Create(decrypter.destpath + project_name));
                file.Write(project_cont.ToCharArray());
                file.Close();

                AddLog("Créer un projet " + project_name);
            }

            if (checkBoxLog.Checked)
            {
                StreamWriter file;
                if (File.Exists(decrypter.destpath + "DRGSS.log"))
                    file = File.AppendText(decrypter.destpath + "DRGSS.log");
                else
                    file = File.CreateText(decrypter.destpath + "DRGSS.log");
                file.Write(textBoxLog.Text);
                file.Close();
            }
        }

        ///////////////////////////////////////////////////////////////////////
        /// Batch Decrypt
        ///////////////////////////////////////////////////////////////////////

        private void AddBatchLog(string txt)
        {
            textBoxBatchLog.AppendText(txt + Environment.NewLine);
        }

        private void ClearBatchLog()
        {
            textBoxBatchLog.ResetText();
        }

        private void CheckBatchStartEnabled()
        {
            buttonBatchStart.Enabled = listBoxBatch.Items.Count > 0 && (!checkBoxBatchPath.Checked || Directory.Exists(textBoxBatchPath.Text)) && CheckHex(textBoxMagicKey.Text);
        }

        private void buttonBatchBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "RGSSAD/2A files(*.rgssad; *.rgss2a)|*.rgssad; *.rgss2a";
            dialog.Title = "Sélectionner un fichier";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    listBoxBatch.Items.Add(dialog.FileNames[i]);
                }
            }
            CheckBatchStartEnabled();
        }

        private void textBoxBatchPath_TextChanged(object sender, EventArgs e)
        {
            CheckBatchStartEnabled();
        }

        private void buttonBatchDelete_Click(object sender, EventArgs e)
        {
            listBoxBatch.Items.RemoveAt(listBoxBatch.SelectedIndex);
        }

        private void listBoxBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonBatchDelete.Enabled = listBoxBatch.SelectedIndex > -1;
        }

        private void checkBoxBatchPath_CheckedChanged(object sender, EventArgs e)
        {
            textBoxBatchPath.Enabled = checkBoxBatchPath.Checked;
            buttonBatchPathBrowse.Enabled = checkBoxBatchPath.Checked;
            CheckBatchStartEnabled();
        }

        private void buttonBatchPathBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxBatchPath.Text = dialog.SelectedPath;
            }
        }

        private void buttonBatchStart_Click(object sender, EventArgs e)
        {
            ClearBatchLog();
            AddBatchLog("Décryptage Batch. Actions: " + listBoxBatch.Items.Count.ToString());
            for (int i = 0; i < listBoxBatch.Items.Count; i++)
            {
                string path = "";
                if (checkBoxBatchPath.Checked)
                    path = textBoxBatchPath.Text;
                else
                    path = Path.GetDirectoryName(listBoxBatch.Items[i].ToString());

                if (checkBoxBatchSubfolders.Checked)
                    path += "\\" + Path.GetFileName(listBoxBatch.Items[i].ToString()) + " DRGSS";

                Decrypter decrypter = new Decrypter(listBoxBatch.Items[i].ToString(), path);
                decrypter.magickey = GetHex(textBoxMagicKey.Text);
                decrypter.not_overwrite = !checkBoxBatchOverwrite.Checked;

                progressBarBatch.Value = 0;
                AddBatchLog("");
                AddBatchLog("");
                AddBatchLog("Checking file " + listBoxBatch.Items[i].ToString());
                int files = decrypter.Start();

                if (files == -1)
                {
                    decrypter.End();
                    AddBatchLog("RGSSAD/2A Invalide");
                    AddBatchLog("Fichier Ignoré");
                    AddBatchLog("");
                    continue;
                }

                AddBatchLog("Fichier Correcte. Total:" + files.ToString());

                progressBarBatch.Maximum = files;

                string str;

                for (int j = 0; j < files; j++)
                {
                    str = decrypter.Advance();
                    if (str.Length > 0) AddBatchLog(str);
                    progressBarBatch.Increment(1);
                }

                decrypter.End();

                if (checkBoxBatchProject.Checked)
                {
                    string project_name = "Game.";
                    string project_cont;
                    if (textBoxFile.Text.EndsWith(".rgssad"))
                    {
                        project_name += "rxproj";
                        project_cont = "RPGXP 1.00";
                    }
                    else
                    {
                        project_name += "rvproj";
                        project_cont = "RPGVX 1.00";
                    }

                    BinaryWriter file = new BinaryWriter(File.Create(decrypter.destpath + project_name));
                    file.Write(project_cont.ToCharArray());
                    file.Close();

                    AddBatchLog("Créer un projet " + project_name);
                }

                if (checkBoxBatchLog.Checked)
                {
                    StreamWriter file;
                    if (File.Exists(decrypter.destpath + "DRGSS.log"))
                        file = File.AppendText(decrypter.destpath + "DRGSS.log");
                    else
                        file = File.CreateText(decrypter.destpath + "DRGSS.log");
                    file.Write(textBoxBatchLog.Text);
                    file.Close();
                }
            }
        }

        ///////////////////////////////////////////////////////////////////////
        /// Encrypt
        ///////////////////////////////////////////////////////////////////////

        private void AddEncryptLog(string txt)
        {
            textBoxEncryptLog.AppendText(txt + Environment.NewLine);
        }

        private void ClearEncryptLog()
        {
            textBoxEncryptLog.ResetText();
        }

        private void CheckEncryptStartEnabled()
        {
            bool flag = false;
            if (textBoxEncryptOutput.Text.Length > 0)
                flag = Directory.Exists(Path.GetDirectoryName(textBoxEncryptOutput.Text));
            buttonEncryptStart.Enabled = listBoxEncryptFiles.Items.Count > 0 && File.Exists(textBoxEncryptProj.Text) && flag && CheckHex(textBoxMagicKey.Text);
        }

        private void textBoxEncryptProj_TextChanged(object sender, EventArgs e)
        {
            CheckEncryptStartEnabled();
        }

        private void textBoxEncryptOutput_TextChanged(object sender, EventArgs e)
        {
            CheckEncryptStartEnabled();
        }

        private void buttonEncryptProj_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "RPG Maker XP/VX project files(*.rxproj; *.rvproj)|*.rxproj; *.rvproj";
            dialog.Title = "Sélectionner un fichier";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEncryptProj.Text = dialog.FileName;
                CheckBatchStartEnabled();

                if (listBoxEncryptFiles.Items.Count == 0)
                    AddEncryptFiles(Path.GetDirectoryName(dialog.FileName) + "\\Data");
                    AddEncryptFiles(Path.GetDirectoryName(dialog.FileName) + "\\Graphics");

                if (textBoxEncryptOutput.Text.Length == 0)
                {
                    textBoxEncryptOutput.Text = Path.GetDirectoryName(dialog.FileName);
                    if (textBoxEncryptProj.Text.EndsWith(".rxproj"))
                        textBoxEncryptOutput.Text += "\\Game.rgssad";
                    else
                        textBoxEncryptOutput.Text += "\\Game.rgss2a";
                }
            }
        }

        private void buttonEncryptOutput_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "RGSSAD/2A files(*.rgssad; *.rgss2a)|*.rgssad; *.rgss2a";
            dialog.FilterIndex = 1;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                textBoxEncryptOutput.Text = dialog.FileName;
                CheckBatchStartEnabled();
            }
        }

        private void listBoxEncryptFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonEncryptFilesDel.Enabled = listBoxEncryptFiles.SelectedIndex != -1;
        }

        private void AddEncryptFiles(string path)
        {
            if (Directory.Exists(path))
            {
                string[] files = Directory.GetFiles(path);
                foreach (string f in files)
                    listBoxEncryptFiles.Items.Add(f);
                string[] dirs = Directory.GetDirectories(path);
                foreach (string d in dirs)
                    AddEncryptFiles(d);
            }
            else if (File.Exists(path))
                listBoxEncryptFiles.Items.Add(path);
        }

        private void buttonEncryptFilesBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Sélectionner un fichier";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < dialog.FileNames.Length; i++)
                {
                    AddEncryptFiles(dialog.FileNames[i]);
                }
            }
        }

        private void buttonEncryptFolderBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                AddEncryptFiles(dialog.SelectedPath);
            }
        }

        private void buttonEncryptFilesDel_Click(object sender, EventArgs e)
        {
            int items = listBoxEncryptFiles.SelectedIndices.Count;
            foreach (int i in listBoxEncryptFiles.SelectedIndices)
                listBoxEncryptFiles.Items[i] = "nil";
            for (int i = 0; i < items; i++)
                listBoxEncryptFiles.Items.Remove("nil");
        }

        private void buttonEncryptStart_Click(object sender, EventArgs e)
        {
            List<string> files = new List<string>();
            foreach (string f in listBoxEncryptFiles.Items)
                files.Add(f);
            Encrypter encrypter = new Encrypter(textBoxEncryptOutput.Text, Path.GetDirectoryName(textBoxEncryptProj.Text), files);
            encrypter.magickey = GetHex(textBoxMagicKey.Text);

            ClearEncryptLog();

            progressBarEncrypt.Value = 0;
            progressBarEncrypt.Maximum = listBoxEncryptFiles.Items.Count;
            AddEncryptLog("Cryptage en cours");

            encrypter.Start();

            AddEncryptLog("Fichier crypter: " + listBoxEncryptFiles.Items.Count.ToString());

            string str;
            for (int j = 0; j < listBoxEncryptFiles.Items.Count; j++)
            {
                str = encrypter.Advance();
                if (str.Length > 0) AddEncryptLog(str);
                progressBarEncrypt.Increment(1);
            }

            encrypter.End();

            if (checkBoxEncryptLog.Checked)
            {
                StreamWriter file;
                file = File.CreateText(Path.GetDirectoryName(textBoxEncryptOutput.Text) + "\\DRGSS.log");
                file.Write(textBoxEncryptLog.Text);
                file.Close();
            }
        }
    }
}
