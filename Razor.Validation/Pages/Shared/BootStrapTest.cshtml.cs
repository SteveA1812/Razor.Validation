using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EntAppSecond.Pages.Shared
{
    public class BootStrapTestModel : PageModel
    {
        public void OnGet()
        {

        }

        [BindProperty]
        public string Colour{ get; set; }

        [BindProperty]
        public string ProductLabel { get; set; }
        [BindProperty]
        public bool Consent{ get; set; }


    }
}