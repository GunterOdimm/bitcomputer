using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _12_WebFormDropDownList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<string> list = new List<string>();
                list.Add("Item1");
                list.Add("Item2");
                list.Add("Item3");
                DropDownList1.DataSource = list;
                DropDownList1.DataBind();

            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            String s = "항목을 선택해 주세요 ";
            s = "선택한 항목의 Index : " + DropDownList1.SelectedIndex + "<br/>";
            s += "선택한 항목의 Text : " + DropDownList1.SelectedItem.Text+ "<br/>";
            s += "선택한 항목의 Value : " + DropDownList1.SelectedItem.Value;
            Label1.Text = s;
        }
    }
}