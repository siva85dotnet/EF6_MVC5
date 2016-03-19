using System;
using System.ComponentModel.DataAnnotations;

namespace EF6_MVC5_DB_First.Models
{
    [MetadataType(typeof(StudentMetadata))]
    public partial class Student
    {
    }

    [MetadataType(typeof(EnrollmentMetadata))]
    public partial class Enrollment
    {
    }
}