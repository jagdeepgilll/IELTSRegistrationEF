using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IELTSRegistrationEF.Model
{
    public class Booking
    {
        [Key]
        // Booking Test entity with Booking ID
        public int ID { get; set; }
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }
        public string Location { get; set; } // location of test center
        public int RegistrationID { get; set; }
        public int Fee { get; set; } // Fees for Test

        public Registration Registration { get; set; }
    }
}
