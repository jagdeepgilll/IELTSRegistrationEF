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
    public class IndexModel : PageModel
    {
        private readonly IELTSRegistrationEF.Data.IELTSRegistrationEFContext _context;

        public IndexModel(IELTSRegistrationEF.Data.IELTSRegistrationEFContext context)
        {
            _context = context;
        }

        public IList<Registration> Registration { get;set; }

        public async Task OnGetAsync()
        {
            Registration = await _context.Registration.ToListAsync();
        }
    }
}
