using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Credential : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void go(object sender, EventArgs e)
    {
        Logins l = new Logins();
        l.Login = txtlog.Text;
        l.Password = txtpas.Text;
        if (l.CheckLogin() == true)
        {
            Session["user"] = txtlog.Text;
            Response.Redirect("WelcomeAPP.aspx");
        }
        else
        {
            lblmes.Text = "Login or Password is wrong" + l.Error;
        }
    }
    protected void clear(object sender, EventArgs e)
    {
        txtlog.Text="";
        txtpas.Text="";
    }
}