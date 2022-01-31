using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class LinkedList
    {
        public Node head;

        public LinkedList()
        {
        }


        //delete the last node at a specified index
        public void Delete()
        {
            if(head == null)
            {
                return;
            }
            if (head.next == null)
            {
                head = null;
                return;
            }

            Node current = head;
            Node prev = current;
            while(current.next != null)
            {
                prev = current;
                current = current.next;
            }
            prev.next = null;
        }

        public void Add(object value)
        {
            if(head == null)
            {
                head = new Node(value);
                return;
            }
            Node current = head;

            while(current.next != null)
            {
                current = current.next; 
            }
            current.next = new Node(value);
        }
        
        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            Node current = head;

            while (current != null)
            {
                builder.Append(current.value);
                current = current.next;
            }

            return builder.ToString();
        }
    }
}
