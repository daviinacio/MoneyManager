using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MoneyManeger.Utils;
using MoneyManeger.Models;
using MoneyManeger.DataBase;

namespace MoneyManeger {
    public partial class MainForm : Form {

        // TableData
        private MonthlyFeesDB monthlyFees = new MonthlyFeesDB();
        private ExpensesDB expenses = new ExpensesDB();
        private IncomesDB moneys = new IncomesDB();

        // Variables
        private MonthDate currentMonth = MonthDate.Now;
        private bool resizing = false;

        public MainForm() {
            InitializeComponent();
        }

        /*  *   *   *   FORM EVENTS *   FORM EVENTS *   FORM EVENTS *   FORM EVENTS *   *   *   */

        private void MainForm_Load(object sender, EventArgs e) {
            RefreshVisualContent();

            // DEBUG
            //foreach(Expense ex in expenses.Select("1 = 1"))
            //    MessageBox.Show(ex.ToString());

            //foreach (Money ex in moneys.Select("1 = 1"))
            //    MessageBox.Show(ex.ToString());

            //MessageBox.Show(expenses.Count.ToString());
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e) {
            listView_SizeChanged(expenses_listView, null);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            if (WindowState.Equals(FormWindowState.Maximized))
                listView_SizeChanged(expenses_listView, null);
        }

        /*  *   *   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   *   *   */

        //  MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU ** MENU

        // MANAGE -> INSERIR || MANAGE -> INSERIR || MANAGE -> INSERIR || MANAGE -> INSERIR
        private void Menu_Manage_Insert_Expense_Click(object sender, EventArgs e) {
            InsertExpenseForm form = new InsertExpenseForm(this.currentMonth);

            form.ShowDialog();
            RefreshVisualContent();
        }

        private void Menu_Manage_Insert_MonthlyFee_Click(object sender, EventArgs e) {

        }

        private void Menu_Manage_Insert_Reserva_Click(object sender, EventArgs e) {

        }

        private void Menu_Manage_Insert_Money_Click(object sender, EventArgs e) {

        }


        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            //currentMonth.AddMonth(1);
            //RefreshVisualContent();
            //MessageBox.Show(currentMonth.ToString());
            // AUTO_INCREMENT IDENTITY(1,1)

            //MessageBox.Show(moneys.Insert(new Money("Salário", 1000)).ToString());

            /*for(int i = 0; i < 10; i++)
                expenses.Insert(new Expense("Despesa " + i, 4, 10, currentMonth.Date));

            for (int i = 0; i < 2; i++)
                moneys.Insert(new Money("Dinheiro " + i, 1000, currentMonth.Date));

            expenses.Insert(new Expense("Batata", 5, 2));

            try {
                Expense exp = expenses.SelectById(5);

                MessageBox.Show(exp.ToString());

                exp.Description = "Tesdfçgkmlsdçgskdlkglkdsfgte2";

                expenses.Update(exp);
            } catch (Exceptions.RowNotFoundException ex) {
                MessageBox.Show(ex.Message, "RowNotFoundException");
            }*/

            RefreshVisualContent();

            //MessageBox.Show(expenses.Insert(new Expense(0, "Teste")).ToString());
            //for(int i = 3; i < 11; i++)
            //    expenses.Delete(i);

        }


        //  LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW
        private void listView_SizeChanged(object sender, EventArgs e) {
            if (!resizing || e == null) {
                if (e != null) resizing = true;

                ListView listview = sender as ListView;

                if (listview != null) {
                    float totalColumnWidth = 0;
                    float totalColumnFixedWidth = 1;


                    for (int i = 0; i < listview.Columns.Count; i++) {
                        Int32 tag = Convert.ToInt32(listview.Columns[i].Tag);
                        if (tag >= 0)
                            totalColumnWidth += tag;
                        else if (tag == -1)
                            totalColumnFixedWidth += listview.Columns[i].Width;
                    }

                    for (int i = 0; i < listview.Columns.Count; i++) {
                        Int32 tag = Convert.ToInt32(listview.Columns[i].Tag);
                        float colPercentage = (tag / totalColumnWidth);
                        int width = (int) (colPercentage * (listview.ClientRectangle.Width - totalColumnFixedWidth));
                        if (tag >= 0)
                            listview.Columns[i].Width = width;
                    }
                }
            }
        }

