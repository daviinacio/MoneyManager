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

        private MonthDate month = MonthDate.Now;

        private bool initialized = false;

        // Constructors
        public ComboBoxMonthPicker() {
            InitializeComponent();
        }

        // Form Events
        private void ListboxMonthPicker_Load(object sender, EventArgs e) {
            // Fill months
            foreach(String m in (ShortMonthText ? shortMonthList : monthList))
                cbMonth.Items.Add(m);

            // Fill years
            for (int i = minYear; i < maxYear; i++)
                cbYear.Items.Add(i.ToString());

            // Set default value
            this.Month = MonthDate.Now;

            // Turn the initialized variable to true
            initialized = true;

        }

        // ComboBox Click
        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                // Put month content on the object
                this.month.Month = cbMonth.SelectedIndex + 1;

                // Call event
                if (initialized)
                    MonthChanged.DynamicInvoke(this.Month);

            }
            catch (NullReferenceException) { }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString(), "Select month error");
            }
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e) {
            try {
                // Put year content on the object
                this.month.Year = Convert.ToInt32(cbYear.Items[cbYear.SelectedIndex]);

                // Call event
                if(initialized)
                    MonthChanged.DynamicInvoke(this.Month);

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
        public MonthDate Month {
            get { return this.month; }
            set {
                this.month = value;

                cbMonth.SelectedIndex = this.month.Month - 1;
                cbYear.SelectedItem = this.month.Year.ToString();
            }
        }

        // Delegates
        public delegate void MonthChangedEvent(MonthDate month);

        // Events
        [Localizable(true)]
        [Category("Ação")]
        public event MonthChangedEvent MonthChanged;
    }
}
