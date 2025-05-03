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
    public partial class FormMyLoans : Form
    {
        private ClassComboBoxMenu ClassComboBoxMenu;
        private ClassToProfile ClassToProfile;
        private ClassMoneyManager moneyManager = new ClassMoneyManager();

        public FormMyLoans()
        {
            InitializeComponent();
            ClassComboBoxMenu = new ClassComboBoxMenu(this);
            ClassComboBoxMenu.PopulateComboBox(cb_menu);
            ClassToProfile = new ClassToProfile(this);
            ClassToProfile.FillPictureProfile(pbProfil);
        }

        // Načtení uložený půjčky v JSON souboru
        private void FormMyLoans_Load(object sender, EventArgs e)
        {
            string username = CurrentSession.Username; // Aktuální uživatel
            var loans = moneyManager.GetLoansByUser(username);

            foreach (var loan in loans)
            {
                listBoxLoans.Items.Add($"Částka: {loan.Amount}, Datum: {loan.LoanDate}, Úrok: {loan.InterestRate}%");
            }
        }

        private void cb_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassComboBoxMenu.HandleComboBoxSelection(cb_menu);
        }

        private void pbProfil_Click(object sender, EventArgs e)
        {
            ClassToProfile.OpenProfile();
        }
    }
}
