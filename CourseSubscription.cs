using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PPAW.NivelAccesDate
{
    public class CourseSubscription
    {


        public string Id { get; set; }
        public string SubscriptionId {  get; set; }
        public virtual Subscription Subscription { get; set; }

        public string CourseId { get; set; }
        public virtual Course Course { get; set; }

    }
}
