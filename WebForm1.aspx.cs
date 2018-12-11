using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MyfirstWebApp
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string user_name = username.Text;
            string Email = email.Text;

            string Result = "You have registered with below information"  + user_name + " "  + Email;

            resultLabel.Text = Result; 
        }
    }
}