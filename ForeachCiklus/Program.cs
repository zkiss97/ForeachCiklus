using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeachCiklus
{
    class Listak
    {
        private int l;
        private int[] numbers = new int[10];
        Random rnd = new Random();

        public Listak(int l)
        {
            this.l = l;
        }

        public Listak()
        {
            this.l = 0;
        }

        public void Feltolt()
        {
            Console.WriteLine("Add meg milyen hosszú legyen a lista:");
            l = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                numbers[i] = rnd.Next(10, 99);
            }

            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

    }

    class Elagazas
    {
        private int l;
        private int[] numbers = new int[10];
        private int[] evenNumbers = new int[10];
        Random rnd = new Random();

        public Elagazas(int l)
        {
            this.l = l;
        }

        public Elagazas()
        {
            this.l = 0;
        }

        public void Feltolt()
        {
            Console.WriteLine("Add meg milyen hosszú legyen a lista:");
            l = int.Parse(Console.ReadLine());
            int parosdb = 0;

            for (int i = 0; i < l; i++)
            {
                numbers[i] = rnd.Next(10, 99);
            }

            Console.WriteLine("A lista összes eleme:\n");
            for (int i = 0; i < l; i++)
            {
                Console.WriteLine(numbers[i]);
                if (numbers[i] % 2 == 0)
                {
                    parosdb++;
                }
            }

            Console.WriteLine("\nEbből a páros számok:\n");
            for (int i = 0; i < parosdb; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    evenNumbers[i] = numbers[i];
                }
            }

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }


        }

    }

    class ForAndEach
    {
        private int a;
        private int[] fortomb = new int[10];
        private int[] foreachtomb = new int[10];
        Random rnd = new Random();

        public ForAndEach(int a)
        {
            this.a = a;
        }

        public ForAndEach()
        {
            this.a = 0;
        }

        public void Forciklus()
        {
            Console.WriteLine("Alább látható a sima for ciklus eredménye: ");
            for (int i = 0; i < 10; i++)
            {
                fortomb[i] = rnd.Next(0, 100);
                Console.WriteLine(fortomb[i]);
            }
        }

        public void ForeachCiklus()
        {
            Console.WriteLine("\nAlább látható a foreach ciklus eredménye: ");
            for (int i = 0; i < 10; i++)
            {
                foreachtomb[i] = rnd.Next(0, 100);
            }

            foreach (int i in foreachtomb)
            {
                Console.WriteLine($"{i}");
            }
        }
    }

    class Fibonacci
    {
        private int eddig;
        private int number;

        public Fibonacci(int eddig)
        {
            this.eddig = eddig;
            this.number = number;
        }

        public Fibonacci()
        {
            this.eddig = 0;
            this.number = 2;
        }

        public void Fibnumbers()
        {
            Console.WriteLine("Add meg hanyadik elemig írjam ki a Fibonacci számokat:");
            eddig = int.Parse(Console.ReadLine());

            int a = 0, b = 1, c = 0;
            Console.WriteLine("{0}, {1}", a, b);
            for (int i = 2; i <= eddig; i++)
            {
                c = a + b;
                Console.WriteLine("{0}", c);
                a = b;
                b = c;
            }

        }

    }

internal class Program
    {
        static void Main(string[] args)
        {
            //Listak l1 = new Listak();
            //l1.Feltolt();

            //Elagazas e1 = new Elagazas();
            //e1.Feltolt();

            //ForAndEach fae1 = new ForAndEach();
            //fae1.Forciklus();
            //fae1.ForeachCiklus();

            Fibonacci fib1 = new Fibonacci();
            fib1.Fibnumbers();

            Console.ReadLine();
        }
    }
}