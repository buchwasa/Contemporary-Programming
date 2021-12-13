using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass1028
{
    class Program
    {
        static void Main(string[] args)
        {
            List<String> myList = new List<String>();
            ArrayList arrayList = new ArrayList(); //Not type-safe

            myList.Add("42");
            arrayList.Add(42);
            arrayList.Add("42");

            myList.Add("Hamburger");
            myList.Add("Mountain");
            myList.Add("Corvette");

            foreach(String item in myList)
            {
                Console.WriteLine(item);
            }

            for (int i = 0; i < myList.Count; i++)
            {
                myList[i] = "new string";
            }

            myList.ForEach(delegate(String item)
            {
                Console.WriteLine(item);
            });

            myList.ForEach(Console.WriteLine);


            myList.Remove("new string");
            Console.WriteLine("removed string");
            myList.ForEach(Console.WriteLine);

            myList.Add("Hamburger");
            myList.Add("Mountain");
            myList.Add("Corvette");

            myList.Sort();

            Console.WriteLine("sorted");
            myList.ForEach(Console.WriteLine);
            // Is it thread safe?
        }
    }
}
