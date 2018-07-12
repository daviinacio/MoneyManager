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
    class IncomesDB : DBHelper<Income> {

        public IncomesDB() : base("Incomes") { }

        // SQL Functions
        public override void Delete(Income item) {
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
                MessageBox.Show(e.Message, "IncomesDB.Delete('" + id + "') Exception");

            } finally { connection.Close(); }
        }

        public override Income Insert(Income item) {
            // Check if yet exists
            if (this.GetSimilarItem(item.Description, item.Date).Count > 0)
                throw new Exception("Já existe uma despesa com dados similares!");

            // Open the database connection
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO " + DBName +
                        " (description, value, date) Values(@description, @value, @date)", connection)) {

                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@value", item.Value);
                    cmd.Parameters.AddWithValue("@date", item.Date);

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "IncomesDB.Insert('" + item.Id + "') Exception");
                return null;

            } finally { connection.Close(); }

            // Return the last table item (the inserted item with id)
            return this.Max;
        }

        public override List<Income> Select(string query) {
            List<Income> result = new List<Income>();

            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("SELECT I.id, I.description, I.value, I.date FROM " + DBName + " as I " + query, connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);

            try {
                connection.Open();

                sda.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                    result.Add(new Income(
                            int.Parse(row["id"].ToString()),
                            row["description"].ToString(),
                            Double.Parse(row["value"].ToString()),
                            DateTime.Parse(row["date"].ToString())
                        ));


            } catch (Exception e) {
                MessageBox.Show(e.Message, "IncomesDB.Select('" + query + "') Exception");

            } finally { connection.Close(); }

            return result;
        }

        public override void Update(Income item) {
            // Check if yet exists
            List<Income> similar = this.GetSimilarItem(item.Description, item.Date);
            if (similar.Count > 0)
                if (similar[0].Id != item.Id)
                    throw new Exception("Já existe uma receita com dados similares!");

            // Open the database connection
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("UPDATE " + DBName + " SET" +
                        " description = @description, value = @value, date = @date WHERE id = @id;", connection)) {

                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@value", item.Value);
                    cmd.Parameters.AddWithValue("@date", item.Date);

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "IncomesDB.Update('" + item.Id + "') Exception");

            } finally { connection.Close(); }
        }

        /*public override List<Income> SelectByMonth(DateTime month) {
            return this.Select(String.Format("DATEPART(month, date) = {0} AND DATEPART(year, date) = {1}", month.Month, month.Year), "date ASC, description ASC");
        }*/
    }
}
