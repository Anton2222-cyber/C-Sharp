using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIPaint
{
    public partial class MyPaint2 : Form
    {
       
        Pen pen;
        Color color;
		Point first;
		Point second;
        public MyPaint2()
        {
            InitializeComponent();
			pen = new Pen(Color.Black, 3);
			
		}

        private void MyPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
           
			if(toolStripButtonLine.Checked==true)
            {
				g.DrawLine(pen, first, second);
            }
            //g.Dispose();
        }

        private void toolStripButtonPen_Click(object sender, EventArgs e)
        {
			ToolStripButton t = sender as ToolStripButton;
			if(t.Name == "toolStripButtonLine")
            {
				t.Checked = true;
				
				toolStripButtonSquare.Checked = false;
				toolStripButtonCircle.Checked = false;
			}
			else if (t.Name == "toolStripButtonSquare")
			{
				t.Checked = true;
				
				toolStripButtonLine.Checked = false;
				toolStripButtonCircle.Checked = false;
			}
			else if (t.Name == "toolStripButtonCircle")
			{
				t.Checked = true;
				
				toolStripButtonLine.Checked = false;
				toolStripButtonSquare.Checked = false;
			}
		}

        private void MyPaint_MouseUp(object sender, MouseEventArgs e)
        {
			second = new Point(e.X, e.Y);
		}

        private void MyPaint_MouseDown(object sender, MouseEventArgs e)
        {
			first = new Point(e.X,e.Y);

		}
    }
    
}
