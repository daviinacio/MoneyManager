﻿using System;
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
                MessageBox.Show(e.Message, "MoneysDB.Delete('" + id + "') Exception");

            } finally { connection.Close(); }
        }

        public override Income Insert(Income item) {
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
                MessageBox.Show(e.Message, "MoneysDB.Insert('" + item.Id + "') Exception");
                return null;

            } finally { connection.Close(); }

            // Return the last table item (the inserted item with id)
            return this.Max;
        }

        public override List<Income> Select(string where) {
            List<Income> result = new List<Income>();

            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("SELECT * FROM " + DBName + " WHERE " + where, connection);
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
                MessageBox.Show(e.Message, "MoneysDB.Select('" + where + "') Exception");

            } finally { connection.Close(); }

            return result;
        }

        public override void Update(Income item) {
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
                MessageBox.Show(e.Message, "MoneysDB.Update('" + item.Id + "') Exception");

            } finally { connection.Close(); }
        }
    }
}