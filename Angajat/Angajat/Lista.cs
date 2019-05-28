using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    class Lista<T>
    {
        T[] array;
        int n;
        public int Capacity
        {
            get
            {
                return array.Length;
            }
        }
        public int Count
        {
            get
            {
                return n;
            }
        }
        public Lista(T[] array)
        {
            this.array = array;
            n = array.Length;
        }
        public Lista(int capacity)
        {
            array = new T[capacity];
            n = 0;
        }
        public void Add(T value)
        {
            if (n < array.Length - 1)
                array[n++] = value;
            else
            {
                
                if(n==0)
                {
                    array = new T[1];
                    n = 1;
                    array[0] = value;
                   return;                    
                }
                
                T[] temp;
                  
               

                    temp = new T[2 * n];
                for (int i = 0; i < n; i++)
                    temp[i] = array[i];
                temp[n++] = value;
                array = temp;
            }
        }
        public void Remove()
        {
            n--;
            if(n<Capacity/3)
            {
                T[] temp;
                temp = new T[n];
                for (int i = 0; i < n; i++)
                    temp[i] = array[i];
                array = temp;
            }

        }
        public T this[int index]
        {
            get
            {
                if (index < Capacity)
                    return array[index];
                else
                    throw new IndexOutOfRangeException();
            }
          
        }
        public void Sort(IComparer<T> comparer)
        {
            Array.Sort(array, 0, n, comparer);
        }

        public static string Join(string sep, Lista<T> lista)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < lista.Count; i++)
                sb.Append(lista[i].ToString()).Append("\n");
            return sb.ToString();
        }




    }
}
