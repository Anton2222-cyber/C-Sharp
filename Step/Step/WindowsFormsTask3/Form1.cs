using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsTask3 {
	public partial class Form1 : Form {
		string path = "";

		public Form1() {
			InitializeComponent();


			//DirectoryInfo directory = new DirectoryInfo();

			//directory.

			LoadDrives();
		}

		private void LoadDrives() {
			listBox.Items.Clear();

			DriveInfo[] allDrives = DriveInfo.GetDrives();
			foreach (DriveInfo drive in allDrives) {
				listBox.Items.Add(drive.Name);
			}
		}

		private void listBox_SelectedIndexChanged(object sender, EventArgs e) {
			if (listBox.SelectedIndex == -1)
				return;

			SafeOpenFolder(listBox.SelectedItem.ToString());
		}

		private void listBoxDirectoryViewer_DoubleClick(object sender, EventArgs e) {
			if (listBoxDirectoryViewer.SelectedIndex == -1)
				return;

			SafeOpenFolder(path + '\\' + listBoxDirectoryViewer.SelectedItem.ToString());
		}

		private void buttonUndo_Click(object sender, EventArgs e) {
			if (path.Length == 0)
				return;

			DirectoryInfo directory = new DirectoryInfo(path);

			if (directory.FullName == directory.Root.FullName)
				return;

			SafeOpenFolder(directory.Parent.FullName);
		}

		private void SafeOpenFolder(string path) {
			if (path.Length == 0)
				return;

			try {
				OpenFolder(path);
			}
			catch (System.UnauthorizedAccessException) {
				MessageBox.Show("Немає доступу до папки", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				OpenFolder(this.path);
			}
		}

		private void OpenFolder(string path) {
			DirectoryInfo directory = new DirectoryInfo(path);

			if (!directory.Exists)
				return;

			listBoxDirectoryViewer.Items.Clear();

			foreach (DirectoryInfo dir in directory.GetDirectories()) {
				listBoxDirectoryViewer.Items.Add(dir.Name);
			}

			foreach (FileInfo file in directory.GetFiles()) {
				listBoxDirectoryViewer.Items.Add(file.Name);
			}

			textBoxPath.Text = this.path = directory.FullName;
		}

		private void ToolStripMenuItemUpdate_Click(object sender, EventArgs e) {
			SafeOpenFolder(path);
		}
	}
}
