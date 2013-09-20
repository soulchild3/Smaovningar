using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: Småövningar.
 *                 Datum: 2013-09-18
 *            Programare: Hrodvar Johannsson
 */

class Program
{
    //  properties
    static bool Retry { get; set; }
    //  end of properties

    //  constructor
    static void Main(string[] args)
    {
        UserInformation();
        do
        {
            Utseende();
            Kalender(); 
            Palindrom(Roversprak());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(8, 35);
            Console.Write("\nTryck på 'Enter' till att fortsätta eller 'Esc' för att sluta!");
            
            Retry = Run();
        }
        while (Retry);
    }   //  end of Main()
    //  end of constructor

    //  methoder
    static void Utseende()
    {
        Console.Title = "Systemutvecklare: Småövningar";
        Console.SetWindowSize(73, 37);
    }   //  end of Utseende()

    static void Kalender()
    {
        //  skapa nytt object av klassen 'Kalender'.
        Kalender kalender = new Kalender();
    }   //  end of Kalender()

    static string Roversprak()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\n\tSkriv in text på svenska: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string input = Console.ReadLine();
        //  skapa nytt object av klassen 'RovarSprakKompiler'.
        RovarSprakKompiler kompiler = new RovarSprakKompiler(input);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\tRövarspråk:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\t" + kompiler.RovarOrd + "\n");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\tSvenska:");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\t" + kompiler.SvenskaOrd + "\n\n");
        return input;
    }   //  end of Roversprak()

    static void Palindrom(string str)
    {
        //  skapa nytt object av klassen 'Palindrom'.
        Palindrom palindrom = new Palindrom(str);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\tBaklänges: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\t" + palindrom.TextBaklanges);
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\n\tPalindrom: ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("\n\t" + palindrom.TextPalindrom);
    }   //  end of Palindrom()

    static bool Run()
    {
        bool result = false;
        do
        {
            ConsoleKey key = Console.ReadKey(true).Key;
            if (key == ConsoleKey.Enter)
            {
                Console.Clear();
                result = true;
            }   //  end of if
            else if (key == ConsoleKey.Escape)
                Environment.Exit(0);
            else
                result = false;
        } while (!result);
        return result;
    }   //  end of Run()

    static void UserInformation()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n\n\t\tSkriv in ditt username: ");
        Console.ForegroundColor = ConsoleColor.Red;
        string username = Console.ReadLine();
        Console.ForegroundColor = ConsoleColor.Cyan;
        if (username != Environment.UserName)
        {
            Console.Write("\n\t\t" + username + " är idot!\n\tRätt username är " + Environment.UserName);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(8, 20);
            Environment.Exit(0);
        }
    }  //  end of UserIformation()
    //  end of methoder
}

