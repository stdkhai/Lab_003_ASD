using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Lab_003
{
    class El_LinkedList
    {
       public  Stack stack = new Stack();

        public El_LinkedList()
        {
            stack = new Stack();
        }
        public void ClearEl()
        {
            stack.Clear();
        }
        public int CountEl()
        {
            int k = stack.Count;
            return k;
        }

        public void Dequeue()
        {
            if (stack.Count != 0)
                stack.Pop();
        }

        public void EnQueue(El_Stack El)
        {
            stack.Push(El);
        }
        public IEnumerator GetEnumerator()
        {
            return this.stack.GetEnumerator();
        }
        public bool QueueIsEmpty()
        {
            if (stack.Count == 0) return true;
            else return false;
        }
        public override string ToString()
        {
            string s = "";

            foreach (El_Stack el in stack)
                s += el._inf + "\t";
            return s;
        }


    }

}
