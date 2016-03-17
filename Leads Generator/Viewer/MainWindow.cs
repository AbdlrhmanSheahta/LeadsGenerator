using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Text;
using System.Data.OleDb;
using System.Linq;
using System.Xml;
using OfficeOpenXml;
using System.Drawing;

namespace Leads_Generator
{
    public partial class MainWindow : Form
    {
        #region ooooooooooooooooooooooooooo G L O B A L S ooooooooooooooooooooooooooo
        
        private static string PATH_LEADS = Application.StartupPath + "\\Databases\\Leads.txt";
        private static string PATH_SCHEMA = Application.StartupPath + "\\Databases\\Schema.txt";
        private static string PATH_ACCDB = Application.StartupPath + "\\Databases\\Database.accdb";
        private static string PATH_REMINDER_CRITERIA = Application.StartupPath + "\\Files\\ReminderCriteria.txt";
        private static string PATH_REPORT_STATE_CRITERIA = Application.StartupPath + "\\Files\\ReportStateCriteria.txt";
        private static string PATH_REPORT_DATE_CRITERIA = Application.StartupPath + "\\Files\\ReportDateCriteria.txt";
        
        const string REMINDER_NOTSET = "N/A";
        const string XML_HEADER = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";

        private Color[] ColoringThemes = new Color[] { Color.Red, Color.Orange, Color.Yellow}; // Call , Email , Sample
        #endregion

         

        #region ooooooooooooooooooooooooooo M E T H O D S ooooooooooooooooooooooooooo

        private void Export_DGV(string schema_file,string data_file, DataGridView dgv)
        {
            //Write Schema
            int num_columns = dgv.Columns.Count;
            if (num_columns > 0)
            {
                string[] schema = new string[num_columns];
                DataGridViewColumn[] ordered_columns = OrderedColumns(dgv);
                for (int i = 0; i < ordered_columns.Length; i++)
                {
                    DataGridViewColumn col = ordered_columns[i];
                    schema[i] = col.HeaderText.Replace(' ', '_') + ";" + col.ValueType.ToString();
                }
                File.WriteAllLines(schema_file, schema);

                //Write Data
                XmlTable table = new XmlTable(lbl_reminderCirteria.Text);
                foreach (DataGridViewRow row in dgv_leads.Rows)
                {
                    table.AddRow(row);
                }
                File.WriteAllText(data_file, table.Xml);
            }
        }
        private void Import_DGV(string schema_file,string data_file, DataGridView dgv)
        {
            //Import Schema
            string[] total_column_information = File.ReadAllLines(schema_file);
            if (total_column_information.Length > 0)
            {
                foreach (string current_column_information in total_column_information)
                {
                    string[] NameType = current_column_information.Split(';');
                    string column_name = NameType[0];
                    string column_type = NameType[1];

                    if (column_type == typeof(bool).ToString())
                    {
                        DataGridViewColumn new_column = new DataGridViewCheckBoxColumn()
                        {
                            Name = column_name,
                            HeaderText = column_name,
                            CellTemplate = new DataGridViewCheckBoxCell(),
                            ValueType = column_type.ToType()
                        };
                        dgv.Columns.Add(new_column);
                    }
                    else
                    {
                        DataGridViewColumn new_column = new DataGridViewColumn()
                        {
                            Name = column_name,
                            HeaderText = column_name,
                            CellTemplate = new DataGridViewTextBoxCell(),
                            ValueType = column_type.ToType(),
                        };
                        dgv.Columns.Add(new_column);
                    }
                }
                //Add Data
                string xml = File.ReadAllText(PATH_LEADS);
                if (xml != null && xml.Length > 0)
                {
                    XmlDocument doc = new XmlDocument();
                    doc.LoadXml(xml);
                    XmlNodeList rows = doc.GetElementsByTagName("row");
                    foreach (XmlNode row in rows)
                    {
                        //bool colorize = false;
                        //string bcolor = "";
                        XmlNodeList cells = row.ChildNodes;
                        string[] values = new string[cells.Count];
                        
                        for (int i = 0; i < cells.Count; i++)
                        {
                            //if (cells[i].Attributes.Count != 0)
                            //{
                            //    bcolor = "<" + cells[i].Attributes[0].InnerText + ">";
                            //    colorize = true;
                            //}
                            values[i] = cells[i].InnerText;
                        }
                        dgv_leads.Rows.Add(values);
                        //if (colorize)
                        //{
                        //    bcolor = bcolor.Replace("<","");
                        //    bcolor = bcolor.Replace(">","");
                        //    if (dgv_leads.Columns.Contains(lbl_reminderCirteria.Text))
                        //    {
                        //        dgv_leads.Rows[dgv_leads.Rows.Count - 1].Cells[lbl_reminderCirteria.Text].Style.BackColor = bcolor.ToColor();   

                        //    }
                        //}

                    }
                }
            }
        }

