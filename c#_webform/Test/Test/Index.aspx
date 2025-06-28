<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="Test.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="styles.css" />
</head>
<body>
    <div class="container">

        <!-- Section One -->
        <div class="section-one">
            <h2>BIỂU MẪU ĐĂNG KÝ</h2>
            <form id="formRegister" runat="server" method="GET">
                <div class="inner-group">
                    <label for="fullName">Họ và tên</label>
                    <input type="text" placeholder="Enter full name" name="fullName" id="fullName" />
                    <div class="messageError fullName"></div>
                </div>

                <div class="inner-group">
                    <label for="email">Email</label>
                    <input type="text" placeholder="Enter email address" name="email" id="email" />
                    <div class="messageError email"></div>
                </div>

                <div class="inner-form">
                    <div class="inner-group">
                        <label for="phoneNumber">Số điện thoại</label>
                        <input type="text" placeholder="Enter phone number" name="phoneNumber" id="phoneNumber" />
                        <div class="messageError phoneNumber"></div>
                    </div>
                    <div class="inner-group">
                        <label for="dateOfBirth">Ngày sinh</label>
                        <input type="date" placeholder="dd/mm/yyyy" name="dateOfBirth" id="dateOfBirth" />
                        <div class="messageError dateOfBirth"></div>
                    </div>
                </div>


                <div class="inner-group">
                    <label>Giới tính</label>
                    <div class="inner-radio">
                        <input type="radio" value="nam" name="gender" id="male" />
                        <label for="male">nam</label>
                        <input type="radio" value="nữ" name="gender" id="female" />
                        <label for="female">nữ</label>
                    </div>
                    <div class="messageError radio"></div>
                </div>


                <div class="inner-group">
                    <label for="course">Chọn khóa học</label>

                    <asp:DropDownList ID="course" runat="server">
                        <asp:ListItem Value="">[CHỌN KHÓA HỌC]</asp:ListItem>
                        <asp:ListItem Value="1">lập trình web</asp:ListItem>
                        <asp:ListItem Value="2">lập trình hướng sự kiện</asp:ListItem>
                        <asp:ListItem Value="3">lập trình hướng đối tượng</asp:ListItem>
                        <asp:ListItem Value="4">lập trình cơ bản</asp:ListItem>
                        <asp:ListItem Value="5">lập trình thiết bị di động</asp:ListItem>
                    </asp:DropDownList>

                    <div class="messageError course"></div>
                </div>


                <div class="inner-buttons">
                    <button class="btn btn-reset" type="button" id="buttonClear">Nhập lại</button>
                    <button type="submit" class="btn btn-submit" id="buttonSubmit">Đăng ký</button>
                </div>

            </form>
        </div>
        <!-- End Section One -->

        <!-- Section Two -->
        <div class="section-two">
            <h2>ĐÃ ĐĂNG KÝ</h2>
            <table>
                <thead>
                    <tr>
                        <th class="text-center">STT</th>
                        <th class="text-center">Môn học</th>
                        <th class="text-center">Giảng viên</th>
                        <th class="text-center">Tác vụ</th>
                    </tr>
                </thead>
                <tbody id="table-content">
                </tbody>
            </table>
        </div>
        <!-- End Section Two -->

    </div>
</body>

<script>
    var arr = [
        {
            id: 0,
            course: "",
        }
    ];

    const inputFullName = document.getElementById("fullName");
    const inputEmail = document.getElementById("email");
    const inputPhoneNumber = document.getElementById("phoneNumber");
    const inputDateOfBirth = document.getElementById("dateOfBirth");
    const maleGender = document.getElementById("male");
    const femaleGender = document.getElementById("female");
    const selectCourse = document.getElementById("course");

    const formRegister = document.getElementById("formRegister"); //form
    const buttonClear = document.getElementById("buttonClear"); //button nhập lại

    const isValidInput = () => { //check input
        [...document.getElementsByClassName("messageError")].forEach(item => item.innerHTML = "");

        let isValid = true;

        if (inputFullName.value.trim() === "") {
            document.getElementsByClassName("fullName")[0].innerHTML = "Họ và tên không hợp lệ";
            isValid = false;
        }

        if (!/^[0-9a-zA-Z]{1,}@[0-9a-zA-Z]{0,}\.[0-9a-zA-Z]/.test(inputEmail.value)) {
            document.getElementsByClassName("email")[0].innerHTML = "Email không hợp lệ";
            isValid = false;
        }

        if (!/^[0-9]{1,10}$/.test(inputPhoneNumber.value)) {
            document.getElementsByClassName("phoneNumber")[0].innerHTML = "Số điện thoại không hợp lệ";
            isValid = false;
        }

        if (inputDateOfBirth.value.trim() === "") {
            document.getElementsByClassName("dateOfBirth")[0].innerHTML = "Ngày sinh không hợp lệ";
            isValid = false;
        }

        if (!maleGender.checked && !femaleGender.checked) {
            document.getElementsByClassName("radio")[0].innerHTML = "Giới tính không được trống";
            isValid = false;
        }

        if (selectCourse.value.trim() === "") {
            document.getElementsByClassName("course")[0].innerHTML = "Khóa học không được rỗng";
            isValid = false;
        }
        return isValid;
    }  //check input


    formRegister.onsubmit = function (e) { //đăng ký
        e.preventDefault();

        let isValid = isValidInput();

        if (isValid == true) {
            let obj = {
                id: arr[arr.length - 1].id + 1,
                course: selectCourse.value,
                nameTeacher: inputFullName.value
            };

            arr.push(obj);
            loadListRegister();
            console.log(arr);
        }//if
    };//onSubmit


    const loadListRegister = () => { //load danh sách
        const listRegister = document.getElementById("table-content");
        listRegister.innerHTML = "";
        let i = 1;
        arr.forEach(item => {
            if (item.id !== 0) {
                listRegister.innerHTML += `<tr id=${item.id}>
                                                <td class="text-center">${i++}</td>
                                                <td>${item.course}</td>
                                                <td>nguyen van a</td>
                                                <td><a href="#" onclick="cancelRegister(${item.id})">Hủy đăng ký</a></td>
                                            </tr>`;
            } //if
        }) //map
    };// load

    const clearInput = () => { //nhập lại
        inputFullName.value = "";
        inputEmail.value = "";
        inputPhoneNumber.value = "";
        inputDateOfBirth.value = "";
        maleGender.checked = false;
        femaleGender.checked = false;
        selectCourse.value = "";
    };
    buttonClear.onclick = clearInput;


    const cancelRegister = (id) => { //hủy đăng ký
        arr.forEach((item, index) => {
            if (item.id === id) {
                arr.splice(index, 1);
            }
        });
        loadListRegister();
    };

</script>

</html>
