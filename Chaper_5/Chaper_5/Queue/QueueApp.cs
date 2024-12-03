using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_5.Queue
{
    internal class QueueApp
    {
        public ArrayList list;
        public QueueApp()
        {
            list = new ArrayList();
        }

        public Boolean Empty()
        {
            return list.Count == 0;
        }
        public void Clear()
        {
            list.Clear();
        }
        public void Enqueue(Object value)
        {
            list.Add(value);
        }
        public Object Peek()
        {
            return list[0];
        }
        public Object Dequeue()
        {
            object res = list[0];
            list.RemoveAt(0);
            return res;
        }
    }
}
