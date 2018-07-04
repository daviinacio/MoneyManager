using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MoneyManeger.Utils {
    public class MonthDate {
        // Private variables
        private int month, year;

        // Constructor
        public MonthDate(int year, int month) {
            this.Year = year; this.Month = month;
        }

        // Methods
        public bool IsInRange(MonthDate start, MonthDate end) {
            // Throw if the start is bigger that end
            if (start.Date > end.Date) throw new Exception("The initial date is bigger that the end");
            // Throw if the start is equals the end
            if (start.Date == end.Date) throw new Exception("The initial date is equals the end");
            // Return true if the current object date is between the range
            return this.Date >= start.Date && this.Date <= end.Date;
        }

        public MonthDate AddMonth(int months) {
            // Use the DateTime to calc the months increment or decrement
            DateTime temp = this.Date.AddMonths(months);

            this.Month = temp.Month;
            this.Year = temp.Year;

            return this;
        }

        public MonthDate AddYear(int years) {
            // Use the DateTime to calc the year increment or decrement
            this.Year = this.Date.AddYears(years).Year;

            return this;
        }

        // Properties
        public int Month {
            // Return the month value
            get { return this.month; }
            set {
                // Check if the value is between  [1, 12] 
                if (value >= DateTime.MinValue.Month && value <= DateTime.MaxValue.Month)
                    this.month = value;
                // Throw and exception showing that the value is wrong
                else throw new ArgumentOutOfRangeException("Month value", value, 
                    String.Format("Only values between {0} and {1}", DateTime.MinValue.Month, DateTime.MaxValue.Month));
            }
        }
        public int Year {
            get { return this.year; }
            set {
                // Check if the value is between  [1, 9999] 
                if (value >= DateTime.MinValue.Year && value <= DateTime.MaxValue.Year)
                    this.year = value;
                // Throw and exception showing that the value is wrong
                else throw new ArgumentOutOfRangeException("Year value", value,
                    String.Format("Only values between {0} and {1}", DateTime.MinValue.Year, DateTime.MaxValue.Year));
            }
        }

        public DateTime Date {
            // Return a DateTime with the Year and Month values
            get { return new DateTime(Year, Month, DateTime.Today.Day); }
        }

        // Object mthods
        public override bool Equals(object obj) {
            // Check if the object is equals this
            return this.Equals(obj as MonthDate);
        }
        public bool Equals(MonthDate monthdate) {
            // Check if the year and the month ir equals
            return (this.Month == monthdate.Month) && (this.Year == monthdate.Year);
        }
        public override int GetHashCode() {
            // TODO: Override this method   **  **  **  **
            return base.GetHashCode();
        }

        public override string ToString() {
            // Return a string with important values
            return String.Format(this.Equals(MonthDate.Infinity) ? "Infinity" : "Month:\t{0}\nYear:\t{1}", Month, Year);
        }

        // Static Methods and Properties
        public static MonthDate Parse(DateTime date) {
            return new MonthDate(date.Year, date.Month);
        }
        public static MonthDate Now {
            get { return new MonthDate(DateTime.Today.Year, DateTime.Today.Month); }
        }
        /* This says that a end date is not defined */
        public static MonthDate Infinity {
            get { return MonthDate.Parse(DateTime.MaxValue); }
        }

        public static int GetFifthWorkingDay(DateTime month) {
            return GetWorkingDay(month, 5).Day;
        }

        public static DateTime GetWorkingDay(DateTime month, int day) {
            month = month.AddDays(-(month.Day -1));
            DateTime _month = month.Date;

            //MessageBox.Show(month.Day.ToString());

            for (int daysCount = 0; month.Day < DateTime.MaxValue.Month; month = month.AddDays(1)) {

                if (month.DayOfWeek != DayOfWeek.Sunday &&
                    month.DayOfWeek != DayOfWeek.Saturday)
                    daysCount++;

                // If the working days reach 5, return the current count days
                if (daysCount >= day) return month;
            }

            return _month;
        }

        /*public static int GetDiffDays(DateTime initialDate, DateTime finalDate) {
            int days = 0;
            int daysCount = 0;
            days = initialDate.Subtract(finalDate).Days;

            //Módulo
            if (days < 0)
                days = days * -1;

            for (int i = 1; i <= days; i++) {
                initialDate = initialDate.AddDays(1);
                //Conta apenas dias da semana.
                if (initialDate.DayOfWeek != DayOfWeek.Sunday &&
                    initialDate.DayOfWeek != DayOfWeek.Saturday)
                    daysCount++;
            }
            return daysCount;
        }*/

    }
}
