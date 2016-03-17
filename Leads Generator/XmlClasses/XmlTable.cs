using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leads_Generator
{
    class XmlTable
    {
        const string XML_HEADER = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>";
        public string Xml { 
            get {
                return XML_HEADER + "\r\n" + "<Table>\r\n" + Rows.ToString() + "\r\n</Table>";
            } 
        }
        public StringBuilder Rows { get; set; }

        public string ColoredColumn { get; set; }




        public XmlTable(string colored_column)
        {
            Rows = new StringBuilder("");
            this.ColoredColumn = colored_column;
        }

        public void AddRow(DataGridViewRow dgv_row) {
            StringBuilder xml_row = new StringBuilder("<row>\r\n");
            foreach (DataGridViewCell cell in dgv_row.Cells)
            {
                //Colorize
                string to_append = string.Empty;
                if (cell.OwningColumn.Name == this.ColoredColumn)
                {
                    string bcolor = cell.Style.BackColor.R.ToString() + "," + cell.Style.BackColor.G.ToString() + "," + cell.Style.BackColor.B.ToString();
                    //string fcolor = cell.Style.ForeColor.R.ToString() + "," + cell.Style.ForeColor.G.ToString() + "," + cell.Style.ForeColor.B.ToString();
                    to_append = string.Format("<cell bcolor=\"{0}\">", bcolor);
                }
                else
                {
                    to_append = "<cell>";
                }

                //Add cell value
                if (cell.ValueType == typeof(bool))
                {
                    to_append += (cell.Value != null) ? cell.Value.ToString() : "False";
                }
                else
                {
                    to_append += (cell.Value != null) ? cell.Value.ToString() : "";
                }
                
                to_append += "</cell>";
                xml_row.AppendLine(to_append);
            }
            xml_row.AppendLine("</row>");
            Rows.AppendLine(xml_row.ToString());
        }
    }
}
