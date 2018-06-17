using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManeger.Utils;

namespace MoneyManeger.Models {
    public class Expense {
        // Constructors
        public Expense(int id, String description, double value, double count, DateTime date) {
            this.Id = id; this.Count = count; this.Value = value;
            this.Description = description; this.Date = date;
        }
        public Expense(int id, String description, double value, double count) :
            this(id, description, value, count, DateTime.Now) { }

        public Expense(int id, String description) :
            this(id, description, 0, 0) { }

        public Expense(String description, double value, double count, DateTime date) :
            this(-1, description, value, count, date){ }

        public Expense(String description, double value, double count) :
            this(-1, description, value, count) { }

        public Expense(String description) :
            this(-1, description) { }

        // Properties
        public int Id { get; }
        public double Value { get; set; }
        public double Count { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }


        public override String ToString() {
            return String.Format("ID:\t\t{0}\nDescription:\t{1}\nValue:\t\t{2}\nCount:\t\t{3}\nDate:\t\t{4}", 
                Id, Description, Value, Count, Date.ToString());
        }
    }
}
