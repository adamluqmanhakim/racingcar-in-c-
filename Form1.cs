using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Racingcar1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            over.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            moveline(gamespeed);
            Obstacle(gamespeed);
            gameover();
            coins(gamespeed);
            coinscollection();
            /*if (over.Visible = true)
            {
                gameOver();

                this.Close();
            }*/
        }

        int collectedcoin = 0;
        Random r = new Random();
        int x, y;

        void Obstacle (int speed)
        {
            //obstacle 1
            if (Obstacle1.Top >= 500)
            {
                x = r.Next(0,200);
             
                Obstacle1.Location = new Point(x, 0);
            }
            else
            {
                Obstacle1.Top += speed;
            }

            //obstacle 2
            if (Obstacle2.Top >= 500)
            {
                x = r.Next(0, 200);
              
                Obstacle2.Location = new Point(x, 0);
            }
            else
            {
                Obstacle2.Top += speed;
            }

            //obstacle 3
            if (Obstacle3.Top >= 500)
            {
                x = r.Next(0, 200);
                
                Obstacle3.Location = new Point(x, 0);
            }
            else
            {
                Obstacle3.Top += speed;
            }
        }



        void coins(int speed)
        {
            //coin 1
            if (coin1.Top >= 500)
            {
                x = r.Next(50, 300);

                coin1.Location = new Point(x, 0);
            }
            else
            {
               coin1.Top += speed;
            }
            //coin 2
            if (coin2.Top >= 500)
            {
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }
            else
            {
                coin2.Top += speed;
            }
            //coin 3
            if (coin3.Top >= 500)
            {
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }
            else
            {
                coin3.Top += speed;
            }
            //coin 4
            if (coin4.Top >= 500)
            {
                x = r.Next(50, 300);

                coin4.Location = new Point(x, 0);
            }
            else
            {
                coin4.Top += speed;
            }
        }



        void gameover()
        {
            if (car.Bounds.IntersectsWith(Obstacle1.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;
                
            }
            if (car.Bounds.IntersectsWith(Obstacle2.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }
            if (car.Bounds.IntersectsWith(Obstacle3.Bounds))
            {
                timer1.Enabled = false;
                over.Visible = true;

            }
        }

        void moveline(int speed)
        {
            if (pictureBox1.Top >= 500)
            {
                pictureBox1.Top = 0;
            }
            else
            {
                pictureBox1.Top += speed ;
            }

            if (pictureBox2.Top >= 500)
            {
                pictureBox2.Top = 0;
            }
            else
            {
                pictureBox2.Top += speed;
            }


            if (pictureBox3.Top >= 500)
            {
                pictureBox3.Top = 0;
            }
            else
            {
                pictureBox3.Top += speed;
            }

            if (pictureBox6.Top >= 500)
            {
                pictureBox6.Top = 0;
            }
            else
            {
                pictureBox6.Top += speed;
            }
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Car_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                car.Left += -1;
            }
            if (e.KeyCode == Keys.Right)
            {
                car.Left += 1;
            }
        }

        void coinscollection()
        {
            if (car.Bounds.IntersectsWith(coin1.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin1.Location = new Point(x, 0);

            }

            if (car.Bounds.IntersectsWith(coin2.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin2.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin3.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin3.Location = new Point(x, 0);
            }

            if (car.Bounds.IntersectsWith(coin4.Bounds))
            {
                collectedcoin++;
                label1.Text = "Coins = " + collectedcoin.ToString();
                x = r.Next(50, 300);

                coin4.Location = new Point(x, 0);
            }
        }


        int gamespeed = 0;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                if (car.Left>15)
                car.Left += -8;
            }
            if (e.KeyCode == Keys.Right)
            {
                if (car.Right < 300)
                    car.Left += 8;
            }

            if (e.KeyCode ==Keys.Up)
            {
                if (gamespeed < 21)
                {
                    gamespeed++;
                    label2.Text = "Speed = " + gamespeed.ToString();
                }
            }    
              
            if (e.KeyCode == Keys.Down)
            {
                if (gamespeed > 0)
                {
                    gamespeed--;
                    label2.Text = "Speed = " + gamespeed.ToString();
                }
            }    
                

        }
         void ResetGame()
        {

        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }
    }
}
