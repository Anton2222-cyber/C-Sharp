using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameBomb
{
    public partial class Game : Form
    {
        PictureBox[,] pictureBoxes;
        bool[,] is_flat;
        Timer timer;
        PictureBox bomb;
        Point locationPlane;
        int speedplane;
        public Game()
        {
            InitializeComponent();
            pictureBoxes = new PictureBox[4, 6];
            is_flat = new bool[4, 6];
            pictureBoxes[0, 0] = flat1;
            pictureBoxes[0, 1] = flat2;
            pictureBoxes[0, 2] = flat3;
            pictureBoxes[0, 3] = flat4;
            pictureBoxes[0, 4] = flat5;
            pictureBoxes[0, 5] = flat6;

            pictureBoxes[1, 0] = flat7;
            pictureBoxes[1, 1] = flat8;
            pictureBoxes[1, 2] = flat9;
            pictureBoxes[1, 3] = flat10;
            pictureBoxes[1, 4] = flat11;
            pictureBoxes[1, 5] = flat12;

            pictureBoxes[2, 0] = flat13;
            pictureBoxes[2, 1] = flat14;
            pictureBoxes[2, 2] = flat15;
            pictureBoxes[2, 3] = flat16;
            pictureBoxes[2, 4] = flat17;
            pictureBoxes[2, 5] = flat18;

            pictureBoxes[3, 0] = flat19;
            pictureBoxes[3, 1] = flat20;
            pictureBoxes[3, 2] = flat21;
            pictureBoxes[3, 3] = flat22;
            pictureBoxes[3, 4] = flat23;
            pictureBoxes[3, 5] = flat24;
            locationPlane = new Point(pictureplane.Location.X, pictureplane.Location.Y);
            New_Start();
        }
        void New_Start()
        {
            timer?.Dispose();
            GenerateCity();
            timer = new Timer();
            timer.Tick+=Progress;
            timer.Interval = 55;
            DeleteBomb();
        }

        void ClearCity()
        {
            for (int i = 0; i < pictureBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < pictureBoxes.GetLength(1); j++)
                {
                    pictureBoxes[i, j].Image = Image.FromFile("images\\empty.jpg");
                    is_flat[i, j] = false;
                }
            }
        }
        void PlaneMove()
        {
            pictureplane.Location = new Point(pictureplane.Location.X + speedplane, pictureplane.Location.Y);

            if (pictureplane.Location.X >= groupBox1.Location.X-87)
            {
                pictureplane.Location = new Point(-pictureplane.Size.Width, pictureplane.Location.Y + 100);
            }
            pictureplane.BringToFront();
        }
        bool BombHome()
        {
            bool isFine = false;
            for (int i = 0; i < pictureBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < pictureBoxes.GetLength(1); j++)
                {
                    if (is_flat[i, j] && Hit.IsHit(bomb, pictureBoxes[i, j]))
                    {
                        is_flat[i, j] = false;
                        pictureBoxes[i, j].Image = Image.FromFile("images\\empty.jpg");
                        isFine = true;

                        int rnd = new Random().Next(0, 2);
                        if(rnd==0)
                        {
                            if(i!=3)
                            {
                                is_flat[i+1, j] = false;
                                pictureBoxes[i+1, j].Image = Image.FromFile("images\\empty.jpg");
                            }
                        }
                    }
                }
            }
            return isFine;
        }
        void DeleteBomb()
        {
            if (bomb == null)
                return;

            Controls.Remove(bomb);
            bomb = null;
        }
        void BombMove()
        {
            
                if (bomb == null)
                {
                    return;
                }

                if (BombHome())
                {
                    DeleteBomb();
                    return;
                }

                if (bomb.Location.Y + bomb.Size.Height >= Size.Height)
                {
                    DeleteBomb();
                    return;
                }
            bomb.Location = new Point(bomb.Location.X, bomb.Location.Y + 15);
           
            
        }
        private void Progress(object sender, EventArgs e)
        {
            PlaneMove();
            BombMove();

            if (IsEnd())
            {
                timer.Dispose();
                timer = null;

                if (IsWin())
                {
                    MessageBox.Show("Ви виграли!","Win");
                }
                else if (IsLoose())
                {
                    MessageBox.Show("Ви програли!","Loose");
                }
            }
        }

        void GenerateCity()
        {
            ClearCity();

            Random random = new Random(DateTime.Now.Millisecond);
            for (int i = 0; i < pictureBoxes.GetLength(1); i++)
            {
                int height = random.Next(0, pictureBoxes.GetLength(0) + 1);
                for (int j = 0; j < height; j++)
                {
                    pictureBoxes[pictureBoxes.GetLength(0) - 1 - j, i].Image = Image.FromFile("images\\flat.jpg");
                    is_flat[is_flat.GetLength(0) - 1 - j, i] = true;
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            DropABomb.Enabled = true;
            difficulty1.Enabled = false;
            difficulty2.Enabled = false;
            difficulty3.Enabled = false;
            Start.Enabled = false;
            if (difficulty1.Checked==true)
            {
                speedplane = 4;
            }
            else if(difficulty2.Checked==true)
            {
                speedplane = 7;
            }
            else if (difficulty3.Checked == true)
            {
                speedplane = 11;
            }
            timer.Start();
            
        }
        bool IsNoFlats()
        {
            for (int i = 0; i < pictureBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < pictureBoxes.GetLength(1); j++)
                {
                    if (is_flat[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        bool HitWithHome()
        {
            for (int i = 0; i < pictureBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < pictureBoxes.GetLength(1); j++)
                {
                    if (is_flat[i, j] && Hit.IsHit(pictureplane, pictureBoxes[i, j]))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        bool IsLoose()
        {
            return HitWithHome();
        }
        bool IsWin()
        {
            return IsNoFlats();
        }
        bool IsEnd()
        {
            return IsWin() || IsLoose();
        }
        void DropABomb2()
        {
             bomb = new PictureBox();
            bomb.Size = new Size(40, 40);
            bomb.Location = new Point(pictureplane.Location.X + (pictureplane.Size.Width / 2) - (bomb.Size.Width / 2), pictureplane.Location.Y + pictureplane.Size.Height);
            bomb.Image = Image.FromFile("images\\bomb.png");
            bomb.SizeMode = PictureBoxSizeMode.Zoom;
            Controls.Add(bomb);
            Controls[Controls.IndexOf(bomb)].BringToFront();
            groupBox1.BringToFront();
        }

        private void DropABomb_Click(object sender, EventArgs e)
        {
            if (IsEnd())
            {
                return;
            }

            if (bomb != null)
            {
                return;
            }

            if (!timer.Enabled)
            {
                return;
            }
            DropABomb2();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            pictureplane.Location = locationPlane;
            difficulty1.Enabled = true;
            difficulty2.Enabled = true;
            difficulty3.Enabled = true;
            Start.Enabled = true;
            DropABomb.Enabled = false;
            New_Start();
        }
    }
    public static class Hit
    {
        public static bool IsHit(Control first, Control second)
        {
            int x1 = first.Location.X + first.Size.Width;
            int y1 = first.Location.Y + first.Size.Height;
            int y2 = second.Location.X + second.Size.Width;
            int b2 = second.Location.Y + second.Size.Height;
            return (first.Location.X < y2) && (second.Location.X < x1) && (first.Location.Y < b2) && (second.Location.Y < y1);
        }
    }
}
