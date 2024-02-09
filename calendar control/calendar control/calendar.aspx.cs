using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calendar_control
{
    public partial class calendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {if(e.Day.Date.Day==23 && e.Day.Date.Month==3) 
            {
                e.Cell.BackColor = System.Drawing.Color.DeepSkyBlue;
                Label lbl=new Label();
                lbl.Text = "<br>Happy Birthday!";
                e.Cell.Controls.Add(lbl);   

            }
         if(e.Day.Date.Day==31 && e.Day.Date.Month==7)
            {
                Calendar1.SelectedDate = new DateTime(2023, 7, 31);

                Calendar1.SelectedDates.SelectRange(Calendar1.SelectedDate,Calendar1.SelectedDate.AddDays(9));
                Label lbl= new Label();
                lbl.Text = "<br>Student's Exam";
                e.Cell.Controls.Add(lbl );
            }
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Caption = "Vaishu's schedule";
            Label2.Text = "Today's Date:" + Calendar1.TodaysDate.ToShortDateString();
            Label3.Text = "Navratri Festival stats on :10-17-2020";
            TimeSpan d=new DateTime(2020,10,17)-DateTime.Now;

        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
             
        }
    }
}