        private void Import_LeadsOnly(string data_file,DataGridView dgv) {
            if (data_file != null)
            {
                string[] data_lines = File.ReadAllLines(data_file);
                foreach (string data_line in data_lines)
                {
                    string[] records = data_line.Split(',');
                    if (records.Length > 0)
                    {
                        dgv.Rows.Add(records);
                    }
                }
            }
        }
        private DataGridViewColumn NewColumn() {
            string name = txt_columnName.Text.Replace(' ','_');

            if (!string.IsNullOrWhiteSpace(name))
            {
                DataGridViewColumn normal_column = new DataGridViewColumn();
                DataGridViewCheckBoxColumn chkbx_column = new DataGridViewCheckBoxColumn();

                normal_column.Name = name;
                normal_column.HeaderText = name;

                chkbx_column.Name = name;
                chkbx_column.HeaderText = name;
                switch (cbox_columnType.SelectedIndex)
                {
                    case 0: // Text
                        normal_column.CellTemplate = new DataGridViewTextBoxCell();
                        normal_column.ValueType = typeof(string);
                        return normal_column;
                    case 1: // Yes/No
                        chkbx_column.Name = name;
                        chkbx_column.ValueType = typeof(bool);
                        chkbx_column.FalseValue = "False";
                        chkbx_column.TrueValue = "True";
                        chkbx_column.CellTemplate = new DataGridViewCheckBoxCell();
                        return chkbx_column;
                    case 2: // Number
                        normal_column.CellTemplate = new DataGridViewTextBoxCell();
                        normal_column.ValueType = typeof(Int32);
                        return normal_column;
                    //case 3: // Date
                    //    normal_column.CellTemplate = new DataGridViewTextBoxCell();
                    //    normal_column.ValueType = typeof(DateTime);
                    //    return normal_column;
                    default:
                        return null;
                }
            }
            else
            {
                return null;
            }
        }

        /*                          DAILY TASKS VERSION                 */

        private void UpdateDailyTasks(string based_on) {

            //Find Daily Tasks
            List<DataGridViewRow> target_rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgv_leads.Rows)
            {
                DataGridViewCell cell = row.Cells[based_on];
                if (cell.Value != null)
                {
                    string date = cell.Value.ToString();
                    if (date == DateTime.Now.ToShortDateString())
                    {           
                        target_rows.Add(dgv_leads.Rows[cell.RowIndex]);
                    }
                }
            }

            //Update Label
            lbl_todayTasks.Text = target_rows.Count.ToString();

            //Update Reminder Table
            
            dgv_reminder.Rows.Clear();
            dgv_reminder.Columns.Clear();

            foreach (DataGridViewColumn column_to_add in dgv_leads.Columns)
            {
                dgv_reminder.Columns.Add((DataGridViewColumn)column_to_add.Clone());
            }
            foreach (DataGridViewRow row in target_rows)
            {
                DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    clonedRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgv_reminder.Rows.Add(clonedRow);
            }
        }
        private void SetReminderCriteria() {
            foreach (DataGridViewColumn column in dgv_leads.Columns)
            {
                cbox_reminderCriteria.Items.Add(column.Name);    
            }
            string criteria = File.ReadAllText(PATH_REMINDER_CRITERIA);
            if (cbox_reminderCriteria.Items.Contains(criteria))
            {
                lbl_reminderCirteria.Text = criteria;
                cbox_reminderCriteria.Text = criteria;
            }
            else
            {
                lbl_reminderCirteria.Text = REMINDER_NOTSET;
            }
        }
        private void SetReportCriteria() {
            foreach (DataGridViewColumn column in dgv_leads.Columns)
            {
                cbox_reportDateCriteria.Items.Add(column.Name);

            }
            string date_criteria = File.ReadAllText(PATH_REPORT_DATE_CRITERIA);

            lbl_reportDateCriteria.Text = (cbox_reportDateCriteria.Items.Contains(date_criteria)) ? date_criteria : REMINDER_NOTSET;
            cbox_reportDateCriteria.Text = (cbox_reportDateCriteria.Items.Contains(date_criteria)) ? date_criteria : REMINDER_NOTSET;
        }
        private DataGridViewColumn[] OrderedColumns(DataGridView dgv) {
            List<DataGridViewColumn> output = new List<DataGridViewColumn>();

            Dictionary<int, int> dict = new Dictionary<int, int>();
            foreach (DataGridViewColumn column in dgv.Columns)
            {
                dict.Add(column.Index, column.DisplayIndex);
            }
            foreach (KeyValuePair<int, int> item in dict.OrderBy(x => x.Value))
            {
                output.Add(dgv_leads.Columns[item.Key]);
            }

            return output.ToArray();
        }


        /*                          REPORTS SECTION                     */

