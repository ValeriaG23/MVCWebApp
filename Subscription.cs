using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAW.NivelAccesDate
{
    public class Subscription
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }

        public ICollection<CourseSubscription> CourseSubscriptions { get; set; } = new List<CourseSubscription>();
        public ICollection<User> Users { get; set; } = new List<User>();
    }
}
