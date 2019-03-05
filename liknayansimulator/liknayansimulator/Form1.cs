using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace liknayansimulator
{
    public partial class Form1 : Form
    {
        private float x, y, i1, i2, j1, j2;
        private double o, v, vx, vy;
        bool karl = false;
        bool adan = false;
        bool javi = false;
        bool kobe = false;
        private void sabog_Click(object sender, EventArgs e)
        {

        }

        private double t = 0;
        bool tite = false;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;
            pictureBox3.Visible = false;
            pictureBox4.Visible = false;
            sabog.Visible = false;
            sabog2.Visible = false;
            sabog3.Visible = false;
            sabog4.Visible = false;
            timer1.Stop();
            x = 106;
            y = 510;
            MessageBox.Show("WELCOME TO THE PROJECTILE MOTION SIMULATOR! \r\n \r\nYou are now about to graduate from the Basic Education System \r\nHowever, the people that made your school life miserable are still out there breezing through life. \r\n \r\nYOU CAN'T LET THAT HAPPEN \r\nWIPE THEM OUT USING YOUR SUPERIOR KNOWLEDGE OF PHYSICS \r\n \r\nAdjust the velocity and the angle at which you kick the nuclear football to make sure that you hit each one of them. \r\n \r\nINSTRUCTIONS: \r\n 1. Select a target \r\n 2. Initialize the target \r\n 3. Set the velocity and the angle \r\n 4. Kick the ball");
        }

        private void init_Click(object sender, EventArgs e)
        {
            tite = true;
            if (radioButton1.Checked)
            {
                pictureBox1.Visible = true;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                i1 = 280;
                i2 = 445;
                j1 = 64;
                j2 = 267;
            }
            if (radioButton2.Checked)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                i1 = 488;
                i2 = 597;
                j1 = 344;
                j2 = 443;
            }
            if (radioButton3.Checked)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox4.Visible = false;
                i1 = 448;
                i2 = 600;
                j1 = 32;
                j2 = 200;
            }
            if (radioButton4.Checked)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                i1 = 448;
                i2 = 632;
                j1 = 192;
                j2 = 400;
            }
        }

        private void Move_Click(object sender, EventArgs e)
        {
            if (!pictureBox1.Visible&&
                !pictureBox2.Visible&&
                !pictureBox3.Visible&&
                !pictureBox4.Visible
                )
            {
                tite = false;
            }
            if (tite == false)
            {
                MessageBox.Show("Pick a target and initialize, then click this button.");
                return;
            }
            bool bo, bv;
            bo = double.TryParse(angulo.Text, out o);
            bv = double.TryParse(velocity.Text, out v);
            if (!bo || !bv)
            {
                MessageBox.Show("Enter valid doubles for angle and velocity");
            }
            vx = v*Cos(o * Math.PI / 180);
            vy = v*Sin(o * Math.PI / 180);
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if ((y < 511 && x < 800) && !((x >= i1 && x <= i2) && (y >= j1 && y <= j2)))
            {
                t += 0.1;
                x = (float)(106 + vx * t * 8);
                y = (float)(510 - (vy * t + 0.5 * (-9.8) * t * t) * (8));

                Invalidate();
            }
            else if((x >= i1 && x <= i2) && (y >= j1 && y <= j2))
            {
                timer1.Stop();
                if (radioButton1.Checked)
                {
                    sabog.Visible = true;
                    karl = true;
                }
                if (radioButton2.Checked)
                {
                    sabog2.Visible = true;
                    adan = true;
                }
                if (radioButton3.Checked)
                {
                    sabog3.Visible = true;
                    javi = true;
                }
                if (radioButton4.Checked)
                {
                    sabog4.Visible = true;
                    kobe = true;
                }
                MessageBox.Show("TARGET ELIMINATED, GOOD JOB!");
                if (kobe && adan && karl && javi)
                {
                    MessageBox.Show("MISSION COMPLETE, BOSS");
                    MessageBox.Show("You can now live a prosperous life, free from oppression.");
                    this.Close();
                }
                pictureBox1.Visible = false;
                pictureBox2.Visible = false;
                pictureBox3.Visible = false;
                pictureBox4.Visible = false;
                sabog.Visible = false;
                sabog2.Visible = false;
                sabog3.Visible = false;
                sabog4.Visible = false;
                t = 0;
                x = 106;
                y = 510;
                Invalidate();
            }
            else if (y >= 511 || x >= 800)
            {
                timer1.Stop();
                MessageBox.Show("YOU MISSED!!! GAME OVER");
                Application.Restart();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillEllipse(Brushes.Crimson, x, y, 25, 25);
        }
    }
}
