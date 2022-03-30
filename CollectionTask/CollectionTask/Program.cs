using System;
using System.Collections;

namespace CollectionTask
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SortedList proglanguageList = new SortedList();
            SortedList datelanguageList = new SortedList();


            proglanguageList.Add(5,"Java");
            proglanguageList.Add(2,"C++");
            proglanguageList.Add(1,"C");
            proglanguageList.Add(6,"C#");
            proglanguageList.Add(4,"JavaScript");
            proglanguageList.Add(3,"Pyton");

            datelanguageList.Add(5,"23 may 1995");
            datelanguageList.Add(2,"1980");
            datelanguageList.Add(1,"1972");
            datelanguageList.Add(6,"2000");
            datelanguageList.Add(4,"1995");
            datelanguageList.Add(3,"1991");


            foreach (DictionaryEntry sort in datelanguageList)
            {
                Console.WriteLine(sort.Value);
            }
            Console.WriteLine();
            foreach (DictionaryEntry sort in proglanguageList)
            {
                Console.WriteLine(sort.Value);
            }
        }
    }
}
