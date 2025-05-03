namespace ProjektBankaHelisek
{
    partial class FormBankaHome
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
            btnPay = new Button();
            groupBox2 = new GroupBox();
            lblMoney = new Label();
            lblAccountNumber = new Label();
            pbProfil = new PictureBox();
            cb_menu = new ComboBox();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfil).BeginInit();
            SuspendLayout();
            // 
            // btnPay
            // 
            btnPay.Location = new Point(21, 433);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(316, 68);
            btnPay.TabIndex = 0;
            btnPay.Text = "Nová platba";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lblMoney);
            groupBox2.Controls.Add(lblAccountNumber);
            groupBox2.Location = new Point(21, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 337);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tarif Standard";
            // 
            // lblMoney
            // 
            lblMoney.AutoSize = true;
            lblMoney.Location = new Point(10, 73);
            lblMoney.Name = "lblMoney";
            lblMoney.Size = new Size(83, 15);
            lblMoney.TabIndex = 2;
            lblMoney.Text = "Peníze na učtě";
            // 
            // lblAccountNumber
            // 
            lblAccountNumber.AutoSize = true;
            lblAccountNumber.Location = new Point(10, 32);
            lblAccountNumber.Name = "lblAccountNumber";
            lblAccountNumber.Size = new Size(58, 15);
            lblAccountNumber.TabIndex = 1;
            lblAccountNumber.Text = "číslo účtu";
            // 
            // pbProfil
            // 
            pbProfil.Location = new Point(311, 12);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(40, 40);
            pbProfil.TabIndex = 4;
            pbProfil.TabStop = false;
            pbProfil.Click += pbProfil_Click;
            // 
            // cb_menu
            // 
            cb_menu.FormattingEnabled = true;
            cb_menu.Location = new Point(21, 58);
            cb_menu.Name = "cb_menu";
            cb_menu.Size = new Size(146, 23);
            cb_menu.TabIndex = 10;
            cb_menu.Text = "Přehled";
            cb_menu.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // FormBankaHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 521);
            Controls.Add(cb_menu);
            Controls.Add(pbProfil);
            Controls.Add(groupBox2);
            Controls.Add(btnPay);
            Name = "FormBankaHome";
            Text = "Banka";
            Load += FormBankaHome_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfil).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnPay;
        private GroupBox groupBox2;
        private Label lblMoney;
        private Label lblAccountNumber;
        private PictureBox pbProfil;
        private ComboBox cb_menu;
    }
}
