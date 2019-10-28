using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Test3.Data;

namespace Test3.Pages.Departments
{
    public class IndexModel : PageModel
    {
        private readonly Test3.Data.ApplicationDbContext _context;

        public IndexModel(Test3.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public string NameSort { get; set; }
        public string DateShort { get; set; }
        public string CurrentFilter{ get; set; }

        public string CurrentShort { get; set; }


        public IList<Department> Department { get;set; }

        public async Task OnGetAsync()
        {
            Department = await _context.Department.ToListAsync();
        }
    }
}
