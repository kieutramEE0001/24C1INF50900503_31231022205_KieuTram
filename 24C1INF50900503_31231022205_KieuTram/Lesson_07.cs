﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_07
    {
        public static void Main(string[] args)
        {
            //Question_01();
            Vidu_Manglomchom();
            Console.ReadKey();
        }
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
            //XuatDonghoacCot(a);
            //Console.WriteLine();
            //int MaxofMatrix = TimGTLN(a);
            //Console.WriteLine($"Gia tri lon nhat cua mang: {MaxofMatrix}");
            //Console.Write("Nhap so can tim: ");
            //int value = int.Parse(Console.ReadLine());
            //TimKiemPhantu(a, value);
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
            SortRowAtoZ(a,index);
            Console.WriteLine();
            InMang(a);
        }
        private static void NhapMangTuDong(int[][] a)
        {
            Random random = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: ");
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
            for (int i = 0; i < a.Length;i++)
            {
               for (int j = 0; j < a[i].Length;j++)
                {
                    Console.Write($"{a[i][j]}\t");
                }
               Console.WriteLine();
            }
        }
        static void SortRowAtoZ(int[][]a, int index)
        {
            int[] line = a[index];
            for (int i = 0;i < line.Length;i++)
            {
                for (int j = 0; j<i; j++)
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
            int[][] a;
            int rows = 4;
            a = new int[rows][];
            for (int i = 0; i < a.Length;i++)
            {
                Console.Write($"Nhap so cot cho dong {i}: ");
                int cols = int.Parse(Console.ReadLine());
                a[i] = new int[cols]; //cấp phát vùng nhớ cho các phần tư
                for (int j = 0; j < cols; j++)
                {
                    a[i][i];
                }
            }    
        }
    }
}

