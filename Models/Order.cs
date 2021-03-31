using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileHubMVC.Models
{
    public class Order
    {
        [key]
        public int ID { get; set; }
        public int UserID { get; set; }
        public User User { get; set; }
        public int MobileID { get; set;}
        public Mobile Mobilem { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
