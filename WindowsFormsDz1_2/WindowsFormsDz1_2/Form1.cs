using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsDz1_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //Text = e.X + " " + e.Y;
            if (e.X > 180 && e.X < 254 && e.Y > 177 && e.Y < 225)
            {
                Yes.Location = new Point(441, 285);
            }
            else if (e.X > 429 && e.X < 502 && e.Y > 267 && e.Y < 317)
            {
                Yes.Location = new Point(193, 195);
            }
        }
    }
}
