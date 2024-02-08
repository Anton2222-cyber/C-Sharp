using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace ProgressBarReadFromFile
{
    public partial class Reader : System.Windows.Forms.Form
    {
        public Reader()
        {
            InitializeComponent();
        }

        private void Read_Click(object sender, EventArgs e)
        {
            try
            {
                FileStream file = new FileStream(Folder.Text + ".txt", FileMode.Open, FileAccess.Read, FileShare.Read);
                progressBar1.Maximum = (int)file.Length;
                while (file.Position < file.Length)
                {
                    if (file.Position % 2 == 0)
                        Text = "Завантаження.";
                    else if (file.Position % 3 == 0)
                        Text = "Завантаження..";
                    else
                        Text = "Завантаження...";
                    file.Read(new byte[1], 0, 1);
                    progressBar1.PerformStep();
                    Thread.Sleep(200);

                }
                file.Close();
                Thread.Sleep(500);
                Text = "Reader";
                Message.Text = "Зчитано!";
            }
            catch(Exception exc)
            {

            }
        }
    }
}
