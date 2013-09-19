using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: Klassen innhåller methoder som håller ihop veckor, månader och år.
 *                        Detta är en del av småövningar som Thomas har skaffat os.
 *                 Datum: 2013-09-19
 *            Programare: Hrodvar Johannsson
 */

class Kalender
{
    //  properties
    public static DateTime dt = new DateTime();
    public int CurrentYear      { get; set; }
    public int CurrentMonth     { get; set; }
    public int CurrentDay       { get; set; }
    public int CurrentDayOfWeek { get; set; }
    public int CurrentHour      { get; set; }
    public int CurrentMin       { get; set; }
    public int CurrentSek       { get; set; }
    //  end of properties

    //  constructor
    public Kalender()
    {
        CurrentYear      = DateTime.Today.Year;
        CurrentMonth     = DateTime.Today.Month;
        CurrentDay       = DateTime.Today.Day;
        CurrentDayOfWeek = Convert.ToInt16(DateTime.Today.DayOfWeek);
        CurrentHour      = DateTime.Today.Hour;
        CurrentMin       = DateTime.Today.Minute;
        CurrentSek       = DateTime.Today.Second;
        DisplayHeader(MonthName(CurrentMonth), CurrentYear.ToString(), true);
        DisplayCalender(CurrentYear, CurrentMonth, CurrentDay);
    }   //  end of Kalender()
    //  end of constructor

    //  methoder
    private static string MonthName(int currentMonth)
    {
        DateTimeFormatInfo info = new DateTimeFormatInfo();
        string month = info.MonthNames[currentMonth - 1];
        return month;
    }   //  end of MonthName

    public void DisplayHeader(string theMonthName, string theYear, bool ShowCurrentDate)
    {
        System.Console.ForegroundColor = ConsoleColor.Cyan;
        string Header = String.Concat("\t" + theMonthName, ", ");
        Header = String.Concat(Header, theYear);
        String Days = "\tSön\tMån\tTis\tOns\tTor\tFre\tLör";
        String Divider = new String('-', 55);
        
        if (ShowCurrentDate)
            Console.Write("\n\n\n\t\t\tIdag är {0}/{1}/{2}.\n\n", CurrentMonth, CurrentDay, CurrentYear);
        
        Console.Write("\n" + String.Concat("\t\t", Header) + "\n");
        Console.Write("\n" + Days);
        Console.Write("\n\t" + Divider + "\n");
    }   //  DisplayHeader()

    public void DisplayCalender(int TheYear, int TheMonth, int TheDay)
    {
        //  set default som första varja månader.
        int FirstDayOfMonth = 1;
        int NumberOfDaysInMonth = DateTime.DaysInMonth(TheYear, TheMonth);
        DateTime dt2 = new DateTime(TheYear, TheMonth, FirstDayOfMonth);

        //  Detta är dagen i veckan som vi börjar med (0 - 6).
        int StartDay = Convert.ToInt32(dt2.DayOfWeek);

        //  NumberOfTabs visar hur många '\t' vi 
        //  använder för första dagen i månaden. 
        //  + 1 till att flytta texten från sidan.
        int NumberOfTabs = StartDay + 1;
        System.Console.ForegroundColor = ConsoleColor.Red;
        int DayOfWeek = StartDay;
        for (int Counter = 1; Counter <= NumberOfDaysInMonth; Counter++)
        {
            string DayString = "";
            //  Om det är första dagen i månaden vi behöver att
            //  veta hur många '\t' vi behöver att använda så vi 
            //  hamnar på rätt ställe.
            if (Counter == 1)
            {
                String Padding = new String('\t', NumberOfTabs);
                DayString = String.Concat(Padding, Counter.ToString());
            }   //  end of if
            else
                DayString = Counter.ToString();

            //  Använd '*' till at visa dagen idag 
            if (TheDay != 1 && Counter == TheDay)
                DayString = String.Concat("*", DayString);
            
            //  Börja nya rad om det är inte förste dagen i månaden.
            if (DayOfWeek % 7 == 0 && Counter > 1)
                DayString = String.Concat("\n\t", Counter.ToString());

            //  Använd '\t' som mellem dagarna.
            Console.Write("{0}\t", DayString);

            DayOfWeek++;
        }   //  end of for
        System.Console.ForegroundColor = ConsoleColor.Cyan;
        String Divider = new String('-', 55);
        Console.Write("\n\t" + Divider + "\n");
    }   //  DisplayCalender()
    //  end of methoder
}   //  end of class Kalender