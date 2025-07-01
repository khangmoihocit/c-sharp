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
        private List<Student> students;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["StudentList"] != null)
            {
                students = (List<Student>)Session["StudentList"];
            }
            else
            {
                students = new List<Student>();
            }
            messageError.Text = "";

            //hủy đăng ký
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] == null)
                {
                    Console.WriteLine("a");
                }
                else
                {
                    int id = int.Parse(Request.QueryString["id"]);

                    students.RemoveAll(item => item.Id == id);

                    Session["StudentList"] = students;
                    Response.Redirect("~/Index.aspx"); 
                }

            }
            rptStudent.DataSource = students;
            rptStudent.DataBind();
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            if (isValidInput())
            {
                Student newStudent = toStudent();
                bool check = true;

                //kiểm tra trùng lặp đăng ký
                students.ForEach(student =>
                {
                    if (student.FullName.Equals(newStudent.FullName) && student.Course.Contains(newStudent.Course))
                    {
                        check = false;
                    }
                });


                if (check)
                {
                    students.Add(newStudent);
                    Session["StudentList"] = students;
                    messageError.Text = "";
                }
                else messageError.Text = "Lỗi! " + newStudent.FullName + " đã đăng ký khóa học " + newStudent.Course;

                rptStudent.DataSource = students;
                rptStudent.DataBind();

            }//end if isvalid
        }//end submit_click

        private Student toStudent()
        {
            Student student = new Student();
            student.FullName = txtFullName.Text;
            student.Email = txtEmail.Text;
            student.PhoneNumber = txtPhoneNumber.Text;
            try
            {
                student.DateOfBirth = DateTime.ParseExact(txtDateOfBirth.Text, "yyyy-MM-dd", null);
            }
            catch (FormatException ex)
            {
                messageError.Text = ex.Message;
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
                lblFullName.Visible = false;
            }

            if (txtEmail.Text.Trim() == "" || !Regex.IsMatch(txtEmail.Text, @"^[0-9a-zA-Z]{1,}@[0-9a-zA-Z]{1,}\.[0-9a-zA-Z]{1,}$"))
            {
                lblEmail.Text = "Email không hợp lệ";
                lblEmail.Visible = true;
                isValid = false;
            }
            else
            {
                lblEmail.Visible = false;
            }

            if (txtPhoneNumber.Text.Trim() == "" || 
                !Regex.IsMatch(txtPhoneNumber.Text, @"^[0-9]{1,10}$"))
            {
                lblPhoneNumber.Text = "Số điện thoại không hợp lệ";
                lblPhoneNumber.Visible = true;
                isValid = false;
            }
            else
            {
                lblPhoneNumber.Visible = false;
            }


            if (txtDateOfBirth.Text == "")
            {
                lblDateOfBirth.Text = "Ngày sinh không hợp lệ";
                lblDateOfBirth.Visible = true;
                isValid = false;
            }
            else
            {
                lblDateOfBirth.Visible = false;
            }


            if (rblGender.SelectedIndex == -1)
            {
                lblGender.Text = "Giới tính không được trống";
                lblGender.Visible = true;
                isValid = false;
            }
            else
            {
                lblGender.Visible = false;
            }


            if (ddlCourse.SelectedIndex <= 0)
            {
                lblCourse.Text = "Khóa học không được rỗng";
                lblCourse.Visible = true;
                isValid = false;
            }
            else
            {
                lblCourse.Visible = false;
            }
            return isValid;
        }//end isvalidinput

        protected void btnSend_Click(object sender, EventArgs e)
        {

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtPhoneNumber.Text = "";
            txtDateOfBirth.Text = "";
            rblGender.SelectedIndex = -1;
            ddlCourse.SelectedIndex = 0;
        }
    }
}