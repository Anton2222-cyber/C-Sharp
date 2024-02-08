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
    public partial class Form1 : Form
    {
        List<Tovar> tovars;
        public Form1()
        {
            InitializeComponent();
            tovars = new List<Tovar>();
            //tovars.Add(new Tovar { Name = "fdsf", Cost = 12.2F, Coutry = "sddfgfdgfdsf" });
            //tovars.Add(new Tovar { Name = "fddgfd334sf", Cost = 1122.2F, Coutry = "sgdsggfdgfdgfdsf" });
            //tovars.Add(new Tovar { Name = "fds43434f", Cost = 1233.2F, Coutry = "sdgdfdfdsf" });
            baza.DataSource = tovars;
            baza.DisplayMember = tovars.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                if (form2.ShowDialog() == DialogResult.OK)
                {
                   
                    tovars.Add(new Tovar { Name = form2.Name, Coutry = form2.Country,Cost=form2.Cost });
                    baza.DataSource = null;
                    baza.DataSource = tovars;
                    baza.DisplayMember = tovars.ToString();
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show("Не правильний формат!");
            }
        }

        private void RedactButton_Click(object sender, EventArgs e)
        {
            try
            {
                Form2 form2 = new Form2();
                form2.Redact(tovars[baza.SelectedIndex].Name, tovars[baza.SelectedIndex].Coutry, tovars[baza.SelectedIndex].Cost);
                if (form2.ShowDialog() == DialogResult.OK)
                {

                    tovars.Add(new Tovar { Name = form2.Name, Coutry = form2.Country, Cost = form2.Cost });
                    tovars.Remove((Tovar)baza.SelectedItem);
                    baza.DataSource = null;
                    baza.DataSource = tovars;
                    baza.DisplayMember = tovars.ToString();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не правильний формат!");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            tovars.Remove((Tovar)baza.SelectedItem);
            baza.DataSource = null;
            baza.DataSource = tovars;
            baza.DisplayMember = tovars.ToString();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            tovars.Clear();
            baza.DataSource = null;
            baza.DataSource = tovars;
            baza.DisplayMember = tovars.ToString();
        }
    }
    class Tovar
    {
        public string Name { set; get; }
        public string Coutry { set; get; }
        public float Cost { set; get; }
        public override string ToString()
        {
            return Name + " Виробник: " + Coutry + " " + Cost+" грн";
        }
    }
}
