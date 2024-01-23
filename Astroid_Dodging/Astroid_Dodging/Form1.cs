namespace Astroid_Dodging
{
    public partial class Form1 : Form
    {
        Astroid_Dodging astroid_dodger;
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            astroid_dodger = new Astroid_Dodging(this);
            astroid_dodger.Show();

        }

        private void buttonTryAgain_Click(object sender, EventArgs e)
        {
            astroid_dodger = new Astroid_Dodging(this);
            astroid_dodger.Show();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
