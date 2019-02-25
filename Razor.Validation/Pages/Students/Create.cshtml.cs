using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Razor.Validation.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Razor.Validation.Pages.Students
{
    
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Student Student { get; set; }

       
        public void OnGet()
        {

        }
      
     
      public void OnPost()
        {
            if (Student.Email!=Student.EmailCon)
            { ModelState.AddModelError("Student EmailCon", "Your email does not match! "); }


        }
        
    }
}

     
    