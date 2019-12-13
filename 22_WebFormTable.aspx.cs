using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _22_WebFormTable : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int rowCount = int.Parse(DropDownList1.SelectedItem.Value);
            int cellCount = int.Parse(DropDownList2.SelectedItem.Value);

            for(int i=0; i < rowCount; i++)
            {
                TableRow row = new TableRow();
                for(int j =0; j<cellCount; j++)
                {
                    TableCell cell = new TableCell();
                    cell.Controls.Add(new LiteralControl("행 " + i.ToString() + ", 셀 " + j.ToString()));
                    row.Cells.Add(cell);
                }
                Table1.Rows.Add(row);
            }
        }
    }
}