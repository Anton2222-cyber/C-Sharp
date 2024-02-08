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

namespace FileManager
{
    public partial class FileManager : Form
    {
        void AddDirectory(string path,TreeNode node)
        {
            try
            {
                DirectoryInfo directory = new DirectoryInfo(path);
                DirectoryInfo[] directories = directory.GetDirectories();
                foreach (DirectoryInfo d in directories)
                {
                    TreeNode tmp = new TreeNode(d.FullName);//
                    node.Nodes.Add(tmp);
                    AddDirectory(d.FullName, tmp);
                }
            }
            catch(Exception e)
            {

            }
        }
        public FileManager()
        {
            InitializeComponent();
            TreeNode tmp;
            DriveInfo[] driveInfos = DriveInfo.GetDrives();

            //tmp = new TreeNode(driveInfos[1].Name);
            //treeView1.Nodes.Add(tmp);
            //AddDirectory(driveInfos[1].Name, tmp);

            //tmp = new TreeNode(driveInfos[0].Name);
            //treeView1.Nodes.Add(tmp);
            //AddDirectory(driveInfos[0].Name, tmp);
            foreach (DriveInfo d in driveInfos)
            {
                tmp = new TreeNode(d.Name);
                treeView1.Nodes.Add(tmp);
                AddDirectory(d.Name, tmp);
            }
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                listBox1.Items.Clear();

                DirectoryInfo directoryInfo = new DirectoryInfo(treeView1.SelectedNode.Text);
                FileInfo[] files = directoryInfo.GetFiles();
               
                foreach (FileInfo file in files)
                {
                    listBox1.Items.Add(file.Name);
                }
                
            }
            catch (Exception exc)
            {

            }
        }
    }
}
