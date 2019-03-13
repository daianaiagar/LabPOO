using System;
using System.Numerics;
namespace Laborator3
{
    //Modeleaza un nuar natural 
    public  class Numar
    {
       
        private ulong  v;
        public Numar(ulong v)
        {
            this.v = v;
        }
        public ulong Value
        {
            get {
                return v;
                }

        }
        /// <summary>
        /// Calculeaza  suma cifrelor
        /// </summary>
        /// <returns>returneaza suma cifrelor(int)</returns>
        public  ulong  SumaCifre()
        {
            ulong  suma = 0;
            ulong aux = v;
            while(aux>0)
            {
                suma += aux % 10;
                aux /= 10;
            }
            return suma; 
        }
        /// <summary>
        ///  test de primalitate determinist care determina
        ///  verifica  divizorii pana la radical din n.
        ///  
        /// </summary>
      ///<returns> adevarat(fals) daca  numarul (nu) este prim.</returns>
        public  bool EstePrim()
        {
            if (v < 2)
                return false;
            if (v == 2)
                return true;
            if (v % 2 == 0)
                return false;
           
            for (ulong  d = 3; d * d <= v; d+=2)
                if (v % d == 0)
                    return false;
            return true;

        }
        public int NumarDivizori
        {
            get
            {
                int  nd = 2;
                if (v == 0)
                {
                    Console.WriteLine("WTF");
                    return -1;
                }
                if (v == 1)
                    return 1;
                for (ulong  d=2; d<=v/2; d++)
                {
                    if (v % d == 0)
                    {
                       // Console.WriteLine(d);
                        nd++;
                    }
                }
                return nd;

              

            }
        }
    }
}