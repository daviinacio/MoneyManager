using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger {
    static class Program {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main() {
            // Organize your money
            // Realize your dreams

            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Teste());
            //Application.Run(new ImportForms.ImportExpensesByText());
            //Application.Run(new MainForm());


            Application.Run(new GeneralForm());
        }
    }
}
