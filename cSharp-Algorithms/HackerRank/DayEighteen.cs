using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    class QueuesAndStacks
    {

        public Stack<char> stack = new Stack<char>();
        public Queue<char> queue = new Queue<char>();

        public void pushCharacter(char ch)
        {
            stack.Push(ch);
        }

        public void enqueueCharacter(char ch)
        {
            queue.Enqueue(ch);
        }

        public char popCharacter()
        {
            char pop = stack.Pop();
            return pop;
        }

        public char dequeueCharacter()
        {
            char deque = queue.Dequeue();
            return deque;
        }

    }
}
