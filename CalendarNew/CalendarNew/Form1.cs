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


namespace CalendarNew
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Registration.txt", FileMode.Create, FileAccess.Write, FileShare.Write);
            StreamWriter streamWriter = new StreamWriter(fs, Encoding.UTF8);
            streamWriter.WriteLine(lastname.Text+" "+name.Text + " "+ surname.Text);
            streamWriter.WriteLine(sex.Text);
            streamWriter.WriteLine(familystatus.Text);
            streamWriter.WriteLine(dateofbirth.Text);
            streamWriter.WriteLine(addition.Text);
            streamWriter.Dispose();
            fs.Close();
            message.Text = "Збережено!";
        }
    }
}
