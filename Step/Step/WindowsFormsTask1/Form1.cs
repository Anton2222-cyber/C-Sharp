using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsTask1 {
	public partial class Form1 : Form {
		public Form1() {
			InitializeComponent();
		}

		private void buttonLoad_Click(object sender, EventArgs e) {
			openFileDialog.Filter = "XML|*.xml";

			if (openFileDialog.ShowDialog() == DialogResult.OK) {
				try {
					PrintXMLStructure(openFileDialog.FileName);
				}
				catch (Exception) {
					MessageBox.Show("Невідома помилка", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		public void PrintXMLStructure(string path) {
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(path);

			treeView.Nodes.Clear();
			PrintXML(xmlDoc, treeView.Nodes);
		}

		protected void PrintXML(XmlNode parentNode, TreeNodeCollection parentTreeNodeCollection) {
			foreach (XmlNode node in parentNode.ChildNodes) {
				TreeNode treeNode = new TreeNode();
				if (node.Name != "#text") {
					treeNode.Text = node.Name;
				}
				else {
					treeNode.Text = string.Format("\"{0}\"", node.InnerText);
				}

				PrintXML(node, treeNode.Nodes);

				parentTreeNodeCollection.Add(treeNode);
			}
		}
	}
}
