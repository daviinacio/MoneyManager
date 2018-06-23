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
            this.listvewExpenses = new System.Windows.Forms.ListView();
            this.expenseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expensePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelRight = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.68355F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.31646F));
            this.tableLayoutPanel1.Controls.Add(this.listvewExpenses, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelRight, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(872, 433);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // listvewExpenses
            // 
            this.listvewExpenses.BackColor = System.Drawing.SystemColors.Control;
            this.listvewExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listvewExpenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseId,
            this.expenseDescription,
            this.expenseDate,
            this.expenseCount,
            this.expensePrice,
            this.expenseTotal});
            this.listvewExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listvewExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listvewExpenses.FullRowSelect = true;
            this.listvewExpenses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listvewExpenses.Location = new System.Drawing.Point(0, 1);
            this.listvewExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.listvewExpenses.Name = "listvewExpenses";
            this.listvewExpenses.Size = new System.Drawing.Size(651, 432);
            this.listvewExpenses.TabIndex = 1;
            this.listvewExpenses.UseCompatibleStateImageBehavior = false;
            this.listvewExpenses.View = System.Windows.Forms.View.Details;
            this.listvewExpenses.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listvewExpenses_DrawColumnHeader);
            this.listvewExpenses.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.listvewExpenses_DrawItem);
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
            this.expenseDescription.Width = 263;
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
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.SystemColors.Control;
            this.panelRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRight.Location = new System.Drawing.Point(652, 1);
            this.panelRight.Margin = new System.Windows.Forms.Padding(1, 0, 0, 0);
            this.panelRight.Name = "panelRight";
            this.panelRight.Size = new System.Drawing.Size(220, 432);
            this.panelRight.TabIndex = 2;
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
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListView listvewExpenses;
        private System.Windows.Forms.ColumnHeader expenseId;
        private System.Windows.Forms.ColumnHeader expenseDescription;
        private System.Windows.Forms.ColumnHeader expenseDate;
        private System.Windows.Forms.ColumnHeader expenseCount;
        private System.Windows.Forms.ColumnHeader expensePrice;
        private System.Windows.Forms.ColumnHeader expenseTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelRight;
    }
}
