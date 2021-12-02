using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_003
{
    class Sp
    {
        public LinkedList<int> LinkList = new LinkedList<int>();
        El_LinkedList lnkLst = new El_LinkedList();

        public Sp()
        {
            LinkList = new LinkedList<int>();
        }

        public override string ToString()
        {
            string res = "";
            LinkedListNode<int> P = LinkList.First;
            if (LinkList.Count != 0)
            {
                while(P!=null)
                {
                    res += "\t" + P.Value.ToString();
                    P = P.Next;
                }
            }
            return res;
        }
        public void ClearEl()
        {
            LinkList.Clear();
        }

        public int CountEl()
        {
            int k = LinkList.Count;
            return (k);
        }
        public void AddEl(LinkedListNode<int> stack)
        {

            LinkList.AddLast(stack);
        }
        public void InsertEl(LinkedListNode<int> index, LinkedListNode<int> stack)
        {
            LinkList.AddAfter(index, stack);
        }
        public void RemoveEl(LinkedListNode<int> stack)
        {
            LinkList.Remove(stack);
        }
        public void RemoveAtEl(int index)
        {
            LinkList.Remove(index);
        }
        static public bool QueueIsEmpty(El_LinkedList stack)
        {
            if (stack.CountEl() == 0) return true;
            else return false;
        }

        public bool LinkedListIsEmpty()
        {
            if (LinkList.Count == 0) return true;
            else return false;
        }
        public object ArrListEl()
        {
            LinkedList<int> LinkList = new LinkedList<int>();
            return (LinkList);
        }

    }
}
