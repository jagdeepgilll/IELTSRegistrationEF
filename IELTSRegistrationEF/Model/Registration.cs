using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IELTSRegistrationEF.Model
{
    //Add categories
    public enum Category
    {
        Academic, General
    }
    //Add test types
    public enum TestType
    {
        IELTS, PTE, TOFFEL, ESOL
    }
    //Add regestrition class
    public class Registration
    {
        [Key]
        // Person entity with Registration ID
        public int ID { get; set; }// Registration id (Primary Key)
                                   // 1 to 1
        public string FirstName { get; set; }// FirstName
        public string LastName { get; set; }//LastName
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; } // Date of Birth
        public int Contact { get; set; } // Contact
        public string PassportNumber { get; set; } // PassportNumber
        public Category? Category { get; set; } // Category

        public TestType? TestType { get; set; }//TestType
       
        public ICollection<Booking> Bookings { get; set; } // 1 to many relation , linking to booking model
        public ICollection<Result> Results { get; set; } // 1 person have many results, linking to result model

    }
}
