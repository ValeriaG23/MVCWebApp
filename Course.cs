using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAW.NivelAccesDate
{
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string InstructorId { get; set; }
        public virtual Instructor Instructor { get; set; }
        public ICollection<CourseSubscription> CourseSubscriptions { get; set; } = new List<CourseSubscription>();

    }
}
