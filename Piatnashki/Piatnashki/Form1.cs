using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Piatnashki
{
    public partial class Form1 : Form
    {
        List<Picture> pictures;
        Timer t;
        DateTime Time;
        public Form1()
        {
            InitializeComponent();
            pictures = new List<Picture>();
            pictures.Add(new Picture(1,pictureBox1));
            pictures.Add(new Picture(2,pictureBox2));
            pictures.Add(new Picture(3, pictureBox3));
            pictures.Add(new Picture(4, pictureBox4));
            pictures.Add(new Picture(5, pictureBox5));
            pictures.Add(new Picture(6, pictureBox6));
            pictures.Add(new Picture(7, pictureBox7));
            pictures.Add(new Picture(8, pictureBox8));
            pictures.Add(new Picture(9, pictureBox9));
            pictures.Add(new Picture(10, pictureBox10));
            pictures.Add(new Picture(11, pictureBox11));
            pictures.Add(new Picture(12, pictureBox12));
            pictures.Add(new Picture(13, pictureBox13));
            pictures.Add(new Picture(14, pictureBox14));
            pictures.Add(new Picture(15, pictureBox15));
            pictures.Add(new Picture(16, pictureBox16));
            t = new Timer();
            Time = new DateTime(0);
            t.Interval = 1000;
            t.Tick += t_Timer_Tick;
            Shuffle();
            t.Start();
        }
        private void t_Timer_Tick(object sender, EventArgs e)
        {
            Time=Time.AddSeconds(1);        
        }
        void Shuffle()
        {
            int l = new Random().Next(10, 40);
            for (int k = 0; k < l; k++)
            {
                Random random = new Random();
                for (int i = pictures.Count - 1; i >= 1; i--)
                {

                    int j = random.Next(i + 1);

                    int numbertmp = pictures[j].Number;
                    Image tmp = pictures[j].PictureBox.Image;

                    pictures[j].PictureBox.Image = pictures[i].PictureBox.Image;
                    pictures[j].Number = pictures[i].Number;

                    pictures[i].PictureBox.Image = tmp;
                    pictures[i].Number = numbertmp;
                }
            }
        }
        void WinOrNotwin()
        {
            bool b = true;
            for(int i=0,j=1;i<pictures.Count;i++,j++)
            {
                if(pictures[i].Number!=j)
                {
                    b = false;
                    break;
                }

            }
            if (b)
                MessageBox.Show("Ви виграли за: " + Time.ToLongTimeString());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            Image tmp;
            int tmp_number;
            if (pictureBox.Name== "pictureBox1")
            {
                
                if(pictures[1].Number==16)
                {
                    tmp = pictures[1].PictureBox.Image;
                    tmp_number = pictures[1].Number;

                    pictures[1].PictureBox.Image = pictures[0].PictureBox.Image;
                    pictures[1].Number = pictures[0].Number;

                    pictures[0].PictureBox.Image = tmp;
                    pictures[0].Number = tmp_number;
                }
                else if(pictures[4].Number == 16)
                {
                    tmp = pictures[4].PictureBox.Image;
                    tmp_number = pictures[4].Number;

                    pictures[4].PictureBox.Image = pictures[0].PictureBox.Image;
                    pictures[4].Number = pictures[0].Number;

                    pictures[0].PictureBox.Image = tmp;
                    pictures[0].Number = tmp_number;
                }
            }
            else if(pictureBox.Name == "pictureBox2")
            {
                if(pictures[0].Number == 16)
                {
                    tmp = pictures[0].PictureBox.Image;
                    tmp_number = pictures[0].Number;

                    pictures[0].PictureBox.Image = pictures[1].PictureBox.Image;
                    pictures[0].Number = pictures[1].Number;

                    pictures[1].PictureBox.Image = tmp;
                    pictures[1].Number = tmp_number;
                }
                else if(pictures[2].Number == 16)
                {
                    tmp = pictures[2].PictureBox.Image;
                    tmp_number = pictures[2].Number;

                    pictures[2].PictureBox.Image = pictures[1].PictureBox.Image;
                    pictures[2].Number = pictures[1].Number;

                    pictures[1].PictureBox.Image = tmp;
                    pictures[1].Number = tmp_number;
                }
                else if(pictures[5].Number == 16)
                {
                    tmp = pictures[5].PictureBox.Image;
                    tmp_number = pictures[5].Number;

                    pictures[5].PictureBox.Image = pictures[1].PictureBox.Image;
                    pictures[5].Number = pictures[1].Number;

                    pictures[1].PictureBox.Image = tmp;
                    pictures[1].Number = tmp_number;
                }
            }
            else if(pictureBox.Name == "pictureBox3")
            {
                if(pictures[1].Number == 16)
                {
                    tmp = pictures[1].PictureBox.Image;
                    tmp_number = pictures[1].Number;

                    pictures[1].PictureBox.Image = pictures[2].PictureBox.Image;
                    pictures[1].Number = pictures[2].Number;

                    pictures[2].PictureBox.Image = tmp;
                    pictures[2].Number = tmp_number;
                }
                else if (pictures[3].Number == 16)
                {
                    tmp = pictures[3].PictureBox.Image;
                    tmp_number = pictures[3].Number;

                    pictures[3].PictureBox.Image = pictures[2].PictureBox.Image;
                    pictures[3].Number = pictures[2].Number;

                    pictures[2].PictureBox.Image = tmp;
                    pictures[2].Number = tmp_number;
                }
                else if (pictures[6].Number == 16)
                {
                    tmp = pictures[6].PictureBox.Image;
                    tmp_number = pictures[6].Number;

                    pictures[6].PictureBox.Image = pictures[2].PictureBox.Image;
                    pictures[6].Number = pictures[2].Number;

                    pictures[2].PictureBox.Image = tmp;
                    pictures[2].Number = tmp_number;
                }
            }
            else if(pictureBox.Name == "pictureBox4")
            {
                if (pictures[2].Number == 16)
                {
                    tmp = pictures[2].PictureBox.Image;
                    tmp_number = pictures[2].Number;

                    pictures[2].PictureBox.Image = pictures[3].PictureBox.Image;
                    pictures[2].Number = pictures[3].Number;

                    pictures[3].PictureBox.Image = tmp;
                    pictures[3].Number = tmp_number;
                }
                else if (pictures[7].Number == 16)
                {
                    tmp = pictures[7].PictureBox.Image;
                    tmp_number = pictures[7].Number;

                    pictures[7].PictureBox.Image = pictures[3].PictureBox.Image;
                    pictures[7].Number = pictures[3].Number;

                    pictures[3].PictureBox.Image = tmp;
                    pictures[3].Number = tmp_number;
                }
            }
            else if (pictureBox.Name == "pictureBox5")
            {
                if (pictures[0].Number == 16)
                {
                    tmp = pictures[0].PictureBox.Image;
                    tmp_number = pictures[0].Number;

                    pictures[0].PictureBox.Image = pictures[4].PictureBox.Image;
                    pictures[0].Number = pictures[4].Number;

                    pictures[4].PictureBox.Image = tmp;
                    pictures[4].Number = tmp_number;
                }
                else if (pictures[5].Number == 16)
                {
                    tmp = pictures[5].PictureBox.Image;
                    tmp_number = pictures[5].Number;

                    pictures[5].PictureBox.Image = pictures[4].PictureBox.Image;
                    pictures[5].Number = pictures[4].Number;

                    pictures[4].PictureBox.Image = tmp;
                    pictures[4].Number = tmp_number;
                }
                else if (pictures[8].Number == 16)
                {
                    tmp = pictures[8].PictureBox.Image;
                    tmp_number = pictures[8].Number;

                    pictures[8].PictureBox.Image = pictures[4].PictureBox.Image;
                    pictures[8].Number = pictures[4].Number;

                    pictures[4].PictureBox.Image = tmp;
                    pictures[4].Number = tmp_number;
                }

            }
            else if (pictureBox.Name == "pictureBox6")
            {
                if (pictures[4].Number == 16)
                {
                    tmp = pictures[4].PictureBox.Image;
                    tmp_number = pictures[4].Number;

                    pictures[4].PictureBox.Image = pictures[5].PictureBox.Image;
                    pictures[4].Number = pictures[5].Number;

                    pictures[5].PictureBox.Image = tmp;
                    pictures[5].Number = tmp_number;
                }
                else if (pictures[1].Number == 16)
                {
                    tmp = pictures[1].PictureBox.Image;
                    tmp_number = pictures[1].Number;

                    pictures[1].PictureBox.Image = pictures[5].PictureBox.Image;
                    pictures[1].Number = pictures[5].Number;

                    pictures[5].PictureBox.Image = tmp;
                    pictures[5].Number = tmp_number;
                }
                else if (pictures[6].Number == 16)
                {
                    tmp = pictures[6].PictureBox.Image;
                    tmp_number = pictures[6].Number;

                    pictures[6].PictureBox.Image = pictures[5].PictureBox.Image;
                    pictures[6].Number = pictures[5].Number;

                    pictures[5].PictureBox.Image = tmp;
                    pictures[5].Number = tmp_number;
                }
                else if (pictures[9].Number == 16)
                {
                    tmp = pictures[9].PictureBox.Image;
                    tmp_number = pictures[9].Number;

                    pictures[9].PictureBox.Image = pictures[5].PictureBox.Image;
                    pictures[9].Number = pictures[5].Number;

                    pictures[5].PictureBox.Image = tmp;
                    pictures[5].Number = tmp_number;
                }
            }
            else if (pictureBox.Name == "pictureBox7")
            {
                if (pictures[5].Number == 16)
                {
                    tmp = pictures[5].PictureBox.Image;
                    tmp_number = pictures[5].Number;

                    pictures[5].PictureBox.Image = pictures[6].PictureBox.Image;
                    pictures[5].Number = pictures[6].Number;

                    pictures[6].PictureBox.Image = tmp;
                    pictures[6].Number = tmp_number;
                }
                else if (pictures[2].Number == 16)
                {
                    tmp = pictures[2].PictureBox.Image;
                    tmp_number = pictures[2].Number;

                    pictures[2].PictureBox.Image = pictures[6].PictureBox.Image;
                    pictures[2].Number = pictures[6].Number;

                    pictures[6].PictureBox.Image = tmp;
                    pictures[6].Number = tmp_number;

                }
                else if (pictures[7].Number == 16)
                {
                    tmp = pictures[7].PictureBox.Image;
                    tmp_number = pictures[7].Number;

                    pictures[7].PictureBox.Image = pictures[6].PictureBox.Image;
                    pictures[7].Number = pictures[6].Number;

                    pictures[6].PictureBox.Image = tmp;
                    pictures[6].Number = tmp_number;
                }
                else if (pictures[10].Number == 16)
                {
                    tmp = pictures[10].PictureBox.Image;
                    tmp_number = pictures[10].Number;

                    pictures[10].PictureBox.Image = pictures[6].PictureBox.Image;
                    pictures[10].Number = pictures[6].Number;

                    pictures[6].PictureBox.Image = tmp;
                    pictures[6].Number = tmp_number;
                }
            }
            else if (pictureBox.Name == "pictureBox8")
            {
                if (pictures[6].Number == 16)
                {
                    tmp = pictures[6].PictureBox.Image;
                    tmp_number = pictures[6].Number;

                    pictures[6].PictureBox.Image = pictures[7].PictureBox.Image;
                    pictures[6].Number = pictures[7].Number;

                    pictures[7].PictureBox.Image = tmp;
                    pictures[7].Number = tmp_number;
                }
                else if (pictures[3].Number == 16)
                {
                    tmp = pictures[3].PictureBox.Image;
                    tmp_number = pictures[3].Number;

                    pictures[3].PictureBox.Image = pictures[7].PictureBox.Image;
                    pictures[3].Number = pictures[7].Number;

                    pictures[7].PictureBox.Image = tmp;
                    pictures[7].Number = tmp_number;
                }
                else if (pictures[11].Number == 16)
                {
                    tmp = pictures[11].PictureBox.Image;
                    tmp_number = pictures[11].Number;

                    pictures[11].PictureBox.Image = pictures[7].PictureBox.Image;
                    pictures[11].Number = pictures[7].Number;

                    pictures[7].PictureBox.Image = tmp;
                    pictures[7].Number = tmp_number;
                }

            }
            else if (pictureBox.Name == "pictureBox9")
            {
                if (pictures[4].Number == 16)
                {
                    tmp = pictures[4].PictureBox.Image;
                    tmp_number = pictures[4].Number;

                    pictures[4].PictureBox.Image = pictures[8].PictureBox.Image;
                    pictures[4].Number = pictures[8].Number;

                    pictures[8].PictureBox.Image = tmp;
                    pictures[8].Number = tmp_number;
                }
                else if (pictures[9].Number == 16)
                {
                    tmp = pictures[9].PictureBox.Image;
                    tmp_number = pictures[9].Number;

                    pictures[9].PictureBox.Image = pictures[8].PictureBox.Image;
                    pictures[9].Number = pictures[8].Number;

                    pictures[8].PictureBox.Image = tmp;
                    pictures[8].Number = tmp_number;
                }
                else if (pictures[12].Number == 16)
                {
                    tmp = pictures[12].PictureBox.Image;
                    tmp_number = pictures[12].Number;

                    pictures[12].PictureBox.Image = pictures[8].PictureBox.Image;
                    pictures[12].Number = pictures[8].Number;

                    pictures[8].PictureBox.Image = tmp;
                    pictures[8].Number = tmp_number;
                }

            }
            else if (pictureBox.Name == "pictureBox10")
            {
                if (pictures[8].Number == 16)
                {
                    tmp = pictures[8].PictureBox.Image;
                    tmp_number = pictures[8].Number;

                    pictures[8].PictureBox.Image = pictures[9].PictureBox.Image;
                    pictures[8].Number = pictures[9].Number;

                    pictures[9].PictureBox.Image = tmp;
                    pictures[9].Number = tmp_number;
                }
                else if (pictures[5].Number == 16)
                {
                    tmp = pictures[5].PictureBox.Image;
                    tmp_number = pictures[5].Number;

                    pictures[5].PictureBox.Image = pictures[9].PictureBox.Image;
                    pictures[5].Number = pictures[9].Number;

                    pictures[9].PictureBox.Image = tmp;
                    pictures[9].Number = tmp_number;
                }
                else if (pictures[10].Number == 16)
                {
                    tmp = pictures[10].PictureBox.Image;
                    tmp_number = pictures[10].Number;

                    pictures[10].PictureBox.Image = pictures[9].PictureBox.Image;
                    pictures[10].Number = pictures[9].Number;

                    pictures[9].PictureBox.Image = tmp;
                    pictures[9].Number = tmp_number;
                }
                else if (pictures[13].Number == 16)
                {
                    tmp = pictures[13].PictureBox.Image;
                    tmp_number = pictures[13].Number;

                    pictures[13].PictureBox.Image = pictures[9].PictureBox.Image;
                    pictures[13].Number = pictures[9].Number;

                    pictures[9].PictureBox.Image = tmp;
                    pictures[9].Number = tmp_number;
                }

            }
            else if (pictureBox.Name == "pictureBox11")
            {
                if (pictures[9].Number == 16)
                {
                    tmp = pictures[9].PictureBox.Image;
                    tmp_number = pictures[9].Number;

                    pictures[9].PictureBox.Image = pictures[10].PictureBox.Image;
                    pictures[9].Number = pictures[10].Number;

                    pictures[10].PictureBox.Image = tmp;
                    pictures[10].Number = tmp_number;
                }
                else if (pictures[6].Number == 16)
                {
                    tmp = pictures[6].PictureBox.Image;
                    tmp_number = pictures[6].Number;

                    pictures[6].PictureBox.Image = pictures[10].PictureBox.Image;
                    pictures[6].Number = pictures[10].Number;

                    pictures[10].PictureBox.Image = tmp;
                    pictures[10].Number = tmp_number;
                }
                else if (pictures[11].Number == 16)
                {
                    tmp = pictures[11].PictureBox.Image;
                    tmp_number = pictures[11].Number;

                    pictures[11].PictureBox.Image = pictures[10].PictureBox.Image;
                    pictures[11].Number = pictures[10].Number;

                    pictures[10].PictureBox.Image = tmp;
                    pictures[10].Number = tmp_number;
                }
                else if (pictures[14].Number == 16)
                {
                    tmp = pictures[14].PictureBox.Image;
                    tmp_number = pictures[14].Number;

                    pictures[14].PictureBox.Image = pictures[10].PictureBox.Image;
                    pictures[14].Number = pictures[10].Number;

                    pictures[10].PictureBox.Image = tmp;
                    pictures[10].Number = tmp_number;
                }

            }
            else if (pictureBox.Name == "pictureBox12")
            {
                if (pictures[10].Number == 16)
                {
                    tmp = pictures[10].PictureBox.Image;
                    tmp_number = pictures[10].Number;

                    pictures[10].PictureBox.Image = pictures[11].PictureBox.Image;
                    pictures[10].Number = pictures[11].Number;

                    pictures[11].PictureBox.Image = tmp;
                    pictures[11].Number = tmp_number;
                }
                else if (pictures[7].Number == 16)
                {
                    tmp = pictures[7].PictureBox.Image;
                    tmp_number = pictures[7].Number;

                    pictures[7].PictureBox.Image = pictures[11].PictureBox.Image;
                    pictures[7].Number = pictures[11].Number;

                    pictures[11].PictureBox.Image = tmp;
                    pictures[11].Number = tmp_number;
                }
                else if (pictures[15].Number == 16)
                {
                    tmp = pictures[15].PictureBox.Image;
                    tmp_number = pictures[15].Number;

                    pictures[15].PictureBox.Image = pictures[11].PictureBox.Image;
                    pictures[15].Number = pictures[11].Number;

                    pictures[11].PictureBox.Image = tmp;
                    pictures[11].Number = tmp_number;
                }
            }
            else if (pictureBox.Name == "pictureBox13")
            {
                if (pictures[8].Number == 16)
                {
                    tmp = pictures[8].PictureBox.Image;
                    tmp_number = pictures[8].Number;

                    pictures[8].PictureBox.Image = pictures[12].PictureBox.Image;
                    pictures[8].Number = pictures[12].Number;

                    pictures[12].PictureBox.Image = tmp;
                    pictures[12].Number = tmp_number;
                }
                else if (pictures[13].Number == 16)
                {
                    tmp = pictures[13].PictureBox.Image;
                    tmp_number = pictures[13].Number;

                    pictures[13].PictureBox.Image = pictures[12].PictureBox.Image;
                    pictures[13].Number = pictures[12].Number;

                    pictures[12].PictureBox.Image = tmp;
                    pictures[12].Number = tmp_number;
                }
               
            }
            else if (pictureBox.Name == "pictureBox14")
            {
                if (pictures[12].Number == 16)
                {
                    tmp = pictures[12].PictureBox.Image;
                    tmp_number = pictures[12].Number;

                    pictures[12].PictureBox.Image = pictures[13].PictureBox.Image;
                    pictures[12].Number = pictures[13].Number;

                    pictures[13].PictureBox.Image = tmp;
                    pictures[13].Number = tmp_number;
                }
                else if (pictures[9].Number == 16)
                {
                    tmp = pictures[9].PictureBox.Image;
                    tmp_number = pictures[9].Number;

                    pictures[9].PictureBox.Image = pictures[13].PictureBox.Image;
                    pictures[9].Number = pictures[13].Number;

                    pictures[13].PictureBox.Image = tmp;
                    pictures[13].Number = tmp_number;
                }
                else if (pictures[14].Number == 16)
                {
                    tmp = pictures[14].PictureBox.Image;
                    tmp_number = pictures[14].Number;

                    pictures[14].PictureBox.Image = pictures[13].PictureBox.Image;
                    pictures[14].Number = pictures[13].Number;

                    pictures[13].PictureBox.Image = tmp;
                    pictures[13].Number = tmp_number;
                }

            }
            else if (pictureBox.Name == "pictureBox15")
            {
                if (pictures[13].Number == 16)
                {
                    tmp = pictures[13].PictureBox.Image;
                    tmp_number = pictures[13].Number;

                    pictures[13].PictureBox.Image = pictures[14].PictureBox.Image;
                    pictures[13].Number = pictures[14].Number;

                    pictures[14].PictureBox.Image = tmp;
                    pictures[14].Number = tmp_number;
                }
                else if (pictures[10].Number == 16)
                {
                    tmp = pictures[10].PictureBox.Image;
                    tmp_number = pictures[10].Number;

                    pictures[10].PictureBox.Image = pictures[14].PictureBox.Image;
                    pictures[10].Number = pictures[14].Number;

                    pictures[14].PictureBox.Image = tmp;
                    pictures[14].Number = tmp_number;
                }
                else if (pictures[15].Number == 16)
                {
                    tmp = pictures[15].PictureBox.Image;
                    tmp_number = pictures[15].Number;

                    pictures[15].PictureBox.Image = pictures[14].PictureBox.Image;
                    pictures[15].Number = pictures[14].Number;

                    pictures[14].PictureBox.Image = tmp;
                    pictures[14].Number = tmp_number;
                }

            }
            else if (pictureBox.Name == "pictureBox16")
            {
                if (pictures[14].Number == 16)
                {
                    tmp = pictures[14].PictureBox.Image;
                    tmp_number = pictures[14].Number;

                    pictures[14].PictureBox.Image = pictures[15].PictureBox.Image;
                    pictures[14].Number = pictures[15].Number;

                    pictures[15].PictureBox.Image = tmp;
                    pictures[15].Number = tmp_number;
                }
                else if (pictures[11].Number == 16)
                {
                    tmp = pictures[11].PictureBox.Image;
                    tmp_number = pictures[11].Number;

                    pictures[11].PictureBox.Image = pictures[15].PictureBox.Image;
                    pictures[11].Number = pictures[15].Number;

                    pictures[15].PictureBox.Image = tmp;
                    pictures[15].Number = tmp_number;
                }
            

            }
            WinOrNotwin();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Stop();
            Time = new DateTime(0);
            Shuffle();
            t.Start();
        }
    }
    class Picture
    {
        int number;
        PictureBox pictureBox;
        public Picture(int number, PictureBox pictureBox)
        {
            this.number = number;
            this.pictureBox = pictureBox;
        }
        public int Number
        {
            set { number = value; }
            get { return number; }
        }
        public PictureBox PictureBox
        {
            set { pictureBox = value; }
            get { return pictureBox; }
        }
    }
}
