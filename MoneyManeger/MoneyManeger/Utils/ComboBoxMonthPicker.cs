using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger.Utils {
    public partial class ComboBoxMonthPicker : UserControl {
        private String[] monthList = new String[] {
            "Janeiro", "Fevereiro", "Março", "Abril", "Maio", "Junho",
            "Julho", "Agosto", "Setembro", "Outubro",  "Novembro", "Dezembro"
        };

        private String[] shortMonthList = new String[] {
            "Jan", "Fev", "Mar", "Abr", "Mai", "Jun",
            "Jul", "Ago", "Set", "Out",  "Nov", "Dez"
        };

        private int minYear = 1980, maxYear = 2100;

        private DateTime value = DateTime.Now;

        private bool /*initialized = false,*/ isSelected = true;

        // Constructors
        public ComboBoxMonthPicker() {
            InitializeComponent();

            // Fill months
            foreach (String m in (ShortMonthText ? shortMonthList : monthList))
                cbMonth.Items.Add(m);

            // Fill years
            for (int i = minYear; i < maxYear; i++)
                cbYear.Items.Add(i.ToString());

            this.Value = DateTime.Now;
        }

        // Form Events
        private void ListboxMonthPicker_Load(object sender, EventArgs e) {

        }

        // ComboBox Click
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (isSelected) {
                    // Put the month to 1 (refering the variable, to now call the event)
                    value = Value.AddMonths(-Value.Month);
                    // Put the month value
                    Value = Value.AddMonths(cbMonth.SelectedIndex + 1);
                }
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Select month error");
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                if (isSelected) {
                    // Put the month to 1 (refering the variable, to now call the event)
                    value = Value.AddYears(-(Value.Year - 1));
                    // Put the month value
                    Value = Value.AddYears(Convert.ToInt32(cbYear.Items[cbYear.SelectedIndex]) - 1);
                }
            } 
            catch (NullReferenceException) {}
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Select year error");
            }
        }

        // Properties
        [Localizable(true)]
        [Category("Conteúdo")]
        public bool ShortMonthText { get; set; } = true;

        [Localizable(false)]
        public DateTime Value {
            get { return this.value; }
            set {
                this.value = value;

                isSelected = false;

                cbMonth.SelectedIndex = this.Value.Month - 1;
                cbYear.SelectedItem = this.Value.Year.ToString();

                isSelected = true;

                // Call event
                try {
                    MonthChanged.DynamicInvoke(this.Value);
                } catch (NullReferenceException) { }
            }
        }

        // Delegates
        public delegate void MonthChangedEvent(DateTime month);

        // Events
        [Localizable(true)]
        [Category("Ação")]
        public event MonthChangedEvent MonthChanged;
    }
}
