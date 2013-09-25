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
    static List<string> NamnList = new List<string>();
    //  end of properties

    //  constructor
    static void Main(string[] args)
    {
        //Spel spel = new Spel(args);
        Utseende();
        UserInformation();
        do
        {
            Utseende();
            Kalender();
            Palindrom(Roversprak());
            ListOvning1Och2();
            ListOvning3();
            ListOvning4();
            ListOvning5();

            
            ("Tryck på 'Enter' till att fortsätta eller 'Esc' för att sluta!").CW(1, "Yellow");

            Retry = Run();
        } while (Retry);
    }   //  end of Main()
    //  end of constructor

    //  methoder
    static void Cursor()
    {
        int cursorTop = Console.CursorTop + 3;
        int cursorLeft = Console.CursorLeft;
        Console.SetCursorPosition(cursorLeft, cursorTop);
    }   //  end of Cursor()

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
        ("Skriv in text på svenska: ").CW(2, "Cyan");
        Console.ForegroundColor = ConsoleColor.Red;
        string input = Console.ReadLine(); ; 
        //  skapa nytt object av klassen 'RovarSprakKompiler'.
        RovarSprakKompiler kompiler = new RovarSprakKompiler(input);
        ("Rövarspråk: ").CW(1, "Cyan");
        (kompiler.RovarOrd).CW(1, "Red");
        ("Svenska: ").CW(2, "Cyan");
        (kompiler.SvenskaOrd).CW(1, "Red");
        return input;
    }   //  end of Roversprak()

    static void Palindrom(string str)
    {
        //  skapa nytt object av klassen 'Palindrom'.
        Palindrom palindrom = new Palindrom(str);
        ("Baklänges: ").CW(2, "Cyan");
        (palindrom.TextBaklanges).CW(1, "Red");
        ("Palindrom: ").CW(2, "Cyan");
        (palindrom.TextPalindrom).CW(1, "Red");
    }   //  end of Palindrom()

    static void ListOvning1Och2()
    {
        ("Skriv in ett eller flera namn: ").CW(2, "Cyan");
        Console.ForegroundColor = ConsoleColor.Red;
        string namn = Console.ReadLine();
        
        if (namn.Trim() != "" && !namn.Contains("  ") && namn[0] != ' ')
        {
            NamnList.AddRange(namn.Split(' '));
            (NamnList.Join("\n\t")).CW(0, "Red");
        }   // end of if 
        else
        {
            foreach (string item in NamnList)
                (item).CW(1, "Red");
        }   // end of else

    }   // end of ListOvning()

    static void ListOvning3()
    {
        ("Skriv in ett namn till: ").CW(2, "Cyan");
        Console.ForegroundColor = ConsoleColor.Red;
        string namn = Console.ReadLine();

        if (namn.Trim() != "" && !namn.Contains("  ") && !namn.Contains(" ") && namn[0] != ' ')
        {
            ("Var i listan vill du sätta in namnet " + namn + "? ").CW(1, "Cyan");
            Console.ForegroundColor = ConsoleColor.Red;
            int placeInList = Convert.ToInt16(Console.ReadLine());
            if (placeInList > NamnList.Count)
                placeInList = NamnList.Count;
            if (placeInList < 0)
                placeInList = 0;
            NamnList.Insert(placeInList, namn);
            (NamnList.Join("\n\t")).CW(0, "Red");
        }   // end of if 
        else
        {
            foreach (string item in NamnList)
                (item).CW(1, "Red");
        }   // end of else
    }   // end of ListOvning3()

    static void ListOvning4()
    {
        ("Vilket namn vill du radera från listan? ").CW(2, "Cyan");
        Console.ForegroundColor = ConsoleColor.Red;
        int i = 0;
        string namn = Console.ReadLine();
        bool test = int.TryParse(namn, out i);
        if (test)
            NamnList.RemoveAt(i);
        else if (NamnList.Contains(namn))
            NamnList.Remove(namn);
        (NamnList.Join("\n\t")).CW(0, "Red");
    }   // end of ListOvning4()

    static void ListOvning5()
    {
        ListSiffror listSiffror = new ListSiffror(1, 999);
        ("Har skapat en lista med udda tal, från 1 t.o.m 999").CW(2, "Cyan");
        ("Ta bort alla tal som inte innehåller minst två\n\tlikadana siffror och skriv ut listan!").CW(2, "Cyan");
        listSiffror.TaBortTal(2);
        ("Ta bort alla tal som inte innehåller minst tre \n\tlikadana siffror och skriv ut listan!").CW(2, "Cyan");
        listSiffror.TaBortTal(3);

    }

    static void test()
    {
        List<int> list = new List<int>();
        for (int i = 1; i < 1000; i += 2)
        {
            list.Add(i);
        }
        (list.Join()).CW(1,"Blue");
    }

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
                Environment.Exit(0);    //  stänger programmet
            else
                result = false;
        } while (!result);
        return result;
    }   //  end of Run()

    static void UserInformation()
    {
        ("Skriv in ditt username: ").CW(2, "Cyan");
        Console.ForegroundColor = ConsoleColor.Red;
        string username = Console.ReadLine();
        
        if (username != Environment.UserName)
        {
            (username + " är idot!\n\t\tRätt username är " + Environment.UserName).CW(1, "Cyan");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(8, 20);
            Environment.Exit(0);
        }   // end of if
        else
        {
            Console.Clear();
            ("\t\tVälkomen").CW(1, "Cyan");
            ("\t\t" + Environment.UserName).CW(1, "Red");
        }   // end of else
    }  //  end of UserIformation()

    //  end of methoder
}

