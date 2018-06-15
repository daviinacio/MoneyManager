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

namespace MoneyManeger {
    public partial class MainForm : Form {

        // Variables
        private MonthDate currentMonth = MonthDate.Now;
        private bool resizing = false;



        public MainForm() {
            InitializeComponent();
        }

        /*  *   *   *   FORM EVENTS *   FORM EVENTS *   FORM EVENTS *   FORM EVENTS *   *   *   */

        private void MainForm_Load(object sender, EventArgs e) {

            RefreshVisualContent();
        }

        private void MainForm_ResizeEnd(object sender, EventArgs e) {
            listView_SizeChanged(expenses_listView, null);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e) {
            if (WindowState.Equals(FormWindowState.Maximized))
                listView_SizeChanged(expenses_listView, null);
        }

        /*  *   *   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   ELEM FUNC   *   *   *   */

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e) {
            currentMonth.AddMonth(1);
            RefreshVisualContent();
            MessageBox.Show(currentMonth.ToString());
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

            } catch(ArgumentOutOfRangeException ex) {
                MessageBox.Show("Você chegou na borda\nApenas values entre 1 e 9999", "Fora do limite");
            }

            RefreshVisualContent();
        }

        /*  *   *   *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   VISUAL FUNC *   *   *   */

        private void RefreshVisualContent() {
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

            // Update the expenses listview columns width
            listView_SizeChanged(expenses_listView, null);

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
    }
}
