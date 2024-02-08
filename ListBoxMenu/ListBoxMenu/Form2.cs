using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxMenu
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        public string Name
        {
            set { name.Text = value; }
            get { return name.Text; }
        }
        public string Country
        {
            set { country.Text = value; }
            get { return country.Text; }
        }
        public float Cost
        {
           
                set { try { cost.Text = value.ToString(); } catch (Exception e) { } }
                get { return  Convert.ToSingle(cost.Text);}
            
        }

        private void YesButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
        public void Redact(string name_,string country_,float cost_)
        {
            name.Text = name_;
            country.Text = country_;
            cost.Text = cost_.ToString();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
