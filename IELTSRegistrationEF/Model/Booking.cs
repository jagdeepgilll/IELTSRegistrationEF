using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IELTSRegistrationEF.Model
{
    //Add Booking class
    public class Booking
    {
        [Key] //
        // Booking Test entity with Booking ID
        public int ID { get; set; }// Id is primary key
        [DataType(DataType.Date)]
        public DateTime BookingDate { get; set; }//Booking Test Date
        public string Location { get; set; } // location of test center
        public int RegistrationID { get; set; }// Add regestrition id
        public int Fee { get; set; } // Fees for Test

        public Registration Registration { get; set; } // linking to Registartion Model
    }
}
