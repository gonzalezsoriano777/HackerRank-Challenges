using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp_Algorithms.HackerRank
{
    public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    class LinkedList
    {

        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                return new Node(data);
            }

            if (head.next == null)
            {
                head.next = new Node(data);
            }
            else
            {
                insert(head.next, data);
            }

            return head;
        }
    }
    
}
