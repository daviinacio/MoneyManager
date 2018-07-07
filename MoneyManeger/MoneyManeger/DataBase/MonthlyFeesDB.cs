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
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO " + DBName +
                        " (description, monthlyValue, monthStart, monthEnd, dayType, day, status)" +
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

        public override List<MonthlyFee> Select(string where, string order) {
            List<MonthlyFee> result = new List<MonthlyFee>();

            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("SELECT * FROM " + DBName + " WHERE " + where + (order != null ? " ORDER BY " + order : ""), connection);
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
                MessageBox.Show(e.Message, "MonthlyFeesDB.Select('" + where + "') Exception");

            } finally { connection.Close(); }

            return result;
        }

        public override void Update(MonthlyFee item) {
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
    }
}
