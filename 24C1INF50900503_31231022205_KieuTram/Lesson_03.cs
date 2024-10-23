using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_03
    {
        //public static void Main()
        //{
        //    //Question_01();
        //    //Question_02();
        //    //Question_03();
        //    Question_04();
        //    //Question_05();
        //    Console.ReadKey();
        //}
        public static void Question_01()
        {
            Console.Write("Nhap so can doi, don vi do C: ");
            int C = int.Parse(Console.ReadLine());
            int K = C + 273;
            int F = C * 18 / 10 + 32;
            Console.WriteLine($"{C} do C = {K} do K");
            Console.WriteLine($"{C} do C = {F} do F");
        }
        public static void Question_02()
        {
            Console.Write("Nhap ban kinh hinh cau: ");
            float r = float.Parse(Console.ReadLine());
            double S = 4 * Math.PI * Math.Pow(r, 2);
            double V = (4 / 3) * Math.PI * Math.Pow(r, 3);
            Console.WriteLine($"Dien tich mat cau ban kinh {r} la {S}");
            Console.WriteLine($"The tich hinh cau ban kinh {r} la {V}");
        }
        public static void Question_03()
        {
            Console.Write("Nhap so thu nhat: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so thu hai: ");
            int b = int.Parse(Console.ReadLine());
            int tong = a + b;
            int hieu = a - b;
            int tich = a * b;
            int thuong = a / b;
            int sodu = a % b;
            Console.WriteLine($"{a} + {b} = {tong}");
            Console.WriteLine($"{a} - {b} = {hieu}");
            Console.WriteLine($"{a} x {b} = {tich}");
            Console.WriteLine($"{a} / {b} = {thuong}");
            Console.WriteLine($"{a} mod {b} = {sodu}");
        }
        public static void Question_04()
        {
            Console.WriteLine("Phuong trinh X = y^2 + 2y + 1");
            Console.Write("Nhap gia tri cua y: ");
            int y = int.Parse(Console.ReadLine());
            if (y <= 5 && y >= -5)
            {
                int x = (y * y) + (2 * y) + 1;
                Console.WriteLine($"y ={y} => X = {x}");
            }
            else
            {
                Console.WriteLine("Vui long nhap lai gia tri y");
            }
        }
        public static void Question_05()
        {
            Console.Write("Nhap quang duong (km): ");
            double s = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap thoi gian: ");
            Console.Write("gio: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("phut: ");
            int m = int.Parse(Console.ReadLine());
            Console.Write("giay: ");
            int second = int.Parse(Console.ReadLine());
            double total = h + m / 60.0 + second / 3600.0;
            double kmperhour = s / total;
            double mperhour = kmperhour * 0.621371;
            Console.WriteLine("Van toc can tinh:");
            Console.WriteLine($"{kmperhour} km/h");
        }
    }
}
