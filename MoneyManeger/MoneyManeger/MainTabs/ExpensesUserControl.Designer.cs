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
            this.tableLayoutPanelTop = new System.Windows.Forms.TableLayoutPanel();
            this.listviewExpenses = new System.Windows.Forms.ListView();
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.labelTotalUnit = new System.Windows.Forms.Label();
            this.labelTotalItens = new System.Windows.Forms.Label();
            this.valueTotalPrice = new System.Windows.Forms.Label();
            this.valueTotalUnit = new System.Windows.Forms.Label();
            this.valueTotalItens = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTop.SuspendLayout();
            this.tableRight.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelTop
            // 
            this.tableLayoutPanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.tableLayoutPanelTop.ColumnCount = 2;
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 229F));
            this.tableLayoutPanelTop.Controls.Add(this.listviewExpenses, 0, 1);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelTop.Controls.Add(this.tableRight, 1, 1);
            this.tableLayoutPanelTop.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTop.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTop.Name = "tableLayoutPanelTop";
            this.tableLayoutPanelTop.RowCount = 2;
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanelTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTop.Size = new System.Drawing.Size(872, 463);
            this.tableLayoutPanelTop.TabIndex = 2;
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
            this.listviewExpenses.Location = new System.Drawing.Point(0, 31);
            this.listviewExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.listviewExpenses.Name = "listviewExpenses";
            this.listviewExpenses.Size = new System.Drawing.Size(643, 432);
            this.listviewExpenses.TabIndex = 3;
            this.listviewExpenses.UseCompatibleStateImageBehavior = false;
            this.listviewExpenses.View = System.Windows.Forms.View.Details;
            this.listviewExpenses.SelectedIndexChanged += new System.EventHandler(this.listviewExpenses_SelectedIndexChanged);
            this.listviewExpenses.DoubleClick += new System.EventHandler(this.listviewExpenses_DoubleClick);
            this.listviewExpenses.MouseEnter += new System.EventHandler(this.ExpensesUserControl_MouseEnter);
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
            this.tableRight.Location = new System.Drawing.Point(644, 31);
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
            this.monthPicker.BackColor = System.Drawing.Color.Transparent;
            this.monthPicker.ChooseYearBackColor = System.Drawing.SystemColors.Control;
            this.monthPicker.ChooseYearForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.monthPicker.CurrentMonthBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.monthPicker.CurrentMonthBorderColor = System.Drawing.Color.White;
            this.monthPicker.CurrentMonthBorderSize = 0;
            this.monthPicker.CurrentMonthForeColor = System.Drawing.Color.White;
            this.monthPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthPicker.Location = new System.Drawing.Point(0, 0);
            this.monthPicker.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.monthPicker.MonthBackColor = System.Drawing.Color.Empty;
            this.monthPicker.MonthBorderColor = System.Drawing.Color.White;
            this.monthPicker.MonthBorderSize = 0;
            this.monthPicker.MonthForeColor = System.Drawing.Color.DimGray;
            this.monthPicker.Name = "monthPicker";
            this.monthPicker.SelectedMonthBackColor = System.Drawing.SystemColors.Control;
            this.monthPicker.SelectedMonthBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.monthPicker.SelectedMonthBorderSize = 1;
            this.monthPicker.SelectedMonthForeColor = System.Drawing.Color.DimGray;
            this.monthPicker.Size = new System.Drawing.Size(228, 161);
            this.monthPicker.TabIndex = 9;
            this.monthPicker.YearForeColor = System.Drawing.Color.Black;
            this.monthPicker.MonthChanged += new MoneyManeger.Utils.ModernMonthPicker.MonthChangedEvent(this.monthPicker_MonthChanged);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel2.ColumnCount = 8;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 145F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.labelTotalPrice, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTotalUnit, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelTotalItens, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.valueTotalPrice, 7, 0);
            this.tableLayoutPanel2.Controls.Add(this.valueTotalUnit, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.valueTotalItens, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(643, 30);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPrice.Location = new System.Drawing.Point(404, 0);
            this.labelTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(145, 30);
            this.labelTotalPrice.TabIndex = 0;
            this.labelTotalPrice.Text = "Valor total do mês:";
            this.labelTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalUnit
            // 
            this.labelTotalUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalUnit.Location = new System.Drawing.Point(208, 0);
            this.labelTotalUnit.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalUnit.Name = "labelTotalUnit";
            this.labelTotalUnit.Size = new System.Drawing.Size(102, 30);
            this.labelTotalUnit.TabIndex = 1;
            this.labelTotalUnit.Text = "Total de un.:";
            this.labelTotalUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTotalItens
            // 
            this.labelTotalItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalItens.Location = new System.Drawing.Point(0, 0);
            this.labelTotalItens.Margin = new System.Windows.Forms.Padding(0);
            this.labelTotalItens.Name = "labelTotalItens";
            this.labelTotalItens.Size = new System.Drawing.Size(114, 30);
            this.labelTotalItens.TabIndex = 2;
            this.labelTotalItens.Text = "Total de itens:";
            this.labelTotalItens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueTotalPrice
            // 
            this.valueTotalPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTotalPrice.Location = new System.Drawing.Point(549, 0);
            this.valueTotalPrice.Margin = new System.Windows.Forms.Padding(0);
            this.valueTotalPrice.Name = "valueTotalPrice";
            this.valueTotalPrice.Size = new System.Drawing.Size(94, 30);
            this.valueTotalPrice.TabIndex = 3;
            this.valueTotalPrice.Text = "R$ 0,00";
            this.valueTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueTotalUnit
            // 
            this.valueTotalUnit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTotalUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTotalUnit.Location = new System.Drawing.Point(310, 0);
            this.valueTotalUnit.Margin = new System.Windows.Forms.Padding(0);
            this.valueTotalUnit.Name = "valueTotalUnit";
            this.valueTotalUnit.Size = new System.Drawing.Size(93, 30);
            this.valueTotalUnit.TabIndex = 4;
            this.valueTotalUnit.Text = "0";
            this.valueTotalUnit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueTotalItens
            // 
            this.valueTotalItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.valueTotalItens.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueTotalItens.Location = new System.Drawing.Point(114, 0);
            this.valueTotalItens.Margin = new System.Windows.Forms.Padding(0);
            this.valueTotalItens.Name = "valueTotalItens";
            this.valueTotalItens.Size = new System.Drawing.Size(93, 30);
            this.valueTotalItens.TabIndex = 5;
            this.valueTotalItens.Text = "0";
            this.valueTotalItens.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(403, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 30);
            this.panel2.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(207, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1, 30);
            this.panel3.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.29825F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.70175F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(644, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(1, 0, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(228, 30);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // ExpensesUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanelTop);
            this.Name = "ExpensesUserControl";
            this.Size = new System.Drawing.Size(872, 463);
            this.Load += new System.EventHandler(this.ExpensesUserControl_Load);
            this.SizeChanged += new System.EventHandler(this.ExpensesUserControl_SizeChanged);
            this.MouseEnter += new System.EventHandler(this.ExpensesUserControl_MouseEnter);
            this.tableLayoutPanelTop.ResumeLayout(false);
            this.tableRight.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTop;
        private System.Windows.Forms.TableLayoutPanel tableRight;
        private System.Windows.Forms.ListView listviewIncomes;
        private System.Windows.Forms.ColumnHeader money_name;
        private System.Windows.Forms.ColumnHeader money_date;
        private System.Windows.Forms.ColumnHeader money_value;
        private System.Windows.Forms.ListView listviewExpenses;
        private System.Windows.Forms.ColumnHeader expenseId;
        private System.Windows.Forms.ColumnHeader expenseDescription;
        private System.Windows.Forms.ColumnHeader expenseDate;
        private System.Windows.Forms.ColumnHeader expenseCount;
        private System.Windows.Forms.ColumnHeader expensePrice;
        private System.Windows.Forms.ColumnHeader expenseTotal;
        public Utils.ModernMonthPicker monthPicker;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelTotalPrice;
        private System.Windows.Forms.Label labelTotalUnit;
        private System.Windows.Forms.Label labelTotalItens;
        private System.Windows.Forms.Label valueTotalPrice;
        private System.Windows.Forms.Label valueTotalUnit;
        private System.Windows.Forms.Label valueTotalItens;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
