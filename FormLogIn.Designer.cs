namespace ProjektBankaHelisek
{
    partial class FormLogIn
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
            btnLogIn = new Button();
            txbName = new TextBox();
            txbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            lbl_registrace = new Label();
            btnSee = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogIn
            // 
            btnLogIn.Location = new Point(122, 304);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(116, 23);
            btnLogIn.TabIndex = 0;
            btnLogIn.Text = "Přihlasit se";
            btnLogIn.UseVisualStyleBackColor = true;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // txbName
            // 
            txbName.Location = new Point(58, 197);
            txbName.Name = "txbName";
            txbName.Size = new Size(247, 23);
            txbName.TabIndex = 1;
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(58, 258);
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '*';
            txbPassword.Size = new Size(247, 23);
            txbPassword.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 179);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 3;
            label1.Text = "Jméno";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 240);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 4;
            label2.Text = "Heslo";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.profil;
            pictureBox1.Location = new Point(122, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(128, 128);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl_registrace
            // 
            lbl_registrace.AutoSize = true;
            lbl_registrace.Location = new Point(142, 373);
            lbl_registrace.Name = "lbl_registrace";
            lbl_registrace.Size = new Size(75, 15);
            lbl_registrace.TabIndex = 6;
            lbl_registrace.Text = "Nemáš účet?";
            lbl_registrace.Click += lbl_registrace_Click;
            // 
            // btnSee
            // 
            btnSee.Location = new Point(311, 258);
            btnSee.Name = "btnSee";
            btnSee.Size = new Size(20, 23);
            btnSee.TabIndex = 7;
            btnSee.Text = "-";
            btnSee.UseVisualStyleBackColor = true;
            btnSee.Click += btnSee_Click;
            // 
            // FormLogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 521);
            Controls.Add(btnSee);
            Controls.Add(lbl_registrace);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbPassword);
            Controls.Add(txbName);
            Controls.Add(btnLogIn);
            Name = "FormLogIn";
            Text = "FormLogIn";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogIn;
        private TextBox txbName;
        private TextBox txbPassword;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lbl_registrace;
        private Button btnSee;
    }
}