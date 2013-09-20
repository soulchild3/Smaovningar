using System;
using System.Collections.Generic;
using System.Linq;

/* 
 * Programmeringsverktyg: Visual Studio 2012 pro.
 *               Program: Klassen innhåller methoder som kompilar från svenska till rövarspråk 
 *                        och så till svenska igen.
 *                        Detta är en del av småövningar som Thomas har skaffat os.
 *                 Datum: 2013-09-19
 *            Programare: Hrodvar Johannsson
 */

class RovarSprakKompiler
{
    //  properties
    public static List<char> bokstaver = new List<char> {'b', 'c',	'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm',
                                                         'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z'};
    public string RovarOrd   { get; set; }
    public string SvenskaOrd { get; set; }
    //  end of properties

    //  constructor
    public RovarSprakKompiler(string ord)
    {
        RovarOrd = RoversprakKompiler(ord.ToLower());
        SvenskaOrd = SvensksprakKompiler(RovarOrd);
    }   //  end of RovarSprakKompiler()
    //  end of constructor

    //  methoder
    public string RoversprakKompiler(string svenskaOrd)
    {
        string output = "";
        foreach(char o in svenskaOrd)
        {
            output += o;
            foreach (char x in bokstaver)
                if (o == x)
                    output += "o" + x;
        }
        return output;
    }  //  end of RoversprakKompiler()

    public string SvensksprakKompiler(string rovarOrd)
    {
        string output = "";
        for (int i = 0; i < (rovarOrd.Length); i++ )
        {
            foreach (char x in bokstaver)
                if (rovarOrd.ElementAt(i) == x)
                    i = i + 2;
            output += rovarOrd.ElementAt(i);
        }
        return output;
    }   //  SvensksprakKompiler()

    //  end of methoder
}

