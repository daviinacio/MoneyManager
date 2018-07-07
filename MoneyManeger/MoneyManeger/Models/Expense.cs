using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MoneyManeger.Utils;

namespace MoneyManeger.Models {
    public class Expense {
        // Constructors
        public Expense(int id, String description, double price, double count, DateTime date) {
            this.Id = id; this.Count = count; this.Price = price;
            this.Description = description; this.Date = date;
        }
        public Expense(int id, String description, double price, double count) :
            this(id, description, price, count, DateTime.Today) { }

        public Expense(int id, String description) :
            this(id, description, 0, 0) { }

        public Expense(String description, double price, double count, DateTime date) :
            this(-1, description, price, count, date){ }

        public Expense(String description, double price, double count) :
            this(-1, description, price, count) { }

        public Expense(String description) :
            this(-1, description) { }

        public Expense() :
            this(-1, "") { }

        // Properties
        public int Id { get; }
        public double Price { get; set; }
        public double Count { get; set; }
        public String Description { get; set; }
        public DateTime Date { get; set; }
        public double TotalPrice { get { return this.Count * this.Price; } }

        public override String ToString() {
            return String.Format((this.Id == -1 ? "" : "ID:\t\t{0}\n") + "Description:\t{1}\nPrice:\t\t{2}\nCount:\t\t{3}\nDate:\t\t{4}", 
                Id, Description, Price, Count, Date.ToString());
        }
    }
}