        private void month_listView_SelectedIndexChanged(object sender, EventArgs e) {
            ListView listView = sender as ListView;
            if (listView.SelectedIndices.Count <= 0) { return; }
            int item = listView.SelectedIndices[0];

            // Set the current month
            currentMonth.Month = item + 1;
            RefreshVisualContent();
        }
        private void date_year_button_Click(object sender, EventArgs e) {
            try {
                // Increment and decrement the current year
                switch ((sender as Button).Text) {
                    case ">": currentMonth.Year++; break;
                    case "<": currentMonth.Year--; break;
                }

            } catch(ArgumentOutOfRangeException) {
                MessageBox.Show("Você chegou na borda\nApenas values entre 1 e 9999", "Fora do limite");
            }

            RefreshVisualContent();
        }

        private void expenses_listView_SelectedIndexChanged(object sender, EventArgs e) {
            ListView listView = sender as ListView;

            double selectedTotalValue = 0, selectedTotalCount = 0;

            for (int i = 0; i < listView.SelectedItems.Count; i++) {
                selectedTotalValue += double.Parse(listView.SelectedItems[i].SubItems[5].Text.Replace("R$ ", ""));
                selectedTotalCount += double.Parse(listView.SelectedItems[i].SubItems[3].Text);
            }

            center_tableLayoutPanel.RowStyles[1].Height = (listView.SelectedItems.Count > 0 ? 30F : 0);

            total_text_value.Text = String.Format("Total: R$ {0:N}", selectedTotalValue);

            selected_itens_status_label.Text = String.Format("{0} ite{1} selecionado{2}, {3} unidad{4}",
                listView.SelectedItems.Count, (listView.SelectedItems.Count == 1 ? "m" : "ns"),
                (listView.SelectedItems.Count == 1 ? "" : "s"), selectedTotalCount, 
                (selectedTotalCount == 1 ? "e" : "es"));
        }

        /*  *   *   *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   *   *   */
        private void RefreshVisualContent() {
            center_tableLayoutPanel.RowStyles[1].Height = 0;
            selected_itens_status_label.Text = "0 itens";

            // Month refresh
            month_listView.Items.Clear();

            for (int i = 0; i < Properties.Settings.Default.months_abr_pt_br.Count; i++) {
                ListViewItem item = new ListViewItem(Properties.Settings.Default.months_abr_pt_br[i]);
                item.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));

                if (i == currentMonth.Month - 1) {
                    item.BackColor = Color.Gray;
                    item.ForeColor = Color.White;
                } else
                if (i == DateTime.Today.Month - 1 && DateTime.Today.Year == currentMonth.Year)
                    item.BackColor = Color.LightGray;

                month_listView.Items.Add(item);
            }

            // Year refresh
            date_year_label.Text = currentMonth.Year.ToString();

            /* CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT */
            double totalSpents = 0, totalMoneys = 0;
            
            // Expenses
            expenses_listView.Items.Clear();

            foreach (Expense item in expenses.SelectByMonth(currentMonth.Date)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());
                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", item.Count));
                row.SubItems.Add(String.Format("R$ {0:N}", item.Price));
                row.SubItems.Add(String.Format("R$ {0:N}", item.TotalPrice));

                expenses_listView.Items.Add(row);

                totalSpents += item.TotalPrice;
            }

            // Moneys
            moneys_listView.Items.Clear();

            foreach (Income item in moneys.SelectByMonth(currentMonth.Date)) {
                ListViewItem row = new ListViewItem(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("R$ {0:N}", item.Value));

                moneys_listView.Items.Add(row);

                totalMoneys += item.Value;
            }

            // Refresh on form
            all_spents_value.Text = String.Format("R$ {0:N}", totalSpents);
            all_money_value.Text = String.Format("R$ {0:N}", totalMoneys);
            remaining_money_value.Text = String.Format("R$ {0:N}", totalMoneys - totalSpents);

            // Update the expenses listview columns width
            listView_SizeChanged(expenses_listView, null);
        }
    }
}