        private bool ReportCriteriaOkay()
        {
            bool okay = false;
            string[] criteria = lbl_reportStateCriteria.Text.Split(',');
            foreach (string criterion in criteria)
            {
                bool partial_okay = dgv_leads.Columns.Contains(criterion);
                if (!partial_okay) {
                    return false;
                }
                else
                {
                    okay = true;
                }
            }
            return okay;
        }
        private string PreviousDate(int num_days) {
            DateTime time = DateTime.Now;
            time = time.AddDays(-num_days);
            return time.Month + "/" + time.Day + "/" + time.Year;
        }
        private int NumberOfDays() {
            switch (cbox_reportPeriodCriteria.SelectedIndex)
            {
                case 1:
                    return 7;
                case 2:
                    return 30;
                case 3:
                    return 120;
                default:
                    return 7;
            }
        }
        private void GenerateReports(string date_based_on,string[] state_based_on,int num_days) {

            //Find Target Rows Based On Two Conditions
            List<DataGridViewRow> target_rows = new List<DataGridViewRow>();
            foreach (DataGridViewRow row in dgv_leads.Rows)
            {
                // 1) check state
                bool state = false;
                foreach (string based in state_based_on)
                {
                    DataGridViewCell the_cell = row.Cells[based];
                    if (the_cell.Value!=null)
                    {
                        string the_cell_state = the_cell.Value.ToString();
                        if (the_cell_state == "True")
                        {
                            state = true;
                        }
                        else
                        {
                            state = false;
                            break;
                        }
                    }
                    
                }

                // 2) check date

                DataGridViewCell cell_date = row.Cells[date_based_on];
                if (cell_date.Value != null)
                {
                    DateTime date = cell_date.Value.ToString().AmericanDate();
                    DateTime prev_date = PreviousDate(num_days).AmericanDate();
                    
                    if (date != new DateTime(1,1,1) && prev_date != new DateTime(1,1,1))
                    {
                        if (date >= prev_date && state)
                        {
                            target_rows.Add(dgv_leads.Rows[cell_date.RowIndex]);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please have a look on your Report-Criteria.");
                    }
                }
            }

            //Update Reminder Table

            dgv_report.Rows.Clear();
            dgv_report.Columns.Clear();

            foreach (DataGridViewColumn column_to_add in dgv_leads.Columns)
            {
                dgv_report.Columns.Add((DataGridViewColumn)column_to_add.Clone());
            }
            foreach (DataGridViewRow row in target_rows)
            {
                DataGridViewRow clonedRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    clonedRow.Cells[i].Value = row.Cells[i].Value;
                }
                dgv_report.Rows.Add(clonedRow);
            }

        }

        private void tst(DataGridView dgv,DataGridViewColumn[] ordered_columns,string data_file) {
            //Original
            
            //Write Data
            //int num_rows = dgv.Rows.Count;
            //string[] rows = new string[num_rows];
            //for (int i = 0; i < dgv.Rows.Count; i++)
            //{
            //    DataGridViewRow row = dgv.Rows[i];
            //    string new_line = "";
            //    for (int j = 0; j < row.Cells.Count; j++)
            //    {
            //        DataGridViewCell cell = row.Cells[ordered_columns[j].Name];
            //        string value = "";
            //        if (cell.ValueType == typeof(bool))
            //        {
            //            value = (cell.Value != null) ? cell.Value.ToString() : "False";
            //        }
            //        else
            //        {
            //            value = (cell.Value != null) ? cell.Value.ToString() : "";
            //        }
            //        new_line += value + ",";
            //    }
            //    rows[i] = (new_line.TrimEnd(','));
            //}
            //File.WriteAllLines(data_file, rows);




            ////NEW
            //XmlTable table = new XmlTable();
            //foreach (DataGridViewRow row in dgv.Rows)
            //{
            //    table.AddRow(row);
            //}
        }


