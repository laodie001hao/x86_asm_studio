using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace x86_asm_studio
{
    public partial class x86_asm_studio : Form
    {
        public x86_asm_studio()
        {
            InitializeComponent();
        }

        private void DrawLineNo()
        {
            Point editorTopLeftPos = this.richTextBoxEditor.Location;
            int chFstAbsoluteIdx = this.richTextBoxEditor.GetCharIndexFromPosition(editorTopLeftPos);
            int lineFstRelativeIdx = this.richTextBoxEditor.GetLineFromCharIndex(chFstAbsoluteIdx);
            Point chFstRelativePos = this.richTextBoxEditor.GetPositionFromCharIndex(chFstAbsoluteIdx);

            Point editorBottomRightPos = new Point(
                editorTopLeftPos.X, editorTopLeftPos.Y + richTextBoxEditor.Height);
            int chLstRelativeIdx = this.richTextBoxEditor.GetCharIndexFromPosition(editorBottomRightPos);
            int lineLstRelativeIdx = this.richTextBoxEditor.GetLineFromCharIndex(chLstRelativeIdx);
            Point chLstRelativePos = this.richTextBoxEditor.GetPositionFromCharIndex(chLstRelativeIdx);

            Graphics canvas = this.panelLineNumber.CreateGraphics();
            Font font = new Font(this.richTextBoxEditor.Font, this.richTextBoxEditor.Font.Style);
            SolidBrush brush = new SolidBrush(this.panelLineNumber.BackColor);

            brush.Color = Color.Gray;
            canvas.FillRectangle(brush, 0, 0, 
                this.panelLineNumber.ClientRectangle.Width, this.panelLineNumber.ClientRectangle.Height);
            brush.Color = Color.White;

            int lineSpace = 0;
            if (lineFstRelativeIdx != lineLstRelativeIdx) {
                lineSpace = (chLstRelativePos.Y - chFstRelativePos.Y) 
                          / (lineLstRelativeIdx - lineFstRelativeIdx);
            } else {
                lineSpace = Convert.ToInt32(this.richTextBoxEditor.Font.Size);
            }

            int brushX = this.panelLineNumber.ClientRectangle.Width - Convert.ToInt32(font.Size * 2.5);
            int brushY = chLstRelativePos.Y + Convert.ToInt32(font.Size * 0.21f);
            for (int idx = lineLstRelativeIdx; idx >= lineFstRelativeIdx; --idx) {
                canvas.DrawString((idx + 1).ToString(), font, brush, brushX, brushY);
                brushY -= lineSpace;
            }

            canvas.Dispose();
            font.Dispose();
            brush.Dispose();
        }

        protected override void OnLoad(EventArgs e)
        {
            this.textBoxQEMUEmulator.Text = loadConfig("Tools", "Emulator");
            this.textBoxQEMUImage.Text = loadConfig("Tools", "Image");
            this.textBoxCompiler.Text = loadConfig("Tools", "Compiler");
            this.textBoxDD.Text = loadConfig("Tools", "DD");
            this.comboBoxSizeUnit.SelectedIndex = 0;
            base.OnLoad(e);
        }

        protected override void OnClosed(EventArgs e)
        {
            makeConfigFile();
            saveConfig("Tools", "Emulator", this.textBoxQEMUEmulator.Text);
            saveConfig("Tools", "Image", this.textBoxQEMUImage.Text);
            saveConfig("Tools", "Compiler", this.textBoxCompiler.Text);
            saveConfig("Tools", "DD", this.textBoxDD.Text);
            base.OnClosed(e);
        }

        private void buttonQEMUEmulator_Click(object sender, EventArgs e)
        {
            this.textBoxQEMUEmulator.Text = getFileName("exe");
        }

        private void buttonCompiler_Click(object sender, EventArgs e)
        {
            this.textBoxCompiler.Text = getFileName("exe");
        }

        private void buttonQEMUImage_Click(object sender, EventArgs e)
        {
            this.textBoxQEMUImage.Text = getFileName("exe");
        }

        private void buttonDD_Click(object sender, EventArgs e)
        {
            this.textBoxDD.Text = getFileName("exe");
        }

        private string getFileName(string fileType)
        {
            string fileName = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "C:\\";
                openFileDialog.Filter = fileType + " " + "files (*." + fileType + ")|*." + fileType;
                openFileDialog.FilterIndex = 1;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    fileName = openFileDialog.FileName;
                }
            }
            return fileName;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl.SelectedTab.Name == "tabPageEditor")
            {
                this.richTextBoxEditor.Focus();
            }
            else {
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {   
            if (this.textBoxFileName.Text == "") {
                Stream stream;
                SaveFileDialog saveFileDialog = new SaveFileDialog();

                saveFileDialog.Filter = "asm files (*.asm)|*.asm";
                saveFileDialog.FilterIndex = 1;
                saveFileDialog.RestoreDirectory = true;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if ((stream = saveFileDialog.OpenFile()) != null)
                    {
                        var buffer = Encoding.ASCII.GetBytes(richTextBoxEditor.Text);
                        stream.Write(buffer, 0, buffer.Length);
                        this.textBoxFileName.Text = saveFileDialog.FileName;
                        stream.Close();
                    }
                }
            } else {
                using (StreamWriter writer = File.CreateText(this.textBoxFileName.Text)) {
                    writer.Write(this.richTextBoxEditor.Text);
                    writer.Close();
                }
            }
            
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            string fileName = getFileName("asm");

            if (fileName.Length == 0) {
                return;
            }

            this.textBoxFileName.Text = fileName;
            using (StreamReader reader = File.OpenText(fileName))
            {
                string line = string.Empty;
                this.richTextBoxEditor.Clear();
                while ((line = reader.ReadLine()) != null) {
                    this.richTextBoxEditor.Text += line;
                    this.richTextBoxEditor.Text += "\r\n";
                }
            }
            this.tabControl.SelectedTab = this.tabPageEditor;
        }

        private void buttonCompile_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == "") {
            } else {
                if (textBoxFileName.Text == "") {
                    richTextBoxCompileOutput.Text = "Open or Save a file first!";
                } else {
                    string output = string.Empty;
                    doCompile(textBoxFileName.Text, ref output);
                    if (output == "") {
                        this.richTextBoxCompileOutput.Text = "Successful!";
                    } else {
                        this.richTextBoxCompileOutput.Text = output;
                    }
                }
            }
        }

        private void buttonMkImg_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == "") {
            } else {
                string output = string.Empty;
                makeImage(this.textBoxFileName.Text, this.textBoxBlockSize.Text, 
                    this.textBoxBlockCnt.Text, this.comboBoxSizeUnit.SelectedIndex, ref output);
                MessageBox.Show(output, "Image", MessageBoxButtons.OK, MessageBoxIcon.None);
            }
        }

        private void buttonStartEmulator_Click(object sender, EventArgs e)
        {
            if (textBoxFileName.Text == "") {
            } else {
                string[] ops = new string[8];
                startEmulator(this.textBoxFileName.Text, ops);
            }
        }

        private void richTextBoxEditor_TextChanged(object sender, EventArgs e)
        {
            DrawLineNo();
        }

        private void richTextBoxEditor_VScroll(object sender, EventArgs e)
        {
            DrawLineNo();
        }

        private void panelLineNumber_Paint(object sender, PaintEventArgs e)
        {
            DrawLineNo();
        }
    }
}
