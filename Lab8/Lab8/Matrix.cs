using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Matrix
    {
        int[,] data;
        int maxdigits;
        public Matrix(int linii, int coloane)
        {
            data = new int[linii, coloane];

        }
        public int Rows
        {
            get
            {
                return data.GetLength(0);
            }
        }
        public int  Columns
        {
            get
            {
                return data.GetLength(1);
            }
        }
        public Matrix(int linii)
            : this(linii, linii)
        { }
        public override string ToString()
        {

            StringBuilder sb = new StringBuilder();
            string formatString = "{0,";
            formatString += maxdigits;
            formatString += "}";
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {

                    sb.Append(data[i, j] + "\t");
                   // sb.Append(string.Format(formatString, data[i, j]));
                
                }

                sb.Append(Environment.NewLine);

            }
            return sb.ToString();

        }

        public  void RandomInt(int maxValue)
        {
            maxdigits = (int)Math.Log10(Math.Abs(maxValue)) - 1;
            if (maxValue < 0)
                maxdigits++;
            Random rnd = new Random();
           for(int i=0;i<data.GetLength(0);i++)
            {
                for(int j=0;j<data.GetLength(1);j++)
                {
                    data[i, j] = rnd.Next(maxValue+1);
                }
            }
        }
        public void RandomInt(int minValue, int maxValue)
        {
            maxdigits = (int)Math.Log10(Math.Abs(maxValue)) - 1;
            if (maxValue < 0)
                maxdigits++;
            Random rnd = new Random();
            for (int i = 0; i < data.GetLength(0); i++)
            {
                for (int j = 0; j < data.GetLength(1); j++)
                {
                    data[i, j] = rnd.Next(minValue+1,maxValue+1);
                }
            }
        }
        public   int this[int i, int j]
        {
            get
            {
                return data[i, j];
            }
            set
            {
                data[i, j] = value;
            }
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if(a.Columns!=b.Rows)
            {
                throw new ImpossibleMatrixOperationException();
            }
            Matrix p = new Matrix(a.Rows,b.Columns);
            for(int i=0;i<p.Rows;i++)
            {
                for(int j=0;j<p.Columns;j++)
                {
                    int suma = 0;
                    for (int k = 0; k < a.Columns; k++)
                        suma += a[i, k] * b[k,j];
                    p[i, j] = suma;
                }

            }
            return p;


        }
        public static bool operator == (Matrix a, Matrix b)
        {
            if(a.Rows!= b.Rows||a.Columns!=b.Columns)
             return false;
            for (int i = 0; i < a.Rows; i++)
                for (int j = 0; j < a.Columns; j++)
                    if (a[i, j] != b[i, j])
                        return false;
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b) => !(a == b);
      
        
        //Square matrix 

    }
}
