using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dinozor_oyunu_ana
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int kr =0;
        int yemlc;
        int puann = 0;
        int arabahız = 10;
        int yemlcuc = 0;
        int ucakhız = 18;
        int ucakcagır = 70;
        int ucakhde = 200;
        
        
        
        private void Form1_Load(object sender, EventArgs e)
        {                               //Pictures must your file location
            axWindowsMediaPlayer1.URL = "D:\\Code\\visual studio\\dinozor oyunu ana\\dinozor oyunu ana\\pictures\\dancemonkey.mp3";
        }

        private void karakter_Tick(object sender, EventArgs e)
        {
            if (kr == 0)
            {
                PictureBox1.Image = Image.FromFile("D:\\Code\\visual studio\\dinozor oyunu ana\\dinozor oyunu ana\\pictures\\53.png");
            }
            if (kr == 3)
            {
                PictureBox1.Image = Image.FromFile("D:\\Code\\visual studio\\dinozor oyunu ana\\dinozor oyunu ana\\pictures\\54.png");
            }
            kr++;
            if (kr == 6)
            {
                kr = 0;
            }
            if (PictureBox1.Right >= yem.Left && PictureBox1.Bottom >= yem.Top && PictureBox1.Left <= yem.Right && PictureBox1.Top <= yem.Bottom)
            {
                karakter.Stop();
                axWindowsMediaPlayer1.URL = "D:\\Code\\visual studio\\dinozor oyunu ana\\dinozor oyunu ana\\pictures\\kzses.mp3";
                PictureBox1.Image = Image.FromFile("D:\\Code\\visual studio\\dinozor oyunu ana\\dinozor oyunu ana\\pictures\\55.png");
                Yemharaket.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Fikret Diyor Ki : KAYBETTİN ");
                Application.Restart();
            }
            if (PictureBox1.Right >= yemuc.Left && PictureBox1.Bottom >= yemuc.Top && PictureBox1.Left <= yemuc.Right && PictureBox1.Top <= yemuc.Bottom)
            {
                karakter.Stop();
                axWindowsMediaPlayer1.URL = "D:\\Code\\visual studio\\dinozor oyunu ana\\dinozor oyunu ana\\pictures\\kzses.mp3";
                PictureBox1.Image = Image.FromFile("D:\\Code\\visual studio\\dinozor oyunu ana\\dinozor oyunu ana\\pictures\\55.png");
                Yemharaket.Stop();
                timer1.Enabled = false;
                MessageBox.Show("Fikret Diyor Ki : KAYBETTİN ");
                Application.Restart();
            }
            if (puann >= ucakcagır )
            {
                if (PictureBox1.Right >= yem.Left)
                {
                    yem.Location = new Point(1400, 511);
                }
                    yem2.Enabled = true;
                    Yemharaket.Enabled = false;
                    ucakcagır += ucakhde;
                
            }
        }

        private void zıplama_Tick(object sender, EventArgs e)
        {
            PictureBox1.Top = PictureBox1.Top - 80;
            if (label2.Bottom >= PictureBox1.Top)
            {
                zıplama.Stop();
                indirme.Start();
                if (arabahız <=70)
                {
                    arabahız++;
                }
                if (ucakhız <= 80)
                {
                    ucakhız++; 
                }
                ucakhde -= 3;
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                zıplama.Start();
            }
            if (e.KeyCode == Keys.Q)
            {
                Yemharaket.Enabled = true;
                label3.Visible = false;
                timer1.Enabled = true;
            }
        }

        private void indirme_Tick(object sender, EventArgs e)
        {
            PictureBox1.Top = PictureBox1.Top + 80;
            if (Label1.Top <=PictureBox1.Bottom)
            {
                indirme.Stop();
            }
        }
       
        private void Yemharaket_Tick(object sender, EventArgs e)
        {
            Random rast = new Random();
            yemlc = rast.Next(5, arabahız);
            yem.Left = yem.Left - yemlc;
            if (label4.Left >= yem.Right)
            {
                yem.Location = new Point(1400, 475);
            }
        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            puann++;
            puan.Text = puann.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yem2_Tick(object sender, EventArgs e)
        {
            Random raste = new Random();
            yemlcuc = raste.Next(5, ucakhız);
            yemuc.Left = yemuc.Left - yemlcuc;
            if (label4.Left >= yemuc.Right)
            {
                yem2.Enabled = false;
                Yemharaket.Enabled = true;
                yemuc.Location = new Point(1400, 252);
            }
        }
    }
}
