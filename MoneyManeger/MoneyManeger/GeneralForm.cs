using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger {
    public partial class GeneralForm : Form {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        public GeneralForm() {
            InitializeComponent();
        }

        /* FORM FUNCTIONS ** FORM FUNCTIONS ** FORM FUNCTIONS ** FORM FUNCTIONS ** FORM FUNCTIONS */
        private void GeneralForm_Load(object sender, EventArgs e) {

            // Initial tab choose
            tabDashboard_Click(null, null);
        }

        /* TOP ** TOP ** TOP ** TOP ** TOP ** TOP ** TOP ** TOP ** TOP ** TOP ** TOP ** TOP ** TOP */

        private void moveWindow_MouseDown(object sender, MouseEventArgs e) {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        // WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON
        private void buttonClose_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void buttonRestore_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Normal;
            buttonRestore.Visible = false;
            buttonMaximize.Visible = true;
        }

        private void buttonMaximize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Maximized;
            buttonMaximize.Visible = false;
            buttonRestore.Visible = true;
        }

        private void buttonMinimize_Click(object sender, EventArgs e) {
            this.WindowState = FormWindowState.Minimized;
        }

        /*  *   *   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   *   *   */

        //  CHOOSE TAB ** CHOOSE TAB ** CHOOSE TAB ** CHOOSE TAB ** CHOOSE TAB ** CHOOSE TAB ** CHOOSE TAB ** CHOOSE TAB ** CHOOSE TAB
        private void tabDashboard_Click(object sender, EventArgs e) {
            TabDefaultState();
            dashboardUserControl.Visible = true;
            labelTabTitle.Text = dashboardUserControl.Title;
            tabDashboard.BackColor = tabDashboard.FlatAppearance.CheckedBackColor;
        }
        private void tabExpenses_Click(object sender, EventArgs e) {
            TabDefaultState();
            expensesUserControl.Visible = true;
            labelTabTitle.Text = expensesUserControl.Title;
            tabExpenses.BackColor = tabExpenses.FlatAppearance.CheckedBackColor;
        }
        private void tabMonthlyFee_Click(object sender, EventArgs e) {
            TabDefaultState();
            monthlyFeeUserControl.Visible = true;
            labelTabTitle.Text = monthlyFeeUserControl.Title;
            tabMonthlyFee.BackColor = tabMonthlyFee.FlatAppearance.CheckedBackColor;
        }

        private void TabDefaultState() {
            dashboardUserControl.Visible = false;
            expensesUserControl.Visible = false;
            monthlyFeeUserControl.Visible = false;

            tabDashboard.BackColor = panelTabs.BackColor;
            tabExpenses.BackColor = panelTabs.BackColor;
            tabMonthlyFee.BackColor = panelTabs.BackColor;
        }

        //  MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU

        // MANAGE -> INSERIR || MANAGE -> INSERIR || MANAGE -> INSERIR || MANAGE -> INSERIR
        private void Menu_Manage_Insert_Expense_Click(object sender, EventArgs e) {
            new EditExpenseForm().ShowDialog();
        }

        private void Menu_Manage_Insert_MonthlyFee_Click(object sender, EventArgs e) {
            new EditMonthlyFeeForm().ShowDialog();
        }

        private void Menu_Manage_Insert_Reserva_Click(object sender, EventArgs e) {

        }

        private void Menu_Manage_Insert_Income_Click(object sender, EventArgs e) {
            new EditIncomeForm().ShowDialog();
            /*new DataBase.IncomesDB().Insert(
                new Models.Income("Salário", 1080, DateTime.Now)
            );*/
        }
    }
}
