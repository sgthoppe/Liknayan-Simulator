namespace liknayansimulator
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
            this.Move = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.velocity = new System.Windows.Forms.TextBox();
            this.angulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.init = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.sabog = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.sabog4 = new System.Windows.Forms.PictureBox();
            this.sabog3 = new System.Windows.Forms.PictureBox();
            this.sabog2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog2)).BeginInit();
            this.SuspendLayout();
            // 
            // Move
            // 
            this.Move.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Move.Location = new System.Drawing.Point(8, 16);
            this.Move.Name = "Move";
            this.Move.Size = new System.Drawing.Size(100, 23);
            this.Move.TabIndex = 0;
            this.Move.Text = "Sipain ang Bola";
            this.Move.UseVisualStyleBackColor = true;
            this.Move.Click += new System.EventHandler(this.Move_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // velocity
            // 
            this.velocity.Location = new System.Drawing.Point(8, 88);
            this.velocity.Name = "velocity";
            this.velocity.Size = new System.Drawing.Size(96, 20);
            this.velocity.TabIndex = 1;
            // 
            // angulo
            // 
            this.angulo.Location = new System.Drawing.Point(8, 144);
            this.angulo.Name = "angulo";
            this.angulo.Size = new System.Drawing.Size(96, 20);
            this.angulo.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Velocity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Angle of Release (deg)";
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(16, 352);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(61, 17);
            this.radioButton4.TabIndex = 9;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "target 4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(16, 320);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(61, 17);
            this.radioButton3.TabIndex = 8;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "target 3";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(16, 288);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(61, 17);
            this.radioButton2.TabIndex = 7;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "target 2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(16, 256);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 6;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "target 1";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // init
            // 
            this.init.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.init.Location = new System.Drawing.Point(8, 200);
            this.init.Name = "init";
            this.init.Size = new System.Drawing.Size(75, 48);
            this.init.TabIndex = 10;
            this.init.Text = "Initialize Target";
            this.init.UseVisualStyleBackColor = true;
            this.init.Click += new System.EventHandler(this.init_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::liknayansimulator.Properties.Resources.karl_bakla;
            this.pictureBox1.Location = new System.Drawing.Point(280, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::liknayansimulator.Properties.Resources.adan_bakla;
            this.pictureBox2.Location = new System.Drawing.Point(488, 344);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(91, 99);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // sabog
            // 
            this.sabog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sabog.Image = global::liknayansimulator.Properties.Resources.bigsabog;
            this.sabog.Location = new System.Drawing.Point(216, 24);
            this.sabog.Name = "sabog";
            this.sabog.Size = new System.Drawing.Size(300, 289);
            this.sabog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sabog.TabIndex = 13;
            this.sabog.TabStop = false;
            this.sabog.Click += new System.EventHandler(this.sabog_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::liknayansimulator.Properties.Resources.javi_bakla;
            this.pictureBox3.Location = new System.Drawing.Point(448, 32);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(152, 168);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::liknayansimulator.Properties.Resources.kobe_bakla;
            this.pictureBox4.Location = new System.Drawing.Point(448, 192);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(184, 208);
            this.pictureBox4.TabIndex = 17;
            this.pictureBox4.TabStop = false;
            // 
            // sabog4
            // 
            this.sabog4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sabog4.Image = global::liknayansimulator.Properties.Resources.bigsabog;
            this.sabog4.Location = new System.Drawing.Point(384, 160);
            this.sabog4.Name = "sabog4";
            this.sabog4.Size = new System.Drawing.Size(300, 289);
            this.sabog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sabog4.TabIndex = 18;
            this.sabog4.TabStop = false;
            // 
            // sabog3
            // 
            this.sabog3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sabog3.Image = global::liknayansimulator.Properties.Resources.bigsabog;
            this.sabog3.Location = new System.Drawing.Point(392, -16);
            this.sabog3.Name = "sabog3";
            this.sabog3.Size = new System.Drawing.Size(300, 289);
            this.sabog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sabog3.TabIndex = 19;
            this.sabog3.TabStop = false;
            // 
            // sabog2
            // 
            this.sabog2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sabog2.Image = global::liknayansimulator.Properties.Resources.bigsabog;
            this.sabog2.Location = new System.Drawing.Point(368, 288);
            this.sabog2.Name = "sabog2";
            this.sabog2.Size = new System.Drawing.Size(300, 289);
            this.sabog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.sabog2.TabIndex = 20;
            this.sabog2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::liknayansimulator.Properties.Resources.CartesianPlane_242;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(709, 573);
            this.Controls.Add(this.sabog2);
            this.Controls.Add(this.sabog3);
            this.Controls.Add(this.sabog4);
            this.Controls.Add(this.sabog);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.init);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.angulo);
            this.Controls.Add(this.velocity);
            this.Controls.Add(this.Move);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Projectile Motion Simulator";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sabog2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Move;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox velocity;
        private System.Windows.Forms.TextBox angulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button init;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox sabog;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox sabog4;
        private System.Windows.Forms.PictureBox sabog3;
        private System.Windows.Forms.PictureBox sabog2;
    }
}

