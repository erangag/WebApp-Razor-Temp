using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApp_Razor_Temp.Data;

namespace WebApp_Razor_Temp.Pages.Persons
{
    public class IndexModel : PageModel
    {
        private readonly WebApp_Razor_Temp.Data.AppDbContext _context;

        public IndexModel(WebApp_Razor_Temp.Data.AppDbContext context)
        {
            _context = context;
        }

        public IList<Person> Person { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Persons != null)
            {
                Person = await _context.Persons.ToListAsync();
            }
        }
    }
}
