using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.SqlServer.Server;
using TH_04.Models;

namespace Test
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void btnSend_Click(object sender, EventArgs e)
        {

        }

        private List<Student> students = new List<Student>();

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                students.Add(toStudent());
                rptStudent.DataSource = students;
                rptStudent.DataBind();
            }
        }

        private Student toStudent()
        {
            Student student = new Student();
            student.FullName = txtFullName.Text;
            student.Email = txtEmail.Text;
            student.PhoneNumber = txtPhoneNumber.Text;
            try
            {
                student.DateOfBirth = DateTime.ParseExact(txtDateOfBirth.Text, "dd/MM/yyyy", null);
            }catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            student.Gender = rblGender.SelectedItem.Value;
            student.Course = ddlCourse.SelectedItem.Text;
            return student;
        }

        private bool isValidInput()
        {
            bool isValid = true;
            if (txtFullName.Text.Trim() == "")
            {
                lblFullName.Text = "Họ và tên không hợp lệ";
                lblFullName.Visible = true;
                isValid = false;
            }
            else
            {
                lblFullName.Visible=false;
            }

            if (txtEmail.Text.Trim() == "" || !Regex.IsMatch(txtEmail.Text, @"^[0-9a-zA-Z]{1,}@[0-9a-zA-Z]{1,}\.[0-9a-zA-Z]{1,}$"))
            {
                lblEmail.Text = "Email không hợp lệ";
                lblEmail.Visible = true;
                isValid = false;
            }
            else
            {
                lblEmail.Visible=false;
            }

            if(txtPhoneNumber.Text.Trim() == "" || !Regex.IsMatch(txtPhoneNumber.Text, @"^[0-9]{1,10}$"))
            {
                lblPhoneNumber.Text = "Số điện thoại không hợp lệ";
                lblPhoneNumber.Visible = true;
                isValid = false;
            }
            else
            {
                lblPhoneNumber.Visible=false;
            }


            if(txtDateOfBirth.Text == "")
            {
                lblDateOfBirth.Text = "Ngày sinh không hợp lệ";
                lblDateOfBirth.Visible = true;
                isValid = false;
            }
            else
            {
                lblDateOfBirth.Visible=false;
            }


            if(rblGender.SelectedIndex == -1)
            {
                lblGender.Text = "Giới tính không được trống";
                lblGender.Visible = true;
                isValid = false;
            }
            else
            {
                lblGender.Visible=false;
            }


            if(ddlCourse.SelectedIndex == 0)
            {
                lblCourse.Text = "Khóa học không được rỗng";
                lblCourse.Visible = true;
                isValid = false;
            }
            else
            {
                lblCourse.Visible=false;
            }
            return isValid;
        }//end isvalidinput
    }
}