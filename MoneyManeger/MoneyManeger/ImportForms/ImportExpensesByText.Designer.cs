namespace MoneyManeger.ImportForms {
    partial class ImportExpensesByText {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "",
            "Nenhum item processado"}, -1);
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonImport = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonClose = new System.Windows.Forms.Button();
            this.panel_topWindow = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelBack = new System.Windows.Forms.Panel();
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textboxContent = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listviewExpenses = new System.Windows.Forms.ListView();
            this.expenseId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expensePrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.expenseTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel4.SuspendLayout();
            this.panel_topWindow.SuspendLayout();
            this.panelBack.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Gray;
            this.buttonCancel.Location = new System.Drawing.Point(330, 281);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 32);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonImport
            // 
            this.buttonImport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonImport.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.buttonImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.buttonImport.Location = new System.Drawing.Point(427, 281);
            this.buttonImport.Name = "buttonImport";
            this.buttonImport.Size = new System.Drawing.Size(102, 32);
            this.buttonImport.TabIndex = 4;
            this.buttonImport.Text = "Processar";
            this.buttonImport.UseVisualStyleBackColor = true;
            this.buttonImport.Click += new System.EventHandler(this.buttonImport_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(298, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.panel4.Controls.Add(this.buttonClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(298, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(247, 25);
            this.panel4.TabIndex = 100;
            // 
            // buttonClose
            // 
            this.buttonClose.BackgroundImage = global::MoneyManeger.Properties.Resources.white_icons8_delete_32_;
            this.buttonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.ForeColor = System.Drawing.Color.White;
            this.buttonClose.Location = new System.Drawing.Point(207, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 25);
            this.buttonClose.TabIndex = 100;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // panel_topWindow
            // 
            this.panel_topWindow.BackColor = System.Drawing.SystemColors.Control;
            this.panel_topWindow.Controls.Add(this.panel2);
            this.panel_topWindow.Controls.Add(this.panel4);
            this.panel_topWindow.Controls.Add(this.labelTitle);
            this.panel_topWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topWindow.Location = new System.Drawing.Point(1, 1);
            this.panel_topWindow.Name = "panel_topWindow";
            this.panel_topWindow.Size = new System.Drawing.Size(545, 25);
            this.panel_topWindow.TabIndex = 101;
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(298, 25);
            this.labelTitle.TabIndex = 100;
            this.labelTitle.Text = "Importar despesas a partir de texto";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBack
            // 
            this.panelBack.BackColor = System.Drawing.SystemColors.Control;
            this.panelBack.Controls.Add(this.tabs);
            this.panelBack.Controls.Add(this.buttonCancel);
            this.panelBack.Controls.Add(this.buttonImport);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBack.Location = new System.Drawing.Point(1, 26);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(545, 325);
            this.panelBack.TabIndex = 102;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabs.Location = new System.Drawing.Point(12, 15);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(517, 260);
            this.tabs.TabIndex = 7;
            this.tabs.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabs_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.textboxContent);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(509, 231);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cole aqui o conteudo da tabela";
            // 
            // textboxContent
            // 
            this.textboxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textboxContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxContent.Location = new System.Drawing.Point(0, 0);
            this.textboxContent.Margin = new System.Windows.Forms.Padding(0);
            this.textboxContent.Multiline = true;
            this.textboxContent.Name = "textboxContent";
            this.textboxContent.Size = new System.Drawing.Size(509, 231);
            this.textboxContent.TabIndex = 6;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listviewExpenses);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(509, 231);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Despesas reconhecidas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listviewExpenses
            // 
            this.listviewExpenses.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listviewExpenses.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.expenseId,
            this.expenseDescription,
            this.expenseDate,
            this.expenseCount,
            this.expensePrice,
            this.expenseTotal});
            this.listviewExpenses.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listviewExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listviewExpenses.FullRowSelect = true;
            this.listviewExpenses.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listviewExpenses.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listviewExpenses.Location = new System.Drawing.Point(0, 0);
            this.listviewExpenses.Margin = new System.Windows.Forms.Padding(0);
            this.listviewExpenses.Name = "listviewExpenses";
            this.listviewExpenses.Size = new System.Drawing.Size(509, 231);
            this.listviewExpenses.TabIndex = 4;
            this.listviewExpenses.UseCompatibleStateImageBehavior = false;
            this.listviewExpenses.View = System.Windows.Forms.View.Details;
            // 
            // expenseId
            // 
            this.expenseId.Tag = "0";
            this.expenseId.Text = "ID";
            this.expenseId.Width = 0;
            // 
            // expenseDescription
            // 
            this.expenseDescription.Tag = "20";
            this.expenseDescription.Text = "Descrição";
            this.expenseDescription.Width = 197;
            // 
            // expenseDate
            // 
            this.expenseDate.Tag = "10";
            this.expenseDate.Text = "Data";
            this.expenseDate.Width = 81;
            // 
            // expenseCount
            // 
            this.expenseCount.Tag = "5";
            this.expenseCount.Text = "Quant.";
            this.expenseCount.Width = 52;
            // 
            // expensePrice
            // 
            this.expensePrice.Tag = "8";
            this.expensePrice.Text = "Preço";
            this.expensePrice.Width = 73;
            // 
            // expenseTotal
            // 
            this.expenseTotal.Tag = "8";
            this.expenseTotal.Text = "Total";
            this.expenseTotal.Width = 79;
            // 
            // ImportExpensesByText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(547, 352);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel_topWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ImportExpensesByText";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Title";
            this.Load += new System.EventHandler(this.ImportExpensesByText_Load);
            this.panel4.ResumeLayout(false);
            this.panel_topWindow.ResumeLayout(false);
            this.panelBack.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonImport;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Panel panel_topWindow;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelBack;
        private System.Windows.Forms.TextBox textboxContent;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListView listviewExpenses;
        private System.Windows.Forms.ColumnHeader expenseId;
        private System.Windows.Forms.ColumnHeader expenseDescription;
        private System.Windows.Forms.ColumnHeader expenseDate;
        private System.Windows.Forms.ColumnHeader expenseCount;
        private System.Windows.Forms.ColumnHeader expensePrice;
        private System.Windows.Forms.ColumnHeader expenseTotal;
    }
}