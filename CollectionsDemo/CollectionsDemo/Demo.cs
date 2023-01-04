using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Demo
    {
        public void doDictionaryDemo()
        {
            Console.WriteLine("\nIn doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Ayush");
            dictionary.Add(102, "Vijay");
            Console.WriteLine("Access value using Key(Key = 100): " + dictionary[100]);
            Console.WriteLine("\nIterating Dictionary");
            foreach (var element in dictionary)
            {
                Console.WriteLine("Key =" + element.Key + " &  value =" + element.Value);
            }
        }
    }
}
