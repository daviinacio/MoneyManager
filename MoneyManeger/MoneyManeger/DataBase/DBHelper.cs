using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Windows.Forms;

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
                return this.Select("id = " + id)[0];
            }
        }

        public E Min {
            get {
                connection.Open();
                int id = (int) new SqlCommand("SELECT MIN(id) FROM " + DBName, connection).ExecuteScalar();
                connection.Close();
                return this.Select("id = " + id)[0];
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
        public abstract List<E> Select(String where);

        public E SelectById(int id) {
            try {
                return this.Select("id = " + id)[0];

            } catch (System.ArgumentOutOfRangeException) {
                throw new Exceptions.RowNotFoundException("Nunhum resultado para esse id: ['" + id + "']");
            }
        }

        public List<E> SelectByMonth(Utils.MonthDate month) {
            return this.Select(String.Format("DATEPART(month, date) = {0} AND DATEPART(year, date) = {1}", month.Month, month.Year));
        }
    }
}
