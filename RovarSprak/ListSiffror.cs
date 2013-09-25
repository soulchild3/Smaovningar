using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ListSiffror
{
    //  properties
    public List<int> ListanSiffror = new List<int>();
    public int LowestNumber        { get; set; }
    public int HighestNumber       { get; set; }
    //  end of properties

    //  constructor
    public ListSiffror(int low, int high)
    {
        LowestNumber = low;
        HighestNumber = high;
        SkapaListan();
    }   // end of ListSiffror()
    //  end of constructor

    //  methods
    public void SkapaListan()
    {
        for (int i = LowestNumber; LowestNumber <= HighestNumber; LowestNumber += 2)
            ListanSiffror.Add(LowestNumber);
        //ListanSiffror.Join();
    }   // end of SkapaListan()

    public void TaBortTal(int antalLikadana)
    {
        int counter = 0;
        int linebreak = 0;
        Console.WriteLine();
        List<char> itemChars = new List<char>();
        foreach (int itemInt in ListanSiffror)
        {
            itemChars.Clear();
            int y = 1;
            bool test = true;
            foreach (char itemChar in itemInt.ToString().ToCharArray())
            {
                if (itemChars.Contains(itemChar))
                {
                    test = true;
                    y++;
                }
                else
                    test = false;
                itemChars.Add(itemChar);
            }   // foreach
            if (test && y >= antalLikadana)
            {
                if (counter == 7)
                {
                    linebreak = 1;
                    counter = 0;
                }
                else
                    linebreak = 0;
                   
                (itemInt.ToString()).CW(linebreak, "Red");
                counter++;
            }

        }   // foreach
    }   // end of TaBortTal()

    //  end of methods
}

