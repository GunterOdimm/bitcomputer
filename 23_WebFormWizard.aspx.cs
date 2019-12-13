using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _23_WebFormWizard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Wizard1_FinishButtonClick(object sender, WizardNavigationEventArgs e)
        {
            Label1.Text = " 잭필드 남성 면바지 3종 세트 " + TextBox1.Text + " 개 <br />";
            Label2.Text = " 진미령 간장 게장 " + TextBox2.Text + " 개 <br />";
            Label3.Text = " 주소 : " + TextBox3.Text;
        }
    }
}