namespace ProjektBankaHelisek
{
    partial class FormLoan
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
            cb_menu = new ComboBox();
            pbProfil = new PictureBox();
            groupBox2 = new GroupBox();
            lbl_year = new Label();
            lbl_month = new Label();
            btn_view = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            chbAgree = new CheckBox();
            label1 = new Label();
            tb_month = new TextBox();
            tb_loan = new TextBox();
            btnAddLoan = new Button();
            ((System.ComponentModel.ISupportInitialize)pbProfil).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cb_menu
            // 
            cb_menu.FormattingEnabled = true;
            cb_menu.Location = new Point(21, 58);
            cb_menu.Name = "cb_menu";
            cb_menu.Size = new Size(146, 23);
            cb_menu.TabIndex = 17;
            cb_menu.Text = "Půjčky";
            cb_menu.SelectedIndexChanged += cb_menu_SelectedIndexChanged;
            // 
            // pbProfil
            // 
            pbProfil.Location = new Point(311, 12);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(40, 40);
            pbProfil.SizeMode = PictureBoxSizeMode.Zoom;
            pbProfil.TabIndex = 15;
            pbProfil.TabStop = false;
            pbProfil.Click += pbProfil_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(lbl_year);
            groupBox2.Controls.Add(lbl_month);
            groupBox2.Controls.Add(btn_view);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(chbAgree);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(tb_month);
            groupBox2.Controls.Add(tb_loan);
            groupBox2.Location = new Point(21, 90);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 317);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Půjčka";
            // 
            // lbl_year
            // 
            lbl_year.AutoSize = true;
            lbl_year.Location = new Point(170, 214);
            lbl_year.Name = "lbl_year";
            lbl_year.Size = new Size(123, 15);
            lbl_year.TabIndex = 20;
            lbl_year.Text = "Výšše měsíční splátky:";
            // 
            // lbl_month
            // 
            lbl_month.AutoSize = true;
            lbl_month.Location = new Point(170, 169);
            lbl_month.Name = "lbl_month";
            lbl_month.Size = new Size(123, 15);
            lbl_month.TabIndex = 19;
            lbl_month.Text = "Výšše měsíční splátky:";
            // 
            // btn_view
            // 
            btn_view.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 238);
            btn_view.Location = new Point(193, 139);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(100, 23);
            btn_view.TabIndex = 18;
            btn_view.Text = "Zobrazit";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 253);
            label5.Name = "label5";
            label5.Size = new Size(134, 15);
            label5.TabIndex = 7;
            label5.Text = "Datum poslední splátky:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 214);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 6;
            label4.Text = "Výšše roční splátky:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 169);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 5;
            label3.Text = "Výšše měsíční splátky:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 95);
            label2.Name = "label2";
            label2.Size = new Size(136, 30);
            label2.TabIndex = 4;
            label2.Text = "kolika procentní splátku \r\nsi představujete?";
            // 
            // chbAgree
            // 
            chbAgree.AutoSize = true;
            chbAgree.Location = new Point(74, 282);
            chbAgree.Name = "chbAgree";
            chbAgree.Size = new Size(146, 19);
            chbAgree.TabIndex = 3;
            chbAgree.Text = "Souhlas s podmínkami";
            chbAgree.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 44);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 2;
            label1.Text = "Kolik si chcete půjčit?";
            // 
            // tb_month
            // 
            tb_month.Location = new Point(193, 95);
            tb_month.Name = "tb_month";
            tb_month.Size = new Size(100, 23);
            tb_month.TabIndex = 1;
            // 
            // tb_loan
            // 
            tb_loan.Location = new Point(193, 41);
            tb_loan.Name = "tb_loan";
            tb_loan.Size = new Size(100, 23);
            tb_loan.TabIndex = 0;
            // 
            // btnAddLoan
            // 
            btnAddLoan.Location = new Point(21, 433);
            btnAddLoan.Name = "btnAddLoan";
            btnAddLoan.Size = new Size(316, 68);
            btnAddLoan.TabIndex = 12;
            btnAddLoan.Text = "Pujčit";
            btnAddLoan.UseVisualStyleBackColor = true;
            btnAddLoan.Click += btnAddLoan_Click;
            // 
            // FormLoan
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 521);
            Controls.Add(cb_menu);
            Controls.Add(pbProfil);
            Controls.Add(groupBox2);
            Controls.Add(btnAddLoan);
            Name = "FormLoan";
            Text = "FormLoan";
            ((System.ComponentModel.ISupportInitialize)pbProfil).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cb_menu;
        private PictureBox pbProfil;
        private GroupBox groupBox2;
        private Button btnAddLoan;
        private CheckBox chbAgree;
        private Label label1;
        private TextBox tb_month;
        private TextBox tb_loan;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_view;
        private Label lbl_year;
        private Label lbl_month;
    }
}