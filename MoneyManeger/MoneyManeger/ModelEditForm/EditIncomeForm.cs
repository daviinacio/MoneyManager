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
    public partial class EditIncomeForm : Form {

        // Variables
        private DataBase.IncomesDB db = new DataBase.IncomesDB();
        private DateTime currentDate = DateTime.Now;
        private Models.Income item = null;

        // Constructors
        public EditIncomeForm() {
            InitializeComponent();
        }

        public EditIncomeForm(DateTime date) : this() {
            this.currentDate = date;
        }

        public EditIncomeForm(Models.Income item) : this() {
            this.item = item;
        }

        // Form events
        private void EditIncomeForm_Load(object sender, EventArgs e) {
            // Set the delete button visibility
            buttonDelete.Visible = item != null;

            // Set form title
            labelTitle.Text = item == null ? "Nova receita" : "Editar receita";

            // Put item content to the elements
            if(this.item != null) {
                textboxDescription.Text = item.Description;
                textboxValue.Text = String.Format("{0:0.00}", item.Value);
                dpDate.Value = item.Date;

            } else
                dpDate.Value = currentDate;
        }
        
        // TextBox events
        private void textboxValue_KeyPress(object sender, KeyPressEventArgs e) {
            Utils.Transform.TextBox_Money_KeyPress(sender as MaskedTextBox, e);
        }

        // WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON ** WINDOW CONTROL BUTTON
        private void buttonClose_Click(object sender, EventArgs e) {
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e) {
            try {
                // Create the new Model, case don't exists
                if (item == null) item = new Models.Income();

                item.Description = textboxDescription.Text;
                item.Value = Double.Parse(textboxValue.Text);
                item.Date = dpDate.Value.Date;

                // Case if a new item
                if (item.Id == -1) db.Insert(item);

                // Case is a existent item
                else db.Update(item);

                // Close the edit form
                this.Close();

            } catch (System.FormatException ex) {
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

            } catch (FormatException ex) {
                MessageBox.Show(ex.Message, "Confira os dados inseridos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } finally { }
        }

        private void buttonCancel_Click(object sender, EventArgs e) { this.Close(); }
    }
}
