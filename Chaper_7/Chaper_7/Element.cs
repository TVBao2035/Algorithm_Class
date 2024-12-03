using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_7
{
    internal class Element
    {
        public int Key { get; set; }
        public int Value { get; set; }

        public Element(int key, int value)
        {
            Key = key;
            Value = value;
        }
    }
}
