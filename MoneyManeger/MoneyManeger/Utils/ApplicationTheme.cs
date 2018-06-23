using MoneyManeger.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger.Utils {
    public abstract class ApplicationTheme {
        // Variables
        private int themeIndex = 0;
        protected List<Theme> themes = null;

        // Functions
        protected void InitializeTheme() {
            this.themes = new List<Theme>();
            // Light
            themes.Add(new Theme(
                Color.DimGray,
                Color.White,
                Color.Orange
            ));

            // Dark
            themes.Add(new Theme(
                SystemColors.Control,
                Color.Black,
                Color.Green
            ));
            

            // Load the theme
            this.ThemeLoad(themes.ElementAt(themeIndex));
        }
        protected abstract void ThemeLoad(Theme theme);

        // Properties
        //public List<Theme> Themes { get { return new List<Theme>(); } }
        public Theme Theme {
            get {
                if (this.themes == null || this.themes.Count == 0)
                    InitializeTheme();

                return themes.ElementAt(themeIndex);
            }
        }
    }
}
