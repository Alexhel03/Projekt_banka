using System.Runtime.InteropServices;
using static System.Windows.Forms.AxHost;

namespace ProjektBankaHelisek
{
    public partial class FormBankaHome : Form
    {
        private ClassComboBoxMenu ClassComboBoxMenu;  // Instance pro správu ComboBox menu
        private ClassToProfile ClassToProfile; // Instance pro manipulaci s profilem uživatele
        private ClassMoneyManager moneyManager = new ClassMoneyManager(); // Instance pro správu financí

        // Konstruktor pro inicializaci formuláøe
        public FormBankaHome()
        {
            InitializeComponent();
            ClassComboBoxMenu = new ClassComboBoxMenu(this);
            ClassComboBoxMenu.PopulateComboBox(cb_menu); // Naplnìní ComboBox menu daty
            ClassToProfile = new ClassToProfile(this);
            ClassToProfile.FillPictureProfile(pbProfil);  // Nastavení profilového obrázku
        }

        // Event handler pro zmìnu výbìru v ComboBoxu
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassComboBoxMenu.HandleComboBoxSelection(cb_menu);

        }

        // Event handler pro kliknutí na PictureBox (otevøení profilu)
        private void pbProfil_Click(object sender, EventArgs e)
        {
            ClassToProfile.OpenProfile();
        }

        // Naètení údajù pøi naètení formuláøe
        private void FormBankaHome_Load(object sender, EventArgs e)
        {
            string username = CurrentSession.Username; // Aktuální uživatel
            decimal totalAmount = moneyManager.GetTotalLoanAmountByUser(username); // Získání celkové èástky pùjèek

            var user = new ClassUserManager().GetUserByUsername(username);

            lblAccountNumber.Text = $"Èíslo úètu: {user.AccountNumber}";
            lblMoney.Text = $"Celková èástka na úètì: {user.AccountBalance} Kè";

        }

        // Event handler pro otevøení formuláøe k provedení platby
        private void btnPay_Click(object sender, EventArgs e)
        {
            FormPay formPay = new FormPay();
            formPay.StartPosition = FormStartPosition.Manual;
            formPay.Location = new Point(this.Location.X,this.Location.Y+300);
            formPay.ShowDialog();
        }
    }
}
