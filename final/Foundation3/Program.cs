using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("230 Center St", "New York City", "NY", "USA");
        Address address2 = new Address("330 Main St", "Providence", "RI", "USA");
        Address address3 = new Address("30 Washington Ave", "Las Vegas", "NV", "USA");

        Lecture lecture = new Lecture("The Many Types of Urban Noise", "Come and learn the types of night sounds you may already be familiar with","2023-07-15", "10:00 AM", address1, "Mr Bradley", 100);
        Reception reception = new Reception("Company Annual Gathering", "Join us for our annual company party! No plus ones!", "2023-12-20", "7:00 PM", address2, "rsvp@corporateemail.com");
        OutdoorGathering outdoorgathering = new OutdoorGathering("Fallout New Vegas Convention", "Come and join us for the end of the world!", "2023-06-10", "9:00 AM", address3, "Sunny, 75°F");

        var events = new Event[] { lecture, reception, outdoorgathering };

        // Display event details
        foreach (var ev in events)
        {
            Console.WriteLine("Standard Details:");
            Console.WriteLine(ev.GetStandardDetails());
            Console.WriteLine();

            Console.WriteLine("Full Details:");
            Console.WriteLine(ev.GetFullDetails());
            Console.WriteLine();

            Console.WriteLine("Short Description:");
            Console.WriteLine(ev.GetShortDescription());
            Console.WriteLine();
        }
    }
}