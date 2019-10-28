using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Test3.Pages
{
    public class IndModel : PageModel
    {
        public void OnGet(int? id)
        {
            System.Diagnostics.Debug.WriteLine(id);
            
        }
        
    }
}