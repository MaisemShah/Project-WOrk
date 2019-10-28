using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test3.Data;

namespace Test3.Pages
{
    public class EmployModel : PageModel
    {
        public ApplicationDbContext _db { get; set; }
        //public IList<Employee> employee { get; set; }
        public List<IdentityUserRole<string>> URoles { get; private set; }

        public EmployModel (ApplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGetAsync()
        {
            var userRoles = await _db.UserRoles.ToListAsync();
          
        }
       }
}