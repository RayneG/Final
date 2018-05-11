using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Books.Data;
using Books.Models;

namespace Books.Pages.Students
{
    public class IndexModel : PageModel
    {
        private readonly Books.Data.SchoolContext _context;

        public IndexModel(Books.Data.SchoolContext context)
        {
            _context = context;
        }

        public IList<Book> Student { get;set; }

        public async Task OnGetAsync()
        {
            Student = await _context.Students.ToListAsync();
        }
    }
}
