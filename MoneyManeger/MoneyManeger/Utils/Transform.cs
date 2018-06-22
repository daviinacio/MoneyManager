using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger.Utils {
    public static class Transform {
        public static void TextBox_Money_KeyPress(TextBox tb, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && (tb.Text.IndexOf('.') > -1))
                e.Handled = true;

            try {
                //int pos = tb.SelectionStart;
                //tb.Text = String.Format("{0:N}", Double.Parse(tb.Text));
                //tb.SelectionStart = pos + 1 == tb.Text.Length ? tb.Text.Length : pos;

            } catch (FormatException) { }
        }

        public static void TextBox_Double_KeyPress(TextBox tb, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && (tb.Text.IndexOf('.') > -1))
                e.Handled = true;
        }
    }
}
