using System;
using System.Collections.Generic;
using System.Text;

namespace Data_Structures
{
    class Node
    {
        public object value;
        public Node next;

        public Node(object value)
        {
            this.value = value;
        }
        public Node(object value, Node next)
        {
            this.value = value;
            this.next = next;
        }
    }
}
