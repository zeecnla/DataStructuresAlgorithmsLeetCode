using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    //Last in first out
    // like a stack of plates
    // node implementation
    class Stack
    {
        private Node top;
        public Stack()
        {

        }

        public bool isEmpty()
        {
            if (top == null)
            {
                return true;
            }
            return false;
        }

        public object Peek()
        {
            if (top==null)
            {
                return null;
            }
            return top.value;
        }

        public void Push(object data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;
        }

        public object Pop()
        {
            if(top ==null)
            {
                Console.WriteLine("Cant pop, stack is empty");
                return null;
            }
            object data = top.value;
            top = top.next;
            return data;
        }
    }
}
