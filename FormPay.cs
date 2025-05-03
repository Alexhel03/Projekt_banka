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
    public partial class FormPay : Form
    {
        public FormPay()
        {
            InitializeComponent();
        }

        // Event handler pro potvrzení platby
        private void btnPay_Click(object sender, EventArgs e)
        {
            var userManager = new ClassUserManager();

            // Načtení všech uživatelů
            var allUsers = userManager.GetAllUsers();

            // Najít odesílatele podle aktuálního uživatele
            var senderUser = allUsers.FirstOrDefault(u => u.Username == CurrentSession.Username);
            if (senderUser == null)
            {
                MessageBox.Show("Chyba: Aktuální uživatel nebyl nalezen.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Najít příjemce podle čísla účtu
            var recipientAccountNumber = txbAccount.Text.Trim();
            var recipientUser = allUsers.FirstOrDefault(u => u.AccountNumber == recipientAccountNumber);

            if (recipientUser == null)
            {
                MessageBox.Show("Chyba: Příjemce s tímto číslem účtu nebyl nalezen.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Ověřit částku
            if (!decimal.TryParse(txbMoney.Text, out decimal amount) || amount <= 0)
            {
                MessageBox.Show("Zadejte platnou částku.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (senderUser.AccountBalance < amount)
            {
                MessageBox.Show("Nedostatečný zůstatek na účtu.", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Aktualizace zůstatků
            senderUser.AccountBalance -= amount;
            recipientUser.AccountBalance += amount;

            // Uložit změny zpět do JSON
            userManager.SaveUsers(allUsers);

            MessageBox.Show("Platba byla úspěšně provedena.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close(); // Zavřít formulář
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
