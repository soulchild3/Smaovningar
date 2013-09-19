using System;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: Klassen innhåller methode som vänder en text baklänges.
 *                        Detta är en del av småövningar som Thomas har skaffat os.
 *                 Datum: 2013-09-19
 *            Programare: Hrodvar Johannsson
 */

class Palindrom
{
    //  properties
    public string TextOrginal   { get; set; }
    public string TextBaklanges { get; set; }
    //  end of properties

    //  constructor
    public Palindrom(string text)
    {
        TextOrginal = text;
        TextBaklanges = Baklanges(text);
    }
    //  end of constructor

    //  methoder
    public string Baklanges(string str)
    {
        string output = "";
        foreach(char s in str)
        {
            output = s + output;
        }
        return output;
    }
    //  end of methoder
}

