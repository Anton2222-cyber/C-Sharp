using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                if (e.X > 50 && e.X < 552 && e.Y ==51)
                    label1.Text = "На межі";
                else if(e.X==51&&e.Y>50&&e.Y<438)
                    label1.Text = "На межі";
                else if(e.X==551&& e.Y > 50 && e.Y < 438)
                    label1.Text = "На межі";
                else if(e.X > 50 && e.X < 552 && e.Y == 437)
                    label1.Text = "На межі";
                else if (e.X > 50 && e.X < 552 && e.Y > 50 && e.Y < 438)
                    label1.Text = "Усередині:"+ e.X + "," + e.Y;
                else
                    label1.Text = "Ззовні:" + e.X + "," + e.Y;
            }
            else if (e.Button == MouseButtons.Right)
            {
                Text = "Ширина=" + Size.Width + " Висота=" + Size.Height;
            }

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Text = "Ширина=" + Size.Width + " Висота=" + Size.Height;
            }
            else
            Text = "X=" + e.X + " Y=" + e.Y;
        }
    }
}
