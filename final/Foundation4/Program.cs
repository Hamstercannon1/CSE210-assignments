using System;
using System.Collections.Generic;

namespace FitnessApp
{
    public class Program
    {
        public static void Main()
        {
            List<Activity> activities = new List<Activity>
            {
                new Running("03 Nov 2022", 30, 3.0),
                new Cycling("03 Nov 2022", 45, 15.0),
                new Swimming("03 Nov 2022", 60, 20)
            };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}

