using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_v
{
    public class Instructor
    {
        public string Id { get; set; }

        public string Name { get; set; }
        public string Specialization { get; set; }
        public ICollection < Course > Courses { get; set; } = new List<Course> ();

    }
}
