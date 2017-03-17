using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for Logins
/// </summary>
public class Logins
{
    private String log, pas, typ, nam, dep,err;
    
	public Logins()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public String Login
    {
        set
        {
            log = value;
        }
     
    }
    public String Password
    {
        set
        {
            pas = value;
        }
       
    }
    public String UserType
    {
        set
        {
            typ = value;
        }
        get
        {
            return typ;
        }
    }
    public String UserName
    {
        set
        {
            nam = value;
        }
        get
        {
            return nam;
        }
    }

    public String UserDepartment
    {
        set
        {
            dep = value;
        }
        get
        {
            return dep;
        }
    }
    public String Error
    {
        get
        {
            return err;
        }
    }
    public bool NewLogin()
    {
        bool res = false; 
        try
        {
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saurabh\Desktop\Appraisal\App_Data\Database.mdf;Integrated Security=True";
        cn.Open();
        SqlCommand cm = new SqlCommand();
        cm.CommandText = "insert into logins values(@log,@pas,@typ,@nam,@dep,getdate())";
        cm.Connection = cn;
        cm.CommandType = CommandType.Text;
        cm.Parameters.AddWithValue("@log", log);
        cm.Parameters.AddWithValue("@pas", pas);
        cm.Parameters.AddWithValue("@typ", typ);
        cm.Parameters.AddWithValue("@nam", nam);
        cm.Parameters.AddWithValue("@dep", dep);
        int c=cm.ExecuteNonQuery();
        if (c > 0)
        {
            res = true;
        }
        }
        catch(Exception e)
        {
            err=e.Message;
            res = false;
        }
        return res;
    }
    public bool CheckLogin()
    {
        bool res = false;
        try
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Saurabh\Desktop\Appraisal\App_Data\Database.mdf;Integrated Security=True";
            cn.Open();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select count(*) from logins where login=@log and password=@pas";
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@log", log);
            cm.Parameters.AddWithValue("@pas", pas);
            int c = (int)cm.ExecuteScalar();
            if (c == 1)
            {

                res = true;
            }
            else
            {
                res = false;
            }
            cn.Close();
        }
        catch (Exception e)
        {
            err = e.Message;
            res = false;
        }
        return res;
    }
    public void GetDetails(String Login)
    {
        try
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\vaibhav\Desktop\Appraisal\App_Data\Database.mdf;Integrated Security=True";
            cn.Open();
            SqlCommand cm = new SqlCommand();
            cm.CommandText = "select usertype,username,userdepartment from logins where login=@log ";
            cm.Connection = cn;
            cm.CommandType = CommandType.Text;
            cm.Parameters.AddWithValue("@log", Login);
            SqlDataReader dr=cm.ExecuteReader();
            dr.Read();
            typ = dr.GetString(0);
            nam = dr.GetString(1);
            dep = dr.GetString(2);
            cn.Close();
        }
        catch (Exception e)
        {
            err = e.Message;
           
        }
        
    }
}