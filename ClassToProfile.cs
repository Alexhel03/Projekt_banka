using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektBankaHelisek
{
    public class ClassToProfile
    {
        private Form currentForm;

        // Konstruktor třídy, který inicializuje aktuální formulář
        public ClassToProfile(Form currentForm) 
        { 
            this.currentForm = currentForm;
        }

        // Nastaví obrázek profilu do PictureBoxu
        public void FillPictureProfile(PictureBox pictureBox)
        {
            pictureBox.Image = Properties.Resources.profil;
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
        }

        // Otevře formulář profilu aktuálního uživatele
        public void OpenProfile()
        {
            var myProfile = new FormMyProfile(CurrentSession.Username); // Vytvoření instance FormMyProfile s aktuálním uživatelským jménem
            myProfile.StartPosition = FormStartPosition.Manual;
            myProfile.Location = currentForm.Location;

            currentForm.Hide();
            myProfile.ShowDialog();
            currentForm.Close();
        }

    }
}
