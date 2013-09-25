using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public static class MyExtensions
{
    //  properties
    //  end of properties
   
    //  constructor
    //  end of constructor

    //  methods
    public static string Join<T>(this List<T> list)
    {
        return string.Join(", ", list);
    }

    public static string Join<T>(this List<T> list, string glue)
    {
        return string.Join(glue, list);
    }

    public static string Join<T>(this List<T> list, string[] array)
    {
        return string.Join(", ", array);
    }

    public static string Join<T>(this List<T> list, string text, int where)
    {
        return string.Join(", ", text.Insert(where, text));
    }
    
    public static void CW(this string strValue, int lineBreak, string color)
    {
        String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        foreach (string colorName in colorNames)
            if (colorName == color)
            {
                ConsoleColor newColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                Console.ForegroundColor = newColor;
                break;
            }       
        
        string strLineBreak = new String('\n', lineBreak);
        string strTab = new String('\t', 1);
        Console.Write(strLineBreak + strTab + strValue);
    }

    public static string CR(this string strValue, string color)
    {
        String[] colorNames = ConsoleColor.GetNames(typeof(ConsoleColor));
        foreach (string colorName in colorNames)
            if (colorName == color)
            {
                ConsoleColor newColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colorName);
                Console.ForegroundColor = newColor;
                break;
            }   // end of if

        strValue = Console.ReadLine();
        return strValue.CR(color);
    }   // end of CR()

    //  end of methods

}   //  end of class MyExtensions

