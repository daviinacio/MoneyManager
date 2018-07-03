using MoneyManeger.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyManeger.ImportForms {
    public partial class ImportExpensesByText : Form {

        private DataBase.ExpensesDB db = new DataBase.ExpensesDB();
        private List<Expense> expenses = new List<Expense>();

        public ImportExpensesByText() {
            InitializeComponent();
        }

        // FORM EVENTS

        private void ImportExpensesByText_Load(object sender, EventArgs e) {

        }

        // ELEMENT EVENTS
        private void tabs_Selected(object sender, TabControlEventArgs e) {
            // Layout change
            switch (tabs.SelectedIndex) {
                case 0:
                    buttonImport.Text = "Processar";
                    buttonCancel.Text = "Cancelar";
                    break;
                case 1:
                    buttonImport.Text = "Importar";
                    buttonCancel.Text = "Voltar";
                    break;
            }
        }

        // BUTTON EVENTS
        private void buttonImport_Click(object sender, EventArgs e) {
            if (tabs.SelectedIndex == 0) {
                try {
                    String[] lines = textboxContent.Text.Split('\n');

                    // Clear old listview content
                    listviewExpenses.Items.Clear();

                    foreach (String l in lines) {
                        // Separate the row item
                        String [] la = l.Split('\t');

                        // Check row length
                        if (la.Length < 3) continue;

                        // Create items
                        Expense item = new Expense();

                        item.Description = la[0].Trim();
                        item.Date = DateTime.Parse(la[1].Trim());
                        item.Price = Double.Parse(la[2].Trim().Substring(2));
                        item.Count = 1;

                        expenses.Add(item);

                        // Put data on listview
                        ListViewItem row = new ListViewItem(item.Description);

                        row.SubItems.Add(item.Description.ToString());
                        row.SubItems.Add(item.Date.ToString().Split(' ')[0]);
                        row.SubItems.Add(String.Format("{0:0.000}", item.Count));
                        row.SubItems.Add(String.Format("R$ {0:N}", item.Price));
                        row.SubItems.Add(String.Format("R$ {0:N}", item.TotalPrice));

                        listviewExpenses.Items.Add(row);
                    }

                    tabs.SelectedIndex = 1;

                } catch(Exception ex) {
                    MessageBox.Show(ex.Message, "Erro no processamento", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (tabs.SelectedIndex == 1) {
                try {
                    if (expenses.Count == 0)
                        throw new Exception("Nenhum item processado");

                    else {
                        foreach (Expense item in expenses) {
                            MessageBox.Show(item.ToString(), "Item inserido");
                            db.Insert(item);
                        }

                        MessageBox.Show("Totos os itens listados foram inseridos com sucesso.", "Importados com êxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }

                } catch (Exception ex) {
                    MessageBox.Show(ex.Message, "Erro na importação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonCancel_Click(object sender, EventArgs e) {
            switch (tabs.SelectedIndex) {
                case 0: this.Close(); break;
                case 1: tabs.SelectedIndex = 0; break;
            }
        }
        private void buttonClose_Click(object sender, EventArgs e) { this.Close(); }
    }
}
