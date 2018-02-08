using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var stack = new Stack();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());

            stack.Push(4);
            stack.Push(5);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());


            
            

            for (int i = 5; i < 10; i++)
                stack.Push(i);
            
            //czyszczenie listy
            //stack.Clear();

            for (int i = 0; i < 5; i++)
                Console.WriteLine(stack.Pop());

            Console.ReadKey();
        }
    }
}
