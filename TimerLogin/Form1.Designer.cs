namespace TimerLogin
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            tbLogin = new TextBox();
            tbMDP = new TextBox();
            label2 = new Label();
            btConnexion = new Button();
            btAnnuler = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lbTimer = new Label();
            lbInc = new Label();
            progressBar1 = new ProgressBar();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(279, 358);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 40);
            label1.TabIndex = 0;
            label1.Text = "Login";
            // 
            // tbLogin
            // 
            tbLogin.Location = new Point(499, 358);
            tbLogin.Name = "tbLogin";
            tbLogin.Size = new Size(430, 46);
            tbLogin.TabIndex = 1;
            // 
            // tbMDP
            // 
            tbMDP.Location = new Point(499, 496);
            tbMDP.Name = "tbMDP";
            tbMDP.Size = new Size(430, 46);
            tbMDP.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(279, 496);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 40);
            label2.TabIndex = 2;
            label2.Text = "Mot de passe";
            // 
            // btConnexion
            // 
            btConnexion.Location = new Point(279, 728);
            btConnexion.Name = "btConnexion";
            btConnexion.Size = new Size(324, 88);
            btConnexion.TabIndex = 4;
            btConnexion.Text = "Connexion";
            btConnexion.UseVisualStyleBackColor = true;
            btConnexion.Click += btConnexion_Click;
            // 
            // btAnnuler
            // 
            btAnnuler.Location = new Point(621, 728);
            btAnnuler.Name = "btAnnuler";
            btAnnuler.Size = new Size(324, 88);
            btAnnuler.TabIndex = 5;
            btAnnuler.Text = "Annuler";
            btAnnuler.UseVisualStyleBackColor = true;
            btAnnuler.Click += btAnnuler_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lbTimer
            // 
            lbTimer.AutoSize = true;
            lbTimer.Location = new Point(567, 596);
            lbTimer.Margin = new Padding(4, 0, 4, 0);
            lbTimer.Name = "lbTimer";
            lbTimer.Size = new Size(87, 40);
            lbTimer.TabIndex = 6;
            lbTimer.Text = "00:00";
            // 
            // lbInc
            // 
            lbInc.AutoSize = true;
            lbInc.Location = new Point(473, 1041);
            lbInc.Margin = new Padding(4, 0, 4, 0);
            lbInc.Name = "lbInc";
            lbInc.Size = new Size(254, 40);
            lbInc.TabIndex = 7;
            lbInc.Text = "Nombre d'essai : 3";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(279, 882);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(666, 57);
            progressBar1.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(16F, 40F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1257, 1107);
            Controls.Add(progressBar1);
            Controls.Add(lbInc);
            Controls.Add(lbTimer);
            Controls.Add(btAnnuler);
            Controls.Add(btConnexion);
            Controls.Add(tbMDP);
            Controls.Add(label2);
            Controls.Add(tbLogin);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10.875F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tbLogin;
        private TextBox tbMDP;
        private Label label2;
        private Button btConnexion;
        private Button btAnnuler;
        private System.Windows.Forms.Timer timer1;
        private Label lbTimer;
        private Label lbInc;
        private ProgressBar progressBar1;
    }
}