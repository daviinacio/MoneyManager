using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

using MoneyManeger.Models;
using System.Windows.Forms;

namespace MoneyManeger.DataBase {
    class ExpensesDB : DBHelper<Expense> {

        // Put the database name on the base
        public ExpensesDB() : base("Expenses"){ }

        // Futuramente, implementar contrutor que recebe usuário, para autenticação..
        // E poder usar o mesmo programas para varias contas..

        // SQL Functions
        public override void Delete(Expense item) {
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
                MessageBox.Show(e.Message, "ExpensesDB.Delete('" + id + "') Exception");

            } finally { connection.Close(); }
        }

        public override Expense Insert(Expense item) {
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO " + DBName +
                        " (description, value, count, date) Values(@description, @value, @count, @date)", connection)) {

                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@value", item.Value);
                    cmd.Parameters.AddWithValue("@count", item.Count);
                    cmd.Parameters.AddWithValue("@date", item.Date.ToShortDateString());

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "ExpensesDB.Insert('" + item.Id + "') Exception");
                return null;

            } finally { connection.Close(); }

            // Return the last table item (the inserted item with id)
            return this.Max;
        }

        public override List<Expense> Select(string where) {
            List<Expense> result = new List<Expense>();

            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("SELECT * FROM " + DBName + " WHERE " + where, connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);

            try {
                connection.Open();

                sda.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                    result.Add(new Expense(
                            int.Parse(row["id"].ToString()),
                            row["description"].ToString(),
                            Double.Parse(row["value"].ToString()),
                            Double.Parse(row["count"].ToString()),
                            DateTime.Parse(row["date"].ToString())
                        ));


            } catch (Exception e) {
                MessageBox.Show(e.Message, "ExpensesDB.Select('" + where + "') Exception");

            } finally { connection.Close(); }

            return result;
        }

        public override void Update(Expense item) {
            connection.Open();

            try {
                using(SqlCommand cmd = new SqlCommand("UPDATE " + DBName + " SET" +
                        " description = @description, value = @value, count = @count, date = @date WHERE id = @id;", connection)) {

                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@value", item.Value);
                    cmd.Parameters.AddWithValue("@count", item.Count);
                    cmd.Parameters.AddWithValue("@date", item.Date.ToShortDateString());

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "ExpensesDB.Update('" + item.Id + "') Exception");

            } finally { connection.Close(); }
        }
    }
}
