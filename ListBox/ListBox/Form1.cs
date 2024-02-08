using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (txt.Text != "")
            {
                bool b = true;
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    if (string.Compare(txt.Text, (string)listBox1.Items[i]) == 0)
                    {
                        b = false;
                        break;
                    }
                }
                if (b)
                {
                    listBox1.Items.Add(txt.Text);
                }
            }
        }
        private void Delete(string text)
        {
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                if(string.Compare(text, (string)listBox1.Items[i])==0)
                {
                    listBox1.Items.RemoveAt(i);
                    break;
                }
            }
        }
        private void Remove_Click(object sender, EventArgs e)
        {
            var arr = listBox1.SelectedItems;
            while(arr.Count>0)
                Delete((string)arr[0]);
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            for(int i=0;i<listBox1.Items.Count;i++)
            {
                listBox2.Items.Add(listBox1.Items[i]);
            }
        }
    }
}
