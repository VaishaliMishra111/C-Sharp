using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                string str = "Vaishali Mishra";
                if (ViewState["name"]==null)
                {
                    ViewState["name"] = str;

                }

            }

            if (Request.Cookies["BackgrounColor"] != null)
            {
                colorselector.SelectedValue = Request.Cookies["BackgroundColor"].Value;
                bodytag.Style["background-color"] = colorselector.SelectedValue;

            }


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Label2.Text = ViewState["name"].ToString();

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            bodytag.Style["background-color"]=colorselector.SelectedValue;
            HttpCookie c = new HttpCookie("BackgroundColor");
            c.Value = colorselector.SelectedValue;
            c.Expires=DateTime.Now.AddMilliseconds(20);
            Response.SetCookie(c);
        }
    }
}