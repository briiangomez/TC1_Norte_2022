using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            numeros.Add(11);
            int sumaNumeros = 0;
            List<int> numerosPares = new List<int>();
            Console.WriteLine("sin linq");

            foreach (var item in numeros)
            {
                sumaNumeros += item;
                if (item % 2 == 0) numerosPares.Add(item);
            }

            Console.WriteLine(String.Format("La suma de los numeros es {0}", sumaNumeros.ToString()));
            sumaNumeros = 0;
            foreach (var item in numerosPares)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("CON linq");

            Console.WriteLine("ORDER BY");
            numeros.OrderBy(o => o).ToList().ForEach(item => Console.WriteLine(item));
            Console.WriteLine("ORDER BY DESC");
            numeros.OrderByDescending(o => o).ToList().ForEach(item => Console.WriteLine(item));

            Console.WriteLine(String.Format("El mayor es el {0}", numeros.Max()));
            Console.WriteLine(String.Format("El menor es el {0}", numeros.Min()));
            sumaNumeros = numeros.Sum();
            numerosPares = numeros.Where(o => o % 2 == 0).ToList();
            Console.WriteLine(String.Format("La suma de los numeros es {0}", sumaNumeros.ToString()));
            numerosPares.ForEach(item => Console.WriteLine(item));
            Console.ReadLine();



        }
    }
}
