using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IELTSRegistrationEF.Model
{
    public class Result
    {
        [Key]
        public int ID { get; set; }
        public int RegistrationID { get; set; }
        public int BookingID { get; set; }

        public int Band { get; set; }

        public Registration Registration { get; set; }
    }
}
