using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using IELTSRegistrationEF.Data;
using IELTSRegistrationEF.Model;

namespace IELTSRegistrationEF.Pages.Registrations
{
    public class DetailsModel : PageModel
    {
        private readonly IELTSRegistrationEF.Data.IELTSRegistrationEFContext _context;

        public DetailsModel(IELTSRegistrationEF.Data.IELTSRegistrationEFContext context)
        {
            _context = context;
        }

        public Registration Registration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Registration = await _context.Registration.FirstOrDefaultAsync(m => m.ID == id);

            if (Registration == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
