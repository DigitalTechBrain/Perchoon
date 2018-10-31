using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PerchoonWebApp
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            PerchoonServiceReference.AuthUser client = new PerchoonServiceReference.AuthUser();
           
            if(client.UserName == TextBox1.Text && client.Password == TextBox2.Text)
            {
                Label1.Text = "Authenticated";
            }
            else
            {
                Label1.Text = "Not Authenticated";
            }

        }
    }
}