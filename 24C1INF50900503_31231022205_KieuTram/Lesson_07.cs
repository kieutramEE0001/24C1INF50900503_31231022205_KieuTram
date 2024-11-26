using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_07
    {
        //public static void Main(string[] args)
        //{
        //    //Question_01();
        //    //Vidu_Manglomchom();
        //    //Exercise_01p32();
        //    Exercise_02p32();
        //    Console.ReadKey();
        //}
        public static void Question_01()
        {
            int[,] a;
            Console.Write("Nhap so dong: r = ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot: c = ");
            int columns = int.Parse(Console.ReadLine());
            //tạo mảng hai chiều với số dòng và số cột do người dùng nhập
            a = new int[rows, columns];
            //NhapMang(a, rows, columns);
            NhapMangNgauNhien(a, rows, columns);
            Console.WriteLine();
            XuatMang(a);
            Console.WriteLine();
            //Xuất ra dòng hoặc cột theo yêu cầu
            XuatDonghoacCot(a);
            Console.WriteLine();
            int MaxofMatrix = TimGTLN(a);
            Console.WriteLine($"Gia tri lon nhat cua mang: {MaxofMatrix}");
            Console.Write("Nhap so can tim: ");
            int value = int.Parse(Console.ReadLine());
            TimKiemPhantu(a, value);
            GTNNcuaDong(a);
            GTNNcuaCot(a);
            Console.WriteLine();
            Matranchuyenvi(a, rows, columns);
        }
        static void Matranchuyenvi(int[,] a, int rows, int columns)
        {
            Console.WriteLine("Ma tran chuyen vi: ");
            int[,] transposedMatrix = TransposetheMatrix(a, rows, columns);
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(transposedMatrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
        static void XuatDonghoacCot(int[,] a)
        {
            Console.Write("Ban muon xuat dong hay cot? <D/C> ");
            string choice = Console.ReadLine();
            if (choice.ToUpper().Equals("C"))
            {
                Console.Write("Nhap cot muon xuat: ");
                int col = int.Parse(Console.ReadLine());
                XuatCot(a, col);
            }
            else if (choice.ToUpper().Equals("D"))
            {
                Console.Write("Nhap dong muon xuat: ");
                int row = int.Parse(Console.ReadLine());
                XuatDong(a, row);
            }
        }
        static void NhapMang(int[,] a, int rows, int columns)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                    //int x = int.Parse(Console.ReadLine());
                    //a[i, j] = x;
                }
            }
        }
        static void NhapMangNgauNhien(int[,] a, int rows, int columns)
        {
            Random random = new Random();
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = random.Next(0, 100);
                }
            }
        }
        static void XuatCot(int[,] a, int col)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (col - 1 == j)
                        Console.WriteLine(a[i, j]);
                }
            }
        }
        static void XuatDong(int[,] a, int row)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (row - 1 == i)
                        Console.Write(a[i, j] + " ");
                }
            }
        }
        static void XuatMang(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write(a[i, j] + "\t"); //\t = tabs 
                }
                Console.WriteLine();
            }
        }
        //Tìm giá trị lớn nhất của ma trận
        static int TimGTLN(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] > max)
                        max = a[i, j];
                }
            }
            return max;
        }
        //Tìm giá trị nhỏ nhất của dòng
        static void GTNNcuaDong(int[,] a)
        {
            int min = a[0, 0];
            Console.Write("Nhap dong can tim Min: ");
            int dong = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (dong - 1 == i)
                    {
                        if (min > a[i, j])
                            min = a[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri nho nhat cua dong {dong} la: {min}");
        }
        //Tìm giá trị nhỏ nhất của cột
        static void GTNNcuaCot(int[,] a)
        {
            int min = a[0, 0];
            Console.Write("Nhap cot can tim Min: ");
            int cot = int.Parse(Console.ReadLine());
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (cot - 1 == j)
                    {
                        if (min > a[i, j])
                            min = a[i, j];
                    }
                }
            }
            Console.WriteLine($"Gia tri nho nhat cua cot {cot} la: {min}");
        }
        //Ma trận chuyển vị
        static int[,] TransposetheMatrix(int[,] a, int rows, int columns)
        {
            int[,] transposed = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposed[j, i] = a[i, j];
                }
            }
            return transposed;
        }
        static void TimKiemPhantu(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (a[i, j] == value)
                    {
                        Console.WriteLine($"{value} xuat hien tai dong {i} cot {j}\n");
                    }
                }
            }
        }
        public static void Vidu_Manglomchom() //Mảng lỏm chỏm
        {
            int[][] a;
            Console.Write("Nhap so dong: r = ");
            int rows = int.Parse(Console.ReadLine());
            a = new int[rows][];
            NhapMangTuDong(a);
            InMang(a);
            Console.Write("Nhap dong can sap xep: ");
            int index = int.Parse(Console.ReadLine());
            SortRowAtoZ(a, index);
            Console.WriteLine();
            InMang(a);
        }
        private static void NhapMangTuDong(int[][] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i + 1}: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols]; //cấp phát vùng nhớ cho các phần tư
                for (int j = 0; j < cols; j++)
                {
                    a[i][j] = random.Next(100);
                }
            }
        }
        private static void InMang(int[][] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
                Console.WriteLine();
            }
        }
        static void SortRowAtoZ(int[][] a, int index)
        {
            int[] line = a[index - 1];
            for (int i = 0; i < line.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (line[i] < line[j])
                    {
                        int temp = line[i];
                        line[i] = line[j];
                        line[j] = temp;
                    }
                }

            }
        }
        public static void Exercise_01p32()
        {
            int[][] b = TaoMangBai01();
            InMangBai1(b);
        }
        static int[][] TaoMangBai01()
        {
            int[][] b = new int[4][];
            b[0] = new int[] { 1, 1, 1, 1, 1 };
            b[1] = new int[] { 2, 2 };
            b[2] = new int[] { 3, 3, 3, 3 };
            b[3] = new int[] { 4, 4 };
            return b;
        }
        static void InMangBai1(int[][] b)
        {
            Console.WriteLine("Mang b:");
            for (int i = 0; i < b.Length; i++)
            {
                for (int j = 0; j < b[i].Length; j++)
                {
                    Console.Write(b[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void Exercise_02p32()
        {
            int[][] c;
            Console.Write("Nhap so dong: r = ");
            int rows = int.Parse(Console.ReadLine());
            c = new int[rows][];
            //2.0
            TaoMangRandom(c);
            Console.WriteLine();
            Console.WriteLine("Mang da tao:");
            InMangBai2(c);
            Console.WriteLine() ;
            //2.1: In ra giá trị lớn nhất của từng dòng và giá trị lớn nhất của toàn mảng
            for (int i = 0;i < c.Length;i++)
            {
                int gtlncuadong = GTLNcuaDong(c[i]);
                Console.WriteLine($"Gia tri lon nhat cua dong {i+1} la {gtlncuadong}");
            }    
            Console.WriteLine();
            int max = GTLNcuaMang(c);
            Console.WriteLine($"Gia tri lon nhat cua mang la {max}");
            //2.2: lọc theo thứ tự từ nhỏ đến lớn
            Console.WriteLine();
            Console.WriteLine("Mang da sap xep:");
            SortAtoZ(c);
            InMangBai2(c);
            //2.3: Tìm số nguyên tố trong mảng
            Console.WriteLine();
            Songuyento(c);
            //2.4: tìm kiếm phần tử
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Nhap so can tim: ");
            int num = int.Parse(Console.ReadLine());
            TimKiem(c, num);
        }
        static void TaoMangRandom(int[][] c)
        {
            Random rnd = new Random();
            for (int i = 0; i < c.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong a[{i + 1}]: ");
                int cot = int.Parse(Console.ReadLine());
                c[i] = new int[cot];
                for (int j = 0; j < c[i].Length; j++)
                {
                    c[i][j] = rnd.Next(0, 100);
                }
            }
        }
        static void InMangBai2(int[][] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c[i].Length; j++)
                {
                    Console.Write(c[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static int GTLNcuaMang(int[][] c)
        {
            int maxofarrays = c[0][0];
            for (int i = 0;i < c.Length; i++)
            {
                for (int j = 0;j < c[i].Length; j++)
                {
                    if (c[i][j] > maxofarrays)
                        maxofarrays = c[i][j];
                }    
            }    
            return maxofarrays;
        }
        static int GTLNcuaDong(int[] row)
        {
            int maxofrows = row[0];
            for (int i = 1;i < row.Length;i++)
            {
                if (row[i] > maxofrows)
                    maxofrows = row[i];
            }    
            return maxofrows;
        }
        static void SortAtoZ(int[][] c)
        {
            foreach (int[] row in c)
            {
                for (int i = 0; i < row.Length; i++)
                {
                    for (int j = 0; j < i; j++)
                    {
                        if (row[i] < row[j])
                        {
                            int m = row[i];
                            row[i] = row[j];
                            row[j] = m;
                        }
                    }
                }
            }
        }
        //Tìm số nguyên tố trong mảng
        static void Songuyento(int[][] c)
        {
            bool FoundPrime = false;
            Console.WriteLine("Nhung so nguyen to ton tai trong mang:");
            for (int i = 0; i < c.Length; i++)
            {
                for (int j = 0; j < c[i].Length; j++)
                {
                    if (c[i][j] <= 1)
                        continue;
                    else
                    {
                        bool IsPrime = true;
                        for (int k = 2; k <= Math.Sqrt(c[i][j]); k++)
                        {
                            if (c[i][j] % k == 0)
                            {
                                IsPrime = false;
                                break;
                            }
                        }
                        if (IsPrime)
                        {
                            FoundPrime = true;
                            Console.Write(c[i][j] + "\t");
                        }
                    }
                }
            }
            if (!FoundPrime)
                Console.WriteLine("Khong ton tai so nguyen to trong mang.");
        }
        static void TimKiem(int[][] c, int num)
        {
            bool Find = false;
            for(int i = 0;i < c.Length; i++)
            {
                for (int j = 0 ; j < c[i].Length;j++)
                {
                    if (c[i][j] == num)
                    {
                        Console.WriteLine($"So {num} xuat hien tai dong {i + 1} cot {j + 1}");
                        Find = true;
                    }
                }    
            }
            if (!Find)
                Console.WriteLine($"So {num} khong ton tai trong mang.");
        }
    }
}


