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
        private MoneysDB moneys = new MoneysDB();

        // Variables
        private MonthDate currentMonth = MonthDate.Now;
        private bool resizing = false;

        public ExpensesUserControl() {
            InitializeComponent();
        }

        private void ExpensesUserControl_Load(object sender, EventArgs e) {
            listvewExpenses.BackColor = this.BackColor;
            listvewExpenses.ForeColor = this.ForeColor;
            panelRight.BackColor = this.BackColor;

            // listvewExpenses.DrawColumnHeader

            RefreshVisualContent();
        }

        public String Title {
            get { return "Despesas"; }
        }

        private void listvewExpenses_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e) {
            e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
            e.DrawText();
        }

        private void listvewExpenses_DrawItem(object sender, DrawListViewItemEventArgs e) {
            e.DrawDefault = true;
        }

        /*  *   *   *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   *   *   */
        private void RefreshVisualContent() {
            //center_tableLayoutPanel.RowStyles[1].Height = 0;
            //selected_itens_status_label.Text = "0 itens";

            // Month refresh
            //month_listView.Items.Clear();

            /*for (int i = 0; i < Properties.Settings.Default.months_abr_pt_br.Count; i++) {
                ListViewItem item = new ListViewItem(Properties.Settings.Default.months_abr_pt_br[i]);
                item.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));

                if (i == currentMonth.Month - 1) {
                    item.BackColor = Color.Gray;
                    item.ForeColor = Color.White;
                } else
                if (i == DateTime.Today.Month - 1 && DateTime.Today.Year == currentMonth.Year)
                    item.BackColor = Color.LightGray;

                month_listView.Items.Add(item);
            }*/

            // Year refresh
            //date_year_label.Text = currentMonth.Year.ToString();

            /* CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT ** CONTENT */
            double totalSpents = 0, totalMoneys = 0;

            // Expenses
            listvewExpenses.Items.Clear();

            foreach (Expense item in expenses.SelectByMonth(currentMonth)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());
                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("{0:0.000}", item.Count));
                row.SubItems.Add(String.Format("R$ {0:N}", item.Price));
                row.SubItems.Add(String.Format("R$ {0:N}", item.TotalPrice));

                listvewExpenses.Items.Add(row);

                totalSpents += item.TotalPrice;
            }

            // Moneys
            //moneys_listView.Items.Clear();

            /*foreach (Money item in moneys.SelectByMonth(currentMonth)) {
                ListViewItem row = new ListViewItem(item.Description.ToString());
                row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                row.SubItems.Add(String.Format("R$ {0:N}", item.Value));

                //moneys_listView.Items.Add(row);

                totalMoneys += item.Value;
            }*/

            // Refresh on form
            //all_spents_value.Text = String.Format("R$ {0:N}", totalSpents);
            //all_money_value.Text = String.Format("R$ {0:N}", totalMoneys);
            //remaining_money_value.Text = String.Format("R$ {0:N}", totalMoneys - totalSpents);

            // Update the expenses listview columns width
            //listView_SizeChanged(expenses_listView, null);
        }

        // Theme
    }
}
