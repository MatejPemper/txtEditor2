using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace txtEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.Filter = "Text Files | *.txt";
            savefile.DefaultExt = "txt";
            if (savefile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter txtoutput = new StreamWriter(savefile.FileName);
                txtoutput.Write(richTextBox.Text);
                txtoutput.Close();
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Title = "My open file dialog";
            if (openfile.ShowDialog() == DialogResult.OK)
            {
                richTextBox.Clear();
                using (StreamReader sr = new StreamReader(openfile.FileName))
                {
                    richTextBox.Text = sr.ReadToEnd();
                    sr.Close();
                }
            }
        }

        private void uNDOToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            richTextBox.Undo();
        }

        private void cUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        private void cOPYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox.Copy();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void bOLDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(this.richTextBox.Font, FontStyle.Bold);
        }

        private void iTALICToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(this.richTextBox.Font, FontStyle.Italic);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 10.0F);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 12.0F);
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 15.0F);
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 18.0F);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 20.0F);
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            this.richTextBox.SelectionFont = new Font(richTextBox.SelectionFont.FontFamily, 25.0F);
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
        }
    }
}
