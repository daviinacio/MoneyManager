using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger.MainTabs {
    public partial class MonthlyFeeUserControl : UserControl {
        // Variables
        private DataBase.MonthlyFeesDB db = new DataBase.MonthlyFeesDB();

        // Constructors
        public MonthlyFeeUserControl() {
            InitializeComponent();
        }

        // Form events
        private void MonthlyFeeUserControl_Load(object sender, EventArgs e) {


            // Show the content to user
            RefreshContent();
        }

        // Content methods
        private void RefreshContent() {
            foreach (Models.MonthlyFee item in db.Select("1 = 1", null)) {
                ListViewItem row = new ListViewItem(item.Id.ToString());

                row.SubItems.Add(item.Description.ToString());
                row.SubItems.Add(item.MonthStart.ToString().Split(' ')[0].Substring(3));
                row.SubItems.Add(item.MonthEnd.ToString().Split(' ')[0].Substring(3));
                row.SubItems.Add(String.Format("R$ {0:N}", item.MonthlyValue));

                row.ForeColor = Color.Black;

                listviewMonthlyFee.Items.Add(row);
            }
        }

        // Properties
        public String Title {
            get { return "Mensalidades"; }
        }
    }
}
