using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("Via Roma", "Rome", "Lazio", "Italy");

        Lecture lecture = new Lecture("Artistic Insights: 'The Renaissance Connection'", "A deep dive into Renaissance art with Giulia Rossi", "October 21, 2023", "4 PM", address, "Giulia Rossi", 100);
        Console.WriteLine();

        Console.WriteLine("Event Number: 1");
        Console.WriteLine();
        Console.WriteLine(lecture.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateDetailedLecture());

        Console.WriteLine();
        Console.WriteLine(lecture.GenerateShortLecture());

        Address addressR = new Address("Corso Umberto I", "Naples", "Campania", "Italy");

        Reception reception = new Reception("Youth Music Gala", "An evening with maestro Alessandro Bianchi", "July 30, 2023", "7 PM", addressR, "gala@youthmusic.it");
        Console.WriteLine();

        Console.WriteLine("Event Number: 2");
        Console.WriteLine();
        Console.WriteLine(reception.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateDetailedReception());

        Console.WriteLine();
        Console.WriteLine(reception.GenerateShortReception());

        Address addressOG = new Address("Piazza del Campo", "Siena", "Tuscany", "Italy");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Historic Siena Festival", "Medieval traditions and modern festivities", "June 14, 2023", "8 PM", addressOG, "clear skies");
        Console.WriteLine();

        Console.WriteLine("Event Number: 3");

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateStandard());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateDetailedOutdoorGathering());

        Console.WriteLine();
        Console.WriteLine(outdoorGathering.GenerateShortOutdoorGathering());
    }
}
