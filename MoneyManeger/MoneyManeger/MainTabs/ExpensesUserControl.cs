using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyManeger.Models;
using MoneyManeger.DataBase;
using MoneyManeger.Utils;

namespace MoneyManeger {
    public partial class ExpensesUserControl : UserControl {

        // TableData
        private MonthlyFeesDB monthlyFees = new MonthlyFeesDB();
        private ExpensesDB expenses = new ExpensesDB();
        private IncomesDB incomes = new IncomesDB();

        // Variables
        private bool resizing = false;

        public ExpensesUserControl() {
            InitializeComponent();
        }

        /*  *   *   *   FORM EVENTS *   FORM EVENTS *   FORM EVENTS *   FORM EVENTS *   *   *   */

        private void ExpensesUserControl_Load(object sender, EventArgs e) {
            listviewExpenses.BackColor = this.BackColor;
            listviewExpenses.ForeColor = Color.Black;
            listviewIncomes.BackColor = this.BackColor;

            monthPicker.Value = DateTime.Now;
        }

        private void ExpensesUserControl_SizeChanged(object sender, EventArgs e) {
            // Update the expenses listview columns width
            listView_SizeChanged(listviewExpenses, null);
            listView_SizeChanged(listviewIncomes, null);
        }

        /*  *   *   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   *   *   */

        //  LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW

        // Expenses listview
        private void listViewExpenses_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            e.DrawText();
        }

        private void listViewExpenses_DrawItem(object sender, DrawListViewItemEventArgs e) {
            e.DrawDefault = true;
        }

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

        private void listviewExpenses_SelectedIndexChanged(object sender, EventArgs e) {
            ListView listView = sender as ListView;

            //listView.SelectedItems[0]
        }

        private void listviewExpenses_DoubleClick(object sender, EventArgs e) {
            ListView listView = sender as ListView;

            // Find the selected item
            Expense item = expenses.SelectById(
                Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text));

            // Open the expense editor
            new EditExpenseForm(item).ShowDialog();

            // Update the content
            monthPicker.Value = monthPicker.Value;
        }

        // Year listview
        private void listviewIncomes_DoubleClick(object sender, EventArgs e) {
            ListView listView = sender as ListView;

            // Find the selected item
            Income item = incomes.SelectById(
                Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text));

            // Open the income editor
            new EditIncomeForm(item).ShowDialog();

            // Update the content
            monthPicker.Value = monthPicker.Value;
        }

        // MONTH PICKER ** MONTH PICKER ** MONTH PICKER ** MONTH PICKER ** MONTH PICKER ** MONTH PICKER
        private void monthPicker_MonthChanged(DateTime month) {
            //  CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT
            //double totalSpents = 0, totalMoneys = 0;
            double totalIncomes = 0, totalExpenses = 0, totalExpenseUnit = 0, totalExpensePrice = 0;


            // Clear expenses listview items
            listviewExpenses.Items.Clear();

            // MonthlyFee
            foreach (MonthlyFee item in monthlyFees.SelectByMonth(month)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());

                DateTime workingDay = MonthDate.GetWorkingDay(month, item.BusinessDay);

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(workingDay.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", 1));
                row.SubItems.Add(String.Format("R$ {0:N}", item.MonthlyValue));
                //row.SubItems.Add(String.Format("Pendente"));

                if (workingDay < DateTime.Now) {
                    row.SubItems.Add(String.Format("Atrazado"));
                    row.BackColor = Color.Red;
                }
                else if (true) {
                    row.SubItems.Add(String.Format("Pendente"));
                    row.BackColor = Color.Yellow;
                }
                else {
                    row.SubItems.Add(String.Format("Pago"));
                    row.BackColor = Color.Transparent;
                }

                row.ForeColor = Color.Black;


                listviewExpenses.Items.Add(row);
            }

            // Expenses
            foreach (Expense item in expenses.SelectByMonth(month)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", item.Count));
                row.SubItems.Add(String.Format("R$ {0:N}", item.Price));
                row.SubItems.Add(String.Format("R$ {0:N}", item.TotalPrice));

                row.ForeColor = Color.Black;

                listviewExpenses.Items.Add(row);

                totalExpenses++;
                totalExpensePrice += item.TotalPrice;
                totalExpenseUnit += item.Count;
            }

            // Moneys
            listviewIncomes.Items.Clear();

            foreach (Income item in incomes.SelectByMonth(month)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("R$ {0:N}", item.Value));

                listviewIncomes.Items.Add(row);

                totalIncomes += item.Value;
            }

            ExpensesUserControl_SizeChanged(null, null);

            valueTotalItens.Text = String.Format("{0:0.000}", totalExpenses);
            valueTotalPrice.Text = String.Format("R$ {0:N}", totalExpensePrice);
            valueTotalUnit.Text = String.Format("{0}", totalExpenseUnit);
        }

        // PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES
        public String Title {
            get { return "Despesas"; }
        }

        // Expense editor methods
        public void AddNewExpense() {
            // Open the expense editor
            new EditExpenseForm(monthPicker.Value).ShowDialog();

            // Update the content
            monthPicker.Value = monthPicker.Value;
        }

        public void AddNewIncome() {
            // Open the income editor
            new EditIncomeForm(
                Utils.MonthDate.GetWorkingDay(
                    monthPicker.Value, 5
                )).ShowDialog();

            // Update the content
            monthPicker.Value = monthPicker.Value;
        }
    }
}
