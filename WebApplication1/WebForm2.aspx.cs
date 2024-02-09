using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label9.Text = "my rollno" + Request.QueryString ["rollno"];
            Label10.Text = "my name" + Request.QueryString["name"];
            Label11.Text = "my class" + Request.QueryString["class"];

        }
    }
}