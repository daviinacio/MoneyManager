using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManeger.Utils;

namespace MoneyManeger.Models {
    public class MonthlyFee {
        // Default values
        private static int DefaultBusinessDay = 5;

        // Constructors
        public MonthlyFee(int id, String description, double monthlyValue, DateTime monthStart, DateTime monthEnd, int businessDay) {
            this.Id = id; this.Description = description; this.MonthlyValue = monthlyValue;
            this.MonthStart = MonthDate.Parse(monthStart);
            this.MonthEnd = MonthDate.Parse(monthEnd);
            this.BusinessDay = businessDay;
        }
        public MonthlyFee(int id, String description, double monthlyValue, DateTime monthStart) :
            this(id, description, monthlyValue, monthStart, MonthDate.Infinity.Date, DefaultBusinessDay) { }

        public MonthlyFee(int id, String description, double monthlyValue) :
            this(id, description, monthlyValue, MonthDate.Now.Date) { }

        public MonthlyFee(String description, double monthlyValue, DateTime monthStart, DateTime monthEnd, int businessDay) :
            this(-1, description, monthlyValue, monthStart, monthEnd, businessDay) { }

        public MonthlyFee(String description, double monthlyValue, DateTime monthStart) :
            this(-1, description, monthlyValue, monthStart) { }

        public MonthlyFee(String description, double monthlyValue) :
            this(-1, description, monthlyValue) { }

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

            return date;
        }

        public bool IsOnMonth(MonthDate current) {
            return current.IsInRange(this.MonthStart, this.MonthEnd);
        }

        // Properties
        public int Id { get; }
        public String Description { get; set; }
        public double MonthlyValue { get; set; }
        public MonthDate MonthStart { get; set; }
        public MonthDate MonthEnd { get; set; }
        //public int Parcels { get; }
        public int BusinessDay { get; set; }

        
        public override String ToString() {
            return String.Format("ID:\t\t{0}\nDescription:\t{1}\nMonthlyValue:\t{2}\nMonthStart:\t{3}\nMonthEnd:\t{4}\nBusinessDay:\t{5}",
                Id, Description, MonthlyValue, MonthStart, MonthEnd, BusinessDay);
        }
    }
}
