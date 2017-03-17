using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
       
    }
    protected void save(object sender, EventArgs e)
    {
        Logins l = new Logins();
        l.Login = txtlog.Text;
        l.Password = txtpas.Text;
        l.UserName = txtuna.Text;
        l.UserType = txtuty.Text;
        l.UserDepartment = txtdep.Text;
        bool status=l.NewLogin();
        if (status == true)
        {
            lblmes.Text = "login Created";     
        }
        else
        {

            lblmes.Text = "login Already Exist" +l.Error;
        }
    }
    protected void blank(object sender, EventArgs e)
    {
        txtlog.Text = "";
        txtpas.Text = "";
        
        txtcpas.Text="";
        txtuna.Text="";
        txtuty.Text="";
        txtdep.Text = "";
    }
}