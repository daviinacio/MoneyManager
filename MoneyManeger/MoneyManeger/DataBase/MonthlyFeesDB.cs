using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using MoneyManeger.Models;
using System.Windows.Forms;

namespace MoneyManeger.DataBase {
    class MonthlyFeesDB : DBHelper<MonthlyFee> {

        public MonthlyFeesDB() : base("MonthlyFees") { }

        // SQL Functions
        public override void Delete(MonthlyFee item) {
            this.Delete(item.Id);
        }

        public override void Delete(int id) {
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM " + DBName + " WHERE id = @id", connection)) {
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "MonthlyFeesDB.Delete('" + id + "') Exception");

            } finally { connection.Close(); }
        }

        public override MonthlyFee Insert(MonthlyFee item) {
            // Check if yet exists
            if (this.GetSimilarItem(item.Description, DateTime.Now).Count > 0)
                throw new Exception("Já existe uma mensalidade com dados similares!");

            // Open the database connection
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO " + DBName +
                        " (description, monthlyValue, monthStart, monthEnd, dayType, day)" +
                        " Values(@description, @monthlyValue, @monthStart, @monthEnd, @dayType, @day)", connection)) {

                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@monthlyValue", item.MonthlyValue);
                    cmd.Parameters.AddWithValue("@monthStart", item.MonthStart.Date);
                    cmd.Parameters.AddWithValue("@monthEnd", item.MonthEnd.Date);
                    cmd.Parameters.AddWithValue("@dayType", item.DayType);
                    cmd.Parameters.AddWithValue("@day", item.Day);

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "MonthlyFeesDB.Insert('" + item.Id + "') Exception");
                return null;

            } finally { connection.Close(); }

            // Return the last table item (the inserted item with id)
            return this.Max;
        }

        public override List<MonthlyFee> Select(string query) {
            List<MonthlyFee> result = new List<MonthlyFee>();

            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("SELECT M.id, M.description, M.monthlyValue, M.monthStart, M.monthEnd, M.dayType, M.day FROM " + DBName + " as M " + query, connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);

            try {
                connection.Open();

                sda.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                    result.Add(new MonthlyFee(
                            int.Parse(row["id"].ToString()),
                            row["description"].ToString(),
                            Double.Parse(row["monthlyValue"].ToString()),
                            DateTime.Parse(row["monthStart"].ToString()),
                            DateTime.Parse(row["monthEnd"].ToString()),
                            (MonthlyFee.eDayType) int.Parse(row["dayType"].ToString()),
                            int.Parse(row["day"].ToString())
                        ));


            } catch (Exception e) {
                MessageBox.Show(e.Message, "MonthlyFeesDB.Select('" + query + "') Exception");

            } finally { connection.Close(); }

            return result;
        }

        public override void Update(MonthlyFee item) {
            // Check if yet exists
            List<MonthlyFee> similar = this.GetSimilarItem(item.Description, DateTime.Now);
            if (similar.Count > 0)
                if (similar[0].Id != item.Id)
                    throw new Exception("Já existe uma mensalidade com dados similares!");

            // Open the database connection
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("UPDATE " + DBName + " SET" +
                        " description = @description, monthlyValue = @monthlyValue, monthStart = @monthStart," +
                        " monthEnd = @monthEnd, dayType = @dayType, day = @day WHERE id = @id;", connection)) {

                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@monthlyValue", item.MonthlyValue);
                    cmd.Parameters.AddWithValue("@monthStart", item.MonthStart.Date);
                    cmd.Parameters.AddWithValue("@monthEnd", item.MonthEnd.Date);
                    cmd.Parameters.AddWithValue("@dayType", item.DayType);
                    cmd.Parameters.AddWithValue("@day", item.Day);

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "MonthlyFeesDB.Update('" + item.Id + "') Exception");

            } finally { connection.Close(); }
        }

        public override List<MonthlyFee> SelectByMonth(DateTime month) {
            /*return this.Select(String.Format(
                "MonthStart <= 06/07/2018 AND MonthEnd >= 06/07/2018",
                month.Month, month.Year), "description ASC");*/

            return this.Select(String.Format(
                "(DATEPART(year, MonthStart) < {1} OR (DATEPART(month, MonthStart) <= {0} AND DATEPART(year, MonthStart) <= {1})) AND " +
                "(DATEPART(year, MonthEnd)   > {1} OR (DATEPART(month, MonthEnd)   >=  {0} AND DATEPART(year, MonthEnd)  >=  {1}))",
                month.Month, month.Year), "day ASC, description ASC");
            //return this.Select(String.Format("1 = 1"), "description ASC");
        }

        public override List<MonthlyFee> GetSimilarItem(String description, DateTime date) {
            return this.Select(String.Format("description = '{0}'", description), null);
        }
    }
}
