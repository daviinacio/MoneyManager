using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MoneyManeger.Utils;

namespace MoneyManeger.Utils {
    public partial class ModernMonthPicker : UserControl {
        private MonthDate month;

        public ModernMonthPicker() {
            InitializeComponent();
        }

        private void ModernMonthPicker_Load(object sender, EventArgs e) {
            this.month = MonthDate.Now;

            RefreshMonths();
            RefreshYears();
        }

        private void month_Click(object sender, EventArgs e) {
            try {
                RefreshMonths();
                MonthChanged.DynamicInvoke(Month);
            } catch (NullReferenceException) { }
        }

        private void year_Click(object sender, EventArgs e) {
            try {
                switch ((sender as Button).Text) {
                    case ">": Month.AddYear(1); break;
                    case "<": Month.AddYear(-1); break;
                }

                RefreshYears();
                MonthChanged.DynamicInvoke(Month);
            } catch (NullReferenceException) { }
        }

        // Functions
        private void RefreshYears() {
            labelYear.Text = Month.Year.ToString();
        }

        private void RefreshMonths(){
            Button[] months = new Button[] {
                bJan, bFeb, bMar, bApr, bMai, bJun, bJul, bAgo, bSep, bOct, bNov, bDec
            };

            foreach(Button b in months) {
                
            }
        }

        // Properties
        public MonthDate Month {
            get { return this.month; }
            set {
                try {
                    this.month = value;

                    RefreshMonths();
                    RefreshYears();

                    MonthChanged.DynamicInvoke(Month);
                } catch (NullReferenceException) { }
            }
        }

        public Color DefaultMonthColor { get; set; }

        // Delegates
        public delegate void MonthChangedEvent(MonthDate month);

        // Events
        public event MonthChangedEvent MonthChanged;
    }
}
