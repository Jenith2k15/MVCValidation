using Foolproof;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ValidatingControlsDemo.Models
{
    public class Register
    {
        [Required(ErrorMessage = "Email cannot be empty")]
        [RegularExpression(@"[a-zA-Z0-9-]{1,}@([a-zA-Z\.])?[a-zA-Z]{1,}\.[a-zA-Z]{1,4}",
            ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [System.ComponentModel.DataAnnotations.Compare("Password",
            ErrorMessage = "Password and ConfirmPassword doesnt match")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string Department { get; set; }

        public SelectList Departments
        {
            get
            {
                return new SelectList(new List<Department>
                {
                    new Department{DeptId=1,DepartmentName="IT"},
                    new Department{DeptId=2,DepartmentName="Payroll"},
                    new Department{DeptId=3,DepartmentName="HR"},
                    new Department{DeptId=4,DepartmentName="None"}
                },"DeptId","DepartmentName");
            }
        }

        [Required]
        public string Gender { get; set; }

        public List<Gender> Genders
        {
            get
            {
                return new List<Gender>
                {
                    new Gender{GenderId=1,GenderName="Male"},
                    new Gender{GenderId=2,GenderName="Female"}
                };
            }
        }
    }
}