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
    public partial class MyGraphic : Form
    {
        List<Point> points;
        public MyGraphic()
        {
            InitializeComponent();
        }
        public MyGraphic(List<Point>points)
        {
            InitializeComponent();
            this.points = points;
        }

        private void Graphic_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Graphics g = e.Graphics;
                g.DrawLine(new Pen(Brushes.White, 3), 330, 0, 330, 900);
                g.DrawLine(new Pen(Brushes.White, 3), 0, 342, 900, 342);
                g.DrawCurve(new Pen(Brushes.Red,3), points.ToArray());
                g.Dispose();
            }
            catch(Exception exc)
            {
                DialogResult = DialogResult.OK;
                MessageBox.Show("Не коректні дані!");
            }
        }

        
    }
}
