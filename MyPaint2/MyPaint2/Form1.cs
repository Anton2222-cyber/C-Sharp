using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint2
{
    public partial class MyPaint : Form
    {
        List<Figure> figures;
        List<Point> tmp_points;
        Pen pen;
        Color color;
        public MyPaint()
        {
            InitializeComponent();
            figures = new List<Figure>();
            tmp_points = null;
            color = Color.Black;
            pen = new Pen(color, 3);
        }

        private void MyPaint_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = graf.CreateGraphics();
            //g.FillRectangle(Brushes.White,0,0, 1265, 570);
            foreach (Figure p in figures)
            {
                p.Draw(g);
            }
           


            g.Dispose();
        }

        private void toolStripButtonLine_Click(object sender, EventArgs e)
        {
            ToolStripButton t = sender as ToolStripButton;
            if (t.Name == "toolStripButtonLine")
            {
                t.Checked = true;

                toolStripButtonSquare.Checked = false;
                toolStripButtonCircle.Checked = false;
                toolStripButtonPen.Checked = false;
            }
            else if (t.Name == "toolStripButtonSquare")
            {
                t.Checked = true;

                toolStripButtonLine.Checked = false;
                toolStripButtonCircle.Checked = false;
                toolStripButtonPen.Checked = false;
            }
            else if (t.Name == "toolStripButtonCircle")
            {
                t.Checked = true;

                toolStripButtonLine.Checked = false;
                toolStripButtonSquare.Checked = false;
                toolStripButtonPen.Checked = false;
            }
            else if (t.Name == "toolStripButtonPen")
            {
                t.Checked = true;
                toolStripButtonCircle.Checked = false;
                toolStripButtonLine.Checked = false;
                toolStripButtonSquare.Checked = false;
            }
            else if(t.Name== "toolStripButtonColor")
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    color = colorDialog1.Color;
                    pen = new Pen(color, Convert.ToInt32(toolStripComboBox1.Text));
                }
            }
            else if (t.Name == "toolStripButtonUndo")
            {
                if (figures.Count == 0)
                    return;

                figures.RemoveAt(figures.Count - 1);

                Graphics g = graf.CreateGraphics();
                g.FillRectangle(Brushes.White, 0, 0, 1265, 570);
                foreach (Figure p in figures)
                {
                    p.Draw(g);
                }



                g.Dispose();
            }
            //else if(t.Name== "toolStripComboBox1")
            //{
            //    pen = new Pen(color, Convert.ToInt32(toolStripComboBox1.Text));
            //}
        }

       
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            tmp_points = new List<Point> {
                e.Location
            };
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            tmp_points.Add(e.Location);

            figures.Add(GetPicture());
            tmp_points = null;
            Invalidate();
        }
        protected Figure GetPicture()
        {
            
                if (toolStripButtonLine.Checked)
                    return new Line(tmp_points, pen);
                else if (toolStripButtonSquare.Checked)
                    return new Rectangle(tmp_points, pen);
                else if (toolStripButtonCircle.Checked)
                    return new Ellipse(tmp_points, pen);
                else if (toolStripButtonPen.Checked)
                    return new PenTool(tmp_points, pen);


            throw new Exception("Error");
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            tmp_points?.Add(e.Location);
        }

        
        

        private void toolStripComboBox1_TextChanged(object sender, EventArgs e)
        {
            pen = new Pen(color, Convert.ToInt32(toolStripComboBox1.Text));
        }
    }
    public class FigureSize
    {
        protected Point point1;
        protected Point point2;

        public FigureSize() : this(new Point(0, 0), new Point(0, 0)) { }
        public FigureSize(Point point1, Point point2)
        {
            this.point1 = point1;
            this.point2 = point2;
        }

        public Point Point1
        {
            get { return point1; }
            set { point1 = value; }
        }
        public Point Point2
        {
            get { return point2; }
            set { point2 = value; }
        }
    }
    public abstract class Figure
    {
        protected Pen p;

        public Figure(Pen p)
        {
            this.p = p;
        }

        public abstract void Draw(Graphics g);
    }

    public class Line : Figure
    {
        protected FigureSize size;

        public Line(List<Point> tmp_points, Pen p) : base(p)
        {
            size = new FigureSize
            {
                Point1 = tmp_points[0],
                Point2 = tmp_points[tmp_points.Count - 1]
            };
        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(p, size.Point1, size.Point2);
           
        }
    }

    public abstract class FigureWithPoints : Figure
    {
        protected FigureSize size;

        public FigureWithPoints(List<Point> tmp_points, Pen p) : base(p)
        {
            size = new FigureSize
            {
                Point1 = tmp_points[0],
                Point2 = tmp_points[tmp_points.Count - 1]
            };

            if (size.Point1.X > size.Point2.X)
            {
                size = new FigureSize(new Point(size.Point2.X, size.Point1.Y), new Point(size.Point1.X, size.Point2.Y));
            }

            if (size.Point1.Y > size.Point2.Y)
            {
                size = new FigureSize(new Point(size.Point1.X, size.Point2.Y), new Point(size.Point2.X, size.Point1.Y));
            }
        }
    }

    public class Rectangle : FigureWithPoints
    {
        public Rectangle(List<Point> tmp_points, Pen p) : base(tmp_points, p) { }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(p, size.Point1.X, size.Point1.Y, size.Point2.X - size.Point1.X, size.Point2.Y - size.Point1.Y);
        }
    }

    public class Ellipse : FigureWithPoints
    {
        public Ellipse(List<Point> tmp_points, Pen p) : base(tmp_points, p) { }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(p, size.Point1.X, size.Point1.Y, size.Point2.X - size.Point1.X, size.Point2.Y - size.Point1.Y);
        }
    }

    public class PenTool : Figure
    {
        protected List<Point> tmp_points;

        public PenTool(List<Point> tmp_points, Pen p) : base(p)
        {
            this.tmp_points = tmp_points;
        }

        public override void Draw(Graphics g)
        {
            g.DrawCurve(p, tmp_points.ToArray());
        }
    }
}
