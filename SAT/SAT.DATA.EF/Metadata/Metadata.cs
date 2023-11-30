using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAT.DATA.EF.Models/*.Metadata*/
{
    public class CourseMetadata
    {
        public int CourseId { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name ="Name")]
        public string CourseName { get; set; } = null!;
        [Required]
        [Display(Name = "Description")]
        public string CourseDescription { get; set; } = null!;
        [Required]
        [Display(Name = "Credit Hours")]
        [Range(0, 255, ErrorMessage ="Cannot exceed 255")]
        public byte CreditHours { get; set; }
        [StringLength(250)]
        public string? Curriculum { get; set; }
        [StringLength(500)]
        public string? Notes { get; set; }
        [Required]
        [Display(Name = "Active")]
        public bool IsActive { get; set; }

    }

    public class EnrollmentMetada
    {
        public int EnrollmentId { get; set; }
        public int StudentId { get; set; }
        public int ScheduledClassId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EnrollmentDate { get; set; }
    }

    public class ScheduledClassMetadata
    {
        public int ScheduledClassId { get; set; }
        public int CourseId { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime EndDate { get; set; }
        [Required]
        [StringLength(40)]
        public string InstructorName { get; set; } = null!;
        [Required]
        [StringLength(20)]
        public string Location { get; set; } = null!;

        public int Scsid { get; set; }
    }

    public class ScheduledClassStatusMetadata
    {
        public int Scsid { get; set; }
        [Required]
        [StringLength(50)]
        public string Scsname { get; set; } = null!;
    }

    public class StudentMetadata
    {
        public int StudentId { get; set; }
        [Required]
        [StringLength(20)]
        [Display(Name = "First Name")]
        public string FirstName { get; set; } = null!;
        [Required]
        [StringLength(20)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; } = null!;
        [StringLength(15)]
        public string? Major { get; set; }
        [StringLength(50)]
        public string? Address { get; set; }
        [StringLength(25)]
        public string? City { get; set; }
        [StringLength(2)]
        public string? State { get; set; }
        [StringLength(10)]
        public string? ZipCode { get; set; }
        [StringLength(13)]
        public string? Phone { get; set; }
        [Required]
        [StringLength(60)]
        public string Email { get; set; } = null!;
        [StringLength(100)]
        public string? PhotoUrl { get; set; }
        public int Ssid { get; set; }
    }

    public class StudentStatusMetadata
    {
        public int Ssid { get; set; }
        [Required]
        [StringLength(30)]
        public string Ssname { get; set; } = null!;
        [StringLength(250)]
        public string? Ssdescription { get; set; }
    }
}
