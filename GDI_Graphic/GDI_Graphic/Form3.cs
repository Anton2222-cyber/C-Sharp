using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI_Graphic
{
    public partial class Diagram : Form
    {
        List<Point> points;
        int k = 0;
        public Diagram()
        {
            InitializeComponent();
        }
        public Diagram(List<Point> points)
        {
            InitializeComponent();
            this.points = points;
        }

        private void Diagram_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.DrawLine(new Pen(Brushes.White, 3), 330, 0, 330, 900);
                g.DrawLine(new Pen(Brushes.White, 3), 0, 342, 900, 342);
                foreach(Point p in points)
                {
                    if (k == 8)
                    {
                        g.DrawLine(new Pen(Brushes.Red, 6), p, new Point(p.X, 342));
                        k = 0;
                    }
                    k++;

                }
                
                g.Dispose();
            }
            catch (Exception exc)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Не коректні дані!");
            }
        }
    }
    
}
