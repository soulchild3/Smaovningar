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
    public string TextPalindrom { get; set; }
    //  end of properties

    //  constructor
    public Palindrom(string text)
    {
        TextOrginal = text.ToLower();
        Baklanges();
        ArOrdetPalindrom();
    }   //  end of Palindrom()
    //  end of constructor

    //  methoder
    public void Baklanges()
    {
        string output = "";
        foreach (char s in TextOrginal)
            output = s + output;
        TextBaklanges = output;
    }   //  end of Baklanges()

    public void ArOrdetPalindrom()
    {
        if (TextOrginal == TextBaklanges)
            TextPalindrom = "Texten " + TextOrginal +" är palindrom.";
        else
            TextPalindrom = "Texten är inte palindrom.";
    }  //  end of ArOrdetPalindrom()
    //  end of methoder
}

