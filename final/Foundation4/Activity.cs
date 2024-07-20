using System;

namespace FitnessApp
{
    public abstract class Activity
    {
        private string date;
        private int length; // in minutes

        public Activity(string date, int length)
        {
            this.date = date;
            this.length = length;
        }

        public string Date { get { return date; } }
        public int Length { get { return length; } }

        public abstract double GetDistance(); // distance in miles or kilometers
        public abstract double GetSpeed();    // speed in mph or kph
        public abstract double GetPace();     // pace in min per mile or min per km

        public virtual string GetSummary()
        {
            return $"{Date} {this.GetType().Name} ({Length} min) - Distance: {GetDistance():0.0} miles, Speed: {GetSpeed():0.0} mph, Pace: {GetPace():0.0} min per mile";
        }
    }
}
