using NetCoreAPILearning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreAPILearning.Services
{
    public interface ITravelPlan
    {
        List<Travel> GetTravelPlans();

        Travel GetTravelPlanById(string Id);
    }
}
