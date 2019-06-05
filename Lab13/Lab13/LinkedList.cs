using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab13
{
    class   SLL<Tip>
    {
        public  class Node
        {
           public  Tip Data;
           public   Node Next;
        
        }

        Node first, last;
        private int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        public SLL()
        {
            first = new Node();
            last = new Node();
            count = 0;
          
        }
       public void Init(Tip item)
        {
            count = 1;
            first.Data = item;
            last = first;
            last.Next = null;
        }
        public void AddFirst(Tip item)
        {
            if(Count==0)
            {
                Init(item);
                return;
            }
            Node node = new Node();
            node.Data = item;
            node.Next = first;
            first = node;
            count++;

        }
        public void AddLast(Tip item)
        {
            if(Count==0)
            {
                AddFirst(item);
                return;
            }
            Node node = new Node();
            node.Data = item;
            last.Next = node;
            last = node;
            count++;
        }
       public Tip RemoveFirst()
        {
            if(Count==0)
            {
                throw new NullListException();
            }
            count--;
            Tip toReturn = first.Data;
            first = first.Next;
            return toReturn;

        }
        public Tip RemoveLast()
        {
            Node p = first;
            while(p.Next!=last)
            {
                p = p.Next;
            }
            Tip toReturn = last.Data;

            p.Next = null;
            count--;
            last = p;
            return toReturn;
        }
        public Tip Remove(int index)
        {
            if (index >= Count)
            {
                //Console.WriteLine(in);
                throw new IndexOutOfRangeException();
            }
            if (index == Count - 1)
                return RemoveLast();
            else
                 if (index == 0)
                return RemoveFirst();

            int i = 0;
            Node p = first;
            while(p!=null&&i+1<index)
            {
                p = p.Next;
                i++;

            }
            count--;
            Tip toReturn = p.Next.Data;
            p.Next = p.Next.Next;
            return toReturn;
           

        }
        public void View()
        {
            Node p = first;
            while(p!=null)
            {
                Console.Write(p.Data+"\t");
                p = p.Next;
            }
            Console.WriteLine();

        }
        public  Node  Find(Tip item)
        {
            Node p = first;
            while(p!=null)
            {
                if (p.Data.Equals(item))
                    return p;
                p = p.Next;

            }
            return null;
        }
       

    }
}
