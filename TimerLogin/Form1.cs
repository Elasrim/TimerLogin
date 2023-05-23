namespace TimerLogin
{
    public partial class Form1 : Form
    {
        int t = 30;
        int nbrIncorrect = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 30;
            progressBar1.Step = 1;
            
            tbMDP.UseSystemPasswordChar = true;
            timer1.Interval = 1000;
            timer1.Start();
            lbTimer.Text = "00:" + t;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t--;
            progressBar1.PerformStep();
            if (t >= 10)
            {
                lbTimer.Text = "00:" + t;
            }
            else
            {
                lbTimer.Text = "00:0" + t;
            }


            if (t == 0)
            {
                timer1.Stop();
                MessageBox.Show("Temps épuisé", "Timer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Close();
            }

            if (nbrIncorrect == 0) { this.Close(); }


        }
        private void btConnexion_Click(object sender, EventArgs e)
        {
            nbrIncorrect--;
            lbInc.Text = "Nombre d'essais : " + nbrIncorrect;
            if (tbLogin.Text == "admin" && tbMDP.Text == "0000")
            {
                timer1.Stop();
                MessageBox.Show("Bienvenu", "Accée Autorisé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbTimer.Visible = false;

            }
            else
            {
                MessageBox.Show("Login ou Mot de passe est incorrect", "Accée non autorisé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            tbLogin.Text = tbMDP.Text = "";
            tbLogin.Focus();
        }
    }
}