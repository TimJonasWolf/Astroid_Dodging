namespace Astroid_Dodging
{
    partial class Astroid_Dodging
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Astroid_Dodging));
            Asteroid1 = new PictureBox();
            GameTimer = new System.Windows.Forms.Timer(components);
            UFO = new PictureBox();
            Asteroid2 = new PictureBox();
            Explosion = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Asteroid1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UFO).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Explosion).BeginInit();
            SuspendLayout();
            // 
            // Asteroid1
            // 
            Asteroid1.BackgroundImage = (Image)resources.GetObject("Asteroid1.BackgroundImage");
            Asteroid1.BackgroundImageLayout = ImageLayout.Stretch;
            Asteroid1.Location = new Point(498, 46);
            Asteroid1.Name = "Asteroid1";
            Asteroid1.Size = new Size(100, 50);
            Asteroid1.TabIndex = 1;
            Asteroid1.TabStop = false;
            Asteroid1.Click += Asteroid1_Click;
            // 
            // GameTimer
            // 
            GameTimer.Enabled = true;
            GameTimer.Interval = 20;
            GameTimer.Tick += GameTimer_Tick;
            // 
            // UFO
            // 
            UFO.BackgroundImage = (Image)resources.GetObject("UFO.BackgroundImage");
            UFO.BackgroundImageLayout = ImageLayout.Stretch;
            UFO.Location = new Point(49, 172);
            UFO.Name = "UFO";
            UFO.Size = new Size(100, 50);
            UFO.TabIndex = 3;
            UFO.TabStop = false;
            UFO.Click += UFO_Click;
            // 
            // Asteroid2
            // 
            Asteroid2.BackgroundImage = (Image)resources.GetObject("Asteroid2.BackgroundImage");
            Asteroid2.BackgroundImageLayout = ImageLayout.Stretch;
            Asteroid2.Location = new Point(570, 316);
            Asteroid2.Name = "Asteroid2";
            Asteroid2.Size = new Size(100, 50);
            Asteroid2.TabIndex = 4;
            Asteroid2.TabStop = false;
            Asteroid2.Click += Asteroid2_Click;
            // 
            // Explosion
            // 
            Explosion.BackgroundImage = (Image)resources.GetObject("Explosion.BackgroundImage");
            Explosion.BackgroundImageLayout = ImageLayout.Stretch;
            Explosion.Location = new Point(49, 172);
            Explosion.Name = "Explosion";
            Explosion.Size = new Size(100, 50);
            Explosion.TabIndex = 5;
            Explosion.TabStop = false;
            Explosion.Visible = false;
            // 
            // Astroid_Dodging
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(Explosion);
            Controls.Add(Asteroid2);
            Controls.Add(UFO);
            Controls.Add(Asteroid1);
            Name = "Astroid_Dodging";
            Text = "Astroid_Dodging";
            KeyDown += Asteroid_Dodging_KeyDown;
            ((System.ComponentModel.ISupportInitialize)Asteroid1).EndInit();
            ((System.ComponentModel.ISupportInitialize)UFO).EndInit();
            ((System.ComponentModel.ISupportInitialize)Asteroid2).EndInit();
            ((System.ComponentModel.ISupportInitialize)Explosion).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox Asteroid1;
        private System.Windows.Forms.Timer GameTimer;
        private PictureBox UFO;
        private PictureBox Asteroid2;
        private PictureBox Explosion;
    }
}