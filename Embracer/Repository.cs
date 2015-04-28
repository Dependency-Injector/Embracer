using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Embracer
{
    class Repository
    {

        EmbracerEntitiesContext context;

        public Repository()
        {

            context = new EmbracerEntitiesContext();
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

        public void RemoveActivity(Activity selectedActivity)
        {
            context.ActivitySet.Remove(selectedActivity);
            context.SaveChanges();
        }
    }
}
