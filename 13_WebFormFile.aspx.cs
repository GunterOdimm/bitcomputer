using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _13_WebFormFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                FileUpload1.SaveAs("D:\\Gunterohdim\\Class file\\IMG\\" + FileUpload1.FileName);
                Label1.Text = "파일명 : " + FileUpload1.FileName + "<br/>콘텐츠 타입 : " + FileUpload1.PostedFile.ContentType + "<br/>파일 크기 : " + FileUpload1.PostedFile.ContentLength + "(byte)";
            }
            else
            {
                Label1.Text = "업로드할 파일이 존재하지 않습니다.";
            }
        }
    }
}