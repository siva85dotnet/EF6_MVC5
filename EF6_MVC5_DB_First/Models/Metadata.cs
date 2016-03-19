using System;
using System.ComponentModel.DataAnnotations;

namespace EF6_MVC5_DB_First.Models
{
    public class StudentMetadata
    {
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName;

        [StringLength(50)]
        [Display(Name = "First Name")]
        public string FirstName;

        [StringLength(50)]
        [Display(Name = "Candidate's Middle Name is")]
        public string MiddleName;

        [Display(Name = "Enrollment Date")]
        public Nullable<System.DateTime> EnrollmentDate;
    }

    public class EnrollmentMetadata
    {
        [Range(0, 4)]
        public Nullable<decimal> Grade;
    }
}