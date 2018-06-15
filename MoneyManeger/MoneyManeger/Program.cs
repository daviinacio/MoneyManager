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


            //Models.Expense expense = new Models.Expense(1000, "Despesa", 10.3, 2);
            //MessageBox.Show(expense.ToString(), "Expense");

            //MessageBox.Show(DateTime.MinValue.Year.ToString());
            //MessageBox.Show(DateTime.MaxValue.Year.ToString());


            Models.MonthlyFee mensalidade = new Models.MonthlyFee(1000, "Faculdade", 260.8);
            //MessageBox.Show(mensalidade.ToString(), "Monthly Fee");


            Utils.MonthDate currentDate = new Utils.MonthDate(2018, 1);


            //MessageBox.Show(currentDate.ToString());
            //MessageBox.Show(mensalidade.GetDate(currentDate).ToString());


            Utils.MonthDate md = Utils.MonthDate.Now;

            //md.Month = 20;

            //MessageBox.Show(md.ToString());

            //MessageBox.Show(md.IsInRange(new Utils.MonthDate(2018, 6), Utils.MonthDate.Infinity).ToString());

            //MessageBox.Show(Models.MonthDate.Infinity.ToString());

            ///md.Equals()

            //return;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
