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
    //  end of methods

}   //  end of class Listor01

