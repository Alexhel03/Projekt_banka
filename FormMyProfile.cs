using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ProjektBankaHelisek
{
    public partial class FormMyProfile : Form
    {

        private ClassUserManager userManager = new ClassUserManager();
        private string currentUsername;


        public FormMyProfile(string username)
        {
            InitializeComponent();
            currentUsername = username;
            ShowUserProfile(username); // Zobrazení údajů o uživateli
        }

        // Event handler pro změnu hesla
        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            try
            {
                // Ověření, zda se hesla shodují a nejsou prázdná
                if (txbPassWord.Text == txbPassWord2.Text && txbPassWord.Text != null)
                {
                    userManager.UpdatePassword(txbPassWord.Text); // Aktualizace hesla
                }
                else 
                {
                    MessageBox.Show("Nelze změnit heslo!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nastal Chyba!", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Event handler pro změnu uživatelského jména
        private void btnChangeName_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbName.Text))
            {
                MessageBox.Show("Nové uživatelské jméno nemůže být prázdné.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool success = userManager.UpdateName(CurrentSession.Username, txbName.Text);

            if (success)
            {
                MessageBox.Show("Uživatelské jméno bylo úspěšně změněno.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CurrentSession.Username = txbName.Text; // Aktualizace CurrentSession
            }
            else
            {
                MessageBox.Show("Změna jména se nezdařila. Možná uživatelské jméno již existuje.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form newForm = new FormBankaHome();
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = this.Location;  // Nastavení pozice nového formuláře
            this.Hide();  // Skryjeme aktuální formulář
            newForm.ShowDialog();  // Otevřeme nový formulář jako modální
            this.Close();  // Zavřeme aktuální formulář
        }

        // Metoda pro zobrazení údajů o uživateli v profilu
        public void ShowUserProfile(string username)
        {
            var user = userManager.GetUserByUsername(username);
            txbName.Text = user.Username;
        }

    }
}
