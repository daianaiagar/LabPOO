using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Lab7
{
    class MyArray
    {
        private int[] arr;
        private int size; //numarul de elemente din vector.
        public static  SumComparer CompareBySum
        {
            get
            {
                return new SumComparer();
            }
        }
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
             else
            {
                Array.Resize(ref arr, arr.Length * 2);
                arr[size] = value;
                size++;

            }


            
                
            
        }

        public bool Find(int v, out int index)
        {
          for(int i=0;i<size;i++)
                 if(arr[i]==v)
                {
                    index = i;
                    return true;
                }
            index = -1;
            return false;
        }
        public int Sum()
        {
            int s = 0;
            for (int i = 0; i < size; i++)
                s += arr[i];
            return s;
        }
        public bool IsEmpty
        {
            get
            {
                return size == 0;
            }
        }
        public MyArray FindAll(int val)
        {
            MyArray toReturn = new MyArray(1);
            for (int i = 0; i < size; i++)
                if (arr[i] == val)
                    toReturn.Add(i);
            if (toReturn.IsEmpty)
                return new MyArray(0);
            else
                return toReturn;

        }
       
       public void BubbleSort()
        {
            bool sorted;
            do
            {
                sorted = true;
                for(int i=0;i<size-1;i++) 
                  if(arr[i]>arr[i+1])
                    {
                        int aux = arr[i];
                        arr[i ] = arr[i+1];
                        arr[i + 1] = aux;
                        sorted = false;
                       
                    }

            } while (!sorted);
        }
        public  void BubbleSort(IComparer comp)
        {
            bool sorted;
            do
            {
                sorted = true;
                for (int i = 0; i < size - 1; i++)
                    if (comp.Compare(arr[i],arr[i+1])>0)
                    {
                        int aux = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = aux;
                        sorted = false;

                    }

            } while (!sorted);
        }
        public void SelectionSort()
        {
            for(int i=0;i<size-1;i++)
            {
                int maxindex = i;
                for (int j = i + 1; j < size; j++)
                    if (arr[j] > arr[maxindex])
                        maxindex = i;
                int aux = arr[maxindex];
                arr[maxindex] = arr[i];
                arr[i] = aux; 
            }
        }
        public void InsertionSort()
        {
            for(int i=1;i<size;i++)
            {
                int key = arr[i];
                int j = i-1;
            
                while(j>=0&&arr[j]>key)
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }
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
            if (IsEmpty)
                return "[]";
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            for (int i = 0; i < size-1; i++)
                sb.Append(arr[i]+",");
            sb.Append(arr[size - 1] + "]");
            return sb.ToString();

        }
        public void Remove(int val)
        {
            /*
            int poz = 0;
            for(int i=0;i<size-poz;i++)
                if(val ==arr[i])
            {
                    int aux = arr[size-poz-1];
                    arr[size-poz-1] = arr[i];
                    arr[i] = aux;
                    poz++;
                    
            }
            size -= poz;
            */
            for(int i=0;i<size;i++)
             if(arr[i]==val)
                {
                    int aux = arr[size - 1];
                    arr[size  - 1] = arr[i];
                    arr[i] = aux;
                    size--;
                    i--;
                }
        }

    }
}
