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

namespace SearchFile
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(textBox2.Text);
                FileInfo[] files = directoryInfo.GetFiles(textBox1.Text);
                Form2 form2 = new Form2();
                foreach(FileInfo file in files)
                {
                    form2.ListBOX.Items.Add(file.Name);
                }
                form2.Show();
            }
            catch(Exception exc)
            {

            }
            
        }
    }
}
