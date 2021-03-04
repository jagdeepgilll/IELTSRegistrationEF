using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace IELTSRegistrationEF.Model
{
    public enum Category
    {
        Academic, General
    }
    public enum TestType
    {
        IELTS, PTE, TOFFEL, ESOL
    }
    public class Registration
    {
        [Key]
        // Person entity with Registration ID
        public int ID { get; set; }// Registration id (Primary Key)
                                   // 1 to 1
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DOB { get; set; } // Date of Birth
        public int Contact { get; set; }
        public string PassportNumber { get; set; }
        public Category? Category { get; set; }

        public TestType? TestType { get; set; }
       
        public ICollection<Booking> Bookings { get; set; } // 1 to many relation , 1 can book many tests
        public ICollection<Result> Results { get; set; } // 1 person have many results

    }
}
