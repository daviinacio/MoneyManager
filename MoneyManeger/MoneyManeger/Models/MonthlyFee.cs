using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManeger.Utils;

namespace MoneyManeger.Models {
    public class MonthlyFee {
        // Default values
        private int DefaultBusinessDay = 5;

        // Constructors
        public MonthlyFee(int id, String description, double monthlyValue, DateTime monthStart, DateTime monthEnd, int businessDay) {
            this.ID = id; this.Description = description; this.MonthlyValue = monthlyValue;
            this.MonthStart = MonthDate.Parse(monthStart);
            this.MonthEnd = MonthDate.Parse(monthEnd);
            this.BusinessDay = businessDay;
        }
        public MonthlyFee(int id, String description, double monthlyValue, DateTime monthStart) {
            this.ID = id; this.Description = description; this.MonthlyValue = monthlyValue;
            this.MonthStart = MonthDate.Parse(monthStart);
            this.MonthEnd = MonthDate.Infinity;
            this.BusinessDay = DefaultBusinessDay;
        }
        public MonthlyFee(int id, String description, double monthlyValue) {
            this.ID = id; this.Description = description; this.MonthlyValue = monthlyValue;
            this.MonthStart = MonthDate.Now;
            this.MonthEnd = MonthDate.Infinity;
            this.BusinessDay = DefaultBusinessDay;
        }

        // Methods
        public DateTime GetDate(MonthDate current) {
            // TODO: Improve the business day calc  **  **  **  **

            DateTime date = new DateTime(current.Date.Year, current.Date.Month, 1);
            int workDays = this.BusinessDay;

            while (workDays > 0) {
                date = date.AddDays(1);
                if (date.DayOfWeek != DayOfWeek.Saturday &&
                    date.DayOfWeek != DayOfWeek.Sunday)
                    workDays--;
            }

                /*while (this.BusinessDay > 0) {
                    date = date.AddDays(1);
                    if (date.DayOfWeek < DayOfWeek.Saturday &&
                        date.DayOfWeek > DayOfWeek.Sunday )
                        date.AddDays(-1);
                }*/

            return date;
        }

        public bool IsOnMonth(MonthDate current) {
            return current.IsInRange(this.MonthStart, this.MonthEnd);
        }

        // Properties
        public int ID { get; }
        public String Description { get; }
        public double MonthlyValue { get; }
        public MonthDate MonthStart { get; }
        public MonthDate MonthEnd { get; }
        //public int Parcels { get; }
        public int BusinessDay { get; }

        
        public override String ToString() {
            return String.Format("ID:\t\t{0}\nDescription:\t{1}\nMonthlyValue:\t{2}\nMonthStart:\t{3}\nMonthEnd:\t{4}\nBusinessDay:\t{5}",
                ID, Description, MonthlyValue, MonthStart, MonthEnd, BusinessDay);
        }
    }
}
