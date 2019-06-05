using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Lab13
{
    class Program
    {/**
      Creati un TAD  lista simplu inlantuita generica.
       ->Inserare la inceput(timp constant) 
       ->Inserare la sfarsit(timp constant)
       ->Stergerea de la inceputul listei
        ->Stergerea unui nod de la sfarsitul listei 
        ->Cautarea a unei valori(chei)  in lista,functia va intoarce o referinta 
            la nodul gasit, sau null, daca nu-l gaseste. 
        ->Stergere a unui nod arbitrar.
       

    **/
        static void Main(string[] args)
        {
            SLL<int> list = new SLL<int>();
            list.AddFirst(20);
            for (int i = 0; i < 5; i++)
                list.AddLast(i);
            
            list.View();
            
            Console.WriteLine(list.Count);
            list.RemoveFirst();
            list.View();
            Console.WriteLine(list.Count);
            list.RemoveLast();
            list.View();
            Console.WriteLine(list.Count);
            list.Remove(0);
            list.View();
            Console.WriteLine(list.Count);
          

        }
    }
}
