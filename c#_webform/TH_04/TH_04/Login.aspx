<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="TH_04.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styles.css" />
</head>
<body>
    <div class="login-container">
        <form id="formLogin" runat="server">
            <h2>ĐĂNG NHẬP</h2>
            <asp:Label ID="lblError" runat="server" CssClass="error-1" ForeColor="Red"></asp:Label>
            <div class="inner-group">
                <asp:Label runat="server">Tên đăng nhập:</asp:Label>
                <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
            </div>
            <div class="inner-group">
                <asp:Label runat="server">Mật khẩu:</asp:Label>
                <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
            </div>
            <div class="inner-buttons">
                <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Đăng nhập" CssClass="btn btn-submit" />
            </div>
        </form>
    </div>
</body>
</html>
