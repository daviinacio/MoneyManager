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
        public MonthlyFeeUserControl() {
            InitializeComponent();
        }

        public String Title {
            get { return "Mensalidades"; }
        }
    }
}
