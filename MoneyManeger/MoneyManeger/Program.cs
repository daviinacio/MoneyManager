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
            //Models.Expense expense = new Models.Expense(1000, "Despesa", 10.3, 2);
            //MessageBox.Show(expense.ToString(), "Expense");

            Models.MonthlyFee mensalidade = new Models.MonthlyFee(1000, "Faculdade", 260.8);
            MessageBox.Show(mensalidade.ToString(), "Monthly Fee");

            //Models.MonthDate md = Models.MonthDate.Now;
            //MessageBox.Show(md.IsInRange(Models.MonthDate.Infinity, new Models.MonthDate(2018, 6)).ToString());

            //MessageBox.Show(Models.MonthDate.Infinity.ToString());

            ///md.Equals()

            return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
