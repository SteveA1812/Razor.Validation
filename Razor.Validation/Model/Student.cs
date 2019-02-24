using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace EntAppSecond.Model
{
    public class Student
    {
        public Student()
        { }
      

        [Display(Name="Student ID")]
        [RegularExpression (@"(S|s)\d{8}")]
        [Required(ErrorMessage = "You must enter a valid ID")]
        public string StudentID { get; set; } = "";

        [Display(Name = "First Name")]
        [StringLength(2)]
        [Required(ErrorMessage = "You must enter at least 2 characters")]
        public string FirstName{ get; set; } = "";


        [Display(Name = "Last Name")]
        [StringLength(3)]
        [Required(ErrorMessage ="You must enter at least 3 characters")]
        public string LastName { get; set; } = "";


        [Display(Name = "DOB")]
        [RegularExpression (@"(\d{2}(/|-)\d{2}(/|-)\d{2|4})|(\d{8}|\d{6})")]
        [Required(ErrorMessage = "You must enter the date in format nn/nn/nn or nn/nn/nnnn")]
        public string DoB { get; set; } = "";

        [Display(Name = "Modules Taken")]
        [RegularExpression(@"[2-9]")]
        [Required(ErrorMessage = "You must enter the number of modules taken")]
        public string ModulesTaken { get; set; } = "";

        [Display(Name = "Height")]
        [RegularExpression(@"[5-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0]")]
        [Required(ErrorMessage = "You must enter your height in cm")]
        public string Height { get; set; } = "";

        [Display(Name = "Email   ")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$")]
        [Required(ErrorMessage = "You must enter your email")]
        public string Email { get; set; } = "";

        [Display(Name = "EmailCon")]
        [RegularExpression(@"^[a-zA-Z0-9.!#$%&’*+/=?^_`{|}~-]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$")]
        [Required(ErrorMessage = "You must enter your email")]
        public string EmailCon { get; set; } = "";



        [RegularExpression(@"(Spring|Autumn)")]
        [Required(ErrorMessage = "messing")]
        public string GraduationCohort { get; set; }

    }
}
