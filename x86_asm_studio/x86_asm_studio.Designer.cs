namespace x86_asm_studio
{
    partial class x86_asm_studio
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageSetting = new System.Windows.Forms.TabPage();
            this.groupBoxDD = new System.Windows.Forms.GroupBox();
            this.buttonDD = new System.Windows.Forms.Button();
            this.textBoxDD = new System.Windows.Forms.TextBox();
            this.labelDD = new System.Windows.Forms.Label();
            this.groupBoxCompiler = new System.Windows.Forms.GroupBox();
            this.labelCompiler = new System.Windows.Forms.Label();
            this.textBoxCompiler = new System.Windows.Forms.TextBox();
            this.buttonCompiler = new System.Windows.Forms.Button();
            this.groupBoxQEMU = new System.Windows.Forms.GroupBox();
            this.buttonQEMUImage = new System.Windows.Forms.Button();
            this.labelQEMUEmulator = new System.Windows.Forms.Label();
            this.buttonQEMUEmulator = new System.Windows.Forms.Button();
            this.textBoxQEMUImage = new System.Windows.Forms.TextBox();
            this.labeQEMUImage = new System.Windows.Forms.Label();
            this.textBoxQEMUEmulator = new System.Windows.Forms.TextBox();
            this.tabPageEditor = new System.Windows.Forms.TabPage();
            this.panelLineNumber = new System.Windows.Forms.Panel();
            this.richTextBoxEditor = new System.Windows.Forms.RichTextBox();
            this.tabPageCompile = new System.Windows.Forms.TabPage();
            this.buttonCompile = new System.Windows.Forms.Button();
            this.groupBoxOutput = new System.Windows.Forms.GroupBox();
            this.richTextBoxCompileOutput = new System.Windows.Forms.RichTextBox();
            this.groupBoxFile = new System.Windows.Forms.GroupBox();
            this.panelCompile = new System.Windows.Forms.Panel();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.labelFileName = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.tabPageImage = new System.Windows.Forms.TabPage();
            this.buttonMkImg = new System.Windows.Forms.Button();
            this.comboBoxSizeUnit = new System.Windows.Forms.ComboBox();
            this.textBoxBlockCnt = new System.Windows.Forms.TextBox();
            this.textBoxBlockSize = new System.Windows.Forms.TextBox();
            this.labelBlockCnt = new System.Windows.Forms.Label();
            this.labelBlockSize = new System.Windows.Forms.Label();
            this.tabPageEmulator = new System.Windows.Forms.TabPage();
            this.richTextBoxEmulatorOutput = new System.Windows.Forms.RichTextBox();
            this.panelEmulator = new System.Windows.Forms.Panel();
            this.buttonStartEmulator = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabPageSetting.SuspendLayout();
            this.groupBoxDD.SuspendLayout();
            this.groupBoxCompiler.SuspendLayout();
            this.groupBoxQEMU.SuspendLayout();
            this.tabPageEditor.SuspendLayout();
            this.tabPageCompile.SuspendLayout();
            this.groupBoxOutput.SuspendLayout();
            this.groupBoxFile.SuspendLayout();
            this.panelCompile.SuspendLayout();
            this.tabPageImage.SuspendLayout();
            this.tabPageEmulator.SuspendLayout();
            this.panelEmulator.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageSetting);
            this.tabControl.Controls.Add(this.tabPageEditor);
            this.tabControl.Controls.Add(this.tabPageCompile);
            this.tabControl.Controls.Add(this.tabPageImage);
            this.tabControl.Controls.Add(this.tabPageEmulator);
            this.tabControl.Location = new System.Drawing.Point(0, -1);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(617, 304);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // tabPageSetting
            // 
            this.tabPageSetting.AutoScroll = true;
            this.tabPageSetting.Controls.Add(this.groupBoxDD);
            this.tabPageSetting.Controls.Add(this.groupBoxCompiler);
            this.tabPageSetting.Controls.Add(this.groupBoxQEMU);
            this.tabPageSetting.Location = new System.Drawing.Point(4, 28);
            this.tabPageSetting.Name = "tabPageSetting";
            this.tabPageSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSetting.Size = new System.Drawing.Size(609, 272);
            this.tabPageSetting.TabIndex = 0;
            this.tabPageSetting.Text = "Setting";
            this.tabPageSetting.UseVisualStyleBackColor = true;
            // 
            // groupBoxDD
            // 
            this.groupBoxDD.Controls.Add(this.buttonDD);
            this.groupBoxDD.Controls.Add(this.textBoxDD);
            this.groupBoxDD.Controls.Add(this.labelDD);
            this.groupBoxDD.Location = new System.Drawing.Point(8, 257);
            this.groupBoxDD.Name = "groupBoxDD";
            this.groupBoxDD.Size = new System.Drawing.Size(555, 94);
            this.groupBoxDD.TabIndex = 8;
            this.groupBoxDD.TabStop = false;
            this.groupBoxDD.Text = "DD(Cygwin)";
            // 
            // buttonDD
            // 
            this.buttonDD.Location = new System.Drawing.Point(471, 21);
            this.buttonDD.Name = "buttonDD";
            this.buttonDD.Size = new System.Drawing.Size(75, 47);
            this.buttonDD.TabIndex = 2;
            this.buttonDD.Text = "Select";
            this.buttonDD.UseVisualStyleBackColor = true;
            this.buttonDD.Click += new System.EventHandler(this.buttonDD_Click);
            // 
            // textBoxDD
            // 
            this.textBoxDD.Location = new System.Drawing.Point(6, 43);
            this.textBoxDD.Name = "textBoxDD";
            this.textBoxDD.Size = new System.Drawing.Size(459, 25);
            this.textBoxDD.TabIndex = 1;
            // 
            // labelDD
            // 
            this.labelDD.AutoSize = true;
            this.labelDD.Location = new System.Drawing.Point(6, 21);
            this.labelDD.Name = "labelDD";
            this.labelDD.Size = new System.Drawing.Size(85, 18);
            this.labelDD.TabIndex = 0;
            this.labelDD.Text = "Select DD";
            // 
            // groupBoxCompiler
            // 
            this.groupBoxCompiler.Controls.Add(this.labelCompiler);
            this.groupBoxCompiler.Controls.Add(this.textBoxCompiler);
            this.groupBoxCompiler.Controls.Add(this.buttonCompiler);
            this.groupBoxCompiler.Location = new System.Drawing.Point(8, 162);
            this.groupBoxCompiler.Name = "groupBoxCompiler";
            this.groupBoxCompiler.Size = new System.Drawing.Size(555, 89);
            this.groupBoxCompiler.TabIndex = 7;
            this.groupBoxCompiler.TabStop = false;
            this.groupBoxCompiler.Text = "Compiler";
            // 
            // labelCompiler
            // 
            this.labelCompiler.AutoSize = true;
            this.labelCompiler.Location = new System.Drawing.Point(6, 21);
            this.labelCompiler.Name = "labelCompiler";
            this.labelCompiler.Size = new System.Drawing.Size(127, 18);
            this.labelCompiler.TabIndex = 2;
            this.labelCompiler.Text = "Select Compiler";
            // 
            // textBoxCompiler
            // 
            this.textBoxCompiler.Location = new System.Drawing.Point(6, 42);
            this.textBoxCompiler.Name = "textBoxCompiler";
            this.textBoxCompiler.ReadOnly = true;
            this.textBoxCompiler.Size = new System.Drawing.Size(459, 25);
            this.textBoxCompiler.TabIndex = 3;
            // 
            // buttonCompiler
            // 
            this.buttonCompiler.Location = new System.Drawing.Point(471, 21);
            this.buttonCompiler.Name = "buttonCompiler";
            this.buttonCompiler.Size = new System.Drawing.Size(75, 46);
            this.buttonCompiler.TabIndex = 5;
            this.buttonCompiler.Text = "Select";
            this.buttonCompiler.UseVisualStyleBackColor = true;
            this.buttonCompiler.Click += new System.EventHandler(this.buttonCompiler_Click);
            // 
            // groupBoxQEMU
            // 
            this.groupBoxQEMU.Controls.Add(this.buttonQEMUImage);
            this.groupBoxQEMU.Controls.Add(this.labelQEMUEmulator);
            this.groupBoxQEMU.Controls.Add(this.buttonQEMUEmulator);
            this.groupBoxQEMU.Controls.Add(this.textBoxQEMUImage);
            this.groupBoxQEMU.Controls.Add(this.labeQEMUImage);
            this.groupBoxQEMU.Controls.Add(this.textBoxQEMUEmulator);
            this.groupBoxQEMU.Location = new System.Drawing.Point(6, 6);
            this.groupBoxQEMU.Name = "groupBoxQEMU";
            this.groupBoxQEMU.Size = new System.Drawing.Size(557, 150);
            this.groupBoxQEMU.TabIndex = 6;
            this.groupBoxQEMU.TabStop = false;
            this.groupBoxQEMU.Text = "QEMU";
            // 
            // buttonQEMUImage
            // 
            this.buttonQEMUImage.Location = new System.Drawing.Point(473, 86);
            this.buttonQEMUImage.Name = "buttonQEMUImage";
            this.buttonQEMUImage.Size = new System.Drawing.Size(75, 46);
            this.buttonQEMUImage.TabIndex = 7;
            this.buttonQEMUImage.Text = "Select";
            this.buttonQEMUImage.UseVisualStyleBackColor = true;
            this.buttonQEMUImage.Click += new System.EventHandler(this.buttonQEMUImage_Click);
            // 
            // labelQEMUEmulator
            // 
            this.labelQEMUEmulator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelQEMUEmulator.AutoSize = true;
            this.labelQEMUEmulator.Location = new System.Drawing.Point(6, 21);
            this.labelQEMUEmulator.Name = "labelQEMUEmulator";
            this.labelQEMUEmulator.Size = new System.Drawing.Size(180, 18);
            this.labelQEMUEmulator.TabIndex = 0;
            this.labelQEMUEmulator.Text = "Select QEMU Emulator";
            // 
            // buttonQEMUEmulator
            // 
            this.buttonQEMUEmulator.Location = new System.Drawing.Point(473, 21);
            this.buttonQEMUEmulator.Name = "buttonQEMUEmulator";
            this.buttonQEMUEmulator.Size = new System.Drawing.Size(75, 46);
            this.buttonQEMUEmulator.TabIndex = 4;
            this.buttonQEMUEmulator.Text = "Select";
            this.buttonQEMUEmulator.UseVisualStyleBackColor = true;
            this.buttonQEMUEmulator.Click += new System.EventHandler(this.buttonQEMUEmulator_Click);
            // 
            // textBoxQEMUImage
            // 
            this.textBoxQEMUImage.Location = new System.Drawing.Point(9, 107);
            this.textBoxQEMUImage.Name = "textBoxQEMUImage";
            this.textBoxQEMUImage.ReadOnly = true;
            this.textBoxQEMUImage.Size = new System.Drawing.Size(458, 25);
            this.textBoxQEMUImage.TabIndex = 6;
            // 
            // labeQEMUImage
            // 
            this.labeQEMUImage.AutoSize = true;
            this.labeQEMUImage.Location = new System.Drawing.Point(6, 86);
            this.labeQEMUImage.Name = "labeQEMUImage";
            this.labeQEMUImage.Size = new System.Drawing.Size(207, 18);
            this.labeQEMUImage.TabIndex = 5;
            this.labeQEMUImage.Text = "Select QEMU Image Maker";
            // 
            // textBoxQEMUEmulator
            // 
            this.textBoxQEMUEmulator.Location = new System.Drawing.Point(9, 42);
            this.textBoxQEMUEmulator.Name = "textBoxQEMUEmulator";
            this.textBoxQEMUEmulator.ReadOnly = true;
            this.textBoxQEMUEmulator.Size = new System.Drawing.Size(458, 25);
            this.textBoxQEMUEmulator.TabIndex = 1;
            // 
            // tabPageEditor
            // 
            this.tabPageEditor.Controls.Add(this.panelLineNumber);
            this.tabPageEditor.Controls.Add(this.richTextBoxEditor);
            this.tabPageEditor.Location = new System.Drawing.Point(4, 28);
            this.tabPageEditor.Name = "tabPageEditor";
            this.tabPageEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEditor.Size = new System.Drawing.Size(609, 272);
            this.tabPageEditor.TabIndex = 1;
            this.tabPageEditor.Text = "Editor";
            this.tabPageEditor.UseVisualStyleBackColor = true;
            // 
            // panelLineNumber
            // 
            this.panelLineNumber.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panelLineNumber.Location = new System.Drawing.Point(3, 3);
            this.panelLineNumber.Name = "panelLineNumber";
            this.panelLineNumber.Size = new System.Drawing.Size(38, 266);
            this.panelLineNumber.TabIndex = 1;
            this.panelLineNumber.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLineNumber_Paint);
            // 
            // richTextBoxEditor
            // 
            this.richTextBoxEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxEditor.Location = new System.Drawing.Point(47, 3);
            this.richTextBoxEditor.Name = "richTextBoxEditor";
            this.richTextBoxEditor.Size = new System.Drawing.Size(559, 266);
            this.richTextBoxEditor.TabIndex = 0;
            this.richTextBoxEditor.Text = "";
            this.richTextBoxEditor.VScroll += new System.EventHandler(this.richTextBoxEditor_VScroll);
            this.richTextBoxEditor.TextChanged += new System.EventHandler(this.richTextBoxEditor_TextChanged);
            // 
            // tabPageCompile
            // 
            this.tabPageCompile.Controls.Add(this.buttonCompile);
            this.tabPageCompile.Controls.Add(this.groupBoxOutput);
            this.tabPageCompile.Controls.Add(this.groupBoxFile);
            this.tabPageCompile.Location = new System.Drawing.Point(4, 28);
            this.tabPageCompile.Name = "tabPageCompile";
            this.tabPageCompile.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCompile.Size = new System.Drawing.Size(609, 272);
            this.tabPageCompile.TabIndex = 2;
            this.tabPageCompile.Text = "Compile";
            this.tabPageCompile.UseVisualStyleBackColor = true;
            // 
            // buttonCompile
            // 
            this.buttonCompile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCompile.Location = new System.Drawing.Point(476, 6);
            this.buttonCompile.Name = "buttonCompile";
            this.buttonCompile.Size = new System.Drawing.Size(126, 76);
            this.buttonCompile.TabIndex = 0;
            this.buttonCompile.Text = "Compile";
            this.buttonCompile.UseVisualStyleBackColor = true;
            this.buttonCompile.Click += new System.EventHandler(this.buttonCompile_Click);
            // 
            // groupBoxOutput
            // 
            this.groupBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOutput.Controls.Add(this.richTextBoxCompileOutput);
            this.groupBoxOutput.Location = new System.Drawing.Point(8, 79);
            this.groupBoxOutput.Name = "groupBoxOutput";
            this.groupBoxOutput.Size = new System.Drawing.Size(595, 186);
            this.groupBoxOutput.TabIndex = 3;
            this.groupBoxOutput.TabStop = false;
            this.groupBoxOutput.Text = "Output";
            // 
            // richTextBoxCompileOutput
            // 
            this.richTextBoxCompileOutput.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxCompileOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxCompileOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxCompileOutput.Location = new System.Drawing.Point(3, 21);
            this.richTextBoxCompileOutput.Name = "richTextBoxCompileOutput";
            this.richTextBoxCompileOutput.Size = new System.Drawing.Size(589, 162);
            this.richTextBoxCompileOutput.TabIndex = 0;
            this.richTextBoxCompileOutput.Text = "";
            // 
            // groupBoxFile
            // 
            this.groupBoxFile.Controls.Add(this.panelCompile);
            this.groupBoxFile.Controls.Add(this.buttonOpen);
            this.groupBoxFile.Location = new System.Drawing.Point(8, 6);
            this.groupBoxFile.Name = "groupBoxFile";
            this.groupBoxFile.Size = new System.Drawing.Size(462, 67);
            this.groupBoxFile.TabIndex = 2;
            this.groupBoxFile.TabStop = false;
            this.groupBoxFile.Text = "File";
            // 
            // panelCompile
            // 
            this.panelCompile.Controls.Add(this.textBoxFileName);
            this.panelCompile.Controls.Add(this.labelFileName);
            this.panelCompile.Controls.Add(this.buttonSave);
            this.panelCompile.Location = new System.Drawing.Point(87, 13);
            this.panelCompile.Name = "panelCompile";
            this.panelCompile.Size = new System.Drawing.Size(369, 48);
            this.panelCompile.TabIndex = 2;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(191, 13);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(174, 25);
            this.textBoxFileName.TabIndex = 2;
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(84, 18);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(101, 18);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "Current File:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(3, 11);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 33);
            this.buttonSave.TabIndex = 0;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(6, 24);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(75, 33);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "Open";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // tabPageImage
            // 
            this.tabPageImage.Controls.Add(this.buttonMkImg);
            this.tabPageImage.Controls.Add(this.comboBoxSizeUnit);
            this.tabPageImage.Controls.Add(this.textBoxBlockCnt);
            this.tabPageImage.Controls.Add(this.textBoxBlockSize);
            this.tabPageImage.Controls.Add(this.labelBlockCnt);
            this.tabPageImage.Controls.Add(this.labelBlockSize);
            this.tabPageImage.Location = new System.Drawing.Point(4, 28);
            this.tabPageImage.Name = "tabPageImage";
            this.tabPageImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageImage.Size = new System.Drawing.Size(609, 272);
            this.tabPageImage.TabIndex = 3;
            this.tabPageImage.Text = "Image";
            this.tabPageImage.UseVisualStyleBackColor = true;
            // 
            // buttonMkImg
            // 
            this.buttonMkImg.Location = new System.Drawing.Point(331, 9);
            this.buttonMkImg.Name = "buttonMkImg";
            this.buttonMkImg.Size = new System.Drawing.Size(75, 56);
            this.buttonMkImg.TabIndex = 3;
            this.buttonMkImg.Text = "Make";
            this.buttonMkImg.UseVisualStyleBackColor = true;
            this.buttonMkImg.Click += new System.EventHandler(this.buttonMkImg_Click);
            // 
            // comboBoxSizeUnit
            // 
            this.comboBoxSizeUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSizeUnit.FormattingEnabled = true;
            this.comboBoxSizeUnit.Items.AddRange(new object[] {
            "B",
            "KB",
            "MB"});
            this.comboBoxSizeUnit.Location = new System.Drawing.Point(248, 8);
            this.comboBoxSizeUnit.Name = "comboBoxSizeUnit";
            this.comboBoxSizeUnit.Size = new System.Drawing.Size(62, 26);
            this.comboBoxSizeUnit.TabIndex = 2;
            // 
            // textBoxBlockCnt
            // 
            this.textBoxBlockCnt.Location = new System.Drawing.Point(125, 40);
            this.textBoxBlockCnt.Name = "textBoxBlockCnt";
            this.textBoxBlockCnt.Size = new System.Drawing.Size(100, 25);
            this.textBoxBlockCnt.TabIndex = 1;
            this.textBoxBlockCnt.Text = "1";
            this.textBoxBlockCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // textBoxBlockSize
            // 
            this.textBoxBlockSize.Location = new System.Drawing.Point(126, 8);
            this.textBoxBlockSize.Name = "textBoxBlockSize";
            this.textBoxBlockSize.Size = new System.Drawing.Size(100, 25);
            this.textBoxBlockSize.TabIndex = 1;
            this.textBoxBlockSize.Text = "512";
            this.textBoxBlockSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelBlockCnt
            // 
            this.labelBlockCnt.AutoSize = true;
            this.labelBlockCnt.Location = new System.Drawing.Point(8, 43);
            this.labelBlockCnt.Name = "labelBlockCnt";
            this.labelBlockCnt.Size = new System.Drawing.Size(103, 18);
            this.labelBlockCnt.TabIndex = 0;
            this.labelBlockCnt.Text = "Block Count:";
            // 
            // labelBlockSize
            // 
            this.labelBlockSize.AutoSize = true;
            this.labelBlockSize.Location = new System.Drawing.Point(8, 11);
            this.labelBlockSize.Name = "labelBlockSize";
            this.labelBlockSize.Size = new System.Drawing.Size(90, 18);
            this.labelBlockSize.TabIndex = 0;
            this.labelBlockSize.Text = "Block Size:";
            // 
            // tabPageEmulator
            // 
            this.tabPageEmulator.AutoScroll = true;
            this.tabPageEmulator.Controls.Add(this.richTextBoxEmulatorOutput);
            this.tabPageEmulator.Controls.Add(this.panelEmulator);
            this.tabPageEmulator.Location = new System.Drawing.Point(4, 28);
            this.tabPageEmulator.Name = "tabPageEmulator";
            this.tabPageEmulator.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageEmulator.Size = new System.Drawing.Size(609, 272);
            this.tabPageEmulator.TabIndex = 4;
            this.tabPageEmulator.Text = "Emulator";
            this.tabPageEmulator.UseVisualStyleBackColor = true;
            // 
            // richTextBoxEmulatorOutput
            // 
            this.richTextBoxEmulatorOutput.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBoxEmulatorOutput.ForeColor = System.Drawing.SystemColors.Window;
            this.richTextBoxEmulatorOutput.Location = new System.Drawing.Point(3, 3);
            this.richTextBoxEmulatorOutput.Name = "richTextBoxEmulatorOutput";
            this.richTextBoxEmulatorOutput.Size = new System.Drawing.Size(562, 127);
            this.richTextBoxEmulatorOutput.TabIndex = 2;
            this.richTextBoxEmulatorOutput.Text = "";
            // 
            // panelEmulator
            // 
            this.panelEmulator.AutoScroll = true;
            this.panelEmulator.Controls.Add(this.buttonStartEmulator);
            this.panelEmulator.Location = new System.Drawing.Point(3, 133);
            this.panelEmulator.Name = "panelEmulator";
            this.panelEmulator.Size = new System.Drawing.Size(562, 189);
            this.panelEmulator.TabIndex = 1;
            // 
            // buttonStartEmulator
            // 
            this.buttonStartEmulator.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartEmulator.Location = new System.Drawing.Point(484, 3);
            this.buttonStartEmulator.Name = "buttonStartEmulator";
            this.buttonStartEmulator.Size = new System.Drawing.Size(75, 30);
            this.buttonStartEmulator.TabIndex = 0;
            this.buttonStartEmulator.Text = "Start";
            this.buttonStartEmulator.UseVisualStyleBackColor = true;
            this.buttonStartEmulator.Click += new System.EventHandler(this.buttonStartEmulator_Click);
            // 
            // x86_asm_studio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 304);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(640, 360);
            this.MinimumSize = new System.Drawing.Size(640, 360);
            this.Name = "x86_asm_studio";
            this.Text = "X86 ASM Studio";
            this.tabControl.ResumeLayout(false);
            this.tabPageSetting.ResumeLayout(false);
            this.groupBoxDD.ResumeLayout(false);
            this.groupBoxDD.PerformLayout();
            this.groupBoxCompiler.ResumeLayout(false);
            this.groupBoxCompiler.PerformLayout();
            this.groupBoxQEMU.ResumeLayout(false);
            this.groupBoxQEMU.PerformLayout();
            this.tabPageEditor.ResumeLayout(false);
            this.tabPageCompile.ResumeLayout(false);
            this.groupBoxOutput.ResumeLayout(false);
            this.groupBoxFile.ResumeLayout(false);
            this.panelCompile.ResumeLayout(false);
            this.panelCompile.PerformLayout();
            this.tabPageImage.ResumeLayout(false);
            this.tabPageImage.PerformLayout();
            this.tabPageEmulator.ResumeLayout(false);
            this.panelEmulator.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageSetting;
        private System.Windows.Forms.Label labelQEMUEmulator;
        private System.Windows.Forms.Button buttonCompiler;
        private System.Windows.Forms.Button buttonQEMUEmulator;
        private System.Windows.Forms.TextBox textBoxCompiler;
        private System.Windows.Forms.Label labelCompiler;
        private System.Windows.Forms.TextBox textBoxQEMUEmulator;
        private System.Windows.Forms.GroupBox groupBoxQEMU;
        private System.Windows.Forms.GroupBox groupBoxCompiler;
        private System.Windows.Forms.TabPage tabPageEditor;
        private System.Windows.Forms.TabPage tabPageCompile;
        private System.Windows.Forms.Label labeQEMUImage;
        private System.Windows.Forms.TextBox textBoxQEMUImage;
        private System.Windows.Forms.Button buttonQEMUImage;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.GroupBox groupBoxFile;
        private System.Windows.Forms.Button buttonCompile;
        private System.Windows.Forms.GroupBox groupBoxOutput;
        private System.Windows.Forms.TabPage tabPageImage;
        private System.Windows.Forms.TabPage tabPageEmulator;
        private System.Windows.Forms.Panel panelCompile;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.RichTextBox richTextBoxEditor;
        private System.Windows.Forms.RichTextBox richTextBoxCompileOutput;
        private System.Windows.Forms.GroupBox groupBoxDD;
        private System.Windows.Forms.Button buttonDD;
        private System.Windows.Forms.TextBox textBoxDD;
        private System.Windows.Forms.Label labelDD;
        private System.Windows.Forms.ComboBox comboBoxSizeUnit;
        private System.Windows.Forms.TextBox textBoxBlockCnt;
        private System.Windows.Forms.TextBox textBoxBlockSize;
        private System.Windows.Forms.Label labelBlockCnt;
        private System.Windows.Forms.Label labelBlockSize;
        private System.Windows.Forms.Button buttonMkImg;
        private System.Windows.Forms.Panel panelEmulator;
        private System.Windows.Forms.Button buttonStartEmulator;
        private System.Windows.Forms.RichTextBox richTextBoxEmulatorOutput;
        private System.Windows.Forms.Panel panelLineNumber;
    }
}

