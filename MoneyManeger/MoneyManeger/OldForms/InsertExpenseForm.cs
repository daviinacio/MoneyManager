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
    public partial class InsertExpenseForm : Form {
        // DataSet
        private DataBase.ExpensesDB db = new DataBase.ExpensesDB();
        private Utils.MonthDate month = null;

        public InsertExpenseForm() { InitializeComponent(); }

        public InsertExpenseForm(Utils.MonthDate month) : this() {
            this.month = month;
        }

        private void InsertExpenseForm_Load(object sender, EventArgs e) {
            if(month != null && !month.Equals(Utils.MonthDate.Now))
                dateTimePicker_Date.Value = month.Date;
        }

        private void InsertExpenseForm_FormClosing(object sender, FormClosingEventArgs e) {
            
        }

        // TEXTBOX * TEXTBOX * TEXTBOX * TEXTBOX * TEXTBOX * TEXTBOX * TEXTBOX
        private void textBox_Count_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.Transform.TextBox_Double_KeyPress(sender as TextBox, e);
        }

        private void textBox_Price_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.Transform.TextBox_Money_KeyPress(sender as TextBox, e);
        }

        // BUTTONS * BUTTONS * BUTTONS * BUTTONS * BUTTONS * BUTTONS * BUTTONS
        private void button_Save_Click(object sender, EventArgs e) {
            try {
                Models.Expense item = new Models.Expense("");

                item.Description = textBox_Description.Text;
                item.Price = Double.Parse(textBox_Price.Text);
                item.Count = Double.Parse(textBox_Count.Text);
                item.Date = dateTimePicker_Date.Value;

                db.Insert(item);

                this.Close();

            } catch (System.FormatException ex) {
                MessageBox.Show(ex.Message, "Confira os dados inseridos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally { }
        }

        private void button_Cancel_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
