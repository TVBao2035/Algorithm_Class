using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Stack
{
    internal class StackApp
    {
        private int headElementIndex;
        private ArrayList list;

        public StackApp()
        {
            headElementIndex = -1;
            list = new ArrayList();
        }
        public Boolean Empty()
        {
            return headElementIndex == -1;
        }
        public object Top()
        {
            return list[headElementIndex];
        }

        public void Push(object value)
        {
            headElementIndex++;
            list.Add(value);
        }

        public object Pop()
        {
            object topElementValue = list[headElementIndex];
            list.RemoveAt(headElementIndex);
            headElementIndex--;
            return topElementValue;
        }

        public int Size()
        {
            return list.Count;
        }

        public void Clear()
        {
            list.Clear();
            headElementIndex = -1;
        }

    }
}
