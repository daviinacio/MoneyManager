using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManeger.Models {
    public class Income {
        public Income(int id, string description, double value, DateTime date) {
            this.Id = id; this.Description = description;
            this.Value = value; this.Date = date;
        }
        public Income(int id, string description, double value) :
            this(id, description, value, DateTime.Now) { }

        public Income(int id, string description) :
            this(id, description, 0) { }

        public Income(string description, double value, DateTime date) :
            this(-1, description, value, date) { }

        public Income(string description, double value) :
            this(-1, description, value) { }

        public Income(string description) :
            this(-1, description) { }

        public Income() :
            this(-1, "") { }


        // Properties
        public int Id { get; }
        public string Description { get; set; }
        public double Value { get; set; }
        public DateTime Date { get; set; }

        public override String ToString() {
            return String.Format("ID:\t\t{0}\nDescription:\t{1}\nValue:\t\t{2}\nDate:\t\t{3}",
                Id, Description, Value, Date.ToString());
        }
    }
}
