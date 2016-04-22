namespace Leads_Generator
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_leads = new System.Windows.Forms.DataGridView();
            this.context_export = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportExcel = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportCSV = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_importLeads = new System.Windows.Forms.Button();
            this.pnl_leadsTop = new System.Windows.Forms.Panel();
            this.colorize_sample = new System.Windows.Forms.Label();
            this.colorize_email = new System.Windows.Forms.Label();
            this.colorize_call = new System.Windows.Forms.Label();
            this.rbtn_removeColumn = new System.Windows.Forms.RadioButton();
            this.rbtn_addColumn = new System.Windows.Forms.RadioButton();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.btn_addRecord = new System.Windows.Forms.Button();
            this.colorize_none = new System.Windows.Forms.Label();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.chkbx_leadStatus = new System.Windows.Forms.CheckBox();
            this.chkbx_leadInformation = new System.Windows.Forms.CheckBox();
            this.chkbx_coldLeads = new System.Windows.Forms.CheckBox();
            this.chkbx_lstleads = new System.Windows.Forms.CheckBox();
            this.pnl_navigation = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.tlp_navigation = new System.Windows.Forms.TableLayoutPanel();
            this.btn_report = new System.Windows.Forms.Button();
            this.btn_leads = new System.Windows.Forms.Button();
            this.lbl_todayTasks = new System.Windows.Forms.Label();
            this.btn_reminder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_reminderCirteria = new System.Windows.Forms.Label();
            this.lbl_reportDateCriteria = new System.Windows.Forms.Label();
            this.gbox_table = new System.Windows.Forms.GroupBox();
            this.pnl_leadsPage = new System.Windows.Forms.Panel();
            this.panel_leadsUpper = new System.Windows.Forms.Panel();
            this.flowpanelLeads_temporaryAdd = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_columnName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbox_columnType = new System.Windows.Forms.ComboBox();
            this.lbl_addColumn = new System.Windows.Forms.Label();
            this.flowpanelLeads_temporaryRemove = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cbox_columnNames = new System.Windows.Forms.ComboBox();
            this.panel_body = new System.Windows.Forms.Panel();
            this.panel_reminderPage = new System.Windows.Forms.Panel();
            this.gbox_reminder = new System.Windows.Forms.GroupBox();
            this.dgv_reminder = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowpanelLeads_temporaryReminder = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.cbox_reminderCriteria = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.panel_reminderTop = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.pnl_reportPage = new System.Windows.Forms.Panel();
            this.gbox_report = new System.Windows.Forms.GroupBox();
            this.dgv_report = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flp_report = new System.Windows.Forms.FlowLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_reportStateCriteria = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cbox_reportDateCriteria = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbox_reportPeriodCriteria = new System.Windows.Forms.ComboBox();
            this.lbl_generateReport = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rbtn_reports = new System.Windows.Forms.RadioButton();
            this.closeBarWin101 = new CloseBarWin10.CloseBarWin10();
            this.context_reminderExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportExcelReminder = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportCSVReminder = new System.Windows.Forms.ToolStripMenuItem();
            this.context_reportExport = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportExcelReport = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_exportCSVReport = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leads)).BeginInit();
            this.context_export.SuspendLayout();
            this.pnl_leadsTop.SuspendLayout();
            this.pnl_navigation.SuspendLayout();
            this.tlp_navigation.SuspendLayout();
            this.gbox_table.SuspendLayout();
            this.pnl_leadsPage.SuspendLayout();
            this.panel_leadsUpper.SuspendLayout();
            this.flowpanelLeads_temporaryAdd.SuspendLayout();
            this.flowpanelLeads_temporaryRemove.SuspendLayout();
            this.panel_body.SuspendLayout();
            this.panel_reminderPage.SuspendLayout();
            this.gbox_reminder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reminder)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowpanelLeads_temporaryReminder.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel_reminderTop.SuspendLayout();
            this.pnl_reportPage.SuspendLayout();
            this.gbox_report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).BeginInit();
            this.panel3.SuspendLayout();
            this.flp_report.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.closeBarWin101.TLP_MAIN.SuspendLayout();
            this.closeBarWin101.SuspendLayout();
            this.context_reminderExport.SuspendLayout();
            this.context_reportExport.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_leads
            // 
            this.dgv_leads.AllowUserToAddRows = false;
            this.dgv_leads.AllowUserToOrderColumns = true;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_leads.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgv_leads.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_leads.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_leads.BackgroundColor = System.Drawing.Color.White;
            this.dgv_leads.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_leads.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_leads.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgv_leads.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_leads.ContextMenuStrip = this.context_export;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.NullValue = null;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_leads.DefaultCellStyle = dataGridViewCellStyle13;
            this.dgv_leads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_leads.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_leads.Location = new System.Drawing.Point(6, 21);
            this.dgv_leads.Name = "dgv_leads";
            this.dgv_leads.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_leads.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgv_leads.Size = new System.Drawing.Size(1105, 309);
            this.dgv_leads.TabIndex = 1;
            this.dgv_leads.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellEndEdit);
            this.dgv_leads.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.table_DataError);
            // 
            // context_export
            // 
            this.context_export.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.context_export.Name = "contextMenuStrip1";
            this.context_export.Size = new System.Drawing.Size(108, 26);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_exportExcel,
            this.btn_exportCSV});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // btn_exportExcel
            // 
            this.btn_exportExcel.Name = "btn_exportExcel";
            this.btn_exportExcel.Size = new System.Drawing.Size(100, 22);
            this.btn_exportExcel.Text = "Excel";
            this.btn_exportExcel.Click += new System.EventHandler(this.btn_exportExcel_Click);
            // 
            // btn_exportCSV
            // 
            this.btn_exportCSV.Name = "btn_exportCSV";
            this.btn_exportCSV.Size = new System.Drawing.Size(100, 22);
            this.btn_exportCSV.Text = "CSV";
            this.btn_exportCSV.Click += new System.EventHandler(this.btn_exportCSV_Click);
            // 
            // btn_importLeads
            // 
            this.btn_importLeads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_importLeads.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_importLeads.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btn_importLeads.FlatAppearance.BorderSize = 0;
            this.btn_importLeads.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_importLeads.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.btn_importLeads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_importLeads.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_importLeads.ForeColor = System.Drawing.Color.Black;
            this.btn_importLeads.Location = new System.Drawing.Point(0, 0);
            this.btn_importLeads.Margin = new System.Windows.Forms.Padding(0);
            this.btn_importLeads.Name = "btn_importLeads";
            this.btn_importLeads.Size = new System.Drawing.Size(101, 35);
            this.btn_importLeads.TabIndex = 2;
            this.btn_importLeads.Text = "Import Leads";
            this.btn_importLeads.UseVisualStyleBackColor = false;
            this.btn_importLeads.Click += new System.EventHandler(this.btn_importLeads_Click);
            // 
            // pnl_leadsTop
            // 
            this.pnl_leadsTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.pnl_leadsTop.Controls.Add(this.colorize_sample);
            this.pnl_leadsTop.Controls.Add(this.colorize_email);
            this.pnl_leadsTop.Controls.Add(this.colorize_call);
            this.pnl_leadsTop.Controls.Add(this.rbtn_removeColumn);
            this.pnl_leadsTop.Controls.Add(this.rbtn_addColumn);
            this.pnl_leadsTop.Controls.Add(this.splitter1);
            this.pnl_leadsTop.Controls.Add(this.btn_addRecord);
            this.pnl_leadsTop.Controls.Add(this.btn_importLeads);
            this.pnl_leadsTop.Controls.Add(this.colorize_none);
            this.pnl_leadsTop.Controls.Add(this.splitter2);
            this.pnl_leadsTop.Controls.Add(this.chkbx_leadStatus);
            this.pnl_leadsTop.Controls.Add(this.chkbx_leadInformation);
            this.pnl_leadsTop.Controls.Add(this.chkbx_coldLeads);
            this.pnl_leadsTop.Controls.Add(this.chkbx_lstleads);
            this.pnl_leadsTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_leadsTop.Location = new System.Drawing.Point(0, 0);
            this.pnl_leadsTop.Name = "pnl_leadsTop";
            this.pnl_leadsTop.Size = new System.Drawing.Size(1117, 35);
            this.pnl_leadsTop.TabIndex = 3;
            // 
            // colorize_sample
            // 
            this.colorize_sample.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorize_sample.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorize_sample.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorize_sample.ForeColor = System.Drawing.Color.Yellow;
            this.colorize_sample.Image = global::Leads_Generator.Properties.Resources.sample2;
            this.colorize_sample.Location = new System.Drawing.Point(753, 0);
            this.colorize_sample.Name = "colorize_sample";
            this.colorize_sample.Size = new System.Drawing.Size(28, 35);
            this.colorize_sample.TabIndex = 2;
            this.colorize_sample.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorize_sample.Click += new System.EventHandler(this.colorize_sample_Click);
            // 
            // colorize_email
            // 
            this.colorize_email.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorize_email.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorize_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorize_email.ForeColor = System.Drawing.Color.Orange;
            this.colorize_email.Image = global::Leads_Generator.Properties.Resources.email4;
            this.colorize_email.Location = new System.Drawing.Point(781, 0);
            this.colorize_email.Name = "colorize_email";
            this.colorize_email.Size = new System.Drawing.Size(28, 35);
            this.colorize_email.TabIndex = 0;
            this.colorize_email.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorize_email.Click += new System.EventHandler(this.colorize_email_Click);
            // 
            // colorize_call
            // 
            this.colorize_call.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorize_call.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorize_call.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorize_call.ForeColor = System.Drawing.Color.Red;
            this.colorize_call.Image = global::Leads_Generator.Properties.Resources.call2;
            this.colorize_call.Location = new System.Drawing.Point(809, 0);
            this.colorize_call.Name = "colorize_call";
            this.colorize_call.Size = new System.Drawing.Size(28, 35);
            this.colorize_call.TabIndex = 1;
            this.colorize_call.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorize_call.Click += new System.EventHandler(this.colorize_call_Click);
            // 
            // rbtn_removeColumn
            // 
            this.rbtn_removeColumn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn_removeColumn.AutoSize = true;
            this.rbtn_removeColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtn_removeColumn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_removeColumn.FlatAppearance.BorderSize = 0;
            this.rbtn_removeColumn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.rbtn_removeColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rbtn_removeColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.rbtn_removeColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_removeColumn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbtn_removeColumn.Location = new System.Drawing.Point(315, 0);
            this.rbtn_removeColumn.Name = "rbtn_removeColumn";
            this.rbtn_removeColumn.Size = new System.Drawing.Size(112, 35);
            this.rbtn_removeColumn.TabIndex = 9;
            this.rbtn_removeColumn.Text = "Remove Column";
            this.rbtn_removeColumn.UseVisualStyleBackColor = true;
            this.rbtn_removeColumn.CheckedChanged += new System.EventHandler(this.rbtn_removeColumn_CheckedChanged);
            // 
            // rbtn_addColumn
            // 
            this.rbtn_addColumn.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn_addColumn.AutoSize = true;
            this.rbtn_addColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_addColumn.Checked = true;
            this.rbtn_addColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtn_addColumn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_addColumn.FlatAppearance.BorderSize = 0;
            this.rbtn_addColumn.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.rbtn_addColumn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.rbtn_addColumn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.rbtn_addColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_addColumn.Font = new System.Drawing.Font("Arial", 9.75F);
            this.rbtn_addColumn.Location = new System.Drawing.Point(226, 0);
            this.rbtn_addColumn.Name = "rbtn_addColumn";
            this.rbtn_addColumn.Size = new System.Drawing.Size(89, 35);
            this.rbtn_addColumn.TabIndex = 8;
            this.rbtn_addColumn.TabStop = true;
            this.rbtn_addColumn.Text = "Add Column";
            this.rbtn_addColumn.UseVisualStyleBackColor = false;
            this.rbtn_addColumn.CheckedChanged += new System.EventHandler(this.rbtn_addColumn_CheckedChanged);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(195, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(31, 35);
            this.splitter1.TabIndex = 11;
            this.splitter1.TabStop = false;
            // 
            // btn_addRecord
            // 
            this.btn_addRecord.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.btn_addRecord.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_addRecord.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.btn_addRecord.FlatAppearance.BorderSize = 0;
            this.btn_addRecord.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.btn_addRecord.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.btn_addRecord.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addRecord.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addRecord.ForeColor = System.Drawing.Color.Black;
            this.btn_addRecord.Location = new System.Drawing.Point(101, 0);
            this.btn_addRecord.Margin = new System.Windows.Forms.Padding(0);
            this.btn_addRecord.Name = "btn_addRecord";
            this.btn_addRecord.Size = new System.Drawing.Size(94, 35);
            this.btn_addRecord.TabIndex = 5;
            this.btn_addRecord.TabStop = false;
            this.btn_addRecord.Text = "Add Record";
            this.btn_addRecord.UseVisualStyleBackColor = false;
            this.btn_addRecord.Click += new System.EventHandler(this.btn_addRecord_Click);
            // 
            // colorize_none
            // 
            this.colorize_none.Cursor = System.Windows.Forms.Cursors.Hand;
            this.colorize_none.Dock = System.Windows.Forms.DockStyle.Right;
            this.colorize_none.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorize_none.Image = global::Leads_Generator.Properties.Resources.none1;
            this.colorize_none.Location = new System.Drawing.Point(837, 0);
            this.colorize_none.Name = "colorize_none";
            this.colorize_none.Size = new System.Drawing.Size(28, 35);
            this.colorize_none.TabIndex = 4;
            this.colorize_none.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.colorize_none.Click += new System.EventHandler(this.colorize_none_Click);
            // 
            // splitter2
            // 
            this.splitter2.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter2.Location = new System.Drawing.Point(865, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(25, 35);
            this.splitter2.TabIndex = 12;
            this.splitter2.TabStop = false;
            // 
            // chkbx_leadStatus
            // 
            this.chkbx_leadStatus.AutoSize = true;
            this.chkbx_leadStatus.Checked = true;
            this.chkbx_leadStatus.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_leadStatus.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkbx_leadStatus.Location = new System.Drawing.Point(890, 0);
            this.chkbx_leadStatus.Name = "chkbx_leadStatus";
            this.chkbx_leadStatus.Size = new System.Drawing.Size(56, 35);
            this.chkbx_leadStatus.TabIndex = 4;
            this.chkbx_leadStatus.Text = "Status";
            this.chkbx_leadStatus.UseVisualStyleBackColor = true;
            this.chkbx_leadStatus.CheckedChanged += new System.EventHandler(this.chkbx_leadStatus_CheckedChanged);
            // 
            // chkbx_leadInformation
            // 
            this.chkbx_leadInformation.AutoSize = true;
            this.chkbx_leadInformation.Checked = true;
            this.chkbx_leadInformation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_leadInformation.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkbx_leadInformation.Location = new System.Drawing.Point(946, 0);
            this.chkbx_leadInformation.Name = "chkbx_leadInformation";
            this.chkbx_leadInformation.Size = new System.Drawing.Size(78, 35);
            this.chkbx_leadInformation.TabIndex = 3;
            this.chkbx_leadInformation.Text = "Information";
            this.chkbx_leadInformation.UseVisualStyleBackColor = true;
            this.chkbx_leadInformation.CheckedChanged += new System.EventHandler(this.chkbx_leadInformation_CheckedChanged);
            // 
            // chkbx_coldLeads
            // 
            this.chkbx_coldLeads.AutoSize = true;
            this.chkbx_coldLeads.Checked = true;
            this.chkbx_coldLeads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_coldLeads.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkbx_coldLeads.Location = new System.Drawing.Point(1024, 0);
            this.chkbx_coldLeads.Name = "chkbx_coldLeads";
            this.chkbx_coldLeads.Size = new System.Drawing.Size(47, 35);
            this.chkbx_coldLeads.TabIndex = 13;
            this.chkbx_coldLeads.Text = "Cold";
            this.chkbx_coldLeads.UseVisualStyleBackColor = true;
            this.chkbx_coldLeads.CheckedChanged += new System.EventHandler(this.chkbx_coldLeads_CheckedChanged);
            // 
            // chkbx_lstleads
            // 
            this.chkbx_lstleads.AutoSize = true;
            this.chkbx_lstleads.Checked = true;
            this.chkbx_lstleads.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkbx_lstleads.Dock = System.Windows.Forms.DockStyle.Right;
            this.chkbx_lstleads.Location = new System.Drawing.Point(1071, 0);
            this.chkbx_lstleads.Name = "chkbx_lstleads";
            this.chkbx_lstleads.Size = new System.Drawing.Size(46, 35);
            this.chkbx_lstleads.TabIndex = 14;
            this.chkbx_lstleads.Text = "Lost";
            this.chkbx_lstleads.UseVisualStyleBackColor = true;
            this.chkbx_lstleads.CheckedChanged += new System.EventHandler(this.chkbx_lstleads_CheckedChanged);
            // 
            // pnl_navigation
            // 
            this.pnl_navigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.pnl_navigation.Controls.Add(this.label11);
            this.pnl_navigation.Controls.Add(this.tlp_navigation);
            this.pnl_navigation.Controls.Add(this.label4);
            this.pnl_navigation.Controls.Add(this.lbl_reminderCirteria);
            this.pnl_navigation.Controls.Add(this.lbl_reportDateCriteria);
            this.pnl_navigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_navigation.Location = new System.Drawing.Point(0, 71);
            this.pnl_navigation.Name = "pnl_navigation";
            this.pnl_navigation.Size = new System.Drawing.Size(1117, 83);
            this.pnl_navigation.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label11.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Linen;
            this.label11.Location = new System.Drawing.Point(858, 67);
            this.label11.Margin = new System.Windows.Forms.Padding(0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Report Date Criteria  :";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tlp_navigation
            // 
            this.tlp_navigation.AutoSize = true;
            this.tlp_navigation.ColumnCount = 4;
            this.tlp_navigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_navigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_navigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_navigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tlp_navigation.Controls.Add(this.btn_report, 3, 0);
            this.tlp_navigation.Controls.Add(this.btn_leads, 0, 0);
            this.tlp_navigation.Controls.Add(this.lbl_todayTasks, 2, 0);
            this.tlp_navigation.Controls.Add(this.btn_reminder, 1, 0);
            this.tlp_navigation.Location = new System.Drawing.Point(380, 6);
            this.tlp_navigation.Name = "tlp_navigation";
            this.tlp_navigation.RowCount = 1;
            this.tlp_navigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_navigation.Size = new System.Drawing.Size(345, 65);
            this.tlp_navigation.TabIndex = 9;
            // 
            // btn_report
            // 
            this.btn_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_report.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_report.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_report.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_report.FlatAppearance.BorderSize = 0;
            this.btn_report.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_report.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_report.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_report.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_report.ForeColor = System.Drawing.Color.Linen;
            this.btn_report.Image = global::Leads_Generator.Properties.Resources.report_40;
            this.btn_report.Location = new System.Drawing.Point(242, 0);
            this.btn_report.Margin = new System.Windows.Forms.Padding(0);
            this.btn_report.Name = "btn_report";
            this.btn_report.Size = new System.Drawing.Size(103, 65);
            this.btn_report.TabIndex = 5;
            this.btn_report.TabStop = false;
            this.btn_report.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_report.UseVisualStyleBackColor = false;
            this.btn_report.Click += new System.EventHandler(this.btn_report_Click);
            // 
            // btn_leads
            // 
            this.btn_leads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_leads.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_leads.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_leads.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_leads.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_leads.FlatAppearance.BorderSize = 0;
            this.btn_leads.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_leads.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_leads.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_leads.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leads.ForeColor = System.Drawing.Color.Linen;
            this.btn_leads.Image = global::Leads_Generator.Properties.Resources.yellow_lead_40;
            this.btn_leads.Location = new System.Drawing.Point(0, 0);
            this.btn_leads.Margin = new System.Windows.Forms.Padding(0);
            this.btn_leads.Name = "btn_leads";
            this.btn_leads.Size = new System.Drawing.Size(121, 65);
            this.btn_leads.TabIndex = 2;
            this.btn_leads.TabStop = false;
            this.btn_leads.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_leads.UseVisualStyleBackColor = false;
            this.btn_leads.Click += new System.EventHandler(this.btn_leads_Click);
            // 
            // lbl_todayTasks
            // 
            this.lbl_todayTasks.AutoSize = true;
            this.lbl_todayTasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lbl_todayTasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_todayTasks.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_todayTasks.ForeColor = System.Drawing.Color.Orange;
            this.lbl_todayTasks.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_todayTasks.Location = new System.Drawing.Point(220, 0);
            this.lbl_todayTasks.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_todayTasks.Name = "lbl_todayTasks";
            this.lbl_todayTasks.Size = new System.Drawing.Size(22, 24);
            this.lbl_todayTasks.TabIndex = 4;
            this.lbl_todayTasks.Text = "0";
            this.lbl_todayTasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_reminder
            // 
            this.btn_reminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_reminder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_reminder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_reminder.FlatAppearance.BorderSize = 0;
            this.btn_reminder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_reminder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.btn_reminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reminder.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reminder.ForeColor = System.Drawing.Color.Linen;
            this.btn_reminder.Image = global::Leads_Generator.Properties.Resources.alarm_40;
            this.btn_reminder.Location = new System.Drawing.Point(121, 0);
            this.btn_reminder.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reminder.Name = "btn_reminder";
            this.btn_reminder.Size = new System.Drawing.Size(99, 65);
            this.btn_reminder.TabIndex = 3;
            this.btn_reminder.TabStop = false;
            this.btn_reminder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_reminder.UseVisualStyleBackColor = false;
            this.btn_reminder.Click += new System.EventHandler(this.btn_reminder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Linen;
            this.label4.Location = new System.Drawing.Point(858, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Reminder Criteria :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_reminderCirteria
            // 
            this.lbl_reminderCirteria.AutoSize = true;
            this.lbl_reminderCirteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lbl_reminderCirteria.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reminderCirteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.lbl_reminderCirteria.Location = new System.Drawing.Point(981, 55);
            this.lbl_reminderCirteria.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_reminderCirteria.Name = "lbl_reminderCirteria";
            this.lbl_reminderCirteria.Size = new System.Drawing.Size(25, 13);
            this.lbl_reminderCirteria.TabIndex = 8;
            this.lbl_reminderCirteria.Text = "N/A";
            this.lbl_reminderCirteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_reportDateCriteria
            // 
            this.lbl_reportDateCriteria.AutoSize = true;
            this.lbl_reportDateCriteria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.lbl_reportDateCriteria.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportDateCriteria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.lbl_reportDateCriteria.Location = new System.Drawing.Point(1003, 67);
            this.lbl_reportDateCriteria.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_reportDateCriteria.Name = "lbl_reportDateCriteria";
            this.lbl_reportDateCriteria.Size = new System.Drawing.Size(25, 13);
            this.lbl_reportDateCriteria.TabIndex = 14;
            this.lbl_reportDateCriteria.Text = "N/A";
            this.lbl_reportDateCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbox_table
            // 
            this.gbox_table.Controls.Add(this.dgv_leads);
            this.gbox_table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_table.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_table.Location = new System.Drawing.Point(0, 76);
            this.gbox_table.Name = "gbox_table";
            this.gbox_table.Padding = new System.Windows.Forms.Padding(6);
            this.gbox_table.Size = new System.Drawing.Size(1117, 336);
            this.gbox_table.TabIndex = 3;
            this.gbox_table.TabStop = false;
            this.gbox_table.Text = "Data Explorer";
            // 
            // pnl_leadsPage
            // 
            this.pnl_leadsPage.Controls.Add(this.gbox_table);
            this.pnl_leadsPage.Controls.Add(this.panel_leadsUpper);
            this.pnl_leadsPage.Controls.Add(this.pnl_leadsTop);
            this.pnl_leadsPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_leadsPage.Location = new System.Drawing.Point(0, 0);
            this.pnl_leadsPage.Name = "pnl_leadsPage";
            this.pnl_leadsPage.Size = new System.Drawing.Size(1117, 412);
            this.pnl_leadsPage.TabIndex = 5;
            // 
            // panel_leadsUpper
            // 
            this.panel_leadsUpper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel_leadsUpper.Controls.Add(this.flowpanelLeads_temporaryAdd);
            this.panel_leadsUpper.Controls.Add(this.flowpanelLeads_temporaryRemove);
            this.panel_leadsUpper.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_leadsUpper.Location = new System.Drawing.Point(0, 35);
            this.panel_leadsUpper.Name = "panel_leadsUpper";
            this.panel_leadsUpper.Size = new System.Drawing.Size(1117, 41);
            this.panel_leadsUpper.TabIndex = 7;
            // 
            // flowpanelLeads_temporaryAdd
            // 
            this.flowpanelLeads_temporaryAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.flowpanelLeads_temporaryAdd.Controls.Add(this.label1);
            this.flowpanelLeads_temporaryAdd.Controls.Add(this.txt_columnName);
            this.flowpanelLeads_temporaryAdd.Controls.Add(this.label2);
            this.flowpanelLeads_temporaryAdd.Controls.Add(this.cbox_columnType);
            this.flowpanelLeads_temporaryAdd.Controls.Add(this.lbl_addColumn);
            this.flowpanelLeads_temporaryAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelLeads_temporaryAdd.Location = new System.Drawing.Point(0, 0);
            this.flowpanelLeads_temporaryAdd.Name = "flowpanelLeads_temporaryAdd";
            this.flowpanelLeads_temporaryAdd.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowpanelLeads_temporaryAdd.Size = new System.Drawing.Size(1117, 41);
            this.flowpanelLeads_temporaryAdd.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Column Name :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_columnName
            // 
            this.txt_columnName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_columnName.Location = new System.Drawing.Point(91, 9);
            this.txt_columnName.Name = "txt_columnName";
            this.txt_columnName.Size = new System.Drawing.Size(184, 20);
            this.txt_columnName.TabIndex = 1;
            this.txt_columnName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_columnName.TextChanged += new System.EventHandler(this.txt_columnName_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Location = new System.Drawing.Point(281, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "Data Type :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_columnType
            // 
            this.cbox_columnType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_columnType.FormattingEnabled = true;
            this.cbox_columnType.Items.AddRange(new object[] {
            "Text",
            "Yes/No",
            "Number"});
            this.cbox_columnType.Location = new System.Drawing.Point(359, 9);
            this.cbox_columnType.Name = "cbox_columnType";
            this.cbox_columnType.Size = new System.Drawing.Size(155, 21);
            this.cbox_columnType.TabIndex = 2;
            this.cbox_columnType.SelectedIndexChanged += new System.EventHandler(this.txt_columnName_TextChanged);
            // 
            // lbl_addColumn
            // 
            this.lbl_addColumn.AutoSize = true;
            this.lbl_addColumn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.lbl_addColumn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_addColumn.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_addColumn.Enabled = false;
            this.lbl_addColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addColumn.Location = new System.Drawing.Point(520, 6);
            this.lbl_addColumn.Name = "lbl_addColumn";
            this.lbl_addColumn.Size = new System.Drawing.Size(21, 27);
            this.lbl_addColumn.TabIndex = 3;
            this.lbl_addColumn.Text = "+";
            this.lbl_addColumn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_addColumn.Click += new System.EventHandler(this.lbl_addColumn_Click);
            // 
            // flowpanelLeads_temporaryRemove
            // 
            this.flowpanelLeads_temporaryRemove.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.flowpanelLeads_temporaryRemove.Controls.Add(this.label3);
            this.flowpanelLeads_temporaryRemove.Controls.Add(this.cbox_columnNames);
            this.flowpanelLeads_temporaryRemove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelLeads_temporaryRemove.Location = new System.Drawing.Point(0, 0);
            this.flowpanelLeads_temporaryRemove.Name = "flowpanelLeads_temporaryRemove";
            this.flowpanelLeads_temporaryRemove.Padding = new System.Windows.Forms.Padding(6);
            this.flowpanelLeads_temporaryRemove.Size = new System.Drawing.Size(1117, 41);
            this.flowpanelLeads_temporaryRemove.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(9, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 29);
            this.label3.TabIndex = 9;
            this.label3.Text = "Column Name :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_columnNames
            // 
            this.cbox_columnNames.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbox_columnNames.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbox_columnNames.FormattingEnabled = true;
            this.cbox_columnNames.Location = new System.Drawing.Point(107, 9);
            this.cbox_columnNames.Name = "cbox_columnNames";
            this.cbox_columnNames.Size = new System.Drawing.Size(208, 23);
            this.cbox_columnNames.TabIndex = 8;
            this.cbox_columnNames.SelectedIndexChanged += new System.EventHandler(this.cbox_columnNames_SelectedIndexChanged);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.pnl_leadsPage);
            this.panel_body.Controls.Add(this.panel_reminderPage);
            this.panel_body.Controls.Add(this.pnl_reportPage);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 154);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1117, 412);
            this.panel_body.TabIndex = 6;
            // 
            // panel_reminderPage
            // 
            this.panel_reminderPage.Controls.Add(this.gbox_reminder);
            this.panel_reminderPage.Controls.Add(this.panel2);
            this.panel_reminderPage.Controls.Add(this.panel_reminderTop);
            this.panel_reminderPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_reminderPage.Location = new System.Drawing.Point(0, 0);
            this.panel_reminderPage.Name = "panel_reminderPage";
            this.panel_reminderPage.Size = new System.Drawing.Size(1117, 412);
            this.panel_reminderPage.TabIndex = 6;
            // 
            // gbox_reminder
            // 
            this.gbox_reminder.Controls.Add(this.dgv_reminder);
            this.gbox_reminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_reminder.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_reminder.Location = new System.Drawing.Point(0, 76);
            this.gbox_reminder.Name = "gbox_reminder";
            this.gbox_reminder.Padding = new System.Windows.Forms.Padding(6);
            this.gbox_reminder.Size = new System.Drawing.Size(1117, 336);
            this.gbox_reminder.TabIndex = 3;
            this.gbox_reminder.TabStop = false;
            this.gbox_reminder.Text = "Reminder";
            // 
            // dgv_reminder
            // 
            this.dgv_reminder.AllowUserToAddRows = false;
            this.dgv_reminder.AllowUserToDeleteRows = false;
            this.dgv_reminder.AllowUserToResizeColumns = false;
            this.dgv_reminder.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_reminder.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_reminder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_reminder.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_reminder.BackgroundColor = System.Drawing.Color.White;
            this.dgv_reminder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_reminder.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_reminder.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_reminder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_reminder.ContextMenuStrip = this.context_reminderExport;
            this.dgv_reminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_reminder.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_reminder.Location = new System.Drawing.Point(6, 21);
            this.dgv_reminder.Name = "dgv_reminder";
            this.dgv_reminder.ReadOnly = true;
            this.dgv_reminder.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_reminder.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_reminder.Size = new System.Drawing.Size(1105, 309);
            this.dgv_reminder.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Orange;
            this.panel2.Controls.Add(this.flowpanelLeads_temporaryReminder);
            this.panel2.Controls.Add(this.flowLayoutPanel2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 38);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1117, 38);
            this.panel2.TabIndex = 7;
            // 
            // flowpanelLeads_temporaryReminder
            // 
            this.flowpanelLeads_temporaryReminder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.flowpanelLeads_temporaryReminder.Controls.Add(this.label5);
            this.flowpanelLeads_temporaryReminder.Controls.Add(this.cbox_reminderCriteria);
            this.flowpanelLeads_temporaryReminder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowpanelLeads_temporaryReminder.Location = new System.Drawing.Point(0, 0);
            this.flowpanelLeads_temporaryReminder.Name = "flowpanelLeads_temporaryReminder";
            this.flowpanelLeads_temporaryReminder.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flowpanelLeads_temporaryReminder.Size = new System.Drawing.Size(1117, 38);
            this.flowpanelLeads_temporaryReminder.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(3, 6);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "Set Reminder Based On :";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_reminderCriteria
            // 
            this.cbox_reminderCriteria.FormattingEnabled = true;
            this.cbox_reminderCriteria.Location = new System.Drawing.Point(146, 9);
            this.cbox_reminderCriteria.Name = "cbox_reminderCriteria";
            this.cbox_reminderCriteria.Size = new System.Drawing.Size(235, 21);
            this.cbox_reminderCriteria.TabIndex = 1;
            this.cbox_reminderCriteria.SelectedIndexChanged += new System.EventHandler(this.cbox_reminderCriteria_SelectedIndexChanged);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label7);
            this.flowLayoutPanel2.Controls.Add(this.comboBox2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1117, 38);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Left;
            this.label7.Location = new System.Drawing.Point(9, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "Column Name :";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(107, 9);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(208, 23);
            this.comboBox2.TabIndex = 8;
            // 
            // panel_reminderTop
            // 
            this.panel_reminderTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel_reminderTop.Controls.Add(this.radioButton2);
            this.panel_reminderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_reminderTop.Location = new System.Drawing.Point(0, 0);
            this.panel_reminderTop.Name = "panel_reminderTop";
            this.panel_reminderTop.Size = new System.Drawing.Size(1117, 38);
            this.panel_reminderTop.TabIndex = 3;
            // 
            // radioButton2
            // 
            this.radioButton2.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton2.AutoSize = true;
            this.radioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radioButton2.Checked = true;
            this.radioButton2.Dock = System.Windows.Forms.DockStyle.Left;
            this.radioButton2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radioButton2.FlatAppearance.BorderSize = 0;
            this.radioButton2.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radioButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radioButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.radioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton2.Font = new System.Drawing.Font("Arial", 9.75F);
            this.radioButton2.Location = new System.Drawing.Point(0, 0);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(122, 38);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Reminder Options";
            this.radioButton2.UseVisualStyleBackColor = false;
            // 
            // pnl_reportPage
            // 
            this.pnl_reportPage.Controls.Add(this.gbox_report);
            this.pnl_reportPage.Controls.Add(this.panel3);
            this.pnl_reportPage.Controls.Add(this.panel4);
            this.pnl_reportPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_reportPage.Location = new System.Drawing.Point(0, 0);
            this.pnl_reportPage.Name = "pnl_reportPage";
            this.pnl_reportPage.Size = new System.Drawing.Size(1117, 412);
            this.pnl_reportPage.TabIndex = 8;
            // 
            // gbox_report
            // 
            this.gbox_report.Controls.Add(this.dgv_report);
            this.gbox_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbox_report.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_report.Location = new System.Drawing.Point(0, 76);
            this.gbox_report.Name = "gbox_report";
            this.gbox_report.Padding = new System.Windows.Forms.Padding(6);
            this.gbox_report.Size = new System.Drawing.Size(1117, 336);
            this.gbox_report.TabIndex = 3;
            this.gbox_report.TabStop = false;
            this.gbox_report.Text = "Report";
            // 
            // dgv_report
            // 
            this.dgv_report.AllowUserToAddRows = false;
            this.dgv_report.AllowUserToDeleteRows = false;
            this.dgv_report.AllowUserToResizeColumns = false;
            this.dgv_report.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_report.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_report.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgv_report.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgv_report.BackgroundColor = System.Drawing.Color.White;
            this.dgv_report.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_report.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_report.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_report.ContextMenuStrip = this.context_reportExport;
            this.dgv_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_report.GridColor = System.Drawing.SystemColors.ControlLight;
            this.dgv_report.Location = new System.Drawing.Point(6, 21);
            this.dgv_report.Name = "dgv_report";
            this.dgv_report.ReadOnly = true;
            this.dgv_report.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgv_report.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgv_report.Size = new System.Drawing.Size(1105, 309);
            this.dgv_report.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Orange;
            this.panel3.Controls.Add(this.flp_report);
            this.panel3.Controls.Add(this.flowLayoutPanel3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1117, 38);
            this.panel3.TabIndex = 7;
            // 
            // flp_report
            // 
            this.flp_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(218)))), ((int)(((byte)(68)))));
            this.flp_report.Controls.Add(this.label10);
            this.flp_report.Controls.Add(this.lbl_reportStateCriteria);
            this.flp_report.Controls.Add(this.label12);
            this.flp_report.Controls.Add(this.cbox_reportDateCriteria);
            this.flp_report.Controls.Add(this.label13);
            this.flp_report.Controls.Add(this.cbox_reportPeriodCriteria);
            this.flp_report.Controls.Add(this.lbl_generateReport);
            this.flp_report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flp_report.Location = new System.Drawing.Point(0, 0);
            this.flp_report.Name = "flp_report";
            this.flp_report.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.flp_report.Size = new System.Drawing.Size(1117, 38);
            this.flp_report.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(3, 6);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 27);
            this.label10.TabIndex = 2;
            this.label10.Text = "1)  Showing Leads Based On";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_reportStateCriteria
            // 
            this.lbl_reportStateCriteria.AutoSize = true;
            this.lbl_reportStateCriteria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_reportStateCriteria.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbl_reportStateCriteria.Font = new System.Drawing.Font("Consolas", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_reportStateCriteria.Location = new System.Drawing.Point(154, 6);
            this.lbl_reportStateCriteria.Name = "lbl_reportStateCriteria";
            this.lbl_reportStateCriteria.Size = new System.Drawing.Size(32, 27);
            this.lbl_reportStateCriteria.TabIndex = 10;
            this.lbl_reportStateCriteria.Text = "N/A";
            this.lbl_reportStateCriteria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_reportStateCriteria.Click += new System.EventHandler(this.lbl_reportStateCriteria_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(192, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 27);
            this.label12.TabIndex = 6;
            this.label12.Text = "               2) The";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_reportDateCriteria
            // 
            this.cbox_reportDateCriteria.FormattingEnabled = true;
            this.cbox_reportDateCriteria.Location = new System.Drawing.Point(296, 9);
            this.cbox_reportDateCriteria.Name = "cbox_reportDateCriteria";
            this.cbox_reportDateCriteria.Size = new System.Drawing.Size(130, 21);
            this.cbox_reportDateCriteria.TabIndex = 5;
            this.cbox_reportDateCriteria.SelectedIndexChanged += new System.EventHandler(this.cbox_reportDateCriteria_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(432, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 27);
            this.label13.TabIndex = 7;
            this.label13.Text = "Date Is Within The Last";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbox_reportPeriodCriteria
            // 
            this.cbox_reportPeriodCriteria.FormattingEnabled = true;
            this.cbox_reportPeriodCriteria.Items.AddRange(new object[] {
            "Week",
            "Month",
            "Quarter Year"});
            this.cbox_reportPeriodCriteria.Location = new System.Drawing.Point(558, 9);
            this.cbox_reportPeriodCriteria.Name = "cbox_reportPeriodCriteria";
            this.cbox_reportPeriodCriteria.Size = new System.Drawing.Size(130, 21);
            this.cbox_reportPeriodCriteria.TabIndex = 8;
            // 
            // lbl_generateReport
            // 
            this.lbl_generateReport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_generateReport.Font = new System.Drawing.Font("Arial", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_generateReport.Location = new System.Drawing.Point(694, 6);
            this.lbl_generateReport.Name = "lbl_generateReport";
            this.lbl_generateReport.Size = new System.Drawing.Size(120, 27);
            this.lbl_generateReport.TabIndex = 9;
            this.lbl_generateReport.Text = "Generate";
            this.lbl_generateReport.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_generateReport.Click += new System.EventHandler(this.lbl_generateReport_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.label8);
            this.flowLayoutPanel3.Controls.Add(this.comboBox3);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1117, 38);
            this.flowLayoutPanel3.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(9, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 29);
            this.label8.TabIndex = 9;
            this.label8.Text = "Column Name :";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox3
            // 
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Arial Unicode MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(107, 9);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(208, 23);
            this.comboBox3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.panel4.Controls.Add(this.rbtn_reports);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1117, 38);
            this.panel4.TabIndex = 3;
            // 
            // rbtn_reports
            // 
            this.rbtn_reports.Appearance = System.Windows.Forms.Appearance.Button;
            this.rbtn_reports.AutoSize = true;
            this.rbtn_reports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_reports.Checked = true;
            this.rbtn_reports.Dock = System.Windows.Forms.DockStyle.Left;
            this.rbtn_reports.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_reports.FlatAppearance.BorderSize = 0;
            this.rbtn_reports.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_reports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_reports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.rbtn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rbtn_reports.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_reports.Location = new System.Drawing.Point(0, 0);
            this.rbtn_reports.Name = "rbtn_reports";
            this.rbtn_reports.Size = new System.Drawing.Size(108, 38);
            this.rbtn_reports.TabIndex = 8;
            this.rbtn_reports.TabStop = true;
            this.rbtn_reports.Text = "Report Settings";
            this.rbtn_reports.UseVisualStyleBackColor = false;
            // 
            // closeBarWin101
            // 
            this.closeBarWin101.BackColor = System.Drawing.Color.Transparent;
            // 
            // closeBarWin101.BTN_CLOSE
            // 
            this.closeBarWin101.BTN_CLOSE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.closeBarWin101.BTN_CLOSE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBarWin101.BTN_CLOSE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBarWin101.BTN_CLOSE.FlatAppearance.BorderSize = 0;
            this.closeBarWin101.BTN_CLOSE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.closeBarWin101.BTN_CLOSE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.closeBarWin101.BTN_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBarWin101.BTN_CLOSE.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBarWin101.BTN_CLOSE.ForeColor = System.Drawing.Color.White;
            this.closeBarWin101.BTN_CLOSE.Location = new System.Drawing.Point(1088, 0);
            this.closeBarWin101.BTN_CLOSE.Margin = new System.Windows.Forms.Padding(0);
            this.closeBarWin101.BTN_CLOSE.Name = "BTN_CLOSE";
            this.closeBarWin101.BTN_CLOSE.Size = new System.Drawing.Size(29, 71);
            this.closeBarWin101.BTN_CLOSE.TabIndex = 2;
            this.closeBarWin101.BTN_CLOSE.TabStop = false;
            this.closeBarWin101.BTN_CLOSE.Text = "X";
            this.closeBarWin101.BTN_CLOSE.UseVisualStyleBackColor = false;
            // 
            // closeBarWin101.BTN_MAX
            // 
            this.closeBarWin101.BTN_MAX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.closeBarWin101.BTN_MAX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBarWin101.BTN_MAX.FlatAppearance.BorderSize = 0;
            this.closeBarWin101.BTN_MAX.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.closeBarWin101.BTN_MAX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.closeBarWin101.BTN_MAX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBarWin101.BTN_MAX.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBarWin101.BTN_MAX.ForeColor = System.Drawing.Color.White;
            this.closeBarWin101.BTN_MAX.Location = new System.Drawing.Point(1059, 0);
            this.closeBarWin101.BTN_MAX.Margin = new System.Windows.Forms.Padding(0);
            this.closeBarWin101.BTN_MAX.Name = "BTN_MAX";
            this.closeBarWin101.BTN_MAX.Size = new System.Drawing.Size(29, 71);
            this.closeBarWin101.BTN_MAX.TabIndex = 1;
            this.closeBarWin101.BTN_MAX.TabStop = false;
            this.closeBarWin101.BTN_MAX.Text = "o";
            this.closeBarWin101.BTN_MAX.UseVisualStyleBackColor = false;
            // 
            // closeBarWin101.BTN_MIN
            // 
            this.closeBarWin101.BTN_MIN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.closeBarWin101.BTN_MIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBarWin101.BTN_MIN.FlatAppearance.BorderSize = 0;
            this.closeBarWin101.BTN_MIN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.closeBarWin101.BTN_MIN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.closeBarWin101.BTN_MIN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBarWin101.BTN_MIN.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBarWin101.BTN_MIN.ForeColor = System.Drawing.Color.White;
            this.closeBarWin101.BTN_MIN.Location = new System.Drawing.Point(1030, 0);
            this.closeBarWin101.BTN_MIN.Margin = new System.Windows.Forms.Padding(0);
            this.closeBarWin101.BTN_MIN.Name = "BTN_MIN";
            this.closeBarWin101.BTN_MIN.Size = new System.Drawing.Size(29, 71);
            this.closeBarWin101.BTN_MIN.TabIndex = 0;
            this.closeBarWin101.BTN_MIN.TabStop = false;
            this.closeBarWin101.BTN_MIN.Text = "v";
            this.closeBarWin101.BTN_MIN.UseVisualStyleBackColor = false;
            this.closeBarWin101.Dock = System.Windows.Forms.DockStyle.Top;
            this.closeBarWin101.IMG_SIZE = 74F;
            // 
            // closeBarWin101.LBL_IMG
            // 
            this.closeBarWin101.LBL_IMG.AutoSize = true;
            this.closeBarWin101.LBL_IMG.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.closeBarWin101.LBL_IMG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBarWin101.LBL_IMG.Image = global::Leads_Generator.Properties.Resources.leadsIcon_75;
            this.closeBarWin101.LBL_IMG.Location = new System.Drawing.Point(0, 0);
            this.closeBarWin101.LBL_IMG.Margin = new System.Windows.Forms.Padding(0);
            this.closeBarWin101.LBL_IMG.Name = "LBL_IMG";
            this.closeBarWin101.LBL_IMG.Size = new System.Drawing.Size(74, 71);
            this.closeBarWin101.LBL_IMG.TabIndex = 4;
            // 
            // closeBarWin101.LBL_TITLE
            // 
            this.closeBarWin101.LBL_TITLE.AutoSize = true;
            this.closeBarWin101.LBL_TITLE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(54)))), ((int)(((byte)(64)))));
            this.closeBarWin101.LBL_TITLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBarWin101.LBL_TITLE.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBarWin101.LBL_TITLE.ForeColor = System.Drawing.Color.White;
            this.closeBarWin101.LBL_TITLE.Location = new System.Drawing.Point(74, 0);
            this.closeBarWin101.LBL_TITLE.Margin = new System.Windows.Forms.Padding(0);
            this.closeBarWin101.LBL_TITLE.Name = "LBL_TITLE";
            this.closeBarWin101.LBL_TITLE.Size = new System.Drawing.Size(956, 71);
            this.closeBarWin101.LBL_TITLE.TabIndex = 3;
            this.closeBarWin101.LBL_TITLE.Text = "Leads Management";
            this.closeBarWin101.LBL_TITLE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBarWin101.Location = new System.Drawing.Point(0, 0);
            this.closeBarWin101.Name = "closeBarWin101";
            this.closeBarWin101.Size = new System.Drawing.Size(1117, 71);
            this.closeBarWin101.TabIndex = 8;
            this.closeBarWin101.TabStop = false;
            // 
            // closeBarWin101.TLP_MAIN
            // 
            this.closeBarWin101.TLP_MAIN.ColumnCount = 5;
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.closeBarWin101.TLP_MAIN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.closeBarWin101.TLP_MAIN.Location = new System.Drawing.Point(0, 0);
            this.closeBarWin101.TLP_MAIN.Name = "TLP_MAIN";
            this.closeBarWin101.TLP_MAIN.RowCount = 1;
            this.closeBarWin101.TLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBarWin101.TLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBarWin101.TLP_MAIN.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.closeBarWin101.TLP_MAIN.Size = new System.Drawing.Size(1117, 71);
            this.closeBarWin101.TLP_MAIN.TabIndex = 0;
            // 
            // context_reminderExport
            // 
            this.context_reminderExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.context_reminderExport.Name = "contextMenuStrip1";
            this.context_reminderExport.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_exportExcelReminder,
            this.btn_exportCSVReminder});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem1.Text = "Export";
            // 
            // btn_exportExcelReminder
            // 
            this.btn_exportExcelReminder.Name = "btn_exportExcelReminder";
            this.btn_exportExcelReminder.Size = new System.Drawing.Size(100, 22);
            this.btn_exportExcelReminder.Text = "Excel";
            this.btn_exportExcelReminder.Click += new System.EventHandler(this.btn_exportExcelReminder_Click);
            // 
            // btn_exportCSVReminder
            // 
            this.btn_exportCSVReminder.Name = "btn_exportCSVReminder";
            this.btn_exportCSVReminder.Size = new System.Drawing.Size(100, 22);
            this.btn_exportCSVReminder.Text = "CSV";
            this.btn_exportCSVReminder.Click += new System.EventHandler(this.btn_exportCSVReminder_Click);
            // 
            // context_reportExport
            // 
            this.context_reportExport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem4});
            this.context_reportExport.Name = "contextMenuStrip1";
            this.context_reportExport.Size = new System.Drawing.Size(108, 26);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_exportExcelReport,
            this.btn_exportCSVReport});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(107, 22);
            this.toolStripMenuItem4.Text = "Export";
            // 
            // btn_exportExcelReport
            // 
            this.btn_exportExcelReport.Name = "btn_exportExcelReport";
            this.btn_exportExcelReport.Size = new System.Drawing.Size(100, 22);
            this.btn_exportExcelReport.Text = "Excel";
            this.btn_exportExcelReport.Click += new System.EventHandler(this.btn_exportExcelReport_Click);
            // 
            // btn_exportCSVReport
            // 
            this.btn_exportCSVReport.Name = "btn_exportCSVReport";
            this.btn_exportCSVReport.Size = new System.Drawing.Size(100, 22);
            this.btn_exportCSVReport.Text = "CSV";
            this.btn_exportCSVReport.Click += new System.EventHandler(this.btn_exportCSVReport_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 566);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.pnl_navigation);
            this.Controls.Add(this.closeBarWin101);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_leads)).EndInit();
            this.context_export.ResumeLayout(false);
            this.pnl_leadsTop.ResumeLayout(false);
            this.pnl_leadsTop.PerformLayout();
            this.pnl_navigation.ResumeLayout(false);
            this.pnl_navigation.PerformLayout();
            this.tlp_navigation.ResumeLayout(false);
            this.tlp_navigation.PerformLayout();
            this.gbox_table.ResumeLayout(false);
            this.pnl_leadsPage.ResumeLayout(false);
            this.panel_leadsUpper.ResumeLayout(false);
            this.flowpanelLeads_temporaryAdd.ResumeLayout(false);
            this.flowpanelLeads_temporaryAdd.PerformLayout();
            this.flowpanelLeads_temporaryRemove.ResumeLayout(false);
            this.panel_body.ResumeLayout(false);
            this.panel_reminderPage.ResumeLayout(false);
            this.gbox_reminder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_reminder)).EndInit();
            this.panel2.ResumeLayout(false);
            this.flowpanelLeads_temporaryReminder.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel_reminderTop.ResumeLayout(false);
            this.panel_reminderTop.PerformLayout();
            this.pnl_reportPage.ResumeLayout(false);
            this.gbox_report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_report)).EndInit();
            this.panel3.ResumeLayout(false);
            this.flp_report.ResumeLayout(false);
            this.flp_report.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.closeBarWin101.TLP_MAIN.ResumeLayout(false);
            this.closeBarWin101.TLP_MAIN.PerformLayout();
            this.closeBarWin101.ResumeLayout(false);
            this.context_reminderExport.ResumeLayout(false);
            this.context_reportExport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_leads;
        private System.Windows.Forms.Button btn_importLeads;
        private System.Windows.Forms.Panel pnl_leadsTop;
        private System.Windows.Forms.Panel pnl_navigation;
        private System.Windows.Forms.Button btn_reminder;
        private System.Windows.Forms.Button btn_leads;
        private System.Windows.Forms.CheckBox chkbx_leadStatus;
        private System.Windows.Forms.CheckBox chkbx_leadInformation;
        private System.Windows.Forms.Button btn_addRecord;
        private System.Windows.Forms.GroupBox gbox_table;
        private System.Windows.Forms.Panel pnl_leadsPage;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.Panel panel_leadsUpper;
        private System.Windows.Forms.ComboBox cbox_columnType;
        private System.Windows.Forms.TextBox txt_columnName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbox_columnNames;
        private System.Windows.Forms.FlowLayoutPanel flowpanelLeads_temporaryRemove;
        private System.Windows.Forms.FlowLayoutPanel flowpanelLeads_temporaryAdd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbtn_addColumn;
        private System.Windows.Forms.RadioButton rbtn_removeColumn;
        private System.Windows.Forms.Label lbl_addColumn;
        private System.Windows.Forms.Panel panel_reminderPage;
        private System.Windows.Forms.GroupBox gbox_reminder;
        private System.Windows.Forms.DataGridView dgv_reminder;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowpanelLeads_temporaryReminder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Panel panel_reminderTop;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox cbox_reminderCriteria;
        private System.Windows.Forms.Label lbl_todayTasks;
        private System.Windows.Forms.TableLayoutPanel tlp_navigation;
        private System.Windows.Forms.Button btn_report;
        private System.Windows.Forms.Panel pnl_reportPage;
        private System.Windows.Forms.GroupBox gbox_report;
        private System.Windows.Forms.DataGridView dgv_report;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flp_report;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rbtn_reports;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbox_reportDateCriteria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_reminderCirteria;
        private System.Windows.Forms.Label lbl_reportDateCriteria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbox_reportPeriodCriteria;
        private System.Windows.Forms.Label lbl_generateReport;
        private System.Windows.Forms.Label lbl_reportStateCriteria;
        private System.Windows.Forms.ContextMenuStrip context_export;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_exportExcel;
        private System.Windows.Forms.ToolStripMenuItem btn_exportCSV;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label colorize_email;
        private System.Windows.Forms.Label colorize_call;
        private System.Windows.Forms.Label colorize_sample;
        private System.Windows.Forms.Label colorize_none;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.CheckBox chkbx_coldLeads;
        private System.Windows.Forms.CheckBox chkbx_lstleads;
        private CloseBarWin10.CloseBarWin10 closeBarWin101;
        private System.Windows.Forms.ContextMenuStrip context_reminderExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem btn_exportExcelReminder;
        private System.Windows.Forms.ToolStripMenuItem btn_exportCSVReminder;
        private System.Windows.Forms.ContextMenuStrip context_reportExport;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem btn_exportExcelReport;
        private System.Windows.Forms.ToolStripMenuItem btn_exportCSVReport;

    }
}

