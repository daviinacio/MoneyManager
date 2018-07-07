namespace MoneyManeger {
    partial class EditMonthlyFeeForm {
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbDayType = new System.Windows.Forms.ComboBox();
            this.labelDay = new System.Windows.Forms.Label();
            this.textboxDay = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.mpInit = new MoneyManeger.Utils.ComboBoxMonthPicker();
            this.labelInitDate = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.mpEnd = new MoneyManeger.Utils.ComboBoxMonthPicker();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelValue = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textboxValue = new System.Windows.Forms.MaskedTextBox();
            this.textboxDescription = new System.Windows.Forms.TextBox();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panel_topWindow = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelStatus = new System.Windows.Forms.Label();
            this.valueStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel_topWindow.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.valueStatus);
            this.panel1.Controls.Add(this.labelStatus);
            this.panel1.Controls.Add(this.cbDayType);
            this.panel1.Controls.Add(this.labelDay);
            this.panel1.Controls.Add(this.textboxDay);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Controls.Add(this.buttonCancel);
            this.panel1.Controls.Add(this.buttonSave);
            this.panel1.Controls.Add(this.labelValue);
            this.panel1.Controls.Add(this.labelDescription);
            this.panel1.Controls.Add(this.textboxValue);
            this.panel1.Controls.Add(this.textboxDescription);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(1, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 221);
            this.panel1.TabIndex = 9;
            // 
            // cbDayType
            // 
            this.cbDayType.DisplayMember = "0";
            this.cbDayType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDayType.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDayType.FormattingEnabled = true;
            this.cbDayType.Items.AddRange(new object[] {
            "Dia útil",
            "Dia fixo"});
            this.cbDayType.Location = new System.Drawing.Point(135, 136);
            this.cbDayType.Name = "cbDayType";
            this.cbDayType.Size = new System.Drawing.Size(79, 26);
            this.cbDayType.TabIndex = 29;
            this.cbDayType.ValueMember = "0";
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDay.Location = new System.Drawing.Point(12, 117);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(32, 16);
            this.labelDay.TabIndex = 25;
            this.labelDay.Text = "Dia";
            // 
            // textboxDay
            // 
            this.textboxDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDay.Location = new System.Drawing.Point(19, 136);
            this.textboxDay.Name = "textboxDay";
            this.textboxDay.Size = new System.Drawing.Size(110, 26);
            this.textboxDay.TabIndex = 26;
            this.textboxDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxWorkingDay_KeyPress);
            this.textboxDay.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textboxWorkingDay_KeyUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(15, 63);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(413, 51);
            this.tableLayoutPanel1.TabIndex = 31;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.mpInit);
            this.panel3.Controls.Add(this.labelInitDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(202, 51);
            this.panel3.TabIndex = 0;
            // 
            // mpInit
            // 
            this.mpInit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpInit.Location = new System.Drawing.Point(4, 19);
            this.mpInit.Name = "mpInit";
            this.mpInit.ShortMonthText = true;
            this.mpInit.Size = new System.Drawing.Size(195, 30);
            this.mpInit.TabIndex = 21;
            this.mpInit.Value = new System.DateTime(((long)(0)));
            // 
            // labelInitDate
            // 
            this.labelInitDate.AutoSize = true;
            this.labelInitDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInitDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelInitDate.Location = new System.Drawing.Point(-3, 0);
            this.labelInitDate.Name = "labelInitDate";
            this.labelInitDate.Size = new System.Drawing.Size(82, 16);
            this.labelInitDate.TabIndex = 17;
            this.labelInitDate.Text = "Mês Inicial";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.mpEnd);
            this.panel5.Controls.Add(this.labelEndDate);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(211, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(202, 51);
            this.panel5.TabIndex = 1;
            // 
            // mpEnd
            // 
            this.mpEnd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mpEnd.Location = new System.Drawing.Point(10, 19);
            this.mpEnd.Name = "mpEnd";
            this.mpEnd.ShortMonthText = true;
            this.mpEnd.Size = new System.Drawing.Size(189, 30);
            this.mpEnd.TabIndex = 24;
            this.mpEnd.Value = new System.DateTime(2099, 12, 1, 0, 0, 0, 0);
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelEndDate.Location = new System.Drawing.Point(3, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(70, 16);
            this.labelEndDate.TabIndex = 22;
            this.labelEndDate.Text = "Mês final";
            // 
            // buttonDelete
            // 
            this.buttonDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.buttonDelete.Location = new System.Drawing.Point(152, 177);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(87, 32);
            this.buttonDelete.TabIndex = 20;
            this.buttonDelete.Text = "Apagar";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.ForeColor = System.Drawing.Color.Gray;
            this.buttonCancel.Location = new System.Drawing.Point(245, 177);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(91, 32);
            this.buttonCancel.TabIndex = 19;
            this.buttonCancel.Text = "Cancelar";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.buttonSave.Location = new System.Drawing.Point(342, 177);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(86, 32);
            this.buttonSave.TabIndex = 18;
            this.buttonSave.Text = "Salvar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelValue
            // 
            this.labelValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValue.AutoSize = true;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelValue.Location = new System.Drawing.Point(314, 12);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(45, 16);
            this.labelValue.TabIndex = 16;
            this.labelValue.Text = "Valor";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelDescription.Location = new System.Drawing.Point(12, 12);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(79, 16);
            this.labelDescription.TabIndex = 15;
            this.labelDescription.Text = "Descrição";
            // 
            // textboxValue
            // 
            this.textboxValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxValue.Location = new System.Drawing.Point(321, 31);
            this.textboxValue.Name = "textboxValue";
            this.textboxValue.Size = new System.Drawing.Size(107, 26);
            this.textboxValue.TabIndex = 14;
            this.textboxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textboxValue_KeyPress);
            // 
            // textboxDescription
            // 
            this.textboxDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textboxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxDescription.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textboxDescription.Location = new System.Drawing.Point(19, 31);
            this.textboxDescription.Name = "textboxDescription";
            this.textboxDescription.Size = new System.Drawing.Size(296, 26);
            this.textboxDescription.TabIndex = 13;
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
            this.buttonClose.Location = new System.Drawing.Point(271, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 25);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.ForeColor = System.Drawing.Color.White;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(129, 25);
            this.labelTitle.TabIndex = 5;
            this.labelTitle.Text = "Title";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panel_topWindow.Size = new System.Drawing.Size(440, 25);
            this.panel_topWindow.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(129, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1, 25);
            this.panel2.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.panel4.Controls.Add(this.buttonClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(129, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(311, 25);
            this.panel4.TabIndex = 11;
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.labelStatus.Location = new System.Drawing.Point(298, 117);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(51, 16);
            this.labelStatus.TabIndex = 27;
            this.labelStatus.Text = "Status";
            // 
            // valueStatus
            // 
            this.valueStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.valueStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.valueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueStatus.Location = new System.Drawing.Point(307, 136);
            this.valueStatus.Name = "valueStatus";
            this.valueStatus.Size = new System.Drawing.Size(121, 26);
            this.valueStatus.TabIndex = 32;
            this.valueStatus.Text = "Pendente";
            this.valueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EditMonthlyFeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(442, 248);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_topWindow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditMonthlyFeeForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditMonthlyFeeForm";
            this.Load += new System.EventHandler(this.EditMonthlyFeeForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel_topWindow.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panel_topWindow;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelInitDate;
        private System.Windows.Forms.Label labelValue;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.MaskedTextBox textboxValue;
        private System.Windows.Forms.TextBox textboxDescription;
        private System.Windows.Forms.Label labelEndDate;
        private Utils.ComboBoxMonthPicker mpInit;
        private Utils.ComboBoxMonthPicker mpEnd;
        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.TextBox textboxDay;
        private System.Windows.Forms.ComboBox cbDayType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label valueStatus;
        private System.Windows.Forms.Label labelStatus;
    }
}