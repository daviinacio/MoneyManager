using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger {
    public partial class EditMonthlyFeeForm : Form {

        // Variables
        private DataBase.MonthlyFeesDB db = new DataBase.MonthlyFeesDB();
        private DataBase.ExpensesDB dbExpenses = new DataBase.ExpensesDB();
        private DateTime currentDate = DateTime.Now;
        private Models.MonthlyFee item = new Models.MonthlyFee();

        // Constructors
        public EditMonthlyFeeForm() {
            InitializeComponent();
        }
        public EditMonthlyFeeForm(DateTime date): this() {
            this.currentDate = date;
        }
        public EditMonthlyFeeForm(Models.MonthlyFee item) : this() {
            this.item = item;
        }

        // Form events
        private void EditMonthlyFeeForm_Load(object sender, EventArgs e) {
            buttonDelete.Visible = item.Id != -1;

            mpInit.Value = DateTime.Now;
            cbDayType.SelectedIndex = (int) Models.MonthlyFee.eDayType.WorkingDays;


            if(this.item.Id != -1) {
                textboxDescription.Text = item.Description;
                textboxValue.Text = item.MonthlyValue.ToString();
                mpInit.Value = item.MonthStart;
                mpEnd.Value = item.MonthEnd;
                cbDayType.SelectedIndex = (int) item.DayType;
                textboxDay.Text = item.Day.ToString();
                valueStatus.Text = "Teste";

            } else {
                valueStatus.Text = "Inexistente";
            }
        }


        // Text box events
        private void textboxValue_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.Transform.TextBox_Money_KeyPress(sender as MaskedTextBox, e);
        }
        private void textboxWorkingDay_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.Transform.TextBox_Integer_KeyPress(sender as TextBox, e);
        }
        private void textboxWorkingDay_KeyUp(object sender, KeyEventArgs e) {
            Utils.Transform.TextBox_Integer_Limited_KeyUp(sender as TextBox, e, 1, 30);
        }

        // WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            try {

                item.Description = textboxDescription.Text;
                item.MonthlyValue = Convert.ToDouble(textboxValue.Text);
                item.MonthStart = mpInit.Value.Date;
                item.MonthEnd = mpEnd.Value.Date;
                item.DayType = (Models.MonthlyFee.eDayType) cbDayType.SelectedIndex;
                item.Day = Convert.ToInt32(textboxDay.Text);

                // Case if a new item
                if (item.Id == -1) db.Insert(item);

                // Case is a existent item
                else db.Update(item);

                // Close the edit form
                this.Close();

            } catch (System.FormatException ex) {
                MessageBox.Show(ex.Message, "Confira os dados inseridos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally { }
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            try {
                if (MessageBox.Show("Este item será deletado permanentemente.", "Deletar item",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {

                    if(item.Id != -1)
                        db.Delete(item);

                    this.Close();
                }

            } catch (System.FormatException ex) {
                MessageBox.Show(ex.Message, "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally { }
        }
    }
}
