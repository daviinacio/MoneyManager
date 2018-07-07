namespace MoneyManeger.Utils {
    partial class ComboBoxMonthPicker {
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
            this.tlpBack = new System.Windows.Forms.TableLayoutPanel();
            this.cbMonth = new System.Windows.Forms.ComboBox();
            this.cbYear = new System.Windows.Forms.ComboBox();
            this.tlpBack.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpBack
            // 
            this.tlpBack.ColumnCount = 2;
            this.tlpBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tlpBack.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tlpBack.Controls.Add(this.cbMonth, 0, 1);
            this.tlpBack.Controls.Add(this.cbYear, 1, 1);
            this.tlpBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBack.Location = new System.Drawing.Point(0, 0);
            this.tlpBack.Margin = new System.Windows.Forms.Padding(0);
            this.tlpBack.Name = "tlpBack";
            this.tlpBack.RowCount = 3;
            this.tlpBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBack.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBack.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpBack.Size = new System.Drawing.Size(275, 30);
            this.tlpBack.TabIndex = 0;
            // 
            // cbMonth
            // 
            this.cbMonth.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbMonth.DropDownHeight = 250;
            this.cbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMonth.FormattingEnabled = true;
            this.cbMonth.IntegralHeight = false;
            this.cbMonth.Location = new System.Drawing.Point(0, 1);
            this.cbMonth.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.cbMonth.Name = "cbMonth";
            this.cbMonth.Size = new System.Drawing.Size(107, 28);
            this.cbMonth.TabIndex = 0;
            this.cbMonth.SelectedIndexChanged += new System.EventHandler(this.cbMonth_SelectedIndexChanged);
            // 
            // cbYear
            // 
            this.cbYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cbYear.DropDownHeight = 250;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbYear.FormattingEnabled = true;
            this.cbYear.IntegralHeight = false;
            this.cbYear.Location = new System.Drawing.Point(113, 1);
            this.cbYear.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(162, 28);
            this.cbYear.TabIndex = 1;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // ComboBoxMonthPicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpBack);
            this.Name = "ComboBoxMonthPicker";
            this.Size = new System.Drawing.Size(275, 30);
            this.Load += new System.EventHandler(this.ListboxMonthPicker_Load);
            this.tlpBack.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpBack;
        private System.Windows.Forms.ComboBox cbMonth;
        private System.Windows.Forms.ComboBox cbYear;
    }
}
