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
    public partial class Menu : Form
    {
        List<Point> points;
        public Menu()
        {
            InitializeComponent();

        }
        Point GetPoint(float i)
        {
            try
            {
                if (comboBox1.Text == "y=ax^2+b")
                {
                    return new Point((int)(i + 330), (int)(-(Convert.ToSingle(A.Text) * (float)Math.Pow((double)i, (double)2) + Convert.ToSingle(B.Text)) + 342));
                }
                else if (comboBox1.Text == "y=a√x+b")
                {
                    return new Point((int)(i + 330), (int)(342 - (Convert.ToSingle(A.Text) * (float)Math.Sqrt((double)i) + Convert.ToSingle(B.Text))));
                }
                else if (comboBox1.Text == "y=a|x|+b")
                {
                    return new Point((int)(i + 330), (int)(342 - (Convert.ToSingle(A.Text) * (float)Math.Abs((double)i) + Convert.ToSingle(B.Text))));
                }
                else if (comboBox1.Text == "y=ax^3+b")
                {
                    return new Point((int)(i + 330), (int)(-(Convert.ToSingle(A.Text) * (float)Math.Pow((double)i, (double)3) + Convert.ToSingle(B.Text)) + 342));
                }
                else if (comboBox1.Text == "y=ax+b")
                {
                    return new Point((int)(i + 330), (int)(342 - (Convert.ToSingle(A.Text) * i + Convert.ToSingle(B.Text))));
                }
            }
            catch (Exception e)
            {

            }
            throw new Exception("ERROR!");
        }
        void CreatesPoint()
        {
            try
            {
                if (Convert.ToSingle(X_first.Text) >= Convert.ToSingle(X_End.Text))
                    throw new Exception();
                float number;
                if (Single.TryParse(A.Text, out number) == false)
                {
                    throw new Exception();
                }
                if (Single.TryParse(B.Text, out number) == false)
                {
                    throw new Exception();
                }
                points = new List<Point>();
                for (float i = Convert.ToSingle(X_first.Text); i < Convert.ToSingle(X_End.Text); i++)
                {

                    points.Add(GetPoint(i));
                }
               
            }
            catch (Exception exc)
            {
                MessageBox.Show("Не правильний формат!");
            }
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreatesPoint();
            MyGraphic myGraphic = new MyGraphic(points);
            myGraphic.Show();
        

        points = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CreatesPoint();
            Diagram diagram = new Diagram(points);
            diagram.Show();
            points = null;
        }
    }
}
