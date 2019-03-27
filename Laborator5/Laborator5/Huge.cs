using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator5
{
    class Huge
    {
        private byte[] data;

        private readonly int digits;
        public byte[] Data
        {
            get
            {


                return data;
            }
        }
        public int Digits
        {
            get
            {
                return digits;
            }
        }
        public Huge(int v)
        {
            int digits = CountDigits(v);
            data = new byte[digits];
            this.digits = digits;
            for (int i = 0; v > 0; i++)
            {
                data[i] = (byte)(v % 10);
                v = v / 10;
            }

        }
        public Huge()
        {

        }
        public Huge(string v)
        {

            digits = v.Length;
            data = new byte[v.Length];
            /*
            for (int i = 0; i < v.Length; i++)
                data[i] = (byte)(v[digits - i - 1] - '0');
                */
            for (int i = digits - 1; i >= 0; i--)
            {
                data[digits - 1 - i] = (byte)(v[i] - '0');
            }

        }
        private int CountDigits(int v)
        {
            int digits = 0;
            while (v > 0)
            {
                digits++;
                v = v / 10;
            }
            return digits;
        }
        public override string ToString()
        {
            // return string.Join("", data);
            StringBuilder sb = new StringBuilder();
            for (int i = data.Length - 1; i >= 0; i--)
                sb.Append(data[i]);
            return sb.ToString();

        }
        public static Huge operator +(Huge left, int right)
        {
            Huge rightH = new Huge(right);
            return left + rightH;

        }
        public static Huge operator +(Huge left, Huge right)
        {
            Huge result = null;
            byte[] sum = new byte[Math.Max(left.Digits, right.Digits)];
            int carry = 0, i, j, contor = 0;
            for (i = 0; i < Math.Min(left.Digits, right.Digits); i++)
            {
                sum[i] = (byte)((left.Data[i] + right.Data[i] + carry) % 10);
                carry = (left.Data[i] + right.Data[i] + carry) / 10;
                contor++;
            }
            for (j = i; j < left.Digits; j++)
            {
                contor++;
                sum[j] = (byte)((left.Data[j] + carry) % 10);
                carry = (left.Data[j] + carry) / 10;
            }
            for (j = i; j < right.Digits; j++)
            {
                contor++;
                sum[j] = (byte)((right.Data[j] + carry) % 10);
                carry = (right.Data[j] + carry) / 10;
            }
            if (carry > 0)
            {
                Array.Resize(ref sum, sum.Length + 1);

                sum[sum.Length - 1] = (byte)carry;
                contor++;

            }
            result = new Huge(string.Join("", sum));
            result.data = sum;

            return result;
        }

        public static Huge operator *(Huge left, Huge right)
        {
            Huge sum = new Huge();
            uint p = 0;
            for (int i = 0; i < left.Digits; i++)
            {
                sum = sum + (right * left.Data[i]).MultiplyBy10(p);
                p++;
            }
            return sum;
        }
        public Huge MultiplyBy10(uint power)
        {
            string s = this.ToString();
            for (int i = 0; i < power; i++)
                s = s + "0";
            return new Huge(s);
        }
        public static Huge operator *(Huge left, byte right)
        {
            byte carry = 0;
            byte[] product = new byte[left.Digits];
            for (int i = 0; i < left.Digits; i++)
            {
                product[i] = (byte)((left.Data[i] * right + carry) % 10);
                carry = (byte)((left.Data[i] * right + carry) / 10);
            }
            if (carry > 0)
            {
                Array.Resize(ref product, product.Length + 1);
                product[product.Length - 1] = carry;
            }
            Huge rez = new Huge(string.Join("", product.Reverse()));
            return rez;



        }
        public Huge Power(uint power)
        {
            if (power == 0)
                return new Huge("1");
            if (power % 2 == 0)
                return this.Power(power / 2) * this.Power(power / 2);
            else
                return this * Power(power - 1);
        }
        private static  byte Modul(byte s)
        {
            if (s < 0) return (byte)(-(int)s);
            return s;
        }
        public static Huge operator  -(Huge left, Huge right)
        {
            Huge result = null;
            byte[] sum = new byte[Math.Max(left.Digits, right.Digits)];
            int carry = 0, i, j, contor = 0;
            for (i = 0; i < Math.Min(left.Digits, right.Digits); i++)
            {
                byte  dif =(byte)( left.Data[i] -(byte)( carry) - right.Data[i]);
                sum[i] =Modul( dif);
                if (dif < 0)
                    carry = 1;
                else
                     carry = 0;
                contor++;
            }
            for (j = i; j < left.Digits; j++)
            {
                byte dif = (byte)(left.Data[i] - (byte)(carry));
                sum[i] = Modul(dif);
                if (dif < 0)
                    carry = 1;
                else
                    carry = 0;
                contor++;
            }
            /*
            for (j = i; j < right.Digits; j++)
            {
                contor++;
                byte dif = (byte)(left.Data[i] - (byte)(carry) - right.Data[i]);
                sum[j] = (byte)((right.Data[j] + carry) % 10);
                carry = (right.Data[j] + carry) / 10;
            }
            */
            if (carry > 0)
            {
                Array.Resize(ref sum, sum.Length + 1);

                sum[sum.Length - 1] = (byte)carry;
                contor++;

            }
            result = new Huge(string.Join("", sum));
            result.data = sum;

            return result;
        }
      
    }
}
