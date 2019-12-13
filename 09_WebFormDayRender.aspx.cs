using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class _09_WebFormDayRender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        String GetSchedule( int month, int day)
        {
            String schedule = "";
            if(month == 5 && day == 5)
            {
                schedule = "<a href ='http://mycast.xyz'>마이캐스트</a>";
            }
            else if (month == 5 && day == 8)
            {
                schedule = "어버이날";
            }
            else if (month == 5 && day == 15)
            {
                schedule = "스승의날";
            }
            else if (month == 5 && day == 6)
            {
                schedule = "현충일";
            }
            return schedule;

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            // 하루하루 이벤트가 발생하게 된다.
            // 버튼 하루마다 새로고침
            CalendarDay d = e.Day;
            TableCell c = e.Cell;

            String message = GetSchedule(d.Date.Month, d.Date.Day);
            c.Controls.Add(new LiteralControl("<br/>" + message));
        }
    }
}