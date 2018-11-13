<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="webUI.loginAndRegister.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
    <%--<form action="test.aspx.cs" method="post">
        <table>
            <tr>
                <td>用户名：</td>
                <td> <input type="text" name="adminName" value="" id="username" /></td>
            </tr>
            <tr>
                <td> 密  码：</td>
                <td><input type="text" name="adminPwd" value="" id="password" /></td>
            </tr>
        </table>
        <input style="margin-left:150px" type="submit" name="name" value="注册" />
    </form>--%>
    
</body>
</html>
