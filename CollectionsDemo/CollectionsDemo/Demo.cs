using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo
{
    public class Demo
    {
        public void doStackDemo()
        {
           Console.WriteLine("\nIn doListDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ravi");
            stack.Push("Vijay");
            stack.Push("Ravi");
            stack.Push("Ajay");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
        }
    }
}
