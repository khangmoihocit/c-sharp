<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Test.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styles.css" />
</head>
<body>
    <div class="container">
        <form id="formRegister" runat="server">

            <!-- Section One -->
            <div class="section-one">
                <h2>BIỂU MẪU ĐĂNG KÝ</h2>

                <asp:Label ID="messageError" runat="server" Text="Label" CssClass="error-1"></asp:Label>

                <div class="inner-group">
                    <asp:Label runat="server" AssociatedControlID="txtFullName" Text="Họ và tên"></asp:Label>
                    <asp:TextBox ID="txtFullName" runat="server" placeholder="Enter full name"></asp:TextBox>
                    <asp:Label Visible="false" ID="lblFullName" runat="server" Text="Label" CssClass="messageError"></asp:Label>
                </div>

                <div class="inner-group">
                    <asp:Label runat="server" AssociatedControlID="txtEmail" Text="Email"></asp:Label>
                    <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter email address">
                    </asp:TextBox>
                    <asp:Label Visible="false" ID="lblEmail" runat="server" Text="Label" CssClass="messageError"></asp:Label>
                </div>

                <div class="inner-form">
                    <div class="inner-group">
                        <asp:Label runat="server" AssociatedControlID="txtPhoneNumber" Text="Số điện thoại"></asp:Label>
                        <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="Enter phone number">
                        </asp:TextBox>
                        <asp:Label Visible="false" ID="lblPhoneNumber" runat="server" Text="Label" CssClass="messageError"></asp:Label>
                    </div>
                    <div class="inner-group">
                        <asp:Label runat="server" AssociatedControlID="txtDateOfBirth" Text="Ngày sinh"></asp:Label>
                        <asp:TextBox ID="txtDateOfBirth" runat="server" TextMode="Date"></asp:TextBox>
                        <asp:Label Visible="false" ID="lblDateOfBirth" runat="server" Text="Label" CssClass="messageError"></asp:Label>
                    </div>
                </div>

                <div class="inner-group">
                    <asp:Label runat="server" Text="Giới tính"></asp:Label>
                    <div class="inner-radio">
                        <asp:RadioButtonList ID="rblGender" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem Text="Nam" Value="Nam"></asp:ListItem>
                            <asp:ListItem Text="Nữ" Value="Nữ"></asp:ListItem>
                        </asp:RadioButtonList>
                    </div>
                    <asp:Label Visible="false" ID="lblGender" runat="server" Text="Label" CssClass="messageError"></asp:Label>
                </div>

                <div class="inner-group">
                    <asp:Label runat="server" AssociatedControlID="ddlCourse" Text="Chọn khóa học"></asp:Label>
                    <asp:DropDownList ID="ddlCourse" runat="server">
                        <asp:ListItem Value="">[CHỌN KHÓA HỌC]</asp:ListItem>
                        <asp:ListItem Value="1">Lập trình web</asp:ListItem>
                        <asp:ListItem Value="2">Lập trình hướng sự kiện</asp:ListItem>
                        <asp:ListItem Value="3">Lập trình hướng đối tượng</asp:ListItem>
                        <asp:ListItem Value="4">Lập trình cơ bản</asp:ListItem>
                        <asp:ListItem Value="5">Lập trình thiết bị di động</asp:ListItem>
                    </asp:DropDownList>
                    <asp:Label Visible="false" ID="lblCourse" runat="server" Text="Label" CssClass="messageError"></asp:Label>
                </div>

                <div class="inner-buttons">
                    <asp:Button ID="btnReset" runat="server" Text="Nhập lại" CssClass="btn btn-reset" OnClientClick="this.form.reset(); return false;" OnClick="btnReset_Click" />
                    <asp:Button ID="btnSubmit" runat="server" Text="Đăng ký" CssClass="btn btn-submit" OnClick="btnSubmit_Click" />
                </div>

            </div>
            <!-- End Section One -->

            <!-- Section Two -->
            <div class="section-two">
                <h2>ĐÃ ĐĂNG KÝ</h2>

                <table>
                    <asp:Repeater ID="rptStudent" runat="server">
                        <HeaderTemplate>
                            <thead>
                                <tr>
                                    <th>STT</th>
                                    <th>Họ tên</th>
                                    <th>Email</th>
                                    <th>Điện thoại</th>
                                    <th>Ngày sinh</th>
                                    <th>Giới tính</th>
                                    <th>Khóa học</th>
                                    <th>Hủy đăng ký</th>
                                </tr>
                            </thead>
                            <tbody>
                        </HeaderTemplate>

                        <ItemTemplate>
                            <tr>
                                <td><%# Container.ItemIndex + 1 %></td>
                                <td><%# Eval("FullName") %></td>
                                <td><%# Eval("Email") %></td>
                                <td><%# Eval("PhoneNumber") %></td>
                                <td><%# Eval("DateOfBirth", "{0:dd/MM/yyyy}") %></td>
                                <td><%# Eval("Gender") %></td>
                                <td><%# Eval("Course") %></td>
                                <td>
                                    <asp:HyperLink ID="hlDelete" runat="server"
                                        Text="Hủy đăng ký"
                                        CssClass="cancel"
                                        NavigateUrl='<%# String.Format("~/Index.aspx?id={0}", Eval("Id")) %>'>
                                    </asp:HyperLink>
                                </td>
                            </tr>
                        </ItemTemplate>

                        <FooterTemplate>
                            </tbody>
                        </FooterTemplate>
                    </asp:Repeater>
                </table>
            </div>
            <!-- End Section Two -->

        </form>
    </div>

</body>



</html>
