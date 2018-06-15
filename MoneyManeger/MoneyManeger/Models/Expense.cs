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
            this.ID = id; this.Count = count; this.Value = value;
            this.Description = description; this.Date = date;
        }
        public Expense(int id, String description, double value, double count) {
            this.ID = id; this.Count = count; this.Value = value;
            this.Description = description;
            this.Date = DateTime.Now;
        }
        public Expense(int id, String description) {   
            this.ID = id; this.Description = description;
            this.Count = 0; this.Value = 0;
            this.Date = DateTime.Now;
        }
        

        // Properties
        public int ID { get; }
        public double Value { get; }
        public double Count { get; }
        public String Description { get; }
        public DateTime Date { get; }


        public override String ToString() {
            return String.Format("ID:\t\t{0}\nDescription:\t{1}\nValue:\t\t{2}\nCount:\t\t{3}\nDate:\t\t{4}", 
                ID, Description, Value, Count, Date.ToString());
        }
    }
}
