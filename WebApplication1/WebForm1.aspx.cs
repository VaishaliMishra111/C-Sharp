using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date.Day == 23 && e.Day.Date.Month == 3)
            {
                e.Cell.Controls.Add(new LiteralControl("</br>Birthday"));
            }
            if (e.Day.Date.Day == 1 && e.Day.Date.Month == 3) {
                Calendar1.SelectedDate = new DateTime(2023, 3, 1);
                Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDate, Calendar1.SelectedDate.AddDays(5));
                Label l = new Label();
                l.Text = "</br> Vacation";
                e.Cell.Controls.Add(l);
            
            }
            e.Cell.BackColor = System.Drawing.Color.AliceBlue;
            if (e.Day.IsOtherMonth)
            {
                e.Cell.Controls.Clear();
            }
                    }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label4.Text = txt1.Text + "<br>" + txt2.Text +"</br>"+ R1.SelectedItem;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewdetail.aspx?rollno="+txt1.Text+"&name="+txt2.Text+"&class="+R1.SelectedItem);

        }
    }
}