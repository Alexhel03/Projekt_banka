using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjektBankaHelisek
{
    public partial class FormLogIn : Form
    {
        public FormLogIn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        // Event handler pro zobrazení formuláře registrace
        private void lbl_registrace_Click(object sender, EventArgs e)
        {
            FormRegister registerForm = new FormRegister();
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = this.Location;
            this.Hide();
            registerForm.ShowDialog();
            this.Close();
        }

        // Event handler pro Přihlášení do aplikace
        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txbName.Text.Trim();
            string password = txbPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Zadejte uživatelské jméno a heslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ClassUserManager userManager = new ClassUserManager();

            if (userManager.AuthenticateUser(username, password))
            {
                // Přihlášení úspěšné
                Form newForm = new FormBankaHome();
                newForm.StartPosition = FormStartPosition.Manual;
                newForm.Location = this.Location;  
                this.Hide(); 
                newForm.ShowDialog();  
                this.Close();  
            }
            else
            {
                // Chybné přihlašovací údaje
                MessageBox.Show("Neplatné uživatelské jméno nebo heslo.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler pro zobrazení a zakrytí hesla
        private void btnSee_Click(object sender, EventArgs e)
        {
            if (txbPassword.PasswordChar == '*')
            {
                txbPassword.PasswordChar = '\0'; 
                btnSee.Text = "o"; 
            }
            else 
            {
                txbPassword.PasswordChar = '*'; 
                btnSee.Text = "-"; 
            }
        }
    }
}
