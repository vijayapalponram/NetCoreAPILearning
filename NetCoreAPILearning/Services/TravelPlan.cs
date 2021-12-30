using NetCoreAPILearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPILearning.Services
{
    public class TravelPlan : ITravelPlan
    {
        List<Travel> travelPlans = new List<Travel>();
        public TravelPlan()
        {
            Travel travel = new Travel();
            travel.TravelId = "1";
            travel.TravelFrom = "india";
            travel.TravelTo = "uk";
            travel.TravelDate = new DateTime();
            Travel travel2 = new Travel();
            travel2.TravelId = "2";
            travel2.TravelFrom = "india";
            travel2.TravelTo = "uk";
            travel2.TravelDate = new DateTime();
            travelPlans.Add(travel);
            travelPlans.Add(travel2);

        }

        public List<Travel> GetTravelPlans()
        {
            return travelPlans;
        }
        public Travel GetTravelPlanById(string Id)
        {
            return travelPlans.FirstOrDefault(plan => plan.TravelId == Id);
        }
    }
}
