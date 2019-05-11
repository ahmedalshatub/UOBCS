using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["TheOrderNumber"] != null && Session["TheOrderNumber"].ToString() != "")
                {

                    TextBox2.Text = Session["TheOrderNumber"].ToString();
                }
             

            }
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Calendar1.Visible = !Calendar1.Visible;
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            Calendar1.Visible = false;

            TextBox1.Text = Calendar1.SelectedDate.ToShortDateString();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Session["TheOrderNumber"] = TextBox2.Text;
            Session[TextBox2.Text + "-Date"] = TextBox1.Text;
            Session[TextBox2.Text + "-Name"] = TextBox3.Text;
               if (Session[TextBox2.Text + "-ItemQty-"+DropDownList1.SelectedValue] != null )
                {
            Session[TextBox2.Text + "-ItemQty-" + DropDownList1.SelectedValue] = (Convert.ToInt32(Session[TextBox2.Text + "-ItemQty-" + DropDownList1.SelectedValue]) + Convert.ToInt32(TextBox5.Text)).ToString();

                }
               else
               {
                   Session[TextBox2.Text + "-ItemQty-" + DropDownList1.SelectedValue] = TextBox5.Text;

               }
               Session[TextBox2.Text + "-ItemPrice-" + DropDownList1.SelectedValue] = TextBox4.Text;

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //Session["TheOrderNumber"] = TextBox2.Text;
            Response.Redirect("WebForm2.aspx");
        }
    }
}