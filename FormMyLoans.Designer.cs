namespace ProjektBankaHelisek
{
    partial class FormMyLoans
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
            listBoxLoans = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pbProfil).BeginInit();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cb_menu
            // 
            cb_menu.FormattingEnabled = true;
            cb_menu.Location = new Point(16, 62);
            cb_menu.Name = "cb_menu";
            cb_menu.Size = new Size(146, 23);
            cb_menu.TabIndex = 21;
            cb_menu.Text = "Moje Půjčky";
            cb_menu.SelectedIndexChanged += cb_menu_SelectedIndexChanged;
            // 
            // pbProfil
            // 
            pbProfil.Location = new Point(306, 16);
            pbProfil.Name = "pbProfil";
            pbProfil.Size = new Size(40, 40);
            pbProfil.TabIndex = 20;
            pbProfil.TabStop = false;
            pbProfil.Click += pbProfil_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listBoxLoans);
            groupBox2.Location = new Point(16, 94);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(316, 317);
            groupBox2.TabIndex = 19;
            groupBox2.TabStop = false;
            groupBox2.Text = "Moje půjčky";
            // 
            // listBoxLoans
            // 
            listBoxLoans.FormattingEnabled = true;
            listBoxLoans.ItemHeight = 15;
            listBoxLoans.Location = new Point(0, 70);
            listBoxLoans.Name = "listBoxLoans";
            listBoxLoans.Size = new Size(316, 94);
            listBoxLoans.TabIndex = 0;
            // 
            // FormMyLoans
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(363, 521);
            Controls.Add(cb_menu);
            Controls.Add(pbProfil);
            Controls.Add(groupBox2);
            Name = "FormMyLoans";
            Text = "FormMyLoans";
            Load += FormMyLoans_Load;
            ((System.ComponentModel.ISupportInitialize)pbProfil).EndInit();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cb_menu;
        private PictureBox pbProfil;
        private GroupBox groupBox2;
        private Label lbl_year;
        private Label lbl_month;
        private Button btn_view;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private CheckBox checkBox1;
        private Label label1;
        private TextBox tb_month;
        private TextBox tb_loan;
        private ListBox listBoxLoans;
    }
}