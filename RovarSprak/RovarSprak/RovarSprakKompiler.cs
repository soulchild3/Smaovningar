﻿using System;
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
    //  end of properties

    //  constructor
    public RovarSprakKompiler()
    {

    }   //  end of RovarSprakKompiler()
    //  end of constructor

    //  methoder
    public string RoversprakKompiler(string ord)
    {
        string output = "";
        foreach(char o in ord)
        {
            output += o;
            foreach (char x in bokstaver)
                if (o == x)
                    output += "o" + x;
        }
        return output;
    }  //  end of RoversprakKompiler()

    public string SvensksprakKompiler(string ord)
    {
        string output = "";
        for (int i = 0; i < (ord.Length); i++ )
        {
            foreach (char x in bokstaver)
                if (ord.ElementAt(i) == x)
                    i = i + 2;
            output += ord.ElementAt(i);
        }
        return output;
    }   //  SvensksprakKompiler()

    //  end of methoder
}

