using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyManeger.Models;

namespace MoneyManeger.ModelEditForm {
    public partial class EditMonthlyFeeExpenseForm : Form {
        // Variables
        private MonthlyFee monthlyFee = new MonthlyFee();
        private DateTime date = DateTime.Today;

        private DataBase.ExpensesDB eDb = new DataBase.ExpensesDB();

        // Constructors
        public EditMonthlyFeeExpenseForm(DateTime date, MonthlyFee monthlyFee) {
            InitializeComponent();

            // Initialize variables
            this.monthlyFee = monthlyFee;
            this.date = date;
        }

        // Form functions
        private void EditMonthlyFeeExpenseForm_Load(object sender, EventArgs e) {
            Expense expense = monthlyFee.Expense(date);

            if (expense != null) {
                tbDescription.Text = expense.Description;
                tbPrice.Text = expense.TotalPrice.ToString();
                dpDate.Value = expense.Date;
            }
        }

        // Button functions
        private void buttonClose_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            try {
                Expense item = monthlyFee.Expense(date);


                item.Price = Convert.ToDouble(tbPrice.Text);

                eDb.Update(item);

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

                    Expense item = monthlyFee.Expense(date);

                    if (item != null)
                        eDb.Delete(item);

                    this.Close();
                }

            } catch (System.FormatException ex) {
                MessageBox.Show(ex.Message, "Erro ao deletar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally { }
        }
    }
}
