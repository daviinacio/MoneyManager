using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;
using MoneyManeger.Utils;

namespace MoneyManeger.DataBase {
    abstract class DBHelper<E> {
        // SQL Connection Variables
        protected SqlConnection connection = new SqlConnection(Properties.Settings.Default.db_ConnString);
        protected String DBName = "";

        public DBHelper(String dataBaseName) {
            this.DBName = dataBaseName;
        }

        // SQL Parameters
        public E Max {
            get {
                connection.Open();
                int id = (int) new SqlCommand("SELECT MAX(id) FROM " + DBName, connection).ExecuteScalar();
                connection.Close();
                return this.Select("id = " + id, null)[0];
            }
        }

        public E Min {
            get {
                connection.Open();
                int id = (int) new SqlCommand("SELECT MIN(id) FROM " + DBName, connection).ExecuteScalar();
                connection.Close();
                return this.Select("id = " + id, null)[0];
            }
        }

        public int Count {
            get {
                connection.Open();
                int count = (int) new SqlCommand("SELECT COUNT(*) FROM[" + DBName  + "] id", connection).ExecuteScalar();
                connection.Close();
                return count;
            }
        }

        // SQL Functions
        public abstract E Insert(E item);
        public abstract void Delete(E item);
        public abstract void Delete(int id);
        public abstract void Update(E item);
    
        public List<E> Select(String where, String order) {
            return this.Select("WHERE " + where + (order != null ? " ORDER BY " + order : ""));
        }

        public abstract List<E> Select(String query);
        

        public E SelectById(int id) {
            try {
                return this.Select("id = " + id, null)[0];

            } catch (System.ArgumentOutOfRangeException) {
                throw new Exceptions.RowNotFoundException("Nunhum resultado para esse id: ['" + id + "']");
            }
        }

        public virtual List<E> SelectByMonth(DateTime month) {
            DateTime nextMonth = month.AddMonths(1);

            return this.Select(String.Format("date >= '{1}/{0}/{2}' AND date < '{4}/{3}/{5}' ",
            //return this.Select(String.Format("date >= '06/01/2018' AND date < '08/01/2018' ",
                MonthDate.GetFifthWorkingDay(month), month.Month, month.Year,
                MonthDate.GetFifthWorkingDay(nextMonth), nextMonth.Month, nextMonth.Year),
                "date ASC, description ASC");

            //return this.Select(String.Format("DATEPART(month, date) = {0} AND DATEPART(year, date) = {1}", month.Month, month.Year), "date ASC, description ASC");
        }



        public virtual List<E> GetSimilarItem(string description, DateTime date) {
            return this.Select(String.Format("DATEPART(day, date) = {0} AND DATEPART(month, date) = {1} AND DATEPART(year, date) = {2} AND description = '{3}'",
                date.Day, date.Month, date.Year, description
                ), null);
        }
    }
}
