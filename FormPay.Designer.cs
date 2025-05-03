namespace ProjektBankaHelisek
{
    partial class FormPay
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
            txbAccount = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txbMoney = new TextBox();
            btnCancel = new Button();
            btnPay = new Button();
            SuspendLayout();
            // 
            // txbAccount
            // 
            txbAccount.Location = new Point(265, 6);
            txbAccount.Name = "txbAccount";
            txbAccount.Size = new Size(99, 23);
            txbAccount.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(250, 15);
            label1.TabIndex = 1;
            label1.Text = "Zadjete číslo účtu, komu chcete poslat peníze:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(145, 15);
            label2.TabIndex = 2;
            label2.Text = "Kolik korun chcete poslat?";
            // 
            // txbMoney
            // 
            txbMoney.Location = new Point(265, 33);
            txbMoney.Name = "txbMoney";
            txbMoney.Size = new Size(99, 23);
            txbMoney.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(12, 67);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Zrušit";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPay
            // 
            btnPay.Location = new Point(289, 67);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(75, 23);
            btnPay.TabIndex = 5;
            btnPay.Text = "Potvrdit";
            btnPay.UseVisualStyleBackColor = true;
            btnPay.Click += btnPay_Click;
            // 
            // FormPay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 97);
            Controls.Add(btnPay);
            Controls.Add(btnCancel);
            Controls.Add(txbMoney);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txbAccount);
            Name = "FormPay";
            Text = "FormPay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txbAccount;
        private Label label1;
        private Label label2;
        private TextBox txbMoney;
        private Button btnCancel;
        private Button btnPay;
    }
}