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
using MoneyManeger.ModelEditForm;

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

            if (listView.SelectedItems[0].SubItems[5].Text.Contains("R$")) {
                // Find the selected item
                Expense item = expenses.SelectById(
                    Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text));

                // Open the expense editor
                new EditExpenseForm(item).ShowDialog();
            } else {
                // Find the selected item
                MonthlyFee item = monthlyFees.SelectById(
                    Convert.ToInt32(listView.SelectedItems[0].SubItems[0].Text));

                // Open the expense editor
                new EditMonthlyFeeExpenseForm(monthPicker.Value, item).ShowDialog();
                //new EditMonthlyFeeForm(item).ShowDialog();
            }

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
                Expense eItem = item.Expense(month);

                ListViewItem row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date(month).ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", 1));
                row.SubItems.Add(String.Format("R$ {0:N}", eItem != null ? eItem.TotalPrice : item.MonthlyValue));
                //row.SubItems.Add(String.Format("Pendente"));

                row.ForeColor = Color.Black;

                if (eItem != null) {
                    //row.SubItems.Add("Pago", Color.Lime, row.BackColor, new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte) (0))));
                    //row.ForeColor = Color.Lime;

                    row.SubItems.Add("Pago");

                    //row.BackColor = Color.Lime;
                    //row.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Strikeout, System.Drawing.GraphicsUnit.Point, ((byte) (0)));

                    totalExpenses++;
                    totalExpensePrice += eItem.TotalPrice;
                    totalExpenseUnit ++;
                }
                else if (item.Date(month) < DateTime.Now) {
                    row.SubItems.Add("Atrazado");
                    row.BackColor = Color.Red;


                    //row.SubItems.Add("Atrazado", Color.Red, row.BackColor, new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte) (0))));
                    //row.SubItems.Add(String.Format("Atrazado"));
                    //row.ForeColor = Color.Red;
                }
                else {
                    row.SubItems.Add("Pendente");
                    //row.BackColor = Color.Orange;


                    //row.SubItems.Add("Pendente", Color.Yellow, row.BackColor, new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, ((byte) (0))));
                    //row.SubItems.Add(String.Format("Pendente"));
                    //row.ForeColor = Color.Yellow;
                }

                listviewExpenses.Items.Add(row);
            }

            // Expenses
            foreach (Expense item in expenses.SelectCommonByMonth(month)) {

                ListViewItem row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", item.Count));
                row.SubItems.Add(String.Format("R$ {0:N}", item.Price));
                row.SubItems.Add(String.Format("R$ {0:N}", item.TotalPrice));

                row.ForeColor = Color.Black;

                totalExpenses++;
                totalExpensePrice += item.TotalPrice;
                totalExpenseUnit += item.Count;

                listviewExpenses.Items.Add(row);
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
            valueRemaining.Text = String.Format("R$ {0:N}", totalIncomes - totalExpensePrice);
            valueTotalIncomes.Text = String.Format("R$ {0:N}", totalIncomes);
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
