namespace ProjektBankaHelisek
{
    partial class FormRegister
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
            label2 = new Label();
            label1 = new Label();
            txbPassword = new TextBox();
            txbName = new TextBox();
            btn_back = new Button();
            btnRegister = new Button();
            txbConfirmPassword = new TextBox();
            label3 = new Label();
            pbProfil = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbProfil).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 270);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 8;
            label2.Text = "Heslo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 209);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 7;
            label1.Text = "Jméno";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(58, 288);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(247, 23);
            txbPassword.TabIndex = 6;
            // 
            // txbName
            // 
            txbName.Location = new Point(58, 227);
            txbName.Name = "txbName";
            txbName.Size = new Size(247, 23);
            txbName.TabIndex = 5;
            // 
            // btn_back
            // 
            btn_back.Location = new Point(12, 486);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(75, 23);
            btn_back.TabIndex = 9;
            btn_back.Text = "Zpět";
            btn_back.UseVisualStyleBackColor = true;
            btn_back.Click += btn_back_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(142, 386);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(75, 23);
            btnRegister.TabIndex = 10;
            btnRegister.Text = "Registrovat";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // txbConfirmPassword
            // 
            txbConfirmPassword.Location = new Point(58, 346);
            txbConfirmPassword.Name = "txbConfirmPassword";
            txbConfirmPassword.Size = new Size(247, 23);
            txbConfirmPassword.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 328);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 12;
            label3.Text = "Potvrdit heslo";
            // 
            // pbProfil
            // 
            pbProfil.Location = new Point(121, 44);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(128, 128);
            pbProfil.TabIndex = 13;
            pbProfil.TabStop = false;
            pbProfil.Click += pictureBox1_Click;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 521);
            Controls.Add(pbProfil);
            Controls.Add(label3);
            Controls.Add(txbConfirmPassword);
            Controls.Add(btnRegister);
            Controls.Add(btn_back);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbPassword);
            Controls.Add(txbName);
            Name = "FormRegister";
            Text = "FormRegister";
            ((System.ComponentModel.ISupportInitialize)pbProfil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox txbPassword;
        private TextBox txbName;
        private Button btn_back;
        private Button btnRegister;
        private TextBox txbConfirmPassword;
        private Label label3;
        private PictureBox pbProfil;
    }
}