namespace DRGSS
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.labelMagicKey = new System.Windows.Forms.Label();
            this.textBoxMagicKey = new System.Windows.Forms.TextBox();
            this.tabPageEncrypt = new System.Windows.Forms.TabPage();
            this.textBoxEncryptLog = new System.Windows.Forms.TextBox();
            this.buttonEncryptStart = new System.Windows.Forms.Button();
            this.progressBarEncrypt = new System.Windows.Forms.ProgressBar();
            this.groupBoxEncryptOptions = new System.Windows.Forms.GroupBox();
            this.labelEncryptProj = new System.Windows.Forms.Label();
            this.labelEncryptOutput = new System.Windows.Forms.Label();
            this.checkBoxEncryptLog = new System.Windows.Forms.CheckBox();
            this.buttonEncryptOutput = new System.Windows.Forms.Button();
            this.textBoxEncryptOutput = new System.Windows.Forms.TextBox();
            this.buttonEncryptProj = new System.Windows.Forms.Button();
            this.textBoxEncryptProj = new System.Windows.Forms.TextBox();
            this.groupBoxEncryptFiles = new System.Windows.Forms.GroupBox();
            this.buttonEncryptFolderBrowse = new System.Windows.Forms.Button();
            this.buttonEncryptFilesBrowse = new System.Windows.Forms.Button();
            this.buttonEncryptFilesDel = new System.Windows.Forms.Button();
            this.listBoxEncryptFiles = new System.Windows.Forms.ListBox();
            this.tabPageBatch = new System.Windows.Forms.TabPage();
            this.textBoxBatchLog = new System.Windows.Forms.TextBox();
            this.buttonBatchStart = new System.Windows.Forms.Button();
            this.progressBarBatch = new System.Windows.Forms.ProgressBar();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxBatchOverwrite = new System.Windows.Forms.CheckBox();
            this.checkBoxBatchLog = new System.Windows.Forms.CheckBox();
            this.buttonBatchPathBrowse = new System.Windows.Forms.Button();
            this.textBoxBatchPath = new System.Windows.Forms.TextBox();
            this.checkBoxBatchPath = new System.Windows.Forms.CheckBox();
            this.checkBoxBatchSubfolders = new System.Windows.Forms.CheckBox();
            this.checkBoxBatchProject = new System.Windows.Forms.CheckBox();
            this.groupBoxBatch = new System.Windows.Forms.GroupBox();
            this.buttonBatchBrowse = new System.Windows.Forms.Button();
            this.buttonBatchDelete = new System.Windows.Forms.Button();
            this.listBoxBatch = new System.Windows.Forms.ListBox();
            this.tabPageNormal = new System.Windows.Forms.TabPage();
            this.checkBoxOverwrite = new System.Windows.Forms.CheckBox();
            this.textBoxLog = new System.Windows.Forms.TextBox();
            this.textBoxFile = new System.Windows.Forms.TextBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.progressBarFile = new System.Windows.Forms.ProgressBar();
            this.labelFile = new System.Windows.Forms.Label();
            this.checkBoxLog = new System.Windows.Forms.CheckBox();
            this.labelFolder = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.checkBoxProject = new System.Windows.Forms.CheckBox();
            this.buttonBrowseFile = new System.Windows.Forms.Button();
            this.buttonBrowseFolder = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.labelvgvgf = new System.Windows.Forms.Label();
            this.tabPageEncrypt.SuspendLayout();
            this.groupBoxEncryptOptions.SuspendLayout();
            this.groupBoxEncryptFiles.SuspendLayout();
            this.tabPageBatch.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxBatch.SuspendLayout();
            this.tabPageNormal.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelMagicKey
            // 
            this.labelMagicKey.AutoSize = true;
            this.labelMagicKey.Location = new System.Drawing.Point(14, 300);
            this.labelMagicKey.Name = "labelMagicKey";
            this.labelMagicKey.Size = new System.Drawing.Size(57, 13);
            this.labelMagicKey.TabIndex = 12;
            this.labelMagicKey.Text = "MagicKey:";
            // 
            // textBoxMagicKey
            // 
            this.textBoxMagicKey.Location = new System.Drawing.Point(76, 297);
            this.textBoxMagicKey.MaxLength = 8;
            this.textBoxMagicKey.Name = "textBoxMagicKey";
            this.textBoxMagicKey.Size = new System.Drawing.Size(117, 20);
            this.textBoxMagicKey.TabIndex = 13;
            this.textBoxMagicKey.Text = "DEADCAFE";
            this.textBoxMagicKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxMagicKey.TextChanged += new System.EventHandler(this.textBoxMagicKey_TextChanged);
            // 
            // tabPageEncrypt
            // 
            this.tabPageEncrypt.Controls.Add(this.textBoxEncryptLog);
            this.tabPageEncrypt.Controls.Add(this.buttonEncryptStart);
            this.tabPageEncrypt.Controls.Add(this.progressBarEncrypt);
            this.tabPageEncrypt.Controls.Add(this.groupBoxEncryptOptions);
            this.tabPageEncrypt.Controls.Add(this.groupBoxEncryptFiles);
            this.tabPageEncrypt.Location = new System.Drawing.Point(4, 22);
            this.tabPageEncrypt.Name = "tabPageEncrypt";
            this.tabPageEncrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEncrypt.Size = new System.Drawing.Size(516, 252);
            this.tabPageEncrypt.TabIndex = 3;
            this.tabPageEncrypt.Text = "Crypter";
            this.tabPageEncrypt.UseVisualStyleBackColor = true;
            // 
            // textBoxEncryptLog
            // 
            this.textBoxEncryptLog.Location = new System.Drawing.Point(216, 135);
            this.textBoxEncryptLog.Multiline = true;
            this.textBoxEncryptLog.Name = "textBoxEncryptLog";
            this.textBoxEncryptLog.ReadOnly = true;
            this.textBoxEncryptLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxEncryptLog.Size = new System.Drawing.Size(294, 111);
            this.textBoxEncryptLog.TabIndex = 19;
            // 
            // buttonEncryptStart
            // 
            this.buttonEncryptStart.Enabled = false;
            this.buttonEncryptStart.Location = new System.Drawing.Point(216, 106);
            this.buttonEncryptStart.Name = "buttonEncryptStart";
            this.buttonEncryptStart.Size = new System.Drawing.Size(69, 23);
            this.buttonEncryptStart.TabIndex = 18;
            this.buttonEncryptStart.Text = "Démarrer";
            this.buttonEncryptStart.UseVisualStyleBackColor = true;
            this.buttonEncryptStart.Click += new System.EventHandler(this.buttonEncryptStart_Click);
            // 
            // progressBarEncrypt
            // 
            this.progressBarEncrypt.Location = new System.Drawing.Point(291, 106);
            this.progressBarEncrypt.Name = "progressBarEncrypt";
            this.progressBarEncrypt.Size = new System.Drawing.Size(219, 23);
            this.progressBarEncrypt.TabIndex = 17;
            // 
            // groupBoxEncryptOptions
            // 
            this.groupBoxEncryptOptions.Controls.Add(this.labelEncryptProj);
            this.groupBoxEncryptOptions.Controls.Add(this.labelEncryptOutput);
            this.groupBoxEncryptOptions.Controls.Add(this.checkBoxEncryptLog);
            this.groupBoxEncryptOptions.Controls.Add(this.buttonEncryptOutput);
            this.groupBoxEncryptOptions.Controls.Add(this.textBoxEncryptOutput);
            this.groupBoxEncryptOptions.Controls.Add(this.buttonEncryptProj);
            this.groupBoxEncryptOptions.Controls.Add(this.textBoxEncryptProj);
            this.groupBoxEncryptOptions.Location = new System.Drawing.Point(216, 6);
            this.groupBoxEncryptOptions.Name = "groupBoxEncryptOptions";
            this.groupBoxEncryptOptions.Size = new System.Drawing.Size(294, 94);
            this.groupBoxEncryptOptions.TabIndex = 16;
            this.groupBoxEncryptOptions.TabStop = false;
            this.groupBoxEncryptOptions.Text = "Options";
            // 
            // labelEncryptProj
            // 
            this.labelEncryptProj.AutoSize = true;
            this.labelEncryptProj.Location = new System.Drawing.Point(6, 22);
            this.labelEncryptProj.Name = "labelEncryptProj";
            this.labelEncryptProj.Size = new System.Drawing.Size(82, 13);
            this.labelEncryptProj.TabIndex = 14;
            this.labelEncryptProj.Text = "Projet à Crypter:";
            // 
            // labelEncryptOutput
            // 
            this.labelEncryptOutput.AutoSize = true;
            this.labelEncryptOutput.Location = new System.Drawing.Point(6, 48);
            this.labelEncryptOutput.Name = "labelEncryptOutput";
            this.labelEncryptOutput.Size = new System.Drawing.Size(74, 13);
            this.labelEncryptOutput.TabIndex = 13;
            this.labelEncryptOutput.Text = "Emplacement:";
            // 
            // checkBoxEncryptLog
            // 
            this.checkBoxEncryptLog.AutoSize = true;
            this.checkBoxEncryptLog.Location = new System.Drawing.Point(6, 70);
            this.checkBoxEncryptLog.Name = "checkBoxEncryptLog";
            this.checkBoxEncryptLog.Size = new System.Drawing.Size(104, 17);
            this.checkBoxEncryptLog.TabIndex = 12;
            this.checkBoxEncryptLog.Text = "Sauvegarder log";
            this.checkBoxEncryptLog.UseVisualStyleBackColor = true;
            // 
            // buttonEncryptOutput
            // 
            this.buttonEncryptOutput.Location = new System.Drawing.Point(220, 43);
            this.buttonEncryptOutput.Name = "buttonEncryptOutput";
            this.buttonEncryptOutput.Size = new System.Drawing.Size(69, 23);
            this.buttonEncryptOutput.TabIndex = 11;
            this.buttonEncryptOutput.Text = "Rechercher";
            this.buttonEncryptOutput.UseVisualStyleBackColor = true;
            this.buttonEncryptOutput.Click += new System.EventHandler(this.buttonEncryptOutput_Click);
            // 
            // textBoxEncryptOutput
            // 
            this.textBoxEncryptOutput.Location = new System.Drawing.Point(106, 45);
            this.textBoxEncryptOutput.Name = "textBoxEncryptOutput";
            this.textBoxEncryptOutput.Size = new System.Drawing.Size(108, 20);
            this.textBoxEncryptOutput.TabIndex = 10;
            this.textBoxEncryptOutput.TextChanged += new System.EventHandler(this.textBoxEncryptOutput_TextChanged);
            // 
            // buttonEncryptProj
            // 
            this.buttonEncryptProj.Location = new System.Drawing.Point(220, 17);
            this.buttonEncryptProj.Name = "buttonEncryptProj";
            this.buttonEncryptProj.Size = new System.Drawing.Size(69, 23);
            this.buttonEncryptProj.TabIndex = 8;
            this.buttonEncryptProj.Text = "Recherche";
            this.buttonEncryptProj.UseVisualStyleBackColor = true;
            this.buttonEncryptProj.Click += new System.EventHandler(this.buttonEncryptProj_Click);
            // 
            // textBoxEncryptProj
            // 
            this.textBoxEncryptProj.Location = new System.Drawing.Point(106, 19);
            this.textBoxEncryptProj.Name = "textBoxEncryptProj";
            this.textBoxEncryptProj.Size = new System.Drawing.Size(108, 20);
            this.textBoxEncryptProj.TabIndex = 7;
            this.textBoxEncryptProj.TextChanged += new System.EventHandler(this.textBoxEncryptProj_TextChanged);
            // 
            // groupBoxEncryptFiles
            // 
            this.groupBoxEncryptFiles.Controls.Add(this.buttonEncryptFolderBrowse);
            this.groupBoxEncryptFiles.Controls.Add(this.buttonEncryptFilesBrowse);
            this.groupBoxEncryptFiles.Controls.Add(this.buttonEncryptFilesDel);
            this.groupBoxEncryptFiles.Controls.Add(this.listBoxEncryptFiles);
            this.groupBoxEncryptFiles.Location = new System.Drawing.Point(6, 6);
            this.groupBoxEncryptFiles.Name = "groupBoxEncryptFiles";
            this.groupBoxEncryptFiles.Size = new System.Drawing.Size(204, 240);
            this.groupBoxEncryptFiles.TabIndex = 15;
            this.groupBoxEncryptFiles.TabStop = false;
            this.groupBoxEncryptFiles.Text = "Files to Encrypt";
            // 
            // buttonEncryptFolderBrowse
            // 
            this.buttonEncryptFolderBrowse.Location = new System.Drawing.Point(70, 211);
            this.buttonEncryptFolderBrowse.Name = "buttonEncryptFolderBrowse";
            this.buttonEncryptFolderBrowse.Size = new System.Drawing.Size(67, 23);
            this.buttonEncryptFolderBrowse.TabIndex = 9;
            this.buttonEncryptFolderBrowse.Text = "Repertoire";
            this.buttonEncryptFolderBrowse.UseVisualStyleBackColor = true;
            this.buttonEncryptFolderBrowse.Click += new System.EventHandler(this.buttonEncryptFolderBrowse_Click);
            // 
            // buttonEncryptFilesBrowse
            // 
            this.buttonEncryptFilesBrowse.Location = new System.Drawing.Point(0, 211);
            this.buttonEncryptFilesBrowse.Name = "buttonEncryptFilesBrowse";
            this.buttonEncryptFilesBrowse.Size = new System.Drawing.Size(68, 23);
            this.buttonEncryptFilesBrowse.TabIndex = 7;
            this.buttonEncryptFilesBrowse.Text = "Recherche";
            this.buttonEncryptFilesBrowse.UseVisualStyleBackColor = true;
            this.buttonEncryptFilesBrowse.Click += new System.EventHandler(this.buttonEncryptFilesBrowse_Click);
            // 
            // buttonEncryptFilesDel
            // 
            this.buttonEncryptFilesDel.Enabled = false;
            this.buttonEncryptFilesDel.Location = new System.Drawing.Point(140, 211);
            this.buttonEncryptFilesDel.Name = "buttonEncryptFilesDel";
            this.buttonEncryptFilesDel.Size = new System.Drawing.Size(64, 23);
            this.buttonEncryptFilesDel.TabIndex = 8;
            this.buttonEncryptFilesDel.Text = "Supprimer";
            this.buttonEncryptFilesDel.UseVisualStyleBackColor = true;
            this.buttonEncryptFilesDel.Click += new System.EventHandler(this.buttonEncryptFilesDel_Click);
            // 
            // listBoxEncryptFiles
            // 
            this.listBoxEncryptFiles.FormattingEnabled = true;
            this.listBoxEncryptFiles.HorizontalScrollbar = true;
            this.listBoxEncryptFiles.Location = new System.Drawing.Point(6, 19);
            this.listBoxEncryptFiles.Name = "listBoxEncryptFiles";
            this.listBoxEncryptFiles.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBoxEncryptFiles.Size = new System.Drawing.Size(192, 186);
            this.listBoxEncryptFiles.TabIndex = 0;
            this.listBoxEncryptFiles.SelectedIndexChanged += new System.EventHandler(this.listBoxEncryptFiles_SelectedIndexChanged);
            // 
            // tabPageBatch
            // 
            this.tabPageBatch.Controls.Add(this.textBoxBatchLog);
            this.tabPageBatch.Controls.Add(this.buttonBatchStart);
            this.tabPageBatch.Controls.Add(this.progressBarBatch);
            this.tabPageBatch.Controls.Add(this.groupBoxOptions);
            this.tabPageBatch.Controls.Add(this.groupBoxBatch);
            this.tabPageBatch.Location = new System.Drawing.Point(4, 22);
            this.tabPageBatch.Name = "tabPageBatch";
            this.tabPageBatch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBatch.Size = new System.Drawing.Size(516, 252);
            this.tabPageBatch.TabIndex = 1;
            this.tabPageBatch.Text = "Décryptage Batch";
            this.tabPageBatch.UseVisualStyleBackColor = true;
            // 
            // textBoxBatchLog
            // 
            this.textBoxBatchLog.Location = new System.Drawing.Point(204, 130);
            this.textBoxBatchLog.Multiline = true;
            this.textBoxBatchLog.Name = "textBoxBatchLog";
            this.textBoxBatchLog.ReadOnly = true;
            this.textBoxBatchLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxBatchLog.Size = new System.Drawing.Size(306, 116);
            this.textBoxBatchLog.TabIndex = 14;
            // 
            // buttonBatchStart
            // 
            this.buttonBatchStart.Enabled = false;
            this.buttonBatchStart.Location = new System.Drawing.Point(204, 101);
            this.buttonBatchStart.Name = "buttonBatchStart";
            this.buttonBatchStart.Size = new System.Drawing.Size(69, 23);
            this.buttonBatchStart.TabIndex = 13;
            this.buttonBatchStart.Text = "Démarrer";
            this.buttonBatchStart.UseVisualStyleBackColor = true;
            this.buttonBatchStart.Click += new System.EventHandler(this.buttonBatchStart_Click);
            // 
            // progressBarBatch
            // 
            this.progressBarBatch.Location = new System.Drawing.Point(279, 101);
            this.progressBarBatch.Name = "progressBarBatch";
            this.progressBarBatch.Size = new System.Drawing.Size(231, 23);
            this.progressBarBatch.TabIndex = 12;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxBatchOverwrite);
            this.groupBoxOptions.Controls.Add(this.checkBoxBatchLog);
            this.groupBoxOptions.Controls.Add(this.buttonBatchPathBrowse);
            this.groupBoxOptions.Controls.Add(this.textBoxBatchPath);
            this.groupBoxOptions.Controls.Add(this.checkBoxBatchPath);
            this.groupBoxOptions.Controls.Add(this.checkBoxBatchSubfolders);
            this.groupBoxOptions.Controls.Add(this.checkBoxBatchProject);
            this.groupBoxOptions.Location = new System.Drawing.Point(204, 6);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(306, 89);
            this.groupBoxOptions.TabIndex = 11;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Options";
            // 
            // checkBoxBatchOverwrite
            // 
            this.checkBoxBatchOverwrite.AutoSize = true;
            this.checkBoxBatchOverwrite.Checked = true;
            this.checkBoxBatchOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBatchOverwrite.Location = new System.Drawing.Point(203, 42);
            this.checkBoxBatchOverwrite.Name = "checkBoxBatchOverwrite";
            this.checkBoxBatchOverwrite.Size = new System.Drawing.Size(88, 17);
            this.checkBoxBatchOverwrite.TabIndex = 17;
            this.checkBoxBatchOverwrite.Text = "Tous écraser";
            this.checkBoxBatchOverwrite.UseVisualStyleBackColor = true;
            // 
            // checkBoxBatchLog
            // 
            this.checkBoxBatchLog.AutoSize = true;
            this.checkBoxBatchLog.Location = new System.Drawing.Point(203, 19);
            this.checkBoxBatchLog.Name = "checkBoxBatchLog";
            this.checkBoxBatchLog.Size = new System.Drawing.Size(104, 17);
            this.checkBoxBatchLog.TabIndex = 9;
            this.checkBoxBatchLog.Text = "Sauvegarder log";
            this.checkBoxBatchLog.UseVisualStyleBackColor = true;
            // 
            // buttonBatchPathBrowse
            // 
            this.buttonBatchPathBrowse.Enabled = false;
            this.buttonBatchPathBrowse.Location = new System.Drawing.Point(231, 61);
            this.buttonBatchPathBrowse.Name = "buttonBatchPathBrowse";
            this.buttonBatchPathBrowse.Size = new System.Drawing.Size(69, 23);
            this.buttonBatchPathBrowse.TabIndex = 8;
            this.buttonBatchPathBrowse.Text = "Recherche";
            this.buttonBatchPathBrowse.UseVisualStyleBackColor = true;
            this.buttonBatchPathBrowse.Click += new System.EventHandler(this.buttonBatchPathBrowse_Click);
            // 
            // textBoxBatchPath
            // 
            this.textBoxBatchPath.Enabled = false;
            this.textBoxBatchPath.Location = new System.Drawing.Point(87, 63);
            this.textBoxBatchPath.Name = "textBoxBatchPath";
            this.textBoxBatchPath.Size = new System.Drawing.Size(138, 20);
            this.textBoxBatchPath.TabIndex = 7;
            this.textBoxBatchPath.TextChanged += new System.EventHandler(this.textBoxBatchPath_TextChanged);
            // 
            // checkBoxBatchPath
            // 
            this.checkBoxBatchPath.AutoSize = true;
            this.checkBoxBatchPath.Location = new System.Drawing.Point(6, 65);
            this.checkBoxBatchPath.Name = "checkBoxBatchPath";
            this.checkBoxBatchPath.Size = new System.Drawing.Size(75, 17);
            this.checkBoxBatchPath.TabIndex = 2;
            this.checkBoxBatchPath.Text = "Décrypter:";
            this.checkBoxBatchPath.UseVisualStyleBackColor = true;
            this.checkBoxBatchPath.CheckedChanged += new System.EventHandler(this.checkBoxBatchPath_CheckedChanged);
            // 
            // checkBoxBatchSubfolders
            // 
            this.checkBoxBatchSubfolders.AutoSize = true;
            this.checkBoxBatchSubfolders.Location = new System.Drawing.Point(6, 42);
            this.checkBoxBatchSubfolders.Name = "checkBoxBatchSubfolders";
            this.checkBoxBatchSubfolders.Size = new System.Drawing.Size(177, 17);
            this.checkBoxBatchSubfolders.TabIndex = 1;
            this.checkBoxBatchSubfolders.Text = "Décrypter  dans un sous-dossier";
            this.checkBoxBatchSubfolders.UseVisualStyleBackColor = true;
            // 
            // checkBoxBatchProject
            // 
            this.checkBoxBatchProject.AutoSize = true;
            this.checkBoxBatchProject.Checked = true;
            this.checkBoxBatchProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBatchProject.Location = new System.Drawing.Point(6, 19);
            this.checkBoxBatchProject.Name = "checkBoxBatchProject";
            this.checkBoxBatchProject.Size = new System.Drawing.Size(95, 17);
            this.checkBoxBatchProject.TabIndex = 0;
            this.checkBoxBatchProject.Text = "Créer un projet";
            this.checkBoxBatchProject.UseVisualStyleBackColor = true;
            // 
            // groupBoxBatch
            // 
            this.groupBoxBatch.Controls.Add(this.buttonBatchBrowse);
            this.groupBoxBatch.Controls.Add(this.buttonBatchDelete);
            this.groupBoxBatch.Controls.Add(this.listBoxBatch);
            this.groupBoxBatch.Location = new System.Drawing.Point(6, 6);
            this.groupBoxBatch.Name = "groupBoxBatch";
            this.groupBoxBatch.Size = new System.Drawing.Size(192, 240);
            this.groupBoxBatch.TabIndex = 9;
            this.groupBoxBatch.TabStop = false;
            this.groupBoxBatch.Text = "Actions Batch";
            // 
            // buttonBatchBrowse
            // 
            this.buttonBatchBrowse.Location = new System.Drawing.Point(6, 211);
            this.buttonBatchBrowse.Name = "buttonBatchBrowse";
            this.buttonBatchBrowse.Size = new System.Drawing.Size(69, 23);
            this.buttonBatchBrowse.TabIndex = 7;
            this.buttonBatchBrowse.Text = "Recherche";
            this.buttonBatchBrowse.UseVisualStyleBackColor = true;
            this.buttonBatchBrowse.Click += new System.EventHandler(this.buttonBatchBrowse_Click);
            // 
            // buttonBatchDelete
            // 
            this.buttonBatchDelete.Enabled = false;
            this.buttonBatchDelete.Location = new System.Drawing.Point(117, 211);
            this.buttonBatchDelete.Name = "buttonBatchDelete";
            this.buttonBatchDelete.Size = new System.Drawing.Size(69, 23);
            this.buttonBatchDelete.TabIndex = 8;
            this.buttonBatchDelete.Text = "Supprimer";
            this.buttonBatchDelete.UseVisualStyleBackColor = true;
            this.buttonBatchDelete.Click += new System.EventHandler(this.buttonBatchDelete_Click);
            // 
            // listBoxBatch
            // 
            this.listBoxBatch.FormattingEnabled = true;
            this.listBoxBatch.HorizontalScrollbar = true;
            this.listBoxBatch.Location = new System.Drawing.Point(6, 19);
            this.listBoxBatch.Name = "listBoxBatch";
            this.listBoxBatch.Size = new System.Drawing.Size(180, 186);
            this.listBoxBatch.TabIndex = 0;
            this.listBoxBatch.SelectedIndexChanged += new System.EventHandler(this.listBoxBatch_SelectedIndexChanged);
            // 
            // tabPageNormal
            // 
            this.tabPageNormal.Controls.Add(this.checkBoxOverwrite);
            this.tabPageNormal.Controls.Add(this.textBoxLog);
            this.tabPageNormal.Controls.Add(this.textBoxFile);
            this.tabPageNormal.Controls.Add(this.textBoxFolder);
            this.tabPageNormal.Controls.Add(this.progressBarFile);
            this.tabPageNormal.Controls.Add(this.labelFile);
            this.tabPageNormal.Controls.Add(this.checkBoxLog);
            this.tabPageNormal.Controls.Add(this.labelFolder);
            this.tabPageNormal.Controls.Add(this.buttonStart);
            this.tabPageNormal.Controls.Add(this.checkBoxProject);
            this.tabPageNormal.Controls.Add(this.buttonBrowseFile);
            this.tabPageNormal.Controls.Add(this.buttonBrowseFolder);
            this.tabPageNormal.Location = new System.Drawing.Point(4, 22);
            this.tabPageNormal.Name = "tabPageNormal";
            this.tabPageNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageNormal.Size = new System.Drawing.Size(516, 252);
            this.tabPageNormal.TabIndex = 0;
            this.tabPageNormal.Text = "Décryptage Simple";
            this.tabPageNormal.UseVisualStyleBackColor = true;
            // 
            // checkBoxOverwrite
            // 
            this.checkBoxOverwrite.AutoSize = true;
            this.checkBoxOverwrite.Checked = true;
            this.checkBoxOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxOverwrite.Location = new System.Drawing.Point(217, 71);
            this.checkBoxOverwrite.Name = "checkBoxOverwrite";
            this.checkBoxOverwrite.Size = new System.Drawing.Size(88, 17);
            this.checkBoxOverwrite.TabIndex = 16;
            this.checkBoxOverwrite.Text = "Tous écraser";
            this.checkBoxOverwrite.UseVisualStyleBackColor = true;
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(6, 120);
            this.textBoxLog.Multiline = true;
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.ReadOnly = true;
            this.textBoxLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxLog.Size = new System.Drawing.Size(499, 126);
            this.textBoxLog.TabIndex = 15;
            // 
            // textBoxFile
            // 
            this.textBoxFile.Location = new System.Drawing.Point(135, 13);
            this.textBoxFile.Name = "textBoxFile";
            this.textBoxFile.Size = new System.Drawing.Size(271, 20);
            this.textBoxFile.TabIndex = 2;
            this.textBoxFile.TextChanged += new System.EventHandler(this.textBoxFile_TextChanged);
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(135, 39);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.Size = new System.Drawing.Size(271, 20);
            this.textBoxFolder.TabIndex = 3;
            this.textBoxFolder.TextChanged += new System.EventHandler(this.textBoxFolder_TextChanged);
            // 
            // progressBarFile
            // 
            this.progressBarFile.Location = new System.Drawing.Point(6, 94);
            this.progressBarFile.Name = "progressBarFile";
            this.progressBarFile.Size = new System.Drawing.Size(500, 20);
            this.progressBarFile.Step = 1;
            this.progressBarFile.TabIndex = 10;
            // 
            // labelFile
            // 
            this.labelFile.AutoSize = true;
            this.labelFile.Location = new System.Drawing.Point(6, 13);
            this.labelFile.Name = "labelFile";
            this.labelFile.Size = new System.Drawing.Size(97, 13);
            this.labelFile.TabIndex = 0;
            this.labelFile.Text = "Fichier à décrypter:";
            // 
            // checkBoxLog
            // 
            this.checkBoxLog.AutoSize = true;
            this.checkBoxLog.Location = new System.Drawing.Point(107, 71);
            this.checkBoxLog.Name = "checkBoxLog";
            this.checkBoxLog.Size = new System.Drawing.Size(104, 17);
            this.checkBoxLog.TabIndex = 9;
            this.checkBoxLog.Text = "Sauvegarder log";
            this.checkBoxLog.UseVisualStyleBackColor = true;
            // 
            // labelFolder
            // 
            this.labelFolder.AutoSize = true;
            this.labelFolder.Location = new System.Drawing.Point(6, 42);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(130, 13);
            this.labelFolder.TabIndex = 1;
            this.labelFolder.Text = "Repertoire de Destination:";
            // 
            // buttonStart
            // 
            this.buttonStart.Enabled = false;
            this.buttonStart.Location = new System.Drawing.Point(412, 67);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(93, 23);
            this.buttonStart.TabIndex = 7;
            this.buttonStart.Text = "Décrypter";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // checkBoxProject
            // 
            this.checkBoxProject.AutoSize = true;
            this.checkBoxProject.Checked = true;
            this.checkBoxProject.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxProject.Location = new System.Drawing.Point(6, 71);
            this.checkBoxProject.Name = "checkBoxProject";
            this.checkBoxProject.Size = new System.Drawing.Size(95, 17);
            this.checkBoxProject.TabIndex = 6;
            this.checkBoxProject.Text = "Créer un projet";
            this.checkBoxProject.UseVisualStyleBackColor = true;
            // 
            // buttonBrowseFile
            // 
            this.buttonBrowseFile.Location = new System.Drawing.Point(412, 11);
            this.buttonBrowseFile.Name = "buttonBrowseFile";
            this.buttonBrowseFile.Size = new System.Drawing.Size(93, 23);
            this.buttonBrowseFile.TabIndex = 4;
            this.buttonBrowseFile.Text = "Rechercher...";
            this.buttonBrowseFile.UseVisualStyleBackColor = true;
            this.buttonBrowseFile.Click += new System.EventHandler(this.buttonBrowseFile_Click);
            // 
            // buttonBrowseFolder
            // 
            this.buttonBrowseFolder.Location = new System.Drawing.Point(412, 36);
            this.buttonBrowseFolder.Name = "buttonBrowseFolder";
            this.buttonBrowseFolder.Size = new System.Drawing.Size(93, 23);
            this.buttonBrowseFolder.TabIndex = 5;
            this.buttonBrowseFolder.Text = "Rechercher...";
            this.buttonBrowseFolder.UseVisualStyleBackColor = true;
            this.buttonBrowseFolder.Click += new System.EventHandler(this.buttonBrowseFolder_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageNormal);
            this.tabControl.Controls.Add(this.tabPageBatch);
            this.tabControl.Controls.Add(this.tabPageEncrypt);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(524, 278);
            this.tabControl.TabIndex = 10;
            // 
            // labelvgvgf
            // 
            this.labelvgvgf.AutoSize = true;
            this.labelvgvgf.Location = new System.Drawing.Point(230, 300);
            this.labelvgvgf.Name = "labelvgvgf";
            this.labelvgvgf.Size = new System.Drawing.Size(196, 13);
            this.labelvgvgf.TabIndex = 14;
            this.labelvgvgf.Text = "Créer par vgvgf - 2015 Traduit par Slash";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 326);
            this.Controls.Add(this.labelvgvgf);
            this.Controls.Add(this.textBoxMagicKey);
            this.Controls.Add(this.labelMagicKey);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "DRGSS";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabPageEncrypt.ResumeLayout(false);
            this.tabPageEncrypt.PerformLayout();
            this.groupBoxEncryptOptions.ResumeLayout(false);
            this.groupBoxEncryptOptions.PerformLayout();
            this.groupBoxEncryptFiles.ResumeLayout(false);
            this.tabPageBatch.ResumeLayout(false);
            this.tabPageBatch.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxBatch.ResumeLayout(false);
            this.tabPageNormal.ResumeLayout(false);
            this.tabPageNormal.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMagicKey;
        private System.Windows.Forms.TextBox textBoxMagicKey;
        private System.Windows.Forms.TabPage tabPageEncrypt;
        private System.Windows.Forms.TextBox textBoxEncryptLog;
        private System.Windows.Forms.Button buttonEncryptStart;
        private System.Windows.Forms.ProgressBar progressBarEncrypt;
        private System.Windows.Forms.GroupBox groupBoxEncryptOptions;
        private System.Windows.Forms.CheckBox checkBoxEncryptLog;
        private System.Windows.Forms.Button buttonEncryptOutput;
        private System.Windows.Forms.TextBox textBoxEncryptOutput;
        private System.Windows.Forms.Button buttonEncryptProj;
        private System.Windows.Forms.TextBox textBoxEncryptProj;
        private System.Windows.Forms.GroupBox groupBoxEncryptFiles;
        private System.Windows.Forms.Button buttonEncryptFilesBrowse;
        private System.Windows.Forms.Button buttonEncryptFilesDel;
        private System.Windows.Forms.ListBox listBoxEncryptFiles;
        private System.Windows.Forms.TabPage tabPageBatch;
        private System.Windows.Forms.TextBox textBoxBatchLog;
        private System.Windows.Forms.Button buttonBatchStart;
        private System.Windows.Forms.ProgressBar progressBarBatch;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxBatchOverwrite;
        private System.Windows.Forms.CheckBox checkBoxBatchLog;
        private System.Windows.Forms.Button buttonBatchPathBrowse;
        private System.Windows.Forms.TextBox textBoxBatchPath;
        private System.Windows.Forms.CheckBox checkBoxBatchPath;
        private System.Windows.Forms.CheckBox checkBoxBatchSubfolders;
        private System.Windows.Forms.CheckBox checkBoxBatchProject;
        private System.Windows.Forms.GroupBox groupBoxBatch;
        private System.Windows.Forms.Button buttonBatchBrowse;
        private System.Windows.Forms.Button buttonBatchDelete;
        private System.Windows.Forms.ListBox listBoxBatch;
        private System.Windows.Forms.TabPage tabPageNormal;
        private System.Windows.Forms.CheckBox checkBoxOverwrite;
        private System.Windows.Forms.TextBox textBoxLog;
        private System.Windows.Forms.TextBox textBoxFile;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.ProgressBar progressBarFile;
        private System.Windows.Forms.Label labelFile;
        private System.Windows.Forms.CheckBox checkBoxLog;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.CheckBox checkBoxProject;
        private System.Windows.Forms.Button buttonBrowseFile;
        private System.Windows.Forms.Button buttonBrowseFolder;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label labelEncryptProj;
        private System.Windows.Forms.Label labelEncryptOutput;
        private System.Windows.Forms.Button buttonEncryptFolderBrowse;
        private System.Windows.Forms.Label labelvgvgf;
    }
}

