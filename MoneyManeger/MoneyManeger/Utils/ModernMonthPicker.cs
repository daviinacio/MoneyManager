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
        private DateTime value;

        private Button[] btnsMonths;

        public ModernMonthPicker() {
            InitializeComponent();
        }

        private void ModernMonthPicker_Load(object sender, EventArgs e) {
            this.value = DateTime.Now;

            this.btnsMonths = new Button[] {
                bJan, bFeb, bMar, bApr, bMai, bJun, bJul, bAgo, bSep, bOct, bNov, bDec
            };


            RefreshControls();
        }

        private void month_Click(object sender, EventArgs e) {
            try {
                // Put the month to 1 (refering the variable, to now call the event)
                value = Value.AddMonths(-(Value.Month));
                // Put the month value
                Value = Value.AddMonths(Convert.ToInt32((sender as Button).Tag.ToString()));

            } catch (NullReferenceException) { }
        }

        private void year_Click(object sender, EventArgs e) {
            try {
                switch ((sender as Button).Text) {
                    case ">": Value = Value.AddYears(1); break;
                    case "<": Value = Value.AddYears(-1); break;
                }
            } catch (NullReferenceException) { }
        }

        // Functions
        private void RefreshControls() {
            // Year
            labelYear.ForeColor = YearForeColor;
            bYearLess.ForeColor = bYearPlus.ForeColor = ChooseYearForeColor;
            bYearLess.BackColor = bYearPlus.BackColor = ChooseYearBackColor;

            labelYear.Text = Value.Year.ToString();

            // Month
            for (int i = 0; i < btnsMonths.Length; i++) {
                if ((i + 1) == MonthDate.Now.Month && Value.Year == MonthDate.Now.Year) {
                    btnsMonths[i].BackColor = CurrentMonthBackColor;
                    btnsMonths[i].ForeColor = CurrentMonthForeColor;
                    btnsMonths[i].FlatAppearance.BorderSize = CurrentMonthBorderSize;
                    btnsMonths[i].FlatAppearance.BorderColor = CurrentMonthBorderColor;
                } else if ((i + 1) == Value.Month) {
                    btnsMonths[i].BackColor = SelectedMonthBackColor;
                    btnsMonths[i].ForeColor = SelectedMonthForeColor;
                    btnsMonths[i].FlatAppearance.BorderSize = SelectedMonthBorderSize;
                    btnsMonths[i].FlatAppearance.BorderColor = SelectedMonthBorderColor;
                } else {
                    btnsMonths[i].BackColor = MonthBackColor;
                    btnsMonths[i].ForeColor = MonthForeColor;
                    btnsMonths[i].FlatAppearance.BorderSize = MonthBorderSize;
                    btnsMonths[i].FlatAppearance.BorderColor = MonthBorderColor;
                }
            }
        }

        // Properties
        [Localizable(false)]
        [Category("Comportamento")]
        public DateTime Value {
            get { return this.value; }
            set {
                try {
                    this.value = value;

                    RefreshControls();

                    MonthChanged.DynamicInvoke(Value);
                } catch (NullReferenceException) { }
            }
        }

        // Color

        /* Month Apparence */
        [Localizable(true)]
        [Category("Month Apparence")]
        public Color MonthBackColor { get; set; }

        [Localizable(true)]
        [Category("Month Apparence")]
        public Color MonthForeColor { get; set; } = Color.DimGray;

        [Localizable(true)]
        [Category("Month Apparence")]
        public Color MonthBorderColor { get; set; } = Color.White;

        [Localizable(true)]
        [Category("Month Apparence")]
        public int MonthBorderSize { get; set; } = 0;


        [Localizable(true)]
        [Category("Month Apparence")]
        public Color CurrentMonthBackColor { get; set; } = Color.Orange;

        [Localizable(true)]
        [Category("Month Apparence")]
        public Color CurrentMonthForeColor { get; set; } = Color.White;

        [Localizable(true)]
        [Category("Month Apparence")]
        public Color CurrentMonthBorderColor { get; set; } = Color.White;

        [Localizable(true)]
        [Category("Month Apparence")]
        public int CurrentMonthBorderSize { get; set; } = 0;


        [Localizable(true)]
        [Category("Month Apparence")]
        public Color SelectedMonthBackColor { get; set; } = SystemColors.Control;

        [Localizable(true)]
        [Category("Month Apparence")]
        public Color SelectedMonthForeColor { get; set; } = Color.DimGray;

        [Localizable(true)]
        [Category("Month Apparence")]
        public Color SelectedMonthBorderColor { get; set; } = Color.Orange;

        [Localizable(true)]
        [Category("Month Apparence")]
        public int SelectedMonthBorderSize { get; set; } = 1;


        [Localizable(true)]
        [Category("Year Apparence")]
        public Color YearForeColor { get; set; } = Color.Black;

        [Localizable(true)]
        [Category("Year Apparence")]
        public Color ChooseYearForeColor { get; set; } = Color.Orange;

        [Localizable(true)]
        [Category("Year Apparence")]
        public Color ChooseYearBackColor { get; set; } = SystemColors.Control;



        // Delegates
        public delegate void MonthChangedEvent(DateTime month);

        // Events
        [Localizable(true)]
        [Category("Ação")]
        public event MonthChangedEvent MonthChanged;
    }
}
