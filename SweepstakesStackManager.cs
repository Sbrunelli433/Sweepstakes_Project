using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project_
{
    public class SweepstakesStackManager : ISweepstakesManager
    {
        public Sweepstakes GetSweepstakes()
        {
            Console.WriteLine("Stack manager gets the Sweepstakes");
            throw new NotImplementedException();
        }

        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Console.WriteLine("Stack manager inserts the sweepstakes");
        }

        //uses the stack data structure as underlying structure
        //public void PushOnToStack()
        //{
        //    Stack<int> stack = new Stack<int>();

        //    stack.Push(12);
        //    stack.Push(16);
        //    stack.Push(87);

        //    Console.WriteLine("Elements in stack: ");
        //    foreach (int number in stack)
        //    {
        //        Console.WriteLine(number);
        //    }

        //    int topOfStack = stack.Pop();

        //    stack.Push(3);

        //    Console.WriteLine("Elements in stack after Pop and Push(3): ");
        //    foreach (int number in stack)
        //    {
        //        Console.WriteLine(number);
        //    }
        //}
    }
}

