<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="test_generatelistproduct.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        /* CSS đơn giản cho giao diện sản phẩm */
        body { font-family: Arial, sans-serif; }
        .product-container {
            display: flex;
            flex-wrap: wrap;
            gap: 20px; /* Khoảng cách giữa các sản phẩm */
            justify-content: center;
        }
        .product-card {
            border: 1px solid #ddd;
            border-radius: 8px;
            padding: 15px;
            text-align: center;
            width: 220px;
            box-shadow: 0 2px 5px rgba(0,0,0,0.1);
        }
        .product-card img {
            max-width: 100%;
            height: 180px;
            object-fit: contain; /* Giữ tỷ lệ ảnh */
            margin-bottom: 10px;
        }
        .product-card h3 {
            font-size: 1.1em;
            margin: 10px 0;
        }
        .product-card .price {
            color: #d9534f;
            font-weight: bold;
            font-size: 1.2em;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="product-container">
            <asp:Repeater ID="rptKhachHang" runat="server">
                <ItemTemplate>
                    <div class="product-card">
                        <%-- Dùng Eval để lấy dữ liệu từ đối tượng Product --%>
                        <p><%# Eval("Id") %></p>

                        <h3><%# Eval("Name") %></h3>
                        
                        <h1><%# Eval("Address") %></h1>

                        <asp:Button runat="server" Text="Thêm vào giỏ" CssClass="btn-add-to-cart" />
                    </div>
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
