using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator2
{
    class Complex
    {
        private float re, im;
        private int signre, signim;
        public float Re
        {
            get { return re;

            }
        }
        public float Im
        {
            get { return im; }
        }
        private int sign(float val)
        {
            if (val > 0)
                return 1;
            else 
               if (val == 0)
                  return 0;
               else
                  return -1;
        }
        public   Complex(float  re, float im)
        {
            signre = sign(re);
            this.re = Math.Abs(re);
            im = sign(im);
            this.im = Math.Abs(im);
        }
        public Complex(float re)
        {
            this.re = re;
            im = 0;
        }
        public Complex()
        {
           re = 0;
            im = 0;

        }
        public Complex(string c)
        {
           /*
            int sign, val;
            int i = 0;
            if (c[0] == '-')
            {
                i++;
                sign = -1;
            }
            else
                sign = 1;
            val = 0;
            while (i < c.Length && char.IsDigit(c[i]))
            {
                val = val*10 + (c[i] - '0');
                i++;
            }
            if(i>=c.Length)
            {
                if(c[i]!='i')
                {
                    re = val;
                    signre = sign;
                }else
                {
                    im = val;
                    signim = sign;
                }
                return;
            }else
            {
                re = val;
                signre = sign;
                if (c[i] == '+')
                    sign = 1;
                
                else
                     if (c[i] == '-')
                            sign = -1;
                      else
                {
                    Console.WriteLine("Eroare");
                    return;
                }
                val = 0;
                while (i < c.Length-1 && char.IsDigit(c[i]))
                {
                    val = val * 10 + (c[i] - '0');
                    i++;
                }
                if(c[c.Length-1]!='i')
                {
                    Console.WriteLine("Eroare");
                    return;
                }
                im = val;
                signim = sign;


            }
           */
            
            float[] values = new float[2];
            int[] signs = new int[2];
            int i = 0;
            if (c[0] == '-')
            {
                signs[0] = -1;
                i++;
            } else
                signs[0] = 1;
            int vindex =-1, digits = 0;
            bool stop = false;
            while(i<c.Length&&!stop)
                if (!char.IsDigit(c[i]))
                {
                    vindex++;
                    values[vindex] = float.Parse(c.Substring(i - digits, digits));
                    if(vindex<1)
                    vindex++;
                 
                    switch (c[i])
                    {
                        case '+': signs[vindex] = 1; break;
                        case '-': signs[vindex] = -1; break;
                        case 'i': stop = true;  break;
                        default: { Console.WriteLine("Eroare!");
                                   return;
                                 } break;
                        

                    }
                    digits = 0;
                    i++;
                }
                else
                {
                    digits++;
                    i++;
                }
            re = values[0];
            signre = signs[0];
            im = values[1];
            im = signs[1];


        }
        public override string ToString()
        {
            return $"({Re},{Im})";
        }
        public  static Complex operator +(Complex a, Complex b)
        {
            return new Complex(a.Re*a.signre + b.Re*b.signre, a.Im + b.Im);
        }
        public static Complex operator -(Complex b)
        {
            return new Complex(-b.Re, -b.Im);
        }
        public static Complex  operator -(Complex a, Complex b)
        {
            return a + (-b);
        }
       

    }
}