        /*                          Export */
        private string DatagridViewToCSV() {
            StringBuilder output = new StringBuilder();
            //Add columns
            foreach (DataGridViewColumn col in dgv_leads.Columns)
            {
                output.Append(col.Name + ",");
            }
            output = new StringBuilder(output.ToString().TrimEnd(','));
            output.AppendLine();

            //AddRows
            foreach (DataGridViewRow row in dgv_leads.Rows)
            {
                string roww = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        roww += cell.Value.ToString().Replace("\r\n", "").Replace(",", "") + ",";
                    }
                    else
                    {
                        roww += "";
                    }
                }
                output.AppendLine(roww.TrimEnd(','));
            }
            return output.ToString();
        }
        private void ExportCSV() {
            string filename = Essentials.Essentials.SaveFileDialogResult(Essentials.Essentials.Filters.CSV);
            if (filename != null)
            {
                //Save
                File.WriteAllText(filename,DatagridViewToCSV());
            }
        }
        private void ExportExcel() {
            string file_name = Essentials.Essentials.SaveFileDialogResult(Essentials.Essentials.Filters.Excelfiles);
            using (ExcelPackage package = new ExcelPackage(new FileInfo(file_name)))
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add(Path.GetFileNameWithoutExtension(file_name));
                worksheet.Cells["A1"].LoadFromText(DatagridViewToCSV(), new ExcelTextFormat() { Delimiter = ',', EOL = "\r\n" }, OfficeOpenXml.Table.TableStyles.Medium27, true);
                package.Save();
            }
        }
        #endregion

         


        #region ooooooooooooooooooooooooooo H A N D L E R S ooooooooooooooooooooooooooo


        public MainWindow()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_reportStateCriteria.Text = File.ReadAllText(PATH_REPORT_STATE_CRITERIA);
            if (lbl_reminderCirteria.Text != REMINDER_NOTSET)
            {
                UpdateDailyTasks(lbl_reminderCirteria.Text);
            }
            Import_DGV(PATH_SCHEMA, PATH_LEADS, dgv_leads);
            SetReminderCriteria();
            SetReportCriteria();
        }
        private void btn_importLeads_Click(object sender, EventArgs e)
        {
            string filename = Essentials.Essentials.OpenFileDialogResult(Essentials.Essentials.Filters.CSV);
            Import_LeadsOnly(filename,dgv_leads);
            if (lbl_reminderCirteria.Text != REMINDER_NOTSET)
            {
                UpdateDailyTasks(lbl_reminderCirteria.Text);
            }
        }

        //  ------------------------ Navigation Menu ------------------------

        private void btn_reminder_Click(object sender, EventArgs e)
        {
            //Design
            btn_leads.Image = global::Leads_Generator.Properties.Resources.lead_40;
            btn_reminder.Image = global::Leads_Generator.Properties.Resources.yellow_alarm_40;
            btn_report.Image = Properties.Resources.report_40;
            panel_reminderPage.BringToFront();

            //Update Everything
            dgv_leads.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if (lbl_reminderCirteria.Text != REMINDER_NOTSET)
            {
                UpdateDailyTasks(lbl_reminderCirteria.Text);   
            }
        }
        private void btn_leads_Click(object sender, EventArgs e)
        {
            btn_leads.Image = global::Leads_Generator.Properties.Resources.yellow_lead_40;
            btn_reminder.Image = global::Leads_Generator.Properties.Resources.alarm_40;
            btn_report.Image = Properties.Resources.report_40;
            pnl_leadsPage.BringToFront();
        }

        private void btn_report_Click(object sender, EventArgs e)
        {
            btn_leads.Image = global::Leads_Generator.Properties.Resources.lead_40;
            btn_reminder.Image = global::Leads_Generator.Properties.Resources.alarm_40;
            btn_report.Image = Properties.Resources.yellow_report_40;
            pnl_reportPage.BringToFront();
        }
        
        // --------------------------- Leads Page -----------------------
        private void btn_addRecord_Click(object sender, EventArgs e)
        { 
            dgv_leads.AllowUserToAddRows = true;
        }
        private void rbtn_addColumn_CheckedChanged(object sender, EventArgs e)
        {
            flowpanelLeads_temporaryAdd.BringToFront();
        }
        private void rbtn_removeColumn_CheckedChanged(object sender, EventArgs e)
        {
            //Prepare ColumnNames
            cbox_columnNames.Items.Clear();
            foreach (DataGridViewColumn col in dgv_leads.Columns)
            {
                cbox_columnNames.Items.Add(col.Name);
            }

            flowpanelLeads_temporaryRemove.BringToFront();
        }
        /* remove column */
        private void cbox_columnNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Essentials.Essentials.ConfirmSave("Are you sure you want to delete that table!", "CRITICAL"))
            {
                dgv_leads.Columns.Remove(cbox_columnNames.SelectedItem.ToString());
                SetReminderCriteria();
            }
            cbox_columnNames.Text = "";
            rbtn_addColumn.Checked = true;
        }
        private void lbl_addColumn_Click(object sender, EventArgs e)
        {
            DataGridViewColumn column = NewColumn();
            if (column != null)
            {
                dgv_leads.Columns.Add(NewColumn());   
            }
            txt_columnName.Clear();
            txt_columnName.Focus();
            SetReminderCriteria();
        }
        private void txt_columnName_TextChanged(object sender, EventArgs e)
        {
            lbl_addColumn.Enabled = txt_columnName.TextLength > 0 & cbox_columnType.SelectedIndex != -1;
        }
        private void chkbx_leadStatus_CheckedChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in dgv_leads.Columns)
            {
                if (col.ValueType == typeof(bool))
                {
                    col.Visible = chkbx_leadStatus.Checked;
                }
            }
            //DataGridViewColumn[] columns = new DataGridViewColumn[] { table.Columns["follow_up"], table.Columns["p_follow_up"], table.Columns["priority_1"], table.Columns["priority_2"], table.Columns["priority_3"], table.Columns["cold_lead"], table.Columns["lost_lead"], table.Columns["closed_lead"] };
            //foreach (DataGridViewColumn column in columns)
            //{
            //    column.Visible = chkbx_leadStatus.Checked;
            //}
        }
        private void chkbx_leadInformation_CheckedChanged(object sender, EventArgs e)
        {
            DataGridViewColumn[] columns = new DataGridViewColumn[] { dgv_leads.Columns["company"], dgv_leads.Columns["phone"], dgv_leads.Columns["email"] };
            foreach (DataGridViewColumn column in columns)
            {
                column.Visible = chkbx_leadInformation.Checked;
            }
           
        }
        private void rbtn_coloring_CheckedChanged(object sender, EventArgs e)
        {
            flp_coloring.BringToFront();
        }
        
        // --------------------------- Report Page -----------------------
        private void cbox_reportDateCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selected = cbox_reportDateCriteria.SelectedItem.ToString();
            lbl_reportDateCriteria.Text = selected;
            File.WriteAllText(PATH_REPORT_DATE_CRITERIA, selected);
        }
        private void lbl_generateReport_Click(object sender, EventArgs e)
        {
            if (ReportCriteriaOkay())
            {
                if (cbox_reportPeriodCriteria.SelectedIndex == -1)
                {
                    cbox_reportPeriodCriteria.SelectedIndex = 0;
                }
                GenerateReports(lbl_reportDateCriteria.Text, lbl_reportStateCriteria.Text.Split(','), NumberOfDays());
            }
            else
            {
                MessageBox.Show("Please have a look on Report-Criteria");
            }
           
        }
        private void lbl_reportStateCriteria_Click(object sender, EventArgs e)
        {
            ReportCriteriaForm form = new ReportCriteriaForm(dgv_leads, new string[] { });
            form.ShowDialog();
            if (form.Result != null)
            {
                lbl_reportStateCriteria.Text = form.Result;
                File.WriteAllText(PATH_REPORT_STATE_CRITERIA, lbl_reportStateCriteria.Text);
                lbl_generateReport_Click(sender, e);
            }
        }       

        //--------------------------- Export -----------------------
        private void btn_exportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }
        private void btn_exportCSV_Click(object sender, EventArgs e)
        {
            ExportCSV();
        }

        //--------------------------- Coloring -----------------------
        private void colorize_email_Click(object sender, EventArgs e)
        {
            Coloring.Colorize(dgv_leads.SelectedCells[0], Coloring.FollowUpMethod.Email, ColoringThemes, true);
        }
        private void colorize_call_Click(object sender, EventArgs e)
        {
            Coloring.Colorize(dgv_leads.SelectedCells[0], Coloring.FollowUpMethod.Call, ColoringThemes, true);
        }

        private void colorize_sample_Click(object sender, EventArgs e)
        {
            Coloring.Colorize(dgv_leads.SelectedCells[0], Coloring.FollowUpMethod.Sample, ColoringThemes, true);
        }

        private void colorize_none_Click(object sender, EventArgs e)
        {
            Coloring.Colorize(dgv_leads.SelectedCells[0], Coloring.FollowUpMethod.None, ColoringThemes, true);
        }


        //--------------------------- Others -----------------------
        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Export_DGV(PATH_SCHEMA, PATH_LEADS, dgv_leads);
        }
        private void table_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dgv_leads.AllowUserToAddRows = false;
            if (lbl_reminderCirteria.Text != REMINDER_NOTSET)
            {
                if (dgv_leads.SelectedCells[0].OwningColumn == dgv_leads.Columns[lbl_reminderCirteria.Text])
                {
                    UpdateDailyTasks(lbl_reminderCirteria.Text);
                }
            }

        }
        private void cbox_reminderCriteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_reminderCirteria.Text = cbox_reminderCriteria.SelectedItem.ToString();
            File.WriteAllText(PATH_REMINDER_CRITERIA, cbox_reminderCriteria.SelectedItem.ToString());
            if (lbl_reminderCirteria.Text != REMINDER_NOTSET)
            {
                UpdateDailyTasks(lbl_reminderCirteria.Text);
            }
        }
        private void table_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Invalid Data Type!");
        }
        private void closeBar1_LBL_IMG_Click(object sender, EventArgs e)
        {

        }

      

        #endregion

    
       
    }

    static class AccessModel
    {
        public static string GetConnectionString(string filename)
        {
            Dictionary<string, string> props = new Dictionary<string, string>();            
            props["Provider"] = "Microsoft.ACE.OLEDB.12.0;";
            //props["Provider"] = "Microsoft.Jet.OLEDB.4.0";
            props["Persist Security Info"] = "false";
            props["Data Source"] = filename;

            StringBuilder sb = new StringBuilder();
            foreach (KeyValuePair<string, string> prop in props)
            {
                sb.Append(prop.Key);
                sb.Append('=');
                sb.Append(prop.Value);
                sb.Append(';');
            }

            return sb.ToString();
        }
        public static List<string> TableNames(string databasePath)
        {
            string ConnString = GetConnectionString(databasePath);
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConnString;
            cn.Open();
            List<string> _TableNames = new List<string>();
            object[] obj = new object[4] { null, null, null, "table" };
            DataTable Table = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, obj);
            foreach (DataRow Row in Table.Rows)
            {
                _TableNames.Add(Row["TABLE_NAME"].ToString());
            }
            cn.Close();
            return _TableNames;
        }
        public static Dictionary<string, DataTable> Tables(string databasePath)
        {
            Dictionary<string, DataTable> ret = new Dictionary<string, DataTable>();
            //Start Connection
            string ConnString = GetConnectionString(databasePath);
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConnString;
            cn.Open();

            //Get TableNames
            List<string> table_names = new List<string>();
            object[] obj = new object[4] { null, null, null, "table" };
            DataTable Table1 = cn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, obj);
            foreach (DataRow Row in Table1.Rows)
            {
                table_names.Add(Row["TABLE_NAME"].ToString());
            }

            //Get Tables
            foreach (string table_name in table_names)
            {
                string sql = "select*from " + table_name;
                DataTable Table2 = new DataTable();
                OleDbDataAdapter da = new OleDbDataAdapter(sql, cn);
                da.Fill(Table2);
                ret.Add(table_name, Table2);
            }
            cn.Close();
            return ret;
        }
        public static void UpdateTable(string databasePath, string TableName, DataGridView dgv)
        {
            //Start Connection
            string ConnString = GetConnectionString(databasePath);
            OleDbConnection cn = new OleDbConnection();
            cn.ConnectionString = ConnString;
            cn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter();
            DataTable UpdateFrom = (DataTable)dgv.DataSource;
            da = new OleDbDataAdapter("Select * from " + TableName, cn);
            OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
            //cb.QuotePrefix = "[";
            //cb.QuoteSuffix = "]";
            da.Update(UpdateFrom);
            cn.Close();
        }
    }
    static class Coloring{
        public enum FollowUpMethod
        {
            Call,
            Email,
            Sample,
            None
        }
        public static void Colorize(DataGridViewCell cell,FollowUpMethod method,Color[] theme,bool backColor) {
            Color color_to_use = new Color();
            switch (method)
            {
                case FollowUpMethod.Call:
                    color_to_use = theme[0];
                    break;
                case FollowUpMethod.Email:
                    color_to_use = theme[1];
                    break;
                case FollowUpMethod.Sample:
                    color_to_use = theme[2];
                    break;
                case FollowUpMethod.None:
                    color_to_use = Color.White;
                    break;
                default:
                    color_to_use = Color.White;
                    break;
            }
            if (backColor)
            {
                cell.Style.BackColor = color_to_use;
            }
            else
            {
                cell.Style.ForeColor = color_to_use;
            }
        }
    }
    
}




