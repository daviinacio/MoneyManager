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
            //listviewExpenses.ForeColor = this.ForeColor;
            listviewIncomes.BackColor = this.BackColor;

            // listvewExpenses.DrawColumnHeader

            monthPicker.Month = MonthDate.Now;

            //RefreshVisualContent();

            //monthChangePointer += new MonthChange(monthPickerChange);
            //modernMonthPicker1.MonthChange = monthChangePointer;

            //monthPicker.MonthChange += new ModernMonthPicker.MonthChangeEvent(monthPickerChange);

            //listviewExpenses.

            //SetWindowTheme
        }

        private void ExpensesUserControl_SizeChanged(object sender, EventArgs e) {
            // Update the expenses listview columns width
            listView_SizeChanged(listviewExpenses, null);
            listView_SizeChanged(listviewIncomes, null);
        }

        /*  *   *   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   *   *   */

        //  LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW ** LISTVIEW
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

        /*  *   *   *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   *   *   */
        /*public void RefreshVisualContent() {
            //center_tableLayoutPanel.RowStyles[1].Height = 0;
            //selected_itens_status_label.Text = "0 itens";

            //  CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT
            double totalSpents = 0, totalMoneys = 0;

            // Expenses
            listviewExpenses.Items.Clear();

            foreach (Expense item in expenses.SelectByMonth(currentMonth)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", item.Count));
                row.SubItems.Add(String.Format("R$ {0:N}", item.Price));
                row.SubItems.Add(String.Format("R$ {0:N}", item.TotalPrice));

                row.ForeColor = Color.Black;

                //row.

                listviewExpenses.Items.Add(row);

                totalSpents += item.TotalPrice;
            }

            // Update the expenses listview columns width
            //listView_SizeChanged(listviewExpenses, null);

            // Moneys
            listviewIncomes.Items.Clear();

            foreach (Income item in incomes.SelectByMonth(currentMonth)) {
                ListViewItem row = new ListViewItem(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("R$ {0:N}", item.Value));

                listviewIncomes.Items.Add(row);

                totalMoneys += item.Value;
            }

            // Refresh on form
            //all_spents_value.Text = String.Format("R$ {0:N}", totalSpents);
            //all_money_value.Text = String.Format("R$ {0:N}", totalMoneys);
            //remaining_money_value.Text = String.Format("R$ {0:N}", totalMoneys - totalSpents);

            // Update the imcomes listview columns width
            //listView_SizeChanged(listviewIncomes, null);

            ExpensesUserControl_SizeChanged(null, null);

            //listvewExpenses.Refresh();


        }*/

        // MONTH PICKER ** MONTH PICKER ** MONTH PICKER ** MONTH PICKER ** MONTH PICKER ** MONTH PICKER
        private void monthPicker_MonthChanged(MonthDate month) {
            //  CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT
            double totalSpents = 0, totalMoneys = 0;

            // Expenses
            listviewExpenses.Items.Clear();

            foreach (Expense item in expenses.SelectByMonth(month)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", item.Count));
                row.SubItems.Add(String.Format("R$ {0:N}", item.Price));
                row.SubItems.Add(String.Format("R$ {0:N}", item.TotalPrice));

                row.ForeColor = Color.Black;

                //row.

                listviewExpenses.Items.Add(row);

                totalSpents += item.TotalPrice;
            }

            // Update the expenses listview columns width
            //listView_SizeChanged(listviewExpenses, null);

            // Moneys
            listviewIncomes.Items.Clear();

            foreach (Income item in incomes.SelectByMonth(month)) {
                ListViewItem row = new ListViewItem(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("R$ {0:N}", item.Value));

                listviewIncomes.Items.Add(row);

                totalMoneys += item.Value;
            }

            ExpensesUserControl_SizeChanged(null, null);


            //MessageBox.Show(month.ToString());
        }

        // Theme

        // PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES ** PROPERTIES
        public String Title {
            get { return "Despesas"; }
        }
    }
}
