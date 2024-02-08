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

namespace WindowsFormsTask2 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();

			DirectoryInfo directoryInfo = new DirectoryInfo("video");
			FileInfo[] files = directoryInfo.GetFiles();

			foreach (FileInfo file in files) {
				if (IsMp4(file.FullName)) {
					treeView.Nodes.Add(file.FullName);
				}
			}
		}

		private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
			axWindowsMediaPlayer.URL = treeView.SelectedNode.Text;
		}

		private bool IsMp4(string path) {
			return GetFileType(path).ToLower().CompareTo(".mp4".ToLower()) == 0;
		}

		private string GetFileType(string path) {
			int index = path.LastIndexOf('.');
			return path.Substring(index, path.Length - index);
		}
	}
}