#region -------------- XMLMethod --------------
//private void ImportDataGridView()
//{
//    string content = File.ReadAllText(PATH_DATA);
//    if (content.Length > 0)
//    {
//        DataTable my_table = new DataTable();
//        my_table.ReadXmlSchema(PATH_SCHEMA);
//        my_table.ReadXml(PATH_DATA);
//        dgv_leads.DataSource = my_table;
//        foreach (DataGridViewColumn col in dgv_leads.Columns)
//        {
//            string toparse = col.HeaderText;
//            int width = int.Parse(toparse.Split('_')[toparse.Split('_').Length - 1]);
//            col.HeaderText = my_table.Columns[col.HeaderText].Caption;
//            col.Width = width;
//        }
//    }
//}
#endregion
#region -------------- SimpleMethod --------------

//private void ImportCSV(string filename)
//{
//    Essentials.TimeTracker tkr = new Essentials.TimeTracker();
//    string[] lines = File.ReadAllLines(filename);

//    if (lines.Length >0)
//    {
//        bool identical = true;
//        string[] csv_columns = lines[0].Split(',');
//        //Compare CSV with current Template
//        for (int i = 0; i < dgv_leads.Columns.Count; i++)
//        {
//            if (csv_columns[i] != dgv_leads.Columns[i].HeaderText)
//            {
//                identical = false;
//                break;
//            }
//        }
//        if (identical)
//        {
//            for (int i = 1; i < lines.Length; i++)
//            {
//                dgv_leads.Rows.Add(lines[i].Split(','));
//            }
//        }
//    }
//    tkr.PopUpInterval();
//}
//private void ExportCSV()
//{
//    StringBuilder output = new StringBuilder();

//    // Add Column Headers
//    foreach (DataGridViewColumn col in dgv_leads.Columns)
//    {
//        output.Append(col.HeaderText + ",");
//    }
//    output.Remove(output.Length - 1, 1);
//    output.Append("\r\n");

//    //Add Rows
//    foreach (DataGridViewRow row in dgv_leads.Rows)
//    {
//        StringBuilder line = new StringBuilder("");
//        foreach (DataGridViewCell cell in row.Cells)
//        {
//            string toadd = "";
//            if (cell.Value != null)
//            {
//                toadd = cell.Value.ToString();   
//            }
//            line.Append(toadd + ",");
//        }
//        line = line.Remove(line.Length - 1, 1);

//        //Checks if it's empty row
//        if (line.ToString() != ",,,,,,")
//        {
//            output.Append(line.ToString() + "\r\n");
//        }
//    }
//    File.WriteAllText(PATH_LEADS, output.ToString());
//}

#endregion
#region -------------- SQLite --------------

////Import
//private DataTable SQliteTable()
//{
//    SQLiteConnection connection = new SQLiteConnection("Data Source=" + PATH_SQLITE + ";Version=3;");
//    connection.Open();
//    DataTable dt = new DataTable();
//    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from MainTable", connection);
//    adapter.Fill(dt);
//    connection.Close();
//    return dt;
//}
//private void SQLite_DGV()
//{
//    dgv_leads.DataSource = SQliteTable();
//}
////Export
//private void DGV_SQLite()
//{
//    //DataTable tosave = (DataTable)table.DataSource;
//    //tosave.WriteXmlSchema(PATH_SCHEMA);
//    //tosave.WriteXml(PATH_DATA);

//    //DataTable export_table = new DataTable() { TableName = "Table1" };
//    //foreach (DataGridViewColumn col in table.Columns)
//    //{
//    //    Type mytype=typeof(bool);
//    //    if (col.CellType == typeof(DataGridViewTextBoxCell))
//    //    {
//    //        mytype = typeof(string);
//    //    }
//    //    DataColumn toadd = new DataColumn() { 
//    //        ColumnName = col.Name,
//    //        Caption  = col.HeaderText,
//    //        DataType = mytype
//    //    };
//    //    export_table.Columns.Add(toadd);
//    //}

//    //foreach (DataGridViewRow row in table.Rows)
//    //{
//    //    DataRow toadd = export_table.NewRow();
//    //    foreach (DataGridViewCell cell in row.Cells)
//    //    {
//    //        toadd[cell.ColumnIndex] = cell.Value;
//    //    }
//    //    export_table.Rows.Add(toadd);
//    //}
//    //export_table.WriteXmlSchema(PATH_SCHEMA);
//    //export_table.WriteXml(PATH_DATA);
//    SQLiteConnection cn = new SQLiteConnection("Data Source=" + PATH_SQLITE + ";Version=3;");
//    cn.Open();
//    DataTable update_with = (DataTable)dgv_leads.DataSource;
//    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from MainTable", cn);
//    SQLiteCommandBuilder bldr = new SQLiteCommandBuilder(adapter);
//    bldr.QuotePrefix = "[";
//    bldr.QuoteSuffix = "]";
//    adapter.Update(update_with);
//    cn.Close();
//}

////New Record
//private void AddNewRecord()
//{
//    string sql = "INSERT INTO `MainTable`(`Lead_Name`,`Company`,`Email`,`Phone`,`FU`,`PFU`,`P1`,`P2`,`P3`,`Cold`,`Closed`,`Lost`,`Owner`,`Generation_Date`,`Next_Follow_Up`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)";
//    SQLiteConnection connection = new SQLiteConnection("Data Source=" + PATH_SQLITE + ";Version=3;");
//    connection.Open();
//    new SQLiteCommand(sql, connection).ExecuteNonQuery();
//    connection.Close();
//}
//private void AddNewRecords()
//{
//    string sql = "INSERT INTO `MainTable`(`Lead_Name`,`Company`,`Email`,`Phone`,`FU`,`PFU`,`P1`,`P2`,`P3`,`Cold`,`Closed`,`Lost`,`Owner`,`Generation_Date`,`Next_Follow_Up`) VALUES (NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL,NULL)";
//    SQLiteConnection connection = new SQLiteConnection("Data Source=" + PATH_SQLITE + ";Version=3;");
//    connection.Open();
//    new SQLiteCommand(sql, connection).ExecuteNonQuery();
//    new SQLiteCommand(sql, connection).ExecuteNonQuery();
//    new SQLiteCommand(sql, connection).ExecuteNonQuery();
//    new SQLiteCommand(sql, connection).ExecuteNonQuery();
//    connection.Close();
//}

#endregion
#region -------------- MsSqlCompact ------------
//    private void SqlCE_DGV() {
//        string connectionString = "DataSource="+PATH_SQLCOMPACT;
//        SqlCeConnection connection = new SqlCeConnection(connectionString);
//        connection.Open();
//        DataTable dt = new DataTable();
//        new SqlCeDataAdapter("select * from MainTable", connection).Fill(dt);
//        dgv_leads.DataSource = dt;
//        connection.Close();
//    }
//    private void DGV_SqlCE() {
//        string connectionString = "DataSource=" + PATH_SQLCOMPACT;
//        SqlCeConnection connection = new SqlCeConnection(connectionString);
//        connection.Open();

//        DataTable update_with = (DataTable)dgv_leads.DataSource;
//        SqlCeDataAdapter adapter = new SqlCeDataAdapter();
//        SqlCeCommandBuilder cmd_builder = new SqlCeCommandBuilder(adapter);
//        adapter.SelectCommand = new SqlCeCommand("select * from MainTable", connection);
//        adapter.Update(update_with);

//        connection.Close();
//    }
#endregion
#region -------------- ACCDB --------------

//private void ACCDB_DGV()
//{
//    string connection_string = AccessModel.GetConnectionString(PATH_ACCDB);
//    OleDbConnection connection = new OleDbConnection(connection_string);
//    connection.Open();

//    //Get Data
//    DataTable update_with = new DataTable();
//    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from MainTable",connection);
//    adapter.Fill(update_with);

//    ////Get Schema
//    //DataTable schema_table1 = connection.GetSchema("DataTypes");
//    //DataTable schema_table2 = connection.GetSchema("Columns");
//    //DataTable schema_table3 = connection.GetSchema("Tables");
//    //DataTable schema_table4 = connection.GetSchema("Indexes");
//    //DataTable schema_table5 = connection.GetSchema("Views");
//    //DataTable schema_table6 = connection.GetSchema("Restrictions");
//    //adapter.FillSchema(update_with, SchemaType.Mapped);

