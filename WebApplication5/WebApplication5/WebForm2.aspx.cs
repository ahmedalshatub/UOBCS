using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication5
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["TheOrderNumber"] != null && Session["TheOrderNumber"].ToString() != "")
                {

                    Label1.Text = Session["TheOrderNumber"].ToString();
                    string TheOrderNumber = Session["TheOrderNumber"].ToString();
                    Label2.Text = Session[TheOrderNumber+"-Date"].ToString();
                    Label3.Text = Session[TheOrderNumber+"-Name"].ToString();
                    int TPrice =0;
                    TableRow TR = new TableRow();
                 
                   
                    TableCell Tc1 = new TableCell();
                    TableCell Tc2 = new TableCell();
                    TableCell Tc3 = new TableCell();
                    TableCell Tc4 = new TableCell();
                    if (Session[TheOrderNumber + "-ItemQty-" + "0"] != null)
                    {
                        //Label4.Text = Session[TheOrderNumber + "-ItemQty-" + "0"].ToString();

                        TPrice += Convert.ToInt32(Session[TheOrderNumber + "-ItemQty-" + "0"]) * Convert.ToInt32(Session[TheOrderNumber + "-ItemPrice-" + "0"]);
                        Tc1.Text = "Zinger";
                        Tc2.Text = Session[TheOrderNumber + "-ItemPrice-" + "0"].ToString();
                        Tc3.Text = Session[TheOrderNumber + "-ItemQty-" + "0"].ToString();
                        Tc4.Text = (Convert.ToInt32(Session[TheOrderNumber + "-ItemQty-" + "0"]) * Convert.ToInt32(Session[TheOrderNumber + "-ItemPrice-" + "0"])).ToString();
                        TR.Cells.Add(Tc1);
                        TR.Cells.Add(Tc2);
                        TR.Cells.Add(Tc3);
                        TR.Cells.Add(Tc4);
                        Table1.Rows.Add(TR);
                    }
                    TR = new TableRow();
                     Tc1 = new TableCell();
                     Tc2 = new TableCell();
                     Tc3 = new TableCell();
                     Tc4 = new TableCell();
                    if (Session[TheOrderNumber + "-ItemQty-" + "1"] != null)
                    {
                        TPrice += Convert.ToInt32(Session[TheOrderNumber + "-ItemQty-" + "1"]) * Convert.ToInt32(Session[TheOrderNumber + "-ItemPrice-" + "1"]);
                        Tc1.Text = "Burger";
                        Tc2.Text = Session[TheOrderNumber + "-ItemPrice-" + "1"].ToString();
                        Tc3.Text = Session[TheOrderNumber + "-ItemQty-" + "1"].ToString();
                        Tc4.Text = (Convert.ToInt32(Session[TheOrderNumber + "-ItemQty-" + "1"]) * Convert.ToInt32(Session[TheOrderNumber + "-ItemPrice-" + "1"])).ToString();
                        TR.Cells.Add(Tc1);
                        TR.Cells.Add(Tc2);
                        TR.Cells.Add(Tc3);
                        TR.Cells.Add(Tc4);
                        Table1.Rows.Add(TR);

                    }


                    Label4.Text = TPrice.ToString();


                   











                }


            }















             
        }
    }
}