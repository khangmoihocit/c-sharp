using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TH_04.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth {  get; set; }
        public String Gender { get; set; }
        public String Course { get; set; }

        private static int nextId = 1;
        public Student() {
            this.Id = nextId;
            nextId++;
        }
    }
}