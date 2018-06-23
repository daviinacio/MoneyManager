namespace MoneyManeger {
    partial class GeneralForm {
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
            this.panelTabs = new System.Windows.Forms.Panel();
            this.tabMonthlyFee = new System.Windows.Forms.Button();
            this.tabExpenses = new System.Windows.Forms.Button();
            this.tabDashboard = new System.Windows.Forms.Button();
            this.panelAppIcon = new System.Windows.Forms.Panel();
            this.labelAppIcon = new System.Windows.Forms.Label();
            this.panel_topWindow = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonRestore = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.MenuStrip();
            this.Menu_Manage = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Manage_Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Manage_Insert_Expense = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Manage_Insert_MonthlyFee = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Manage_Insert_Reserva = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Manage_Insert_Money = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.visualizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gastosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mensalidadesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dinheirosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.importarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabelatxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabeladdbtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dDBtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.fecharToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonClose = new System.Windows.Forms.Button();
            this.labelTabTitle = new System.Windows.Forms.Label();
            this.dashboardUserControl = new MoneyManeger.MainTabs.DashboardUserControl();
            this.expensesUserControl = new MoneyManeger.ExpensesUserControl();
            this.monthlyFeeUserControl = new MoneyManeger.MainTabs.MonthlyFeeUserControl();
            this.panel1.SuspendLayout();
            this.panelTabs.SuspendLayout();
            this.panelAppIcon.SuspendLayout();
            this.panel_topWindow.SuspendLayout();
            this.panel4.SuspendLayout();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelTabs);
            this.panel1.Controls.Add(this.panelAppIcon);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 537);
            this.panel1.TabIndex = 0;
            // 
            // panelTabs
            // 
            this.panelTabs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.panelTabs.Controls.Add(this.tabMonthlyFee);
            this.panelTabs.Controls.Add(this.tabExpenses);
            this.panelTabs.Controls.Add(this.tabDashboard);
            this.panelTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTabs.Location = new System.Drawing.Point(0, 26);
            this.panelTabs.Margin = new System.Windows.Forms.Padding(0);
            this.panelTabs.Name = "panelTabs";
            this.panelTabs.Size = new System.Drawing.Size(68, 511);
            this.panelTabs.TabIndex = 11;
            // 
            // tabMonthlyFee
            // 
            this.tabMonthlyFee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(217)))));
            this.tabMonthlyFee.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMonthlyFee.FlatAppearance.BorderSize = 0;
            this.tabMonthlyFee.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(167)))), ((int)(((byte)(193)))));
            this.tabMonthlyFee.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.tabMonthlyFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabMonthlyFee.ForeColor = System.Drawing.Color.White;
            this.tabMonthlyFee.Image = global::MoneyManeger.Properties.Resources.white_icons8_expensive_32;
            this.tabMonthlyFee.Location = new System.Drawing.Point(0, 136);
            this.tabMonthlyFee.Name = "tabMonthlyFee";
            this.tabMonthlyFee.Size = new System.Drawing.Size(68, 68);
            this.tabMonthlyFee.TabIndex = 10;
            this.tabMonthlyFee.UseVisualStyleBackColor = false;
            this.tabMonthlyFee.Click += new System.EventHandler(this.tabMonthlyFee_Click);
            // 
            // tabExpenses
            // 
            this.tabExpenses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(217)))));
            this.tabExpenses.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabExpenses.FlatAppearance.BorderSize = 0;
            this.tabExpenses.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(167)))), ((int)(((byte)(193)))));
            this.tabExpenses.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.tabExpenses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabExpenses.ForeColor = System.Drawing.Color.White;
            this.tabExpenses.Image = global::MoneyManeger.Properties.Resources.white_icons8_buy_32;
            this.tabExpenses.Location = new System.Drawing.Point(0, 68);
            this.tabExpenses.Name = "tabExpenses";
            this.tabExpenses.Size = new System.Drawing.Size(68, 68);
            this.tabExpenses.TabIndex = 9;
            this.tabExpenses.UseVisualStyleBackColor = false;
            this.tabExpenses.Click += new System.EventHandler(this.tabExpenses_Click);
            // 
            // tabDashboard
            // 
            this.tabDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(217)))));
            this.tabDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabDashboard.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.tabDashboard.FlatAppearance.BorderSize = 0;
            this.tabDashboard.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(167)))), ((int)(((byte)(193)))));
            this.tabDashboard.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(201)))), ((int)(((byte)(232)))));
            this.tabDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabDashboard.ForeColor = System.Drawing.Color.White;
            this.tabDashboard.Image = global::MoneyManeger.Properties.Resources.white_icons8_combo_chart_32;
            this.tabDashboard.Location = new System.Drawing.Point(0, 0);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Size = new System.Drawing.Size(68, 68);
            this.tabDashboard.TabIndex = 8;
            this.tabDashboard.UseVisualStyleBackColor = false;
            this.tabDashboard.Click += new System.EventHandler(this.tabDashboard_Click);
            // 
            // panelAppIcon
            // 
            this.panelAppIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelAppIcon.Controls.Add(this.labelAppIcon);
            this.panelAppIcon.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAppIcon.Location = new System.Drawing.Point(0, 0);
            this.panelAppIcon.Name = "panelAppIcon";
            this.panelAppIcon.Padding = new System.Windows.Forms.Padding(0, 0, 0, 1);
            this.panelAppIcon.Size = new System.Drawing.Size(68, 26);
            this.panelAppIcon.TabIndex = 7;
            // 
            // labelAppIcon
            // 
            this.labelAppIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.labelAppIcon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAppIcon.Font = new System.Drawing.Font("Magneto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAppIcon.ForeColor = System.Drawing.Color.White;
            this.labelAppIcon.Location = new System.Drawing.Point(0, 0);
            this.labelAppIcon.Name = "labelAppIcon";
            this.labelAppIcon.Size = new System.Drawing.Size(68, 25);
            this.labelAppIcon.TabIndex = 0;
            this.labelAppIcon.Text = "MM";
            this.labelAppIcon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelAppIcon.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            // 
            // panel_topWindow
            // 
            this.panel_topWindow.Controls.Add(this.panel2);
            this.panel_topWindow.Controls.Add(this.panel4);
            this.panel_topWindow.Controls.Add(this.labelTabTitle);
            this.panel_topWindow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_topWindow.Location = new System.Drawing.Point(69, 1);
            this.panel_topWindow.Name = "panel_topWindow";
            this.panel_topWindow.Size = new System.Drawing.Size(836, 25);
            this.panel_topWindow.TabIndex = 1;
            this.panel_topWindow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
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
            this.panel4.Controls.Add(this.buttonMinimize);
            this.panel4.Controls.Add(this.buttonMaximize);
            this.panel4.Controls.Add(this.buttonRestore);
            this.panel4.Controls.Add(this.menu);
            this.panel4.Controls.Add(this.buttonClose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(129, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(707, 25);
            this.panel4.TabIndex = 11;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackgroundImage = global::MoneyManeger.Properties.Resources.white_icons8_minimize_window_32;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(167)))), ((int)(((byte)(193)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.White;
            this.buttonMinimize.Location = new System.Drawing.Point(577, 0);
            this.buttonMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(30, 25);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.UseVisualStyleBackColor = true;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.BackgroundImage = global::MoneyManeger.Properties.Resources.white_icons8_maximize_window_32;
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(167)))), ((int)(((byte)(193)))));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.ForeColor = System.Drawing.Color.White;
            this.buttonMaximize.Location = new System.Drawing.Point(607, 0);
            this.buttonMaximize.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(30, 25);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.UseVisualStyleBackColor = true;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonRestore
            // 
            this.buttonRestore.BackgroundImage = global::MoneyManeger.Properties.Resources.white_icons8_restore_window_32;
            this.buttonRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRestore.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonRestore.FlatAppearance.BorderSize = 0;
            this.buttonRestore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(167)))), ((int)(((byte)(193)))));
            this.buttonRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestore.ForeColor = System.Drawing.Color.White;
            this.buttonRestore.Location = new System.Drawing.Point(637, 0);
            this.buttonRestore.Margin = new System.Windows.Forms.Padding(0);
            this.buttonRestore.Name = "buttonRestore";
            this.buttonRestore.Size = new System.Drawing.Size(30, 25);
            this.buttonRestore.TabIndex = 2;
            this.buttonRestore.UseVisualStyleBackColor = true;
            this.buttonRestore.Visible = false;
            this.buttonRestore.Click += new System.EventHandler(this.buttonRestore_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.menu.Dock = System.Windows.Forms.DockStyle.None;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Manage});
            this.menu.Location = new System.Drawing.Point(1, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(86, 25);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            this.menu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            // 
            // Menu_Manage
            // 
            this.Menu_Manage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Manage_Insert,
            this.visualizarToolStripMenuItem,
            this.toolStripSeparator3,
            this.importarToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.toolStripSeparator4,
            this.configuraçõesToolStripMenuItem,
            this.toolStripSeparator5,
            this.fecharToolStripMenuItem});
            this.Menu_Manage.ForeColor = System.Drawing.Color.White;
            this.Menu_Manage.Name = "Menu_Manage";
            this.Menu_Manage.Size = new System.Drawing.Size(78, 21);
            this.Menu_Manage.Text = "Gerenciar";
            // 
            // Menu_Manage_Insert
            // 
            this.Menu_Manage_Insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Manage_Insert_Expense,
            this.Menu_Manage_Insert_MonthlyFee,
            this.Menu_Manage_Insert_Reserva,
            this.Menu_Manage_Insert_Money,
            this.toolStripSeparator2});
            this.Menu_Manage_Insert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Manage_Insert.Name = "Menu_Manage_Insert";
            this.Menu_Manage_Insert.Size = new System.Drawing.Size(160, 22);
            this.Menu_Manage_Insert.Text = "Inserir";
            // 
            // Menu_Manage_Insert_Expense
            // 
            this.Menu_Manage_Insert_Expense.Name = "Menu_Manage_Insert_Expense";
            this.Menu_Manage_Insert_Expense.Size = new System.Drawing.Size(151, 22);
            this.Menu_Manage_Insert_Expense.Text = "Gasto";
            // 
            // Menu_Manage_Insert_MonthlyFee
            // 
            this.Menu_Manage_Insert_MonthlyFee.Name = "Menu_Manage_Insert_MonthlyFee";
            this.Menu_Manage_Insert_MonthlyFee.Size = new System.Drawing.Size(151, 22);
            this.Menu_Manage_Insert_MonthlyFee.Text = "Mensalidade";
            // 
            // Menu_Manage_Insert_Reserva
            // 
            this.Menu_Manage_Insert_Reserva.Name = "Menu_Manage_Insert_Reserva";
            this.Menu_Manage_Insert_Reserva.Size = new System.Drawing.Size(151, 22);
            this.Menu_Manage_Insert_Reserva.Text = "Reserva";
            // 
            // Menu_Manage_Insert_Money
            // 
            this.Menu_Manage_Insert_Money.Name = "Menu_Manage_Insert_Money";
            this.Menu_Manage_Insert_Money.Size = new System.Drawing.Size(151, 22);
            this.Menu_Manage_Insert_Money.Text = "Dinheiro";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // visualizarToolStripMenuItem
            // 
            this.visualizarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gastosToolStripMenuItem1,
            this.mensalidadesToolStripMenuItem1,
            this.dinheirosToolStripMenuItem1,
            this.reservasToolStripMenuItem});
            this.visualizarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualizarToolStripMenuItem.Name = "visualizarToolStripMenuItem";
            this.visualizarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.visualizarToolStripMenuItem.Text = "Visualizar";
            // 
            // gastosToolStripMenuItem1
            // 
            this.gastosToolStripMenuItem1.Name = "gastosToolStripMenuItem1";
            this.gastosToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.gastosToolStripMenuItem1.Text = "Gastos";
            // 
            // mensalidadesToolStripMenuItem1
            // 
            this.mensalidadesToolStripMenuItem1.Name = "mensalidadesToolStripMenuItem1";
            this.mensalidadesToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.mensalidadesToolStripMenuItem1.Text = "Mensalidades";
            // 
            // dinheirosToolStripMenuItem1
            // 
            this.dinheirosToolStripMenuItem1.Name = "dinheirosToolStripMenuItem1";
            this.dinheirosToolStripMenuItem1.Size = new System.Drawing.Size(157, 22);
            this.dinheirosToolStripMenuItem1.Text = "Dinheiros";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reservasToolStripMenuItem.Text = "Reservas";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(157, 6);
            // 
            // importarToolStripMenuItem
            // 
            this.importarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONFileToolStripMenuItem,
            this.xMLToolStripMenuItem,
            this.tabelatxtToolStripMenuItem,
            this.tabeladdbtToolStripMenuItem});
            this.importarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importarToolStripMenuItem.Name = "importarToolStripMenuItem";
            this.importarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.importarToolStripMenuItem.Text = "Importar";
            // 
            // jSONFileToolStripMenuItem
            // 
            this.jSONFileToolStripMenuItem.Name = "jSONFileToolStripMenuItem";
            this.jSONFileToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.jSONFileToolStripMenuItem.Text = "JavaScript Object Notation (*.json)";
            // 
            // xMLToolStripMenuItem
            // 
            this.xMLToolStripMenuItem.Name = "xMLToolStripMenuItem";
            this.xMLToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.xMLToolStripMenuItem.Text = "eXtensible Markup Language (*.xml)";
            // 
            // tabelatxtToolStripMenuItem
            // 
            this.tabelatxtToolStripMenuItem.Name = "tabelatxtToolStripMenuItem";
            this.tabelatxtToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.tabelatxtToolStripMenuItem.Text = "Text File (*.txt)";
            // 
            // tabeladdbtToolStripMenuItem
            // 
            this.tabeladdbtToolStripMenuItem.Name = "tabeladdbtToolStripMenuItem";
            this.tabeladdbtToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.tabeladdbtToolStripMenuItem.Text = "DCode DataBase Table (*.ddbt)";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jSONToolStripMenuItem,
            this.xMLToolStripMenuItem1,
            this.tXTToolStripMenuItem,
            this.dDBtToolStripMenuItem});
            this.exportarToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // jSONToolStripMenuItem
            // 
            this.jSONToolStripMenuItem.Name = "jSONToolStripMenuItem";
            this.jSONToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.jSONToolStripMenuItem.Text = "JavaScript Object Notation (*.json)";
            // 
            // xMLToolStripMenuItem1
            // 
            this.xMLToolStripMenuItem1.Name = "xMLToolStripMenuItem1";
            this.xMLToolStripMenuItem1.Size = new System.Drawing.Size(286, 22);
            this.xMLToolStripMenuItem1.Text = "eXtensible Markup Language (*.xml)";
            // 
            // tXTToolStripMenuItem
            // 
            this.tXTToolStripMenuItem.Name = "tXTToolStripMenuItem";
            this.tXTToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.tXTToolStripMenuItem.Text = "Text File (*.txt)";
            // 
            // dDBtToolStripMenuItem
            // 
            this.dDBtToolStripMenuItem.Name = "dDBtToolStripMenuItem";
            this.dDBtToolStripMenuItem.Size = new System.Drawing.Size(286, 22);
            this.dDBtToolStripMenuItem.Text = "DCode DataBase Table (*.ddbt)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(157, 6);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(157, 6);
            // 
            // fecharToolStripMenuItem
            // 
            this.fecharToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fecharToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fecharToolStripMenuItem.Name = "fecharToolStripMenuItem";
            this.fecharToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fecharToolStripMenuItem.Text = "Fechar";
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
            this.buttonClose.Location = new System.Drawing.Point(667, 0);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(40, 25);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // labelTabTitle
            // 
            this.labelTabTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(187)))), ((int)(((byte)(216)))));
            this.labelTabTitle.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTabTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTabTitle.ForeColor = System.Drawing.Color.White;
            this.labelTabTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTabTitle.Name = "labelTabTitle";
            this.labelTabTitle.Size = new System.Drawing.Size(129, 25);
            this.labelTabTitle.TabIndex = 5;
            this.labelTabTitle.Text = "WindowTabTitle";
            this.labelTabTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTabTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.moveWindow_MouseDown);
            // 
            // dashboardUserControl
            // 
            this.dashboardUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashboardUserControl.Location = new System.Drawing.Point(69, 26);
            this.dashboardUserControl.Name = "dashboardUserControl";
            this.dashboardUserControl.Size = new System.Drawing.Size(836, 512);
            this.dashboardUserControl.TabIndex = 2;
            // 
            // expensesUserControl
            // 
            this.expensesUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.expensesUserControl.Location = new System.Drawing.Point(69, 26);
            this.expensesUserControl.Name = "expensesUserControl";
            this.expensesUserControl.Size = new System.Drawing.Size(836, 512);
            this.expensesUserControl.TabIndex = 3;
            // 
            // monthlyFeeUserControl
            // 
            this.monthlyFeeUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.monthlyFeeUserControl.Location = new System.Drawing.Point(69, 26);
            this.monthlyFeeUserControl.Name = "monthlyFeeUserControl";
            this.monthlyFeeUserControl.Size = new System.Drawing.Size(836, 512);
            this.monthlyFeeUserControl.TabIndex = 4;
            // 
            // GeneralForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(906, 539);
            this.Controls.Add(this.monthlyFeeUserControl);
            this.Controls.Add(this.expensesUserControl);
            this.Controls.Add(this.dashboardUserControl);
            this.Controls.Add(this.panel_topWindow);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menu;
            this.Name = "GeneralForm";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GeneralForm";
            this.Load += new System.EventHandler(this.GeneralForm_Load);
            this.panel1.ResumeLayout(false);
            this.panelTabs.ResumeLayout(false);
            this.panelAppIcon.ResumeLayout(false);
            this.panel_topWindow.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_topWindow;
        private System.Windows.Forms.Label labelAppIcon;
        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Manage;
        private System.Windows.Forms.ToolStripMenuItem Menu_Manage_Insert;
        private System.Windows.Forms.ToolStripMenuItem Menu_Manage_Insert_Expense;
        private System.Windows.Forms.ToolStripMenuItem Menu_Manage_Insert_MonthlyFee;
        private System.Windows.Forms.ToolStripMenuItem Menu_Manage_Insert_Reserva;
        private System.Windows.Forms.ToolStripMenuItem Menu_Manage_Insert_Money;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem visualizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gastosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mensalidadesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem dinheirosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem importarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabelatxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tabeladdbtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dDBtToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem fecharToolStripMenuItem;
        private System.Windows.Forms.Panel panelAppIcon;
        private System.Windows.Forms.Button tabMonthlyFee;
        private System.Windows.Forms.Button tabExpenses;
        private System.Windows.Forms.Button tabDashboard;
        private MainTabs.DashboardUserControl dashboardUserControl;
        private ExpensesUserControl expensesUserControl;
        private MainTabs.MonthlyFeeUserControl monthlyFeeUserControl;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonRestore;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label labelTabTitle;
        private System.Windows.Forms.Panel panelTabs;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}