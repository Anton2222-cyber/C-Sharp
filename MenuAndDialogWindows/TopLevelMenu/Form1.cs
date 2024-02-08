using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopLevelMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool b = true;
            for(int i=0;i< menuStrip1.Items.Count;i++)
            {
                if(menuStrip1.Items[i].Text== TopLevelMenu.Text)
                {
                    b = false;
                    break;
                }
            }
            if(b)
            {
                menuStrip1.Items.Add(TopLevelMenu.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool b;
            for (int i = 0; i < menuStrip1.Items.Count; i++)
            {
                b = true;
                if (menuStrip1.Items[i].Text == TopLevelMenu.Text)
                {
                    for(int j=0;j< ((ToolStripMenuItem)menuStrip1.Items[i]).DropDownItems.Count;j++)
                    {
                        if(((ToolStripMenuItem)menuStrip1.Items[i]).DropDownItems[j].Text== SubItem.Text)
                        {
                            b = false;
                            break;
                        }
                    }
                    if(b)
                    ((ToolStripMenuItem)menuStrip1.Items[i]).DropDownItems.Add(SubItem.Text);
                }
            }
        }
    }
}
