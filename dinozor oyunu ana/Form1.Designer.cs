namespace dinozor_oyunu_ana
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Label1 = new System.Windows.Forms.Label();
            this.karakter = new System.Windows.Forms.Timer(this.components);
            this.zıplama = new System.Windows.Forms.Timer(this.components);
            this.indirme = new System.Windows.Forms.Timer(this.components);
            this.Yemharaket = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.yem = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.puan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.yem2 = new System.Windows.Forms.Timer(this.components);
            this.yemuc = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemuc)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Green;
            this.Label1.Location = new System.Drawing.Point(-4, 568);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1382, 60);
            this.Label1.TabIndex = 4;
            // 
            // karakter
            // 
            this.karakter.Enabled = true;
            this.karakter.Interval = 40;
            this.karakter.Tick += new System.EventHandler(this.karakter_Tick);
            // 
            // zıplama
            // 
            this.zıplama.Tick += new System.EventHandler(this.zıplama_Tick);
            // 
            // indirme
            // 
            this.indirme.Tick += new System.EventHandler(this.indirme_Tick);
            // 
            // Yemharaket
            // 
            this.Yemharaket.Interval = 10;
            this.Yemharaket.Tick += new System.EventHandler(this.Yemharaket_Tick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-26, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1421, 19);
            this.label2.TabIndex = 9;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(-4, -10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 401);
            this.label4.TabIndex = 10;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(-1, -10);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(194, 45);
            this.axWindowsMediaPlayer1.TabIndex = 11;
            this.axWindowsMediaPlayer1.Visible = false;
            // 
            // yem
            // 
            this.yem.Image = ((System.Drawing.Image)(resources.GetObject("yem.Image")));
            this.yem.Location = new System.Drawing.Point(1313, 510);
            this.yem.Name = "yem";
            this.yem.Size = new System.Drawing.Size(136, 55);
            this.yem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yem.TabIndex = 12;
            this.yem.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(820, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 39);
            this.label5.TabIndex = 13;
            this.label5.Text = "Puan:";
            // 
            // puan
            // 
            this.puan.AutoSize = true;
            this.puan.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.puan.Location = new System.Drawing.Point(960, 22);
            this.puan.Name = "puan";
            this.puan.Size = new System.Drawing.Size(36, 39);
            this.puan.TabIndex = 14;
            this.puan.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 100F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1083, 153);
            this.label3.TabIndex = 15;
            this.label3.Text = "Başla : Q Basınız";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // PictureBox1
            // 
            this.PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox1.Image")));
            this.PictureBox1.Location = new System.Drawing.Point(12, 430);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(72, 138);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 16;
            this.PictureBox1.TabStop = false;
            // 
            // yem2
            // 
            this.yem2.Interval = 10;
            this.yem2.Tick += new System.EventHandler(this.yem2_Tick);
            // 
            // yemuc
            // 
            this.yemuc.Image = ((System.Drawing.Image)(resources.GetObject("yemuc.Image")));
            this.yemuc.Location = new System.Drawing.Point(1400, 252);
            this.yemuc.Name = "yemuc";
            this.yemuc.Size = new System.Drawing.Size(195, 77);
            this.yemuc.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.yemuc.TabIndex = 17;
            this.yemuc.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1370, 616);
            this.Controls.Add(this.yemuc);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.puan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.yem);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Fikret game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yemuc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Timer karakter;
        private System.Windows.Forms.Timer zıplama;
        private System.Windows.Forms.Timer indirme;
        private System.Windows.Forms.Timer Yemharaket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.PictureBox yem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label puan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.PictureBox PictureBox1;
        private System.Windows.Forms.Timer yem2;
        private System.Windows.Forms.PictureBox yemuc;
    }
}

