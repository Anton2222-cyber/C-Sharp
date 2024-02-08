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

namespace TreeViewPlayer
{
    public partial class Player : Form
    {
        List<string> URL;
        AxWMPLib.AxWindowsMediaPlayer my_player;
        public Player()
        {
            my_player = new AxWMPLib.AxWindowsMediaPlayer();
            my_player.Location = new Point(320, 13);
            my_player.Size = new Size(440, 345);
            this.Controls.Add(my_player);
            InitializeComponent();
            URL = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(textBox1.Text);
                FileInfo[] files = directoryInfo.GetFiles("*.mp*");
               
                foreach (FileInfo file in files)
                {
                    treeView1.Nodes.Add(file.Name);
                    URL.Add(file.FullName);
                }
                
            }
            catch (Exception exc)
            {

            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            TreeView tv = sender as TreeView;
            my_player.URL = URL[tv.SelectedNode.Index];
        }
    }
}
