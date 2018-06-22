using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger {
    public partial class GeneralForm : Form {
        public GeneralForm() {
            InitializeComponent();
        }

        private void pb_closeForm_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
