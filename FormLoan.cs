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
    public partial class FormLoan : Form
    {
        private ClassComboBoxMenu ClassComboBoxMenu;
        private ClassUserManager userManager = new ClassUserManager();
        private ClassToProfile ClassToProfile;
        private ClassMoneyManager moneyManager = new ClassMoneyManager();


        public FormLoan()
        {
            InitializeComponent();
            ClassComboBoxMenu = new ClassComboBoxMenu(this);
            ClassComboBoxMenu.PopulateComboBox(cb_menu);

            // Připojení výpočtů měsíční a roční splátky k odpovídajícím labelům
            ClassCalculations.VystupMonth = (vysledek) =>
            {
                lbl_month.Text = $"Měsíční splátka: {vysledek}";
            };
            ClassCalculations.VystupYear += (vysledek) =>
            {
                lbl_year.Text = $"Roční hodnota: {vysledek}";
            };

            ClassToProfile = new ClassToProfile(this);
            ClassToProfile.FillPictureProfile(pbProfil);
        }

        private void cb_menu_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassComboBoxMenu.HandleComboBoxSelection(cb_menu);
        }

        // Event handler pro zobrazení výpočtů měsíční a roční splátky
        private void btn_view_Click(object sender, EventArgs e)
        {
            try
            {

                double loan = Convert.ToDouble(tb_loan.Text);    // Výše půjčky
                double percent = Convert.ToDouble(tb_month.Text); // Procenta
                if (loan > 0 && percent > 0 && percent <= 100)
                {
                    ClassCalculations.Month(loan, percent);
                    ClassCalculations.Year(loan, percent);
                }
                else
                {
                    MessageBox.Show("Tuto půjčku nemůžeme zobrazit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nesprávný input (pište jen čísla).", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Event handler pro kliknutí na profilový obrázek
        private void pbProfil_Click(object sender, EventArgs e)
        {
            ClassToProfile.OpenProfile();
        }

        // Event handler pro kliknutí na profilový obrázek
        private void btnAddLoan_Click(object sender, EventArgs e)
        {            
            try
            {
                string username = CurrentSession.Username; // Aktuální uživatel
                decimal loanAmount = decimal.Parse(tb_loan.Text);
                decimal percent = decimal.Parse(tb_month.Text);
                DateTime loanDate = DateTime.Now;
                if (loanAmount > 0 && percent > 0 && percent <= 100 && chbAgree.Checked == true) 
                {
                    moneyManager.AddLoan(username, loanAmount, DateTime.Now, 5); // Přidání půjčky
                    moneyManager.AddLoanToAccountBalance(username, loanAmount);
                    MessageBox.Show("Půjčka byla úspěšně přidána!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MessageBox.Show("Peníze byly uspěŠně přidány na váš účet!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tuto půjčku nemůžeme schválit", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Musíte vyplnit vševšhny políčka :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
