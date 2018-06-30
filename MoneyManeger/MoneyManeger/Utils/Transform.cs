using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger.Utils {
    public static class Transform {
        public static void TextBox_Money_KeyPress(TextBoxBase tb, KeyPressEventArgs e) {
            TextBox_Decimal_KeyPress(tb, e, ',', 2);
        }

        public static void TextBox_Weight_KeyPress(TextBoxBase tb, KeyPressEventArgs e) {
            TextBox_Decimal_KeyPress(tb, e, ',', 3);
        }

        public static void TextBox_Float_KeyPress(TextBoxBase tb, KeyPressEventArgs e) {
            TextBox_Decimal_KeyPress(tb, e, ',', 7);
        }

        public static void TextBox_Double_KeyPress(TextBoxBase tb, KeyPressEventArgs e) {
            TextBox_Decimal_KeyPress(tb, e, ',', 15);
        }

        public static void TextBox_Decimal_KeyPress(TextBoxBase tb, KeyPressEventArgs e, char separator, int decimalFonts) {
            // Mask the decimal separator
            if (e.KeyChar == '.' || e.KeyChar == ',') e.KeyChar = separator;

            // Check if is number or [separator]
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != separator))
                e.Handled = true;

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == separator) && (tb.Text.IndexOf(separator) > -1))
                e.Handled = true;

            // Allow write until [decimalFonts] digits after [separator]
            if (tb.Text.IndexOf(separator) > 0 ? ((int) tb.Text.IndexOf(separator)) + decimalFonts < tb.Text.Length : false)
                if (tb.SelectionStart > tb.Text.IndexOf(separator) && e.KeyChar != '\b')
                    e.Handled = true;
        }
    }
}


/* BACKUP ** BACKUP ** BACKUP ** BACKUP */

/*
    // Mask the decimal separator
    if (e.KeyChar == '.') e.KeyChar = ',';

    // Check if is number or ','
    if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
        e.Handled = true;

    // If you want, you can allow decimal (float) numbers
    if ((e.KeyChar == ',') && (tb.Text.IndexOf(',') > -1))
        e.Handled = true;

    // Allow write until 3 digits after ','
    if (tb.Text.IndexOf(',') > 0 ? ((int) tb.Text.IndexOf(',')) + 3 < tb.Text.Length : false)
        if (tb.SelectionStart >= tb.Text.IndexOf(',') && e.KeyChar != '\b')
            e.Handled = true;
*/
