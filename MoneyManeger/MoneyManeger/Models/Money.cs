using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneyManeger.Models {
    class Money {

        public Money(int id, string description, double value, DateTime date) {
            this.ID = id; this.Description = description;
            this.Value = value; this.Date = date;
        }

        public Money(int id, string description, double value) {
            this.ID = id; this.Description = description;
            this.Value = value;

            // Default values
            this.Date = DateTime.Now;
        }

        public Money(int id, string description) {
            this.ID = id; this.Description = description;
        }


        // Properties
        public int ID { get; }
        public string Description { get; }
        public double Value { get; }
        public DateTime Date { get; }
    }
}
