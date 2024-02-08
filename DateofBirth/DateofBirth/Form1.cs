using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateofBirth
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void Set_Date()
        {
            try
            {
                
                Calendar.SelectionStart = new DateTime(Convert.ToInt32(year.Text), Convert.ToInt32(month.Text), Convert.ToInt32(day.Text));
                Calendar.SelectionEnd = new DateTime(Convert.ToInt32(year.Text), Convert.ToInt32(month.Text), Convert.ToInt32(day.Text));
            }
            catch(Exception e)
            {
               
            }
        }
        private void day_TextChanged(object sender, EventArgs e)
        {
            Set_Date();
        }

        private void month_TextChanged(object sender, EventArgs e)
        {
            Set_Date();
        }

        private void year_TextChanged(object sender, EventArgs e)
        {
            Set_Date();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
