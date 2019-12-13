using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _10_WebFormCheck : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button_Click(object sender, EventArgs e)
        {
            Label1.Text = "선택한 스포츠 : ";
            if (CheckBox1.Checked)
                Label1.Text += CheckBox1.Text + " ";
            if (CheckBox2.Checked)
                Label1.Text += CheckBox2.Text + " ";
            if (CheckBox3.Checked)
                Label1.Text += CheckBox3.Text + " ";
        }

        protected void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBox4.Checked)
            {
                Label2.Text = "메일링에 가입 합니다.";
            }
            else
            {

            }
        }
    }
}