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
using MoneyManeger.Utils;

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
            // Check if yet exists
            if (this.GetSimilarItem(item.Description, item.Date).Count > 0)
                throw new Exception("Já existe uma despesa com dados similares!");

            // Open the database connection
            connection.Open();

            try {
                using (SqlCommand cmd = new SqlCommand("INSERT INTO " + DBName +
                        " (description, price, count, date) Values(@description, @price, @count, @date)", connection)) {

                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@price", item.Price);
                    cmd.Parameters.AddWithValue("@count", item.Count);
                    cmd.Parameters.AddWithValue("@date", item.Date);

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "ExpensesDB.Insert('" + item.Id + "') Exception");
                return null;

            } finally { connection.Close(); }

            // Return the last table item (the inserted item with id)
            return this.Max;
        }

        public override List<Expense> Select(string query) {
            List<Expense> result = new List<Expense>();

            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("SELECT E.id, E.description, E.price, E.count, E.date FROM " + DBName + " as E " + query, connection);
            SqlDataAdapter sda = new SqlDataAdapter(command);

            try {
                connection.Open();

                sda.Fill(ds);

                foreach (DataRow row in ds.Tables[0].Rows)
                    result.Add(new Expense(
                            int.Parse(row["id"].ToString()),
                            row["description"].ToString().Trim(),
                            Double.Parse(row["price"].ToString()),
                            Double.Parse(row["count"].ToString()),
                            DateTime.Parse(row["date"].ToString())
                        ));


            } catch (Exception e) {
                MessageBox.Show(e.Message, "ExpensesDB.Select('" + query + "') Exception");

            } finally { connection.Close(); }

            return result;
        }

        public override void Update(Expense item) {
            // Check if yet exists
            List<Expense> similar = this.GetSimilarItem(item.Description, item.Date);
            if (similar.Count > 0)
                if(similar[0].Id != item.Id)
                    throw new Exception("Já existe uma despesa com dados similares!");

            // Open the database connection
            connection.Open();

            try {
                using(SqlCommand cmd = new SqlCommand("UPDATE " + DBName + " SET" +
                        " description = @description, price = @price, count = @count, date = @date WHERE id = @id;", connection)) {

                    cmd.Parameters.AddWithValue("@id", item.Id);
                    cmd.Parameters.AddWithValue("@description", item.Description);
                    cmd.Parameters.AddWithValue("@price", item.Price);
                    cmd.Parameters.AddWithValue("@count", item.Count);
                    cmd.Parameters.AddWithValue("@date", item.Date);

                    cmd.ExecuteNonQuery();
                }

            } catch (Exception e) {
                MessageBox.Show(e.Message, "ExpensesDB.Update('" + item.Id + "') Exception");

            } finally { connection.Close(); }
        }

        public List<Expense> SelectCommonByMonth(DateTime month) {
            DateTime nextMonth = month.AddMonths(1);

            //return this.Select(String.Format("LEFT JOIN MonthlyFees as M on (e.Description = m.Description AND (e.Date >= m.MonthStart AND e.Date <= m.MonthEnd) AND (DATEPART(day, e.date) = (CASE WHEN m.DayType = 0 THEN (DATEPART(day, dbo.GetWorkingDay(e.date, m.day))) ELSE m.Day END))) WHERE m.Id is null AND (e.date >= '{0}/{1}/{2}' AND e.date < '{3}/{4}/{5}')", month.Month, MonthDate.GetWorkingDay(month, 5).Day, month.Year, month.Month + 1, MonthDate.GetWorkingDay(month.AddMonths(1), 5).Day, month.AddMonths(1).Year));

            // e.Description = m.Description AND (e.Date >= m.MonthStart AND e.Date < m.MonthEnd

            return this.Select(String.Format("LEFT JOIN MonthlyFees as M on (" +
                "(DATEPART(year, m.MonthStart) < DATEPART(year, e.Date) OR (DATEPART(month, m.MonthStart) <= DATEPART(month, e.Date) AND DATEPART(year, m.MonthStart) <= DATEPART(year, e.Date))) AND (DATEPART(year, m.MonthEnd) > DATEPART(year, e.Date) OR (DATEPART(month, m.MonthEnd) >=  DATEPART(month, e.Date) AND DATEPART(year, m.MonthEnd)  >=  DATEPART(year, e.Date))) AND " +
                "(DATEPART(day, e.date) = (CASE WHEN m.DayType = 0 THEN (DATEPART(day, dbo.GetWorkingDay(e.date, m.day))) ELSE m.Day END))) " +
                "WHERE m.Id is null AND (e.date >= dbo.GetWorkingDay('{1}/1/{3}', {0}) AND e.date < dbo.GetWorkingDay('{2}/1/{3}', {0})) " +
                "ORDER BY date ASC, description ASC", 5, month.Month, nextMonth.Month, month.Year));

            //SELECT * FROM Expenses as E LEFT JOIN MonthlyFees as M on (e.Description = m.Description AND (e.Date >= m.MonthStart AND e.Date <= m.MonthEnd) AND (DATEPART(day, e.date) = (CASE WHEN m.DayType = 0 THEN (DATEPART(day, dbo.GetWorkingDay(e.date, m.day))) ELSE m.Day END)))

            //return this.Select(String.Format(" LEFT JOIN MonthlyFees as M on (e.Description = m.Description AND (e.Date >= m.MonthStart AND e.Date <= m.MonthEnd)) WHERE m.Id is null AND (date >= '{1}/{0}/{2}' AND date < '{4}/{3}/{5}')", MonthDate.GetFifthWorkingDay(month), month.Month, month.Year,
            //MonthDate.GetFifthWorkingDay(nextMonth), nextMonth.Month, nextMonth.Year));



            //DateTime nextMonth = month.AddMonths(1);

            /*
            Select E.Id, E.Price, E.Count, E.Description, E.Date From Expenses as E LEFT JOIN MonthlyFees as M on (
            e.Description = m.Description AND
            (e.Date >= m.MonthStart AND
             e.Date <= m.MonthEnd)
            ) WHERE m.Id is null
            */

            // return this.Select(String.Format("(date >= '{1}/{0}/{2}' AND date < '{4}/{3}/{5}') AND ((SELECT COUNT(*) FROM 'MonthlyFees' WHERE ))",
            //return this.Select(String.Format("date >= '06/01/2018' AND date < '08/01/2018' ",
            //MonthDate.GetFifthWorkingDay(month), month.Month, month.Year,
            //MonthDate.GetFifthWorkingDay(nextMonth), nextMonth.Month, nextMonth.Year),

            //"date ASC, description ASC");
        }

    }
}
