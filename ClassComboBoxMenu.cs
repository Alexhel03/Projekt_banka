using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBankaHelisek
{
    public class ClassComboBoxMenu
    {
        private Form currentForm;

        public ClassComboBoxMenu(Form currentForm)
        {
            this.currentForm = currentForm;
        }

        // Naplní ComboBox výchozími položkami.
        public void PopulateComboBox(ComboBox comboBox)
        {
            comboBox.Items.Clear();
            comboBox.Items.AddRange(new string[]
            {
                "Přehled", "Půjčky", "MojePůjčky"
            });          
        }

        // Zpracuje výběr z ComboBoxu a přepne na odpovídající formulář.
        public void HandleComboBoxSelection(ComboBox comboBox)
        {

            string selectedItem = comboBox.SelectedItem.ToString();
            Form newForm = null;

            switch (selectedItem)
            {
                case "Přehled":
                    newForm = new FormBankaHome();
                    break;
                case "Půjčky":
                    newForm = new FormLoan();
                    break;             
                case "MojePůjčky":
                    newForm = new FormMyLoans();
                    break;
                default:
                    MessageBox.Show("Neznámá položka: " + selectedItem);
                    return;
            }

            if (newForm != null)
            {
                OpenForm(newForm);
            }
        }

        // Otevře nový formulář na stejné pozici jako aktuální formulář.
        private void OpenForm(Form newForm)
        {
            newForm.StartPosition = FormStartPosition.Manual;
            newForm.Location = currentForm.Location;

            currentForm.Hide();
            newForm.ShowDialog();
            currentForm.Close();
        }

    }
}
