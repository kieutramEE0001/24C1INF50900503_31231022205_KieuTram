using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_02
    {
        //static void Main(string[] args)
        //{
        //Question_01();
        //Question_02();
        //Question_03();
        //Question_04();
        //Question_05();
        //Question_06();
        //Question_07();
        //Question_08();
        //Question_09();
        //Question_10();
        //Console.ReadKey();
        //}
        public static void Question_01()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }
        public static void Question_02()
        {
            Console.Write("Nhap so a: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            int b = int.Parse(Console.ReadLine());
            int hoanvi = a;
            a = b;
            b = hoanvi;
            Console.WriteLine("Sau khi hoan vi");
            Console.WriteLine($"Gia tri cua a la {a}, gia tri cua b la {b}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so a: ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("Nhap so b: ");
            float b = float.Parse(Console.ReadLine());
            float c = a * b;
            Console.WriteLine($"{a} x {b} = {c}");
        }
        public static void Question_04()
        {
            Console.Write("Nhap gia tri feet can doi: ");
            float feet = float.Parse(Console.ReadLine());
            double ketqua = feet * 0.3048;
            Console.WriteLine($"{feet} feets = {ketqua} meters");
        }
        public static void Question_05()
        {
            Console.Write("Nhap gia tri do C: ");
            float C = float.Parse(Console.ReadLine());
            float F = (C * 9) / 5 + 32;
            Console.WriteLine($"{C} do C = {F} do F");
        }
        public static void Question_06()
        {
            Console.WriteLine("1 int = " + sizeof(int) + " bytes");
            Console.WriteLine("1 float = " + sizeof(float) + " bytes");
            Console.WriteLine("1 char = " + sizeof(char) + " bytes");
            Console.WriteLine("1 double = " + sizeof(double) + " bytes");
        }
        public static void Question_07()
        {
            Console.Write("Nhap mot ky tu: ");
            char input = Console.ReadKey().KeyChar;
            Console.WriteLine();
            int ascii = (int)input;
            Console.WriteLine($"Gia tri cua {input} trong ASCII la {ascii}");
        }
        public static void Question_08()
        {
            Console.Write("Nhap ban kinh hinh tron: ");
            float r = float.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(r, 2);
        }
    }
}
