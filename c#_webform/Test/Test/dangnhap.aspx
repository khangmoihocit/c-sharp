<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="dangnhap.aspx.cs" Inherits="Test.dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="POST">
        <div>
            <label>ten dang nhap</label>
            <input type="text" name="tendangnhap" id="tendangnhap" />
        </div>

        <div>
            <label>mat khau</label>
            <input type="text" name="matkhau" id="matkhau"/>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Đăng nhập" OnClick="Button1_Click" />
    </form>
</body>
</html>
