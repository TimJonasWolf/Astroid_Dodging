using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Astroid_Dodging
{
    public partial class Astroid_Dodging : Form
    {
        public int playerscore = 0;

        int playerspeed = 10;
        int playergravity = 3;

        public Form1 mainForm = null;

        public Astroid_Dodging(Form1 menue)
        {
            InitializeComponent();
            mainForm = menue as Form1;
        }



        private void GameTimer_Tick(object sender, EventArgs e)
        {
            UFO.Top += playergravity;
            Explosion.Top += playergravity;

            Asteroid1.Left -= playerspeed;
            Asteroid2.Left -= playerspeed;

            if (Asteroid1.Left < -25)
            {
                Asteroid1.Left = 600;
                playerscore++;
                Asteroid1Position();

            }
            if (Asteroid2.Left < -25)
            {
                Asteroid2.Left = 600;
                playerscore++;
                Asteroid2Position();
            }

            if (UFO.Top < -25 || UFO.Bottom > this.ClientSize.Height)
            {
                Gameover();
            }
            if (UFO.Bounds.IntersectsWith(Asteroid1.Bounds))
            {
                Gameover();
            }
            if (UFO.Bounds.IntersectsWith(Asteroid2.Bounds))
            {
                Gameover();
            }
        }

        private void Gameover()
        {
            Explosion.Visible = true;

            mainForm.buttonTryAgain.Visible = true;
            mainForm.buttonTryAgain.Enabled = true;

            mainForm.labelScore.Visible = true;

            mainForm.labelPoints.Visible = true;
            mainForm.labelPoints.Text = ($"{playerscore}");

            this.Close();

        }

        private void Asteroid1Position()
        {
            Random rand = new Random();

            int minY = 0; // Die minimale y-Position, wo du die Astroiden haben möchtest
            int maxY = 425; // Die maximale y-Position, wo du die Astroiden haben möchtest
            int minX = 315; // Die minimale x-Position, wo du die Astroiden haben möchtest
            int maxX = 630; // Die maximale x-Position, wo du die Astroiden haben möchtest

            // Generiere die Positionen für Astroiden1
            int x1 = rand.Next(minX, maxX);
            int y1 = rand.Next(minY, maxY);
            Asteroid1.Location = new Point(x1, y1);

        }

        private void Asteroid2Position()
        {
            Random rand = new Random();

            int minY = 0; // Die minimale y-Position, wo du die Astroiden haben möchtest
            int maxY = 425; // Die maximale y-Position, wo du die Astroiden haben möchtest
            int minX = 315; // Die minimale x-Position, wo du die Astroiden haben möchtest
            int maxX = 630; // Die maximale x-Position, wo du die Astroiden haben möchtest

            // Generiere die Positionen für Astroiden2
            int x1 = rand.Next(minX, maxX);
            int y1 = rand.Next(minY, maxY);
            Asteroid2.Location = new Point(x1, y1);

        }

        private void Asteroid_Dodging_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.W)
            {
                playergravity = -5;

            }
            else if (e.KeyCode == Keys.S)
            {
                playergravity = +5;

            }
            else if (e.KeyCode == Keys.D)
            {
                playerspeed = +10;

            }
            else if (e.KeyCode == Keys.A)
            {
                playerspeed = -10;
            }

            else
            {
                int playerspeed = 10;
                int playergravity = 3;
            }
        }

        private void UFO_Click(object sender, EventArgs e)
        {

        }

        private void Asteroid1_Click(object sender, EventArgs e)
        {

        }

        private void Asteroid2_Click(object sender, EventArgs e)
        {

        }

    }
}
