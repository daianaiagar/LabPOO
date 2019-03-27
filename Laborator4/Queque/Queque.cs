using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queque
{
    class Queque
    {
        private int[] v;
        private int head;
        private int end;
        public Queque()
        {
            v = new int[16];

            head = 0;
            end = -1;
        }
        public Queque(int capacity)
        {
            v = new int[capacity];
            head = end = 0;
        }
        private void Resize()
        {

        }
        public int Count
        {
            get {
                if (end < head)
                    return 0;
                if (end == head)
                    return  1;
                return end - head + 1;
            }
        }
        public int Capacity
        {
            get { return v.Length; }
        }
        public bool IsFull()
        {
            return Capacity == Count;
        }
        public bool IsEmpty()
        {
            return Count == 0;
        }
        private void resize(int newSize)
        {
            int[] v2 = new int[newSize];
            int no = Math.Min(newSize, Count);
            for(int i=0;i<newSize;i++)
                v2 = 
        }
        public void Enqueque(int value)
        {
            if (IsFull())
                resize(Capacity * 2);
            else
            if (end == Capacity)
                shiftToStart();

                 
            
            
            v[++end] = value;
               
           




         }
        public int PeakHead()
        {
            return v[head];
        }
        public void Dequeque()
        {
            if (IsEmpty())
                throw new Exception();
            
            
            ++head;
            if(Count<Capacity/4)
            {
                resize(Capacity / 4);
            }
        }
    }
}
