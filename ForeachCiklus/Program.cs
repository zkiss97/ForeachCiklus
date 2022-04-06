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


internal class Program
    {
        static void Main(string[] args)
        {
            //Listak l1 = new Listak();
            //l1.Feltolt();

            Elagazas e1 = new Elagazas();
            e1.Feltolt();

            Console.ReadLine();
        }
    }
}
