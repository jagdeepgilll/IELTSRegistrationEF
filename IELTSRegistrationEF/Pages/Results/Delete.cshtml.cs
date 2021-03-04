using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IELTSRegistrationEF.Data;
using IELTSRegistrationEF.Model;

namespace IELTSRegistrationEF.Pages.Results
{
    public class DeleteModel : PageModel
    {
        private readonly IELTSRegistrationEF.Data.IELTSRegistrationEFContext _context;

        public DeleteModel(IELTSRegistrationEF.Data.IELTSRegistrationEFContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Result Result { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Result = await _context.Result
                .Include(r => r.Registration).FirstOrDefaultAsync(m => m.ID == id);

            if (Result == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Result = await _context.Result.FindAsync(id);

            if (Result != null)
            {
                _context.Result.Remove(Result);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
