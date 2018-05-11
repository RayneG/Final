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
    public class DetailsModel : PageModel
    {
        private readonly Books.Data.SchoolContext _context;

        public DetailsModel(Books.Data.SchoolContext context)
        {
            _context = context;
        }

        public Book Student { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Student = await _context.Students.SingleOrDefaultAsync(m => m.ISBN == id);

            if (Student == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
