namespace MoneyManeger {
    partial class ExpensesUserControl {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listviewExpenses = new MetroFramework.Controls.MetroListView();
            this.expenseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expensePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableRight = new System.Windows.Forms.TableLayoutPanel();
            this.listviewIncomes = new System.Windows.Forms.ListView();
            this.money_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.money_value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthPicker = new MoneyManeger.Utils.ModernMonthPicker();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableRight.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanel1.Controls.Add(this.listviewExpenses, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableRight, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 433);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // listviewExpenses
            // 
            this.listviewExpenses.BackColor = System.Drawing.SystemColors.Control;
            this.listviewExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewExpenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseId,
            this.expenseDescription,
            this.expenseDate,
            this.expenseCount,
            this.expensePrice,
            this.expenseTotal});
            this.listviewExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewExpenses.FullRowSelect = true;
            this.listviewExpenses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewExpenses.Location = new System.Drawing.Point(0, 1);
            this.listviewExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.listviewExpenses.Name = "listviewExpenses";
            this.listviewExpenses.OwnerDraw = true;
            this.listviewExpenses.Size = new System.Drawing.Size(643, 432);
            this.listviewExpenses.TabIndex = 3;
            this.listviewExpenses.Theme = MetroFramework.MetroThemeStyle.Light;
            this.listviewExpenses.UseCompatibleStateImageBehavior = false;
            this.listviewExpenses.UseSelectable = true;
            this.listviewExpenses.View = System.Windows.Forms.View.Details;
            // 
            // expenseId
            // 
            this.expenseId.Tag = "0";
            this.expenseId.Text = "ID";
            // 
            // expenseDescription
            // 
            this.expenseDescription.Tag = "20";
            this.expenseDescription.Text = "Descrição";
            this.expenseDescription.Width = 168;
            // 
            // expenseDate
            // 
            this.expenseDate.Tag = "10";
            this.expenseDate.Text = "Data";
            this.expenseDate.Width = 78;
            // 
            // expenseCount
            // 
            this.expenseCount.Tag = "5";
            this.expenseCount.Text = "Quant.";
            this.expenseCount.Width = 35;
            // 
            // expensePrice
            // 
            this.expensePrice.Tag = "8";
            this.expensePrice.Text = "Preço";
            this.expensePrice.Width = 68;
            // 
            // expenseTotal
            // 
            this.expenseTotal.Tag = "8";
            this.expenseTotal.Text = "Total";
            this.expenseTotal.Width = 72;
            // 
            // tableRight
            // 
            this.tableRight.ColumnCount = 1;
            this.tableRight.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.Controls.Add(this.listviewIncomes, 0, 1);
            this.tableRight.Controls.Add(this.monthPicker, 0, 0);
            this.tableRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableRight.Location = new System.Drawing.Point(644, 1);
            this.tableRight.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.tableRight.Name = "tableRight";
            this.tableRight.RowCount = 2;
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 162F));
            this.tableRight.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableRight.Size = new System.Drawing.Size(228, 432);
            this.tableRight.TabIndex = 2;
            // 
            // listviewIncomes
            // 
            this.listviewIncomes.BackColor = System.Drawing.SystemColors.Control;
            this.listviewIncomes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewIncomes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.money_name,
            this.money_date,
            this.money_value});
            this.listviewIncomes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewIncomes.FullRowSelect = true;
            this.listviewIncomes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewIncomes.Location = new System.Drawing.Point(0, 162);
            this.listviewIncomes.Margin = new System.Windows.Forms.Padding(0);
            this.listviewIncomes.Name = "listviewIncomes";
            this.listviewIncomes.Size = new System.Drawing.Size(228, 270);
            this.listviewIncomes.TabIndex = 8;
            this.listviewIncomes.UseCompatibleStateImageBehavior = false;
            this.listviewIncomes.View = System.Windows.Forms.View.Details;
            this.listviewIncomes.SizeChanged += new System.EventHandler(this.listView_SizeChanged);
            // 
            // money_name
            // 
            this.money_name.Tag = "10";
            this.money_name.Text = "Entrada";
            this.money_name.Width = 45;
            // 
            // money_date
            // 
            this.money_date.Tag = "8";
            this.money_date.Text = "Data";
            this.money_date.Width = 33;
            // 
            // money_value
            // 
            this.money_value.Tag = "8";
            this.money_value.Text = "Valor";
            this.money_value.Width = 74;
            // 
            // monthPicker
            // 
            this.monthPicker.BackColor = System.Drawing.SystemColors.Control;
            this.monthPicker.DefaultMonthColor = System.Drawing.Color.Lime;
            this.monthPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthPicker.Location = new System.Drawing.Point(0, 0);
            this.monthPicker.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.Size = new System.Drawing.Size(228, 161);
            this.monthPicker.TabIndex = 9;
            this.monthPicker.MonthChanged += new MoneyManeger.Utils.ModernMonthPicker.MonthChangedEvent(this.monthPicker_MonthChanged);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "lsfskdfhljsdflksdhfjksdhflkjsdhfkjshfksjhsdhflkshdkfkfdhdfkghdsfkgdksjg";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(872, 30);
            this.panel1.TabIndex = 1;
            // 
            // ExpensesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Name = "ExpensesUserControl";
            this.Size = new System.Drawing.Size(872, 463);
            this.Load += new System.EventHandler(this.ExpensesUserControl_Load);
            this.SizeChanged += new System.EventHandler(this.ExpensesUserControl_SizeChanged);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableRight.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableRight;
        private System.Windows.Forms.ListView listviewIncomes;
        private System.Windows.Forms.ColumnHeader money_name;
        private System.Windows.Forms.ColumnHeader money_date;
        private System.Windows.Forms.ColumnHeader money_value;
        private MetroFramework.Controls.MetroListView listviewExpenses;
        private System.Windows.Forms.ColumnHeader expenseId;
        private System.Windows.Forms.ColumnHeader expenseDescription;
        private System.Windows.Forms.ColumnHeader expenseDate;
        private System.Windows.Forms.ColumnHeader expenseCount;
        private System.Windows.Forms.ColumnHeader expensePrice;
        private System.Windows.Forms.ColumnHeader expenseTotal;
        private Utils.ModernMonthPicker monthPicker;
    }
}
