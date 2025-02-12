using System;
using System.Collections;
using System.Collections.Generic;

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

            //stack.Clear();

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
        }
    }

    public class Stack
    {

        private readonly ArrayList list = new ArrayList();

        public void Push(object obj)
        {
            if(obj == null)
            {
                throw new InvalidOperationException("Null cannot be passed in.");
            }            
            list.Add(obj);
        }

        public object Pop()
        {
            object isPopped;
            var index = list.Count - 1;

            if (list.Count == 0)
            {
                throw new InvalidOperationException("You cannot evaluate a null list.");
            }
            isPopped = list[index];
            list.RemoveAt(index);

            return isPopped;
        }

        public void Clear()
        {
            list.Clear();
        }
    }
}
