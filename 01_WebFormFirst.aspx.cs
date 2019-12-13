using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
// 이곳을 비하인드 코드 파일이라고 한다.
// 개발함수 iis익스프레스 를 제공해준다.
{
    public partial class _01_WebHomeFirst : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           // Response.Write("현재 시간은 : " + DateTime.Now.ToLongTimeString());
            
        }
    }
}