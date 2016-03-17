using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leads_Generator
{
    public partial class ReportCriteriaForm : Form
    {
        private DataGridView DatagridView { get; set; }
        public string Result { get; set; }
        private string[] InitialValues { get; set; }

        public ReportCriteriaForm(DataGridView dgv,string[] initial)
        {
            InitializeComponent();
            this.DatagridView = dgv;
            this.InitialValues = initial;
        }
        
        private void ReportCriteriaForm_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn col in this.DatagridView.Columns)
            {
                if (col.ValueType == typeof(Boolean))
                {
                    chkbxlst.Items.Add(col.Name);   
                }
            }
        }

        private void btn_confirm_Click(object sender, EventArgs e)
        {
            string result = null;
            if (chkbxlst.CheckedItems.Count > 0)
            {
                foreach (string item in chkbxlst.CheckedItems)
                {
                    result += item + ",";
                }
                this.Result = result.TrimEnd(',');
            }
            this.Close();
        }
    }
}
