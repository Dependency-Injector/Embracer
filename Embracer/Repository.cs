using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embracer
{
    class Repository
    {

        EmbracerEntitiesContainer context;

        public Repository()
        {

            context = new EmbracerEntitiesContainer();
        }


        public void AddActivity(Activity activity)
        {

            context.ActivitySet.Add(activity);
            context.SaveChanges();
        }

        public void UpdateActivity(Activity activity)
        {
            context.ActivitySet.Attach(activity);
            context.SaveChanges();
        }
        public IQueryable<Activity> GetActivities()
        {
            return context.ActivitySet;
        }

        public IQueryable<TimePeriod> GetActivitiesHistory()
        {
            return context.TimePeriodSet;
        }
    }
}
