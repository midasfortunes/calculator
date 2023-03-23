using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int pilih;
            menu:
            Console.Title = "Aplikasi Calculator";

            Console.WriteLine("Pilih menu calculator\n\n1. Penambahan\n2. Pengurangan\n3. Perkalian\n4. Pembagian");

            Console.Write("\nInputkan Nomor menu : ");
            pilih = Convert.ToInt32(Console.ReadLine());
            if(pilih == 1)
            {
                Console.Write("Inputkan nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Penambahan " + a + " + " + b + " = " + Penambahan(a, b));
            }
            else if (pilih == 2)
            {
                Console.Write("Inputkan nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pengurangan {0} - {1} = {2}", a, b, Pengurangan(a, b));
            }
            else if (pilih == 3)
            {
                Console.Write("Inputkan nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Perkalian {0} * {1} = {2}", a, b, Perkalian(a, b));
            }
            else if (pilih == 4)
            {
                Console.Write("Inputkan nilai a : ");
                int a = int.Parse(Console.ReadLine());

                Console.Write("Inputkan nilai b : ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Hasil Pembagian {0} / {1} = {2}", a, b, Pembagian(a, b));
            }
            else
            {
                Console.Write("Pilihan anda tidak tersedia");
                Console.WriteLine("\nTekan sembarang key untuk keluar");
                Console.ReadKey();
                goto menu;
            }
            Console.WriteLine("\nTekan sembarang key untuk keluar");
            Console.ReadKey();
        }
        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
