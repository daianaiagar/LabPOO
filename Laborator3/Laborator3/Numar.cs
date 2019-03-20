using System;
using System.Numerics;
namespace Laborator3
{
    //Modeleaza un nuar natural 
    public  class Numar
    {
       
        private readonly ulong  v;
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
        /// <summary>
        /// Determina  numarul de divizori.(ineficient).
        /// </summary>
       
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
                for (ulong  d=2; d*d<=v; d++)
                {
                    if (v % d == 0)
                    {
                        // Console.WriteLine(d);
                        nd += 2; //v % (v / d) == 0;
                    }
                }
                return nd;

              

            }
        }
        /// <summary>
        /// Det. numarul de divizori(eficient)
        /// </summary>
        public ulong NumarDivizoriV2
        {
            get
            {
                ulong nd = 1;
                ulong aux = Value;
                ulong  p = 2;

                while(aux>1)
                {
                    ulong q = 0;
                   while(aux%p==0)
                    {
                        q++;
                        aux = aux / p;
                    }
                    nd *= (q + 1);
                    p++;
                    Numar n2 = new Numar(aux);
                    if(n2.EstePrim())
                    {
                        nd *= 2;
                        aux = 1;
                    }
                    
                }
                return nd;

            }

        }
        public ulong SumDivizori
        {
            get
            {
                ulong sd = 1;
                ulong aux = Value;
                ulong p = 2;

                while (aux > 1)
                {
                    ulong q = 1;
                    while (aux % p == 0)
                    {
                        q = q * p + 1;
                        aux = aux / p;
                    }
                    sd *= (q + 1);
                    p++;
                    Numar n2 = new Numar(aux);
                    if (n2.EstePrim())
                    {
                        sd *= (1 + aux);
                        aux = 1;
                    }

                }

                return sd;
            }
        }
        /// <summary>
        /// returneaza numarul in baza  "baza" ca string.
        /// </summary>
        /// <param name="baza">o baza(numar fara semn)</param>
        /// <returns></returns>
        public String  ConvertToBase(ulong baza)
        {
            string s = "";
            ulong aux = v;
            while(aux!=0)
            {
                s = aux % baza + s;
                aux /= baza;
            }
            return s;
        }
        /// <summary>
        /// Returneaza numarul in baza 16 ca string.
        /// </summary>
        public string Hex
        {
            get
            {
                string s = "0123456789ABCDEF";
                string nou = "";
                ulong aux = v;

                while (aux != 0)
                {
                    nou = s[(int)(aux%16)].ToString()+ nou;
                    aux /= 16;
                }
                return nou;

            }
        }
        /// <summary>
        /// Aduna  doua numere de tip Numar.
        /// </summary>
        /// <param name="b">al doilea termen din suma </param>
        /// <returns>un obiect detip Numar </returns>
        public Numar Add(Numar b)
        {
            Numar sum = new Numar(v + b.Value);
            return sum;
        }
        /// <summary>
        /// Scade   doua numere de tip Numar.
        /// </summary>
        /// <param name="b">descazutul </param>
        /// <returns>un obiect de tip Numar </returns>
        public Numar Subtract(Numar b)
        {
            return new Numar((ulong)Math.Abs((float)(Value - b.Value)));

        }
        /// <summary>
        /// Inmulteste  doua  numere de tip Numar.
        /// </summary>
        /// <param name="b"> al doilea factor </param>
        /// <returns>un obiect de tip Numar </returns>
        public Numar Multiply(Numar b)
        {
            return new Numar(Value * b.Value);
        }
        /// <summary>
        /// Returneaza  restul a doua numere de tip Numar 
        /// </summary>
        /// <param name="b"> deimpartitul </param>
        /// <returns>un obiect de tip Numar </returns>
        public Numar Mod(Numar b)
        {
            return new Numar(Value % b.Value);
        }
        /// <summary>
        /// Returneaza   catul intreg  a doua numere de tip Numar 
        /// </summary>
        /// <param name="b"> deimpartitul </param>
        /// <returns>un obiect de tip Numar </returns>
        public Numar Div(Numar b)
        {
            return new Numar(Value / b.Value);
        }
       
    }
}