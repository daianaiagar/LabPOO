using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Angajat
{
    class Angajat:IAngajat
    {
        private string nume, prenume;
        public string Nume { get { return nume; } }
        public string Prenume { get { return Prenume; } }
        public DateTime DataAngajarii { get; }
        public static  AngajatNameComparer CompareName
        {
            get
            {
                return new AngajatNameComparer();
            }
        }
        public static AngajatVechimeComparer CompareVechime
        {
            get
            {
                return new AngajatVechimeComparer();
            }
        }
        public Angajat( string nume,string prenume,DateTime DataAngajarii)
        {
            this.nume = nume;
            this.prenume = prenume;
            this.DataAngajarii = DataAngajarii;
        }
        public Angajat(string text)
        {
            string[] tokens = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if(tokens.Length<3)
            {
                throw new InvalidStringException();
            }
            nume = tokens[0];
            prenume = tokens[1];
            string[] datetokens = tokens[2].Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            if(datetokens.Length<3)
            {
                throw new InvalidStringException();
            }
            int day, month, year;
            try
            {

                day = int.Parse(datetokens[0]);
                month = int.Parse(datetokens[1]);
                year = int.Parse(datetokens[2]);


            }catch(Exception e)
            {
                throw e;
            }
            DataAngajarii = new DateTime(year, month, day);
              
        }
        public Vechime  Vechime()
        {
            DateTime left = DateTime.Now, right = DataAngajarii;
            Vechime toReturn;
            toReturn.Luni = Math.Abs((left.Month - right.Month) + 12 * (left.Year - right.Year))%12;
            toReturn.Ani = Math.Abs((left.Month - right.Month) + 12 * (left.Year - right.Year)) / 12;
            return toReturn;

            




        }
        public override string ToString()
        {
            return $"{nume} {prenume} {DataAngajarii}";


        }

    }
}
