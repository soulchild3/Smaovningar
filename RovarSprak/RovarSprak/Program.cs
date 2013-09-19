using System;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: Småövningar.
 *                 Datum: 2013-09-18
 *            Programare: Hrodvar Johannsson
 */

class Program
{
    //  properties
    public static DateTime ToDay { get; set; }
    //  end of properties

    //  constructor
    static void Main(string[] args)
    {
        Utseende();
        Kalender(); 
        Palindrom(Roversprak());

        System.Console.ForegroundColor = ConsoleColor.Yellow;
        System.Console.SetCursorPosition(8, 30);
    }   //  end of Main()
    //  end of constructor

    //  methoder
    static void Utseende()
    {
        System.Console.Title = "Systemutvecklare: Småövningar";
        System.Console.SetWindowSize(73, 35);
        System.Console.ForegroundColor = ConsoleColor.Cyan;
    }   //  end of Utseende()

    static void Kalender()
    {
        //  skapa nytt object av klassen 'Kalender'.
        Kalender kalender = new Kalender();
    }   //  end of Kalender()

    static string Roversprak()
    {
        //  skapa nytt object av klassen 'RovarSprakKompiler'.
        RovarSprakKompiler kompiler = new RovarSprakKompiler();
        
        System.Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\n\tSkriv in text på svenska: ");
        System.Console.ForegroundColor = ConsoleColor.Red;
        string input = Console.ReadLine();
        System.Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\tRövarspråk:");
        System.Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\t" + kompiler.RoversprakKompiler(input) + "\n");
        System.Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\tSvenska:");
        System.Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\t" + kompiler.SvensksprakKompiler(kompiler.RoversprakKompiler(input)) + "\n\n");
        return input;
    }   //  end of Roversprak()

    static void Palindrom(string str)
    {
        //  skapa nytt object av klassen 'Palindrom'.
        Palindrom palindrom = new Palindrom(str);
        System.Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\tBaklänges: ");
        System.Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\t" + palindrom.TextBaklanges);
    }   //  end of Palindrom()
    //  end of methoder
}

