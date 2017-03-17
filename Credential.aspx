<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Credential.aspx.cs" Inherits="Credential" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <table>
    <tr>
    <td colspan="2" align="center">Login Details</td>
       </tr>

    <tr>
    <td>Login</td>
    <td><asp:TextBox ID="txtlog" runat="server" /></td>

    </tr>
    <tr>
    <td>Password</td>
    <td><asp:TextBox ID="txtpas" runat="server"  TextMode="Password"/></td>

    </tr>
    <tr>
    <td>
    <asp:Button ID="btnlogon" runat="server" Text="Logon" OnClick="go" />
    <asp:Button ID="btnclear" runat="server" Text="Reset" OnClick="clear" ValidationGroup="two"/>
     
    </td>
    </tr>
    <tr>
    <td colspan="2" align="center">
    <asp:Label id="lblmes" runat="server" /></td>
       </tr>
    <tr>
    <td colspan="2">
    <asp:HyperLink ID="lnknew" runat="server" NavigateUrl="~/login.aspx">New User</asp:HyperLink>
    
    </td>
    </tr>
    </div>
    
    </form>
</body>
</html>
