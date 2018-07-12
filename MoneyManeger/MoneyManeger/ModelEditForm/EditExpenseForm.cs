using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger.ModelEditForm {
    public partial class EditExpenseForm : Form {
        // Variables
        private DataBase.ExpensesDB db = new DataBase.ExpensesDB();
        private DateTime currentDate = DateTime.Today;
        private Models.Expense item = null;

        // Contructors
        public EditExpenseForm() {
            InitializeComponent();
        }
        public EditExpenseForm(DateTime date) : this() {
            this.currentDate = date;
        }
        public EditExpenseForm(Models.Expense item) : this() {
            this.item = item;
        }

        // Form Events
        private void EditExpenseForm_Load(object sender, EventArgs e) {
            // Set the date to the DatePicker
            if (currentDate != null) dpDate.Value = currentDate;

            // Set initial values of item
            if (item != null) {
                tbDescription.Text = item.Description;
                tbPrice.Text = item.Price.ToString();
                tbCount.Text = item.Count.ToString();
                dpDate.Value = item.Date;

            }

            // Set the form title
            labelTitle.Text = item == null ? "Nova despesa" : "Editar despesa";

            // Set delete button visibility
            buttonDelete.Visible = item != null;
        }

        // WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON
        private void buttonSave_Click(object sender, EventArgs e) {
            try {
                // Create the new Model, case don't exists
                if (item == null) item = new Models.Expense();

                item.Description = tbDescription.Text;
                item.Price = Double.Parse(tbPrice.Text);
                item.Count = Double.Parse(tbCount.Text);
                item.Date = dpDate.Value.Date;

                // Case if a new item
                if (item.Id == -1)
                    db.Insert(item);

                // Case is a existent item
                else db.Update(item);

                // Close the edit form
                this.Close();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Confira os dados inseridos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Destroy the temp item
                if (item.Id == -1) item = null;

            } finally { }
        }

        private void buttonDelete_Click(object sender, EventArgs e) {
            try {
                if (MessageBox.Show("Este item será deletado permanentemente.", "Deletar item",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) {
                    
                    db.Delete(item);

                    this.Close();
                }

            } catch (System.FormatException ex) {
                MessageBox.Show(ex.Message, "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally { }
        }

        private void buttonCancel_Click(object sender, EventArgs e) { Close(); }

        private void tbPrice_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.Transform.TextBox_Money_KeyPress(sender as MaskedTextBox, e);
        }

        private void tbCount_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.Transform.TextBox_Weight_KeyPress(sender as MaskedTextBox, e);
        }
    }
}
