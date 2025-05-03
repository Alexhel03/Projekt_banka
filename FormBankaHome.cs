using System.Runtime.InteropServices;
using static System.Windows.Forms.AxHost;

namespace ProjektBankaHelisek
{
    public partial class FormBankaHome : Form
    {
        private ClassComboBoxMenu ClassComboBoxMenu;  // Instance pro spr�vu ComboBox menu
        private ClassToProfile ClassToProfile; // Instance pro manipulaci s profilem u�ivatele
        private ClassMoneyManager moneyManager = new ClassMoneyManager(); // Instance pro spr�vu financ�

        // Konstruktor pro inicializaci formul��e
        public FormBankaHome()
        {
            InitializeComponent();
            ClassComboBoxMenu = new ClassComboBoxMenu(this);
            ClassComboBoxMenu.PopulateComboBox(cb_menu); // Napln�n� ComboBox menu daty
            ClassToProfile = new ClassToProfile(this);
            ClassToProfile.FillPictureProfile(pbProfil);  // Nastaven� profilov�ho obr�zku
        }

        // Event handler pro zm�nu v�b�ru v ComboBoxu
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassComboBoxMenu.HandleComboBoxSelection(cb_menu);

        }

        // Event handler pro kliknut� na PictureBox (otev�en� profilu)
        private void pbProfil_Click(object sender, EventArgs e)
        {
            ClassToProfile.OpenProfile();
        }

        // Na�ten� �daj� p�i na�ten� formul��e
        private void FormBankaHome_Load(object sender, EventArgs e)
        {
            string username = CurrentSession.Username; // Aktu�ln� u�ivatel
            decimal totalAmount = moneyManager.GetTotalLoanAmountByUser(username); // Z�sk�n� celkov� ��stky p�j�ek

            var user = new ClassUserManager().GetUserByUsername(username);

            lblAccountNumber.Text = $"��slo ��tu: {user.AccountNumber}";
            lblMoney.Text = $"Celkov� ��stka na ��t�: {user.AccountBalance} K�";

        }

        // Event handler pro otev�en� formul��e k proveden� platby
        private void btnPay_Click(object sender, EventArgs e)
        {
            FormPay formPay = new FormPay();
            formPay.StartPosition = FormStartPosition.Manual;
            formPay.Location = new Point(this.Location.X,this.Location.Y+300);
            formPay.ShowDialog();
        }
    }
}
