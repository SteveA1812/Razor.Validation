using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace Razor.Validation.Model
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


    }
}
