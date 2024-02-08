using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDIClock
{
    public partial class Clock : Form
    {
        public Clock()
        {
            InitializeComponent();
            
        }

        private void Clock_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Brushes.Blue, 3), 384, 80, 384, 110);
            g.DrawLine(new Pen(Brushes.Blue, 3), 390, 80, 410, 80);
            g.DrawLine(new Pen(Brushes.Blue, 3), 410, 80, 410, 90);
            g.DrawLine(new Pen(Brushes.Blue, 3), 410, 90, 390, 90);
            g.DrawLine(new Pen(Brushes.Blue, 3), 390, 90, 390, 110);
            g.DrawLine(new Pen(Brushes.Blue, 3), 390, 110, 410, 110);

            g.DrawLine(new Pen(Brushes.Blue, 3), 392, 321, 412, 321);
            g.DrawLine(new Pen(Brushes.Blue, 3), 392, 321, 392, 361);
            g.DrawLine(new Pen(Brushes.Blue, 3), 392, 361, 412, 361);
            g.DrawLine(new Pen(Brushes.Blue, 3), 412, 361, 412, 341);
            g.DrawLine(new Pen(Brushes.Blue, 3), 412, 341, 392, 341);

            g.DrawLine(new Pen(Brushes.Blue, 3), 267, 195, 292, 195);
            g.DrawLine(new Pen(Brushes.Blue, 3), 292, 195, 292, 235);
            g.DrawLine(new Pen(Brushes.Blue, 3), 292, 235, 267, 235);
            g.DrawLine(new Pen(Brushes.Blue, 3), 267, 195, 267, 215);
            g.DrawLine(new Pen(Brushes.Blue, 3), 267, 215, 292, 215);

            g.DrawLine(new Pen(Brushes.Blue, 3), 509, 195, 535, 195);
            g.DrawLine(new Pen(Brushes.Blue, 3), 535, 195, 535, 235);
            g.DrawLine(new Pen(Brushes.Blue, 3), 535, 235, 509, 235);
            g.DrawLine(new Pen(Brushes.Blue, 3), 509, 215, 535, 215);

            g.DrawLine(new Pen(Brushes.Aqua, 3), 460, 99, 446, 121);
            g.DrawLine(new Pen(Brushes.Aqua, 3), 502, 134, 483, 153);
            g.DrawLine(new Pen(Brushes.Aqua, 3), 512, 290, 486, 271);
            g.DrawLine(new Pen(Brushes.Aqua, 3), 473, 339, 453, 308);
            g.DrawLine(new Pen(Brushes.Aqua, 3), 318, 328, 336, 302);
            g.DrawLine(new Pen(Brushes.Aqua, 3), 277, 275, 306, 263);
            g.DrawLine(new Pen(Brushes.Aqua, 3), 288, 139, 307, 158);
            g.DrawLine(new Pen(Brushes.Aqua, 3), 333, 99, 347, 123);


            g.DrawEllipse(new Pen(Brushes.White, 3), 250, 70, 300, 300);
            g.DrawLine(new Pen(Brushes.Red, 3), 396, 214, 396, 95);
            g.DrawLine(new Pen(Brushes.Yellow, 3), 396, 214, 347, 274);
            g.DrawLine(new Pen(Brushes.Bisque, 3), 396, 214, 365, 182);
            
            g.Dispose();
        }

        
    }
}
