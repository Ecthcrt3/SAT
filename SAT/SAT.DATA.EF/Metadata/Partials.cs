using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SAT.DATA.EF.Models/*.Metadata*/
{
    [ModelMetadataType(typeof(CourseMetadata))]
    public partial class Course { }
    [ModelMetadataType(typeof(EnrollmentMetada))]
    public partial class Enrollment { }
    [ModelMetadataType(typeof(ScheduledClassMetadata))]
    public partial class ScheduledClass { }
    [ModelMetadataType(typeof(ScheduledClassStatusMetadata))]
    public partial class ScheduledClassStatus {}

    [ModelMetadataType(typeof(StudentMetadata))]
    public partial class Student {
        [NotMapped]
        public IFormFile? Image { get; set; }
    }
    [ModelMetadataType(typeof(StudentStatusMetadata))]
    public partial class StudentStatus { }

}
