using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPILearning.Models
{
    public class Travel
    {
        public string TravelId { get; set; }
        public string TravelFrom { get; set; }
        public string TravelTo { get; set; }
        public DateTime TravelDate { get; set; }
        public string Purpose { get; set; }

    }
}
