using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManeger.Models {
    class MonthDate {
        // Constructor
        public MonthDate(int year, int month) {
            this.Year = year; this.Month = month;
        }

        // Object mthods
        public override bool Equals(object obj) {
            return this.Equals(obj as MonthDate);
        }
        public bool Equals(MonthDate monthdate) {
            return (this.Month == monthdate.Month) && (this.Year == monthdate.Year);
        }
        public override string ToString() {
            return String.Format(this.Equals(MonthDate.Infinity) ? "Infinity" : "{0}/{1}", Month, Year);
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

        // Properties
        public int Month { get; }
        public int Year { get; }

        public DateTime Date {
            get { return new DateTime(Year, Month, 1); }
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
    }
}
