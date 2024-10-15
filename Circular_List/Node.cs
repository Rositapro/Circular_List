using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Circular_List
{
    internal class Node
    {
       
        public int Value { get; set; }
        public Node Next { get; set; }
        public Node()
        {
            Value = 0;
            Next = null;
        }
        public Node(int value)
        {
            Value = value;
            Next = null;
        }
    }
}
