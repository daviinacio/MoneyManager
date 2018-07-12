using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManeger.Utils;

namespace MoneyManeger.Models {
    public class MonthlyFee {
        public enum eDayType { WorkingDays = 0, FixedDays = 1 }
        public enum eStatus { NaoPago = 0, Pago = 1 }

        // Constructors

        public MonthlyFee(int id, String description, double monthlyValue, DateTime monthStart, DateTime monthEnd, eDayType dayType, int day) {
            this.Id = id;
            this.Description = description;
            this.MonthlyValue = monthlyValue;
            this.MonthStart = monthStart;
            this.MonthEnd = monthEnd;
            this.DayType = dayType;
            this.Day = day;
        }

        public MonthlyFee() { this.Id = -1; }


        // Properties
        public int Id { get; } = -1;
        public String Description { get; set; } = "";
        public double MonthlyValue { get; set; } = 0;
        public DateTime MonthStart { get; set; } = DateTime.Now;
        public DateTime MonthEnd { get; set; } = DateTime.MaxValue;
        public eDayType DayType { get; set; } = eDayType.WorkingDays;
        public int Day { get; set; } = 5;

        public DateTime Date (DateTime currentDate) {

            switch (DayType) {
                case eDayType.WorkingDays:
                    return MonthDate.GetWorkingDay(currentDate, this.Day);
                case eDayType.FixedDays:
                    return currentDate.AddDays(-currentDate.Day).AddDays(this.Day);
            }

            return currentDate;
        }

        public Expense Expense (DateTime month) {
            List<Expense> result = new DataBase.ExpensesDB().GetSimilarItem(this.Description, this.Date(month));
            return result.Count > 0 ? result[0] : null;
        }
        
        public override String ToString() {
            return String.Format("ID:\t\t{0}\nDescription:\t{1}\nMonthlyValue:\t{2}\nMonthStart:\t{3}\nMonthEnd:\t{4}\nDay:\t{5}\nDayType:\t{6}",
                Id, Description, MonthlyValue, MonthStart, MonthEnd, Day, DayType);
        }
    }
}
