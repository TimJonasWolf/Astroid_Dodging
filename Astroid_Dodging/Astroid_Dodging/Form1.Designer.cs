namespace Astroid_Dodging
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitelGames = new Label();
            labelScore = new Label();
            buttonTryAgain = new Button();
            buttonClose = new Button();
            labelPoints = new Label();
            buttonStart = new Button();
            SuspendLayout();
            // 
            // labelTitelGames
            // 
            labelTitelGames.AutoSize = true;
            labelTitelGames.Font = new Font("Leelawadee UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            labelTitelGames.ForeColor = Color.Fuchsia;
            labelTitelGames.Location = new Point(144, 23);
            labelTitelGames.Name = "labelTitelGames";
            labelTitelGames.Size = new Size(538, 86);
            labelTitelGames.TabIndex = 0;
            labelTitelGames.Text = "Astroid Dodging";
            labelTitelGames.TextAlign = ContentAlignment.BottomLeft;
            // 
            // labelScore
            // 
            labelScore.AutoSize = true;
            labelScore.BackColor = Color.FromArgb(255, 192, 255);
            labelScore.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelScore.ForeColor = Color.Blue;
            labelScore.Location = new Point(363, 254);
            labelScore.Name = "labelScore";
            labelScore.Size = new Size(66, 28);
            labelScore.TabIndex = 1;
            labelScore.Text = "Score";
            labelScore.Visible = false;
            // 
            // buttonTryAgain
            // 
            buttonTryAgain.BackColor = Color.FromArgb(192, 255, 255);
            buttonTryAgain.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonTryAgain.ForeColor = Color.Fuchsia;
            buttonTryAgain.Location = new Point(336, 169);
            buttonTryAgain.Name = "buttonTryAgain";
            buttonTryAgain.Size = new Size(122, 38);
            buttonTryAgain.TabIndex = 3;
            buttonTryAgain.Text = "TryAgain";
            buttonTryAgain.UseVisualStyleBackColor = false;
            buttonTryAgain.Visible = false;
            buttonTryAgain.Click += buttonTryAgain_Click;
            // 
            // buttonClose
            // 
            buttonClose.BackColor = Color.FromArgb(192, 255, 255);
            buttonClose.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonClose.ForeColor = Color.Fuchsia;
            buttonClose.Location = new Point(336, 372);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(122, 38);
            buttonClose.TabIndex = 4;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = false;
            buttonClose.Click += buttonClose_Click;
            // 
            // labelPoints
            // 
            labelPoints.AutoSize = true;
            labelPoints.BackColor = Color.FromArgb(255, 192, 255);
            labelPoints.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPoints.ForeColor = Color.Blue;
            labelPoints.Location = new Point(381, 294);
            labelPoints.Name = "labelPoints";
            labelPoints.Size = new Size(23, 28);
            labelPoints.TabIndex = 5;
            labelPoints.Text = "0";
            labelPoints.Visible = false;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = Color.FromArgb(192, 255, 255);
            buttonStart.Font = new Font("Palatino Linotype", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonStart.ForeColor = Color.Fuchsia;
            buttonStart.Location = new Point(336, 169);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(122, 38);
            buttonStart.TabIndex = 6;
            buttonStart.Text = "Start";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += buttonStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(800, 450);
            Controls.Add(labelPoints);
            Controls.Add(buttonClose);
            Controls.Add(buttonTryAgain);
            Controls.Add(labelScore);
            Controls.Add(labelTitelGames);
            Controls.Add(buttonStart);
            Name = "Form1";
            Text = "Menue";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitelGames;
        public Button buttonTryAgain;
        public Button buttonStart;
        public Label labelScore;
        public Button buttonClose;
        public Label labelPoints;
    }
}
