namespace MoneyManeger.MainTabs {
    partial class MonthlyFeeUserControl {
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
            this.listviewMonthlyFee = new System.Windows.Forms.ListView();
            this.monthlyFeeId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlyFeeDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlyFeeMonthStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlyFeeValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthlyFeeMonthEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listviewMonthlyFee
            // 
            this.listviewMonthlyFee.BackColor = System.Drawing.SystemColors.Control;
            this.listviewMonthlyFee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewMonthlyFee.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.monthlyFeeId,
            this.monthlyFeeDescription,
            this.monthlyFeeMonthStart,
            this.monthlyFeeMonthEnd,
            this.monthlyFeeValue});
            this.listviewMonthlyFee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewMonthlyFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewMonthlyFee.FullRowSelect = true;
            this.listviewMonthlyFee.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewMonthlyFee.Location = new System.Drawing.Point(0, 0);
            this.listviewMonthlyFee.Margin = new System.Windows.Forms.Padding(0);
            this.listviewMonthlyFee.Name = "listviewMonthlyFee";
            this.listviewMonthlyFee.Size = new System.Drawing.Size(600, 412);
            this.listviewMonthlyFee.TabIndex = 4;
            this.listviewMonthlyFee.UseCompatibleStateImageBehavior = false;
            this.listviewMonthlyFee.View = System.Windows.Forms.View.Details;
            // 
            // monthlyFeeId
            // 
            this.monthlyFeeId.Tag = "0";
            this.monthlyFeeId.Text = "ID";
            // 
            // monthlyFeeDescription
            // 
            this.monthlyFeeDescription.Tag = "20";
            this.monthlyFeeDescription.Text = "Descrição";
            this.monthlyFeeDescription.Width = 168;
            // 
            // monthlyFeeMonthStart
            // 
            this.monthlyFeeMonthStart.Tag = "10";
            this.monthlyFeeMonthStart.Text = "Inicio";
            this.monthlyFeeMonthStart.Width = 90;
            // 
            // monthlyFeeValue
            // 
            this.monthlyFeeValue.Tag = "5";
            this.monthlyFeeValue.Text = "Valor";
            this.monthlyFeeValue.Width = 97;
            // 
            // monthlyFeeMonthEnd
            // 
            this.monthlyFeeMonthEnd.Tag = "10";
            this.monthlyFeeMonthEnd.Text = "Fim";
            this.monthlyFeeMonthEnd.Width = 119;
            // 
            // MonthlyFeeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listviewMonthlyFee);
            this.Name = "MonthlyFeeUserControl";
            this.Size = new System.Drawing.Size(600, 412);
            this.Load += new System.EventHandler(this.MonthlyFeeUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listviewMonthlyFee;
        private System.Windows.Forms.ColumnHeader monthlyFeeId;
        private System.Windows.Forms.ColumnHeader monthlyFeeDescription;
        private System.Windows.Forms.ColumnHeader monthlyFeeValue;
        private System.Windows.Forms.ColumnHeader monthlyFeeMonthStart;
        private System.Windows.Forms.ColumnHeader monthlyFeeMonthEnd;
    }
}
