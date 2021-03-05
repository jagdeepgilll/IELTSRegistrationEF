using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IELTSRegistrationEF.Model
{
    public class Result
    {
        [Key]//Add primary key
        public int ID { get; set; }// ID is primary key 
        public int RegistrationID { get; set; } // Registration ID coming from class registration
        public int BookingID { get; set; }// Add Booking ID

        public int Band { get; set; }//Add band 

        public Registration Registration { get; set; } //Linking to registration class
       
    }
}
