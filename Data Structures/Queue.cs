using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    
    // first in first out
    class Queue
    {
        private Node head;
        private Node tail;
        public Queue()
        {

        }

        public bool IsEmpty()
        {
            return (head == null) && (tail == null);
        }

        public object Peek()
        {

        }
        public void Add(object data)
        {
            if (head == null)
            {
                head = new Node(data);
                tail = head;
            }



        }
        public object Remove()
        {

        }

    }
}
