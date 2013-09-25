using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: Spel.
 *                 Datum: 2013-09-20
 *            Programare: Hrodvar Johannsson
 */

class Spel
{
    //const ConsoleColor HERO_COLOR = ConsoleColor.DarkBlue;
    //const ConsoleColor BACKGROUND_COLOR = ConsoleColor.Green;

    //public static Coordinate Hero { get; set; } //Will represent our here that's moving around :P/>

    //public Spel(string[] args)
    //{
    //    InitGame();

    //    ConsoleKeyInfo keyInfo;
    //    while ((keyInfo = Console.ReadKey(true)).Key != ConsoleKey.Escape)
    //    {
    //        bool move = true;
    //        switch (keyInfo.Key)
    //        {
    //            case ConsoleKey.UpArrow:
    //                {
    //                    do
    //                    {
    //                        MoveHero(0, -1); //break;
    //                        //if (keyInfo == Console.ReadKey(true))
    //                        //    move = false;
    //                    } while (move);
    //                    break;
    //                }
    //            case ConsoleKey.RightArrow: {MoveHero(1, 0); break; }
    //            case ConsoleKey.DownArrow:  { MoveHero(0, 1); break; }
    //            case ConsoleKey.LeftArrow:  { MoveHero(-1, 0); break; }
    //        }   //  end of switch
    //    }   //  end of while
    //}   //  end of Spel()

    //public static void MoveHero(int x, int y)
    ////  Paint the new hero
    //{
    //    Coordinate newHero = new Coordinate()
    //    {
    //        X = Hero.X + x,
    //        Y = Hero.Y + y
    //    };  //  end of Coordinate

    //    if (CanMove(newHero))
    //    {
    //        RemoveHero();

    //        Console.BackgroundColor = HERO_COLOR;
    //        Console.SetCursorPosition(newHero.X, newHero.Y);
    //        Console.Write(" ");

    //        Hero = newHero;
    //    }   //  end of if
    //}   //  end of MoveHero()

    //ConsoleSpinner spin = new ConsoleSpinner();
    //Console.Write("Working....");
    //while (true) 
    //{
    //    spin.Turn();
    //}

    //public static void RemoveHero()
    ////  Overpaint the old hero
    //{
    //    Console.BackgroundColor = BACKGROUND_COLOR;
    //    Console.SetCursorPosition(Hero.X, Hero.Y);
    //    Console.Write(" ");
    //}   //  end of RemoveHero()

    //public static bool CanMove(Coordinate c)
    ////  Make sure that the new coordinate is not placed outside the
    ////  console window (since that will cause a runtime crash
    //{
    //    if (c.X < 0 || c.X >= Console.WindowWidth)
    //        return false;

    //    if (c.Y < 0 || c.Y >= Console.WindowHeight)
    //        return false;

    //    return true;
    //}   // end of CanMove()

    //public static void SetBackgroundColor()
    ////  Paint a background color
    ////  It is very important that you run the Clear() method after
    ////  changing the background color since this causes a repaint of the background
    //{
    //    Console.BackgroundColor = BACKGROUND_COLOR;
    //    Console.Clear(); //Important!
    //}   //  end of SetBackgroundColor()

    //public static void InitGame()
    ////  Initiates the game by painting the background
    ////  and initiating the hero
    //{
    //    SetBackgroundColor();

    //    Hero = new Coordinate()
    //    {
    //        X = 0,
    //        Y = 0
    //    };

    //    MoveHero(0, 0);

    //}
}