using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_v
{
    public class User
    {
        public string Id {  get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public string SubscriptionId { get; set; }
        public virtual Subscription Subscription { get; set; }  

        
    }
}
