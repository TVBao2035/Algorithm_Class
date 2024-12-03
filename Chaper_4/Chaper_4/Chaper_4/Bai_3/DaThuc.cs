using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaper_4.Bai_3
{
    internal class DaThuc
    {
        public int So_Luong_Don_Thuc { get; set; }
        public LinkedList<DonThuc> list_don_thuc { get; set; }

        public DaThuc(int n)
        {
            list_don_thuc = new LinkedList<DonThuc>();
            So_Luong_Don_Thuc = n;
        }

        public DaThuc()
        {
            Console.Write("Nhap So Luong Don Thuc: ");
            list_don_thuc = new LinkedList<DonThuc>();
            So_Luong_Don_Thuc = int.Parse(Console.ReadLine());
            for(int i=0; i<So_Luong_Don_Thuc; i++)
            {
                DonThuc dt = new DonThuc();
                list_don_thuc.AddLast(dt);
            }
        }

        public DaThuc ToiUuDaThuc()
        {
            DaThuc dt = new DaThuc(100);
            LinkedListNode<DonThuc> currNode = this.list_don_thuc.First;
            LinkedListNode<DonThuc> currNodeCheck;
            while (currNode != null)
            {
                DonThuc d = currNode.Value;
                currNodeCheck = currNode.Next;
                while (currNodeCheck != null)
                {
                    if (d.So_Mu == currNodeCheck.Value.So_Mu)
                    {
                        d.Co_So += currNodeCheck.Value.Co_So;
                    }
                    currNodeCheck = currNodeCheck.Next;
                }
                if(dt.list_don_thuc.FirstOrDefault(e => e.So_Mu == d.So_Mu) == null)
                dt.list_don_thuc.AddLast(d);
                currNode = currNode.Next;
            }

            return dt;
        }

        public void print()
        {
            LinkedListNode<DonThuc> currNode = list_don_thuc.First;
            while(currNode != null )
            {
                currNode.Value.print();
                if(currNode.Next != null) {
                    Console.Write(" + ");
                }
                else
                {
                    Console.WriteLine(" = 0");
                }
                currNode = currNode.Next;
            }
        }

        public DaThuc Cong_Hai_Da_Thuc(DaThuc dt)
        {
            DaThuc res = new DaThuc(1000);
         
            LinkedListNode<DonThuc> currNodeA = this.list_don_thuc.First;
            LinkedListNode<DonThuc> currNodeB = dt.list_don_thuc.First;
            if (this.list_don_thuc.Count < dt.list_don_thuc.Count)
            {
                currNodeB = this.list_don_thuc.First;
                currNodeA = dt.list_don_thuc.First;
            }

            LinkedListNode<DonThuc> currNodeTemp;
            while(currNodeA != null)
            {
                currNodeTemp = currNodeB;
                DonThuc tempt = null;
                while (currNodeTemp != null)
                {
                    tempt = currNodeA.Value;
                    if(tempt.So_Mu == currNodeTemp.Value.So_Mu)
                    {
                        tempt.Co_So += currNodeTemp.Value.Co_So;
                    }
                    currNodeTemp = currNodeTemp.Next;
                }
                
                res.list_don_thuc.AddLast(tempt);
                currNodeA = currNodeA.Next;
            }
            return res;
        }

        public DaThuc Tru_Hai_Da_Thuc(DaThuc dt)
        {
            DaThuc res = new DaThuc(1000);

            LinkedListNode<DonThuc> currNodeA;
            LinkedListNode<DonThuc> currNodeB;
            if (this.list_don_thuc.Count < dt.list_don_thuc.Count)
            {
                currNodeB = this.list_don_thuc.First;
                currNodeA = dt.list_don_thuc.First;
            }
            else
            {
                currNodeA = this.list_don_thuc.First;
                currNodeB = dt.list_don_thuc.First;
            }

            LinkedListNode<DonThuc> currNodeTemp;
            while (currNodeA != null)
            {
                currNodeTemp = currNodeB;
                DonThuc tempt = null;
                while (currNodeTemp != null)
                {
                    tempt = currNodeA.Value;
                    if (tempt.So_Mu == currNodeTemp.Value.So_Mu)
                    {
                        tempt.Co_So = tempt.Co_So -  currNodeTemp.Value.Co_So;
                    }
                    currNodeTemp = currNodeTemp.Next;
                }

                res.list_don_thuc.AddLast(tempt);
                currNodeA = currNodeA.Next;
            }
            return res;
        }

        public DaThuc Nhan_Hai_Da_Thuc(DaThuc dt)
        {
            DaThuc res = new DaThuc(1000);
            LinkedListNode<DonThuc> currNodeA = this.list_don_thuc.First;
            LinkedListNode<DonThuc> currNodeB = dt.list_don_thuc.First;
            if(this.list_don_thuc.Count < dt.list_don_thuc.Count)
            {
                currNodeB = this.list_don_thuc.First;
                currNodeA = dt.list_don_thuc.First;
            }

            while(currNodeA != null)
            {
                LinkedListNode<DonThuc> curr = currNodeB;
              
                while(curr != null)
                {
                    res.list_don_thuc.AddLast(new DonThuc((currNodeA.Value.Co_So * curr.Value.Co_So), (curr.Value.So_Mu + currNodeA.Value.So_Mu)));
                    curr = curr.Next;
                }
                currNodeA = currNodeA.Next;
            }

            return res.ToiUuDaThuc();
        }
    }
}