//    connection.Close();
//    dgv_leads.DataSource = update_with;
//}    
//private void DGV_ACCDB(){
//    string ConnString = AccessModel.GetConnectionString(PATH_ACCDB);
//    OleDbConnection cn = new OleDbConnection();
//    cn.ConnectionString = ConnString;
//    cn.Open();

//    OleDbDataAdapter da = new OleDbDataAdapter();
//    DataTable UpdateFrom = (DataTable)dgv_leads.DataSource;
//    da = new OleDbDataAdapter("Select * from MainTable", cn);
//    OleDbCommandBuilder cb = new OleDbCommandBuilder(da);
//    da.UpdateCommand = cb.GetUpdateCommand();
//    da.DeleteCommand = cb.GetDeleteCommand();
//    da.InsertCommand = cb.GetInsertCommand();
//    da.Update(UpdateFrom);
//    cn.Close();
//}


//private void LoadSettingsPage() {
//    dgv_fieldSettings.Rows.Clear();
//    foreach (DataGridViewColumn col in table.Columns)
//    {
//        string type = "";
//        if (col.ValueType == typeof(string))
//        {
//            type = "Text";
//        }
//        else
//        {
//            type = "Yes/No";
//        }
//        dgv_fieldSettings.Rows.Add(col.Name,type);
//    }
//}
//private void GenerateSQL()
//{
//    rtxtbox_SQL.Clear();
//    rtxtbox_SQL.AppendText("CREATE TABLE `sqlitebrowser_rename_column_new_table` (" + "\r\n");
//    string auto = "INTEGER PRIMARY KEY AUTOINCREMENT";
//    foreach (DataGridViewRow row in dgv_fieldSettings.Rows)
//    {
//        string field_name = row.Cells[0].Value.ToString();
//        string type = row.Cells[1].Value.ToString();
//        rtxtbox_SQL.AppendText(field_name.Quote() + " " + type + "," + "\r\n");
//    }
//    rtxtbox_SQL.AppendText(");");
//}
//private void ExecuteSQL(string sql) {
//    OleDbConnection cn = new OleDbConnection(AccessModel.GetConnectionString(PATH_ACCDB));
//    cn.Open();
//    new OleDbCommand(sql, cn).ExecuteNonQuery();


//    //UpdateDGV
//    DataTable new_table = new DataTable();
//    OleDbDataAdapter adapter = new OleDbDataAdapter("select * from MainTable", cn);
//    adapter.Fill(new_table);
//    dgv_leads.DataSource = new_table;
//    cn.Close();
//}
//private void AddNewColumnSQL()
//{
//    //Prepare SQL
//    int selected_index = cbox_columnType.SelectedIndex;
//    string name = txt_columnName.Text.Replace(' ', '_');
//    string type = cbox_columnType.SelectedItem.ToString().Split(':')[0];
//    string sql = string.Format("ALTER TABLE MainTable ADD COLUMN {0} {1}", name, type);

//    ExecuteSQL(sql);

//    txt_columnName.Clear();
//    cbox_columnType.Text = "";
//    cbox_columnType.SelectedIndex = -1;
//    cbox_columnNames.Text = "";
//    MessageBox.Show("A New Column Is Added Successfully!");
//}
//private void RemoveColumnSQL() {
//    string sql = "ALTER TABLE MainTable DROP COLUMN " + cbox_columnNames.SelectedItem.ToString();
//    if (Essentials.Essentials.ConfirmSave("Are you sure you want to delete that table!", "CRITICAL"))
//    {
//        ExecuteSQL(sql);
//    }
//    cbox_columnNames.Text = "";
//    rbtn_addColumn.Checked = true;
//}
//private void UpdateDailyTask(string dateof) {
//    if (dateof.Length>0)
//    {
//        OleDbConnection cn = new OleDbConnection(AccessModel.GetConnectionString(PATH_ACCDB));
//        DataTable output = new DataTable();

//        cn.Open();

//        //Select By Date And Copy To Another Table
//        string sql = string.Format("SELECT * FROM MainTable WHERE {0} = #{1}#", dateof, DateTime.Now.ToShortDateString());
//        OleDbDataAdapter adapter = new OleDbDataAdapter(sql, cn);
//        adapter.SelectCommand = new OleDbCommand(sql, cn);
//        adapter.Fill(output);
//        dgv_reminder.DataSource = new DataTable();
//        dgv_reminder.DataSource = output;

//        cn.Close();

//        lbl_todayTasks.Text = "";
//        lbl_todayTasks.Text = dgv_reminder.Rows.Count.ToString();
//    }
//}
//private void SuitableNextFollowUp() {
//    foreach (DataColumn col in ((DataTable)dgv_leads.DataSource).Columns)
//    {
//        if (col.DataType == typeof(DateTime))
//        {
//            if (col.ColumnName.Contains("Follow")||col.ColumnName.Contains("follow_up"))
//            {
//                txt_nextFollowUp.Text = col.ColumnName;
//            }
//        }
//    }
//}

#endregion
