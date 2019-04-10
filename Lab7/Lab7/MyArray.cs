using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7
{
    class MyArray
    {
        private int[] arr;
        private int size; //numarul de elemente din vector.
        public MyArray(int capacity)
        {
            arr = new int[capacity];
            size = 0;

        }

        public  void Add(int value)
        {
            if (size < Capacity)
            {
                arr[size] = value;
                size++;
            }
               //exceptie.Dublam capacitatea.


            
                
            
        }
        public int this[int i]
        {
            get {
                return arr[i];
            }
            set {
                arr[i] = value;
            }
        }

        public int Capacity
        {
            get { return arr.Length; }
        }
        public override string ToString()
        {
            // return $"({string.Join(",",arr)})";
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
              foreach(var item in arr)
            {
                sb.Append(item);
                sb.Append(",");
            }
            sb.Remove(sb.Length - 2, 2);
            sb.Append("]");
            return sb.ToString();

        }

    }
}
