using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDILabirint
{
    public partial class Labirint : Form
    {
        public Labirint()
        {
            InitializeComponent();
        }

        

        private void Labirint_Paint(object sender, PaintEventArgs e)
        {
            //340X340
            Graphics g = e.Graphics;
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 53, 490, 53);
            g.DrawLine(new Pen(Brushes.Red, 3), 490, 53, 490, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 490, 393, 150, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 393, 150, 53);

            g.DrawLine(new Pen(Brushes.Red, 3), 150, 359, 490, 359);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 325, 490, 325);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 291, 490, 291);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 257, 490, 257);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 223, 490, 223);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 189, 490, 189);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 155, 490, 155);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 121, 490, 121);
            g.DrawLine(new Pen(Brushes.Red, 3), 150, 87, 490, 87);

            g.DrawLine(new Pen(Brushes.Red, 3), 184, 53, 184, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 218, 53, 218, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 252, 53, 252, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 286, 53, 286, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 320, 53, 320, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 354, 53, 354, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 388, 53, 388, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 422, 53, 422, 393);
            g.DrawLine(new Pen(Brushes.Red, 3), 456, 53, 456, 393);

            g.DrawLine(new Pen(Brushes.Black, 3), 184, 392, 184, 361);
            g.DrawLine(new Pen(Brushes.Black, 3), 150, 358, 150, 327);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 358, 184, 327);
            g.DrawLine(new Pen(Brushes.Black, 3), 217, 359, 186, 359);
            g.DrawLine(new Pen(Brushes.Black, 3), 218, 392, 218, 361);
            g.DrawLine(new Pen(Brushes.Black, 3), 217, 359, 251, 359);
            g.DrawLine(new Pen(Brushes.Black, 3), 220, 325, 251, 325);
            g.DrawLine(new Pen(Brushes.Black, 3), 218, 324, 218, 293);
            g.DrawLine(new Pen(Brushes.Black, 3), 186, 291, 217, 291);
            g.DrawLine(new Pen(Brushes.Black, 3), 218, 290, 218, 259);
            g.DrawLine(new Pen(Brushes.Black, 3), 252, 290, 252, 259);
            g.DrawLine(new Pen(Brushes.Black, 3), 254, 291, 285, 291);
            g.DrawLine(new Pen(Brushes.Black, 3), 286, 293, 286, 324);
            g.DrawLine(new Pen(Brushes.Black, 3), 254, 325, 285, 325);
            g.DrawLine(new Pen(Brushes.Black, 3), 286, 358, 286, 324);
            g.DrawLine(new Pen(Brushes.Black, 3), 288, 359, 319, 359);
            g.DrawLine(new Pen(Brushes.Black, 3), 288, 291, 319, 291);
            g.DrawLine(new Pen(Brushes.Black, 3), 288, 257, 319, 257);
            g.DrawLine(new Pen(Brushes.Black, 3), 288, 223, 319, 223);
            g.DrawLine(new Pen(Brushes.Black, 3), 288, 121, 319, 121);
            g.DrawLine(new Pen(Brushes.Black, 3), 152, 291, 183, 291);
            g.DrawLine(new Pen(Brushes.Black, 3), 152, 257, 183, 257);
            g.DrawLine(new Pen(Brushes.Black, 3), 152, 189, 183, 189);
            g.DrawLine(new Pen(Brushes.Black, 3), 152, 121, 183, 121);
            g.DrawLine(new Pen(Brushes.Black, 3), 186, 223, 217, 223);
            g.DrawLine(new Pen(Brushes.Black, 3), 186, 155, 217, 155);
            g.DrawLine(new Pen(Brushes.Black, 3), 186, 87, 217, 87);
            g.DrawLine(new Pen(Brushes.Black, 3), 220, 223, 251, 223);
            g.DrawLine(new Pen(Brushes.Black, 3), 220, 189, 251, 189);
            g.DrawLine(new Pen(Brushes.Black, 3), 220, 155, 251, 155);
            g.DrawLine(new Pen(Brushes.Black, 3), 220, 121, 251, 121);
            g.DrawLine(new Pen(Brushes.Black, 3), 220, 87, 251, 87);
            g.DrawLine(new Pen(Brushes.Black, 3), 254, 189, 285, 189);
            g.DrawLine(new Pen(Brushes.Black, 3), 322, 325, 353, 325);
            g.DrawLine(new Pen(Brushes.Black, 3), 322, 257, 353, 257);
            g.DrawLine(new Pen(Brushes.Black, 3), 322, 121, 353, 121);
            g.DrawLine(new Pen(Brushes.Black, 3), 322, 87, 353, 87);
            g.DrawLine(new Pen(Brushes.Black, 3), 356, 359, 387, 359);
            g.DrawLine(new Pen(Brushes.Black, 3), 356, 291, 387, 291);
            g.DrawLine(new Pen(Brushes.Black, 3), 356, 223, 387, 223);
            g.DrawLine(new Pen(Brushes.Black, 3), 356, 155, 387, 155);
            g.DrawLine(new Pen(Brushes.Black, 3), 356, 87, 387, 87);
            g.DrawLine(new Pen(Brushes.Black, 3), 390, 325, 421, 325);
            g.DrawLine(new Pen(Brushes.Black, 3), 390, 223, 421, 223);
            g.DrawLine(new Pen(Brushes.Black, 3), 390, 155, 421, 155);
            g.DrawLine(new Pen(Brushes.Black, 3), 390, 87, 421, 87);
            g.DrawLine(new Pen(Brushes.Black, 3), 424, 87, 455, 87);
            g.DrawLine(new Pen(Brushes.Black, 3), 424, 121, 455, 121);
            g.DrawLine(new Pen(Brushes.Black, 3), 458, 359, 489, 359);
            g.DrawLine(new Pen(Brushes.Black, 3), 458, 291, 489, 291);
            g.DrawLine(new Pen(Brushes.Black, 3), 458, 257, 489, 257);
            g.DrawLine(new Pen(Brushes.Black, 3), 458, 155, 489, 155);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 86, 184, 55);
            g.DrawLine(new Pen(Brushes.Black, 3), 252, 86, 252, 55);
            g.DrawLine(new Pen(Brushes.Black, 3), 286, 86, 286, 55);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 86, 354, 55);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 86, 422, 55);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 86, 456, 55);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 120, 184, 89);
            g.DrawLine(new Pen(Brushes.Black, 3), 252, 120, 252, 89);
            g.DrawLine(new Pen(Brushes.Black, 3), 286, 120, 286, 89);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 120, 456, 89);
            g.DrawLine(new Pen(Brushes.Black, 3), 490, 120, 490, 89);
            g.DrawLine(new Pen(Brushes.Black, 3), 388, 120, 388, 89);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 154, 184, 123);
            g.DrawLine(new Pen(Brushes.Black, 3), 286, 154, 286, 123);
            g.DrawLine(new Pen(Brushes.Black, 3), 320, 154, 320, 123);
            g.DrawLine(new Pen(Brushes.Black, 3), 388, 154, 388, 123);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 154, 456, 123);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 188, 184, 157);
            g.DrawLine(new Pen(Brushes.Black, 3), 252, 188, 252, 157);
            g.DrawLine(new Pen(Brushes.Black, 3), 320, 188, 320, 157);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 188, 354, 157);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 188, 422, 157);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 188, 456, 157);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 222, 184, 191);
            g.DrawLine(new Pen(Brushes.Black, 3), 286, 222, 286, 191);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 222, 354, 191);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 222, 422, 191);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 222, 456, 191);
            g.DrawLine(new Pen(Brushes.Black, 3), 490, 222, 490, 191);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 256, 184, 225);
            g.DrawLine(new Pen(Brushes.Black, 3), 252, 256, 252, 225);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 256, 354, 225);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 256, 422, 225);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 256, 456, 225);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 290, 354, 259);
            g.DrawLine(new Pen(Brushes.Black, 3), 388, 290, 388, 259);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 290, 422, 259);
            g.DrawLine(new Pen(Brushes.Black, 3), 184, 324, 184, 293);
            g.DrawLine(new Pen(Brushes.Black, 3), 320, 324, 320, 293);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 324, 354, 293);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 324, 422, 293);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 324, 456, 293);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 358, 354, 327);
            g.DrawLine(new Pen(Brushes.Black, 3), 388, 358, 388, 327);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 358, 422, 327);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 358, 456, 327);
            g.DrawLine(new Pen(Brushes.Black, 3), 286, 392, 286, 361);
            g.DrawLine(new Pen(Brushes.Black, 3), 354, 392, 354, 361);
            g.DrawLine(new Pen(Brushes.Black, 3), 422, 392, 422, 361);
            g.DrawLine(new Pen(Brushes.Black, 3), 456, 392, 456, 361);

            g.DrawLine(new Pen(Brushes.White, 3), 24, 346, 100, 346);
            g.DrawLine(new Pen(Brushes.White, 3), 100, 346, 87, 334);
            g.DrawLine(new Pen(Brushes.White, 3), 100, 346, 87, 358);

            g.DrawLine(new Pen(Brushes.GreenYellow, 3), 516, 104, 590, 104);
            g.DrawLine(new Pen(Brushes.GreenYellow, 3), 590, 104, 577, 92);
            g.DrawLine(new Pen(Brushes.GreenYellow, 3), 590, 104, 577, 116);

            g.DrawLine(new Pen(Brushes.GreenYellow, 3), 516, 206, 590, 206);
            g.DrawLine(new Pen(Brushes.GreenYellow, 3), 590, 206, 577, 194);
            g.DrawLine(new Pen(Brushes.GreenYellow, 3), 590, 206, 577, 218);
            
            g.Dispose();
        }
    }
}
