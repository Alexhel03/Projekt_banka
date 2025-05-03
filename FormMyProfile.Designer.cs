namespace ProjektBankaHelisek
{
    partial class FormMyProfile
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
            btnBack = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label3 = new Label();
            txbPassWord2 = new TextBox();
            txbPassWord = new TextBox();
            txbName = new TextBox();
            btnChangePassword = new Button();
            btnChangeName = new Button();
            label2 = new Label();
            pbProfile = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 486);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(134, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Zpět na hlavní stránku";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 36);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "Jméno:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txbPassWord2);
            groupBox1.Controls.Add(txbPassWord);
            groupBox1.Controls.Add(txbName);
            groupBox1.Controls.Add(btnChangePassword);
            groupBox1.Controls.Add(btnChangeName);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(23, 153);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(316, 277);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            groupBox1.Text = "Můj profil";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 147);
            label3.Name = "label3";
            label3.Size = new Size(112, 15);
            label3.TabIndex = 7;
            label3.Text = "Potvrdit nový heslo:";
            // 
            // txbPassWord2
            // 
            txbPassWord2.Location = new Point(210, 144);
            txbPassWord2.Name = "txbPassWord2";
            txbPassWord2.Size = new Size(100, 23);
            txbPassWord2.TabIndex = 6;
            // 
            // txbPassWord
            // 
            txbPassWord.Location = new Point(210, 86);
            txbPassWord.Name = "txbPassWord";
            txbPassWord.Size = new Size(100, 23);
            txbPassWord.TabIndex = 5;
            // 
            // txbName
            // 
            txbName.Location = new Point(210, 33);
            txbName.Name = "txbName";
            txbName.Size = new Size(100, 23);
            txbName.TabIndex = 4;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(193, 248);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(117, 23);
            btnChangePassword.TabIndex = 3;
            btnChangePassword.Text = "Změnit heslo";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnChangeName
            // 
            btnChangeName.Location = new Point(6, 248);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(117, 23);
            btnChangeName.TabIndex = 2;
            btnChangeName.Text = "Změnit jméno";
            btnChangeName.UseVisualStyleBackColor = true;
            btnChangeName.Click += btnChangeName_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 89);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Heslo:";
            // 
            // pbProfile
            // 
            pbProfile.Image = Properties.Resources.profil;
            pbProfile.Location = new Point(119, 19);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(128, 128);
            pbProfile.SizeMode = PictureBoxSizeMode.AutoSize;
            pbProfile.TabIndex = 15;
            pbProfile.TabStop = false;
            // 
            // FormMyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 521);
            Controls.Add(pbProfile);
            Controls.Add(groupBox1);
            Controls.Add(btnBack);
            Name = "FormMyProfile";
            Text = "FormMyProfile";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private PictureBox pbProfile;
        private Button btnChangePassword;
        private Label label3;
        private TextBox txbPassWord2;
        private TextBox txbPassWord;
        private TextBox txbName;
        private Button btnChangeName;
    }
}