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
    public partial class FormRegister : Form
    {
        private ClassUserManager userManager;
        private ClassToProfile ClassToProfile;

        public FormRegister()
        {
            InitializeComponent();
            userManager = new ClassUserManager();
            ClassToProfile = new ClassToProfile(this);
            ClassToProfile.FillPictureProfile(pbProfil);
        }

        // Event Handler pro registraci uživatele
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text == txbConfirmPassword.Text)
            {
                string username = txbName.Text.Trim();
                string password = txbPassword.Text.Trim();

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Zadejte uživatelské jméno a heslo.");
                    return;
                }

                if (userManager.RegisterUser(username, password))
                {
                    MessageBox.Show("Registrace byla úspěšná!");
                    FormLogIn logIn = new FormLogIn();
                    logIn.StartPosition = FormStartPosition.Manual;
                    logIn.Location = this.Location;
                    this.Hide();
                    logIn.ShowDialog();
                    this.Close(); // Zavření formuláře
                }
                else
                {
                    MessageBox.Show("Uživatelské jméno už existuje.");
                }
            }
            else
            {
                MessageBox.Show("Musíte vyplnít správně heslo.");
            }
        }

        // Event Handler pro registraci uživatele pro vracení se zpět do formuláře LogIn
        private void btn_back_Click(object sender, EventArgs e)
        {
            FormLogIn logIn = new FormLogIn();
            logIn.StartPosition = FormStartPosition.Manual;
            logIn.Location = this.Location;
            this.Hide();
            logIn.ShowDialog();
            this.Close(); // Zavření 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
