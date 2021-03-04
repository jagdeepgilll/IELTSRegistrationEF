using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using IELTSRegistrationEF.Model;

namespace IELTSRegistrationEF.Data
{
    public class IELTSRegistrationEFContext : DbContext
    {
        public IELTSRegistrationEFContext (DbContextOptions<IELTSRegistrationEFContext> options)
            : base(options)
        {
        }

        public DbSet<IELTSRegistrationEF.Model.Registration> Registration { get; set; }

        public DbSet<IELTSRegistrationEF.Model.Booking> Booking { get; set; }

        public DbSet<IELTSRegistrationEF.Model.Result> Result { get; set; }
    }
}
