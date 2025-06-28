<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CourseList.aspx.cs" Inherits="Test.CourseList" %>

    <!DOCTYPE html>

    <html xmlns="http://www.w3.org/1999/xhtml">

    <head runat="server">
        <title></title>
    </head>

    <style>
        h2 {
            text-align: center;
        }

        table {
            width: 60%;
            border-collapse: collapse;
        }

        th,
        td {
            padding: 10px;
            text-align: left;
            border: 1px solid #eee;
        }

        .auto-style1 {
            height: 43px;
        }

        a{
            text-decoration: none;
            color: #000;
        }
    </style>



    <body>
        <form id="form1" runat="server">
            <div>
                <h2>Danh sách khóa học</h2>
                <table>
                    <thead>
                        <tr>
                            <th>STT</th>
                            <th>Tên khóa học</th>
                        </tr>
                    </thead>
                    <tbody id="table-content">
                        
                    </tbody>
                </table>
            </div>
        </form>
    </body>
    <script>
        var courseList = [
            { id: 1, name: "lập trình web" },
            { id: 2, name: "lập trình hướng sự kiện" },
            { id: 3, name: "lập trình hướng đối tượng" },
            { id: 4, name: "lập trình cơ bản" },
            { id: 5, name: "lập trình thiết bị di động" }
        ];

        courseList.forEach(course => {
            document.getElementById("table-content").innerHTML +=
                `<tr>
                    <td><a href="Index.aspx?courseId=${course.id}">${course.id}</a></td>
                    <td><a href="Index.aspx?courseId=${course.id}">${course.name}</a></td>
                 </tr>`
        }
        );
    </script>

    </html>