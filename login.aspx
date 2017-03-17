<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

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
    <td colspan="2" align="center">New Login</td>
       </tr>

    <tr>
    <td>Login</td>
    <td><asp:TextBox ID="txtlog" runat="server" />
    <asp:RequiredFieldValidator ID="rfv1" runat="server" ControlToValidate="txtlog" ErrorMessage="Login must not be blank" />
    </td>

    </tr>
    <tr>
    <td>Password</td>
    <td><asp:TextBox ID="txtpas" runat="server"  TextMode="Password"/>
    <asp:RequiredFieldValidator ID="rfv2" runat="server" ControlToValidate="txtpas" ErrorMessage="Password must not be blank" />
    
    </td>

    </tr>
    <tr>
    <td>Confirm Password</td>
    <td><asp:TextBox ID="txtcpas" runat="server"  TextMode="Password"/>
    <asp:CompareValidator ID="cv1" runat="server" ControlToValidate="txtcpas" ControlToCompare="txtpas" ErrorMessage="Password and Compare Validate must be same" />
    </td>

    </tr>
    <tr>
    <td>User Type</td>
    <td><asp:TextBox ID="txtuty" runat="server"  />
    <asp:RequiredFieldValidator ID="rv3" runat="server" ControlToValidate="txtuty" ErrorMessage="Type must not be blank" />
    
    </td>

    </tr>
    <tr>
    <td>User Name</td>
<td><asp:TextBox ID="txtuna" runat="server"  />
    <asp:RequiredFieldValidator ID="rv4" runat="server" ControlToValidate="txtuna" ErrorMessage="User name must not be blank" />


</td>


    </tr>
    <tr>
    <td>User Department</td>
   <td><asp:TextBox ID="txtdep" runat="server"  /> 
       <asp:RequiredFieldValidator ID="rv5" runat="server" ControlToValidate="txtdep" ErrorMessage="Department must not be blank" />

   </td>

    </tr>
    <tr>
    <td colspan="2" >
    <asp:Button id="btnsav" runat="server" Text="Register" onclick="save"/>
    <asp:Button id="btnclr" runat="server" Text="Clear" onclick="blank" ValidationGroup="no"/>
    
    </td>
       </tr>
       <tr>
    <td colspan="2" >
    <asp:Label id="lblmes" runat="server" /></td>
       </tr>
       <tr>
    <td colspan="2">
    <asp:HyperLink ID="lnklog" runat="server" NavigateUrl="~/Credential.aspx">Logon</asp:HyperLink>
    </td>
    </tr>
    </table>
    </div>
    </form>
</body>
</html>
