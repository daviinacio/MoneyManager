using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManeger.Models {
    public class Theme {
        public Theme(Color BackColor, Color ForeColor, Color AccentColor) {
            this.BackColor = BackColor; this.ForeColor = ForeColor; this.AccentColor = AccentColor;
        }

        public Color BackColor { get; }
        public Color ForeColor { get; }
        public Color AccentColor { get; }
    }
}
