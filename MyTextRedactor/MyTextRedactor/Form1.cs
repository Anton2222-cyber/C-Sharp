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

namespace MyTextRedactor
{
    public partial class Form1 : Form
    {
        string directory;
        public Form1()
        {
            InitializeComponent();
            directory = null;
        }

        private void відкритиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                using (FileStream f = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    directory = openFileDialog1.FileName;
                    StreamReader streamReader = new StreamReader(f, Encoding.UTF8);
                    txt.Text=streamReader.ReadToEnd();

                    streamReader.Dispose();
                }
            }
        }

        private void зберегтиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if(directory!=null)
            {
                using (FileStream f = new FileStream(directory, FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    StreamWriter streamWriter = new StreamWriter(f, Encoding.UTF8);
                    streamWriter.Write(txt.Text);

                    streamWriter.Dispose();
                    MessageBox.Show("Збережено!");
                }
            }
            else
            {
                if(saveFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    using (FileStream f = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.Write))
                    {
                        StreamWriter streamWriter = new StreamWriter(f, Encoding.UTF8);
                        streamWriter.Write(txt.Text);

                        streamWriter.Dispose();
                        MessageBox.Show("Збережено!");
                    }
                }
            }
        }

        private void зберегтиЯкToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (FileStream f = new FileStream(saveFileDialog1.FileName, FileMode.Create, FileAccess.Write, FileShare.Write))
                {
                    StreamWriter streamWriter = new StreamWriter(f, Encoding.UTF8);
                    streamWriter.Write(txt.Text);

                    streamWriter.Dispose();
                    MessageBox.Show("Збережено!");
                }
            }
        }

        private void копіюватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.Copy();
        }

        private void вирізатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.Cut();
        }

        private void вставитиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.Paste();
        }

        private void скасуватиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.Undo();
        }

        private void виділитиВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txt.SelectAll();
        }

        private void колірШрифтуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()==DialogResult.OK)
            {
                txt.ForeColor = colorDialog1.Color;
            }
        }

        private void шрифтToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txt.Font = fontDialog1.Font;
            }
        }

        private void колірФонуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txt.BackColor = colorDialog1.Color;
            }
        }

        
    }
}
