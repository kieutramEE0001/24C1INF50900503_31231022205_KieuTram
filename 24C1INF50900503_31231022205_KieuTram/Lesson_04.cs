using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_04
    {
        //public static void Main()
        //{
        //    Question_00();
        //    Question_02();
        //    Question_03();
        //    Question_1();
        //    Question_2();
        //    Question_3();
        //    Question_4_2();
        //    Question_4_3();
        //    Question_6();
        //    Question_7();
        //    Question_8();
        //    Console.ReadKey();
        //}
        /// <summary>
        /// Game doan so <br/>
        /// May tinh tu nghi ngau nhien 1 so <br/>
        /// Nguoi dung doan so do <br/>
        /// </summary>
        public static void Question_00()
        {
            do
            {
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 10) + 1;
                //hoi nguoi dung doan so
                //doan den khi nao dung thi thoi và dem so lan phai doan
                int count = 0;
                bool isContinue = true;
                do
                {
                    count++;
                    Console.WriteLine("Ban doan so may? <1...10>");
                    int user_num = int.Parse(Console.ReadLine());
                    //kiem tra ket qua
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"Ban da doan dung sau {count} lan! That gioi");
                        isContinue = false;
                    }
                    else
                    {
                        if (user_num > comp_num)
                            Console.WriteLine("Nhap so khac nho hon");
                        else
                            Console.WriteLine("Nhap so khac lon hon");
                    }
                } while (isContinue);
                Console.WriteLine("________________________");
                Console.Write("Ban muon choi tiep khong? <C/K>: ");
                string reply = Console.ReadLine();
                if (reply.ToUpper().Equals("K"))
                {
                    Console.WriteLine("End Game. Hen gap lai lan sau!");
                    return;
                }
            } while (true);
        }
        public static void Question_01()
        //Check so chan le
        {
            Console.Write("Nhap so can kiem tra: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
                Console.WriteLine($"{num} la so chan");
            else
                Console.WriteLine($"{num} la so le");
        }
        public static void Question_02()
        //Tim so lon nhat trong ba so nhap vao
        {
            Console.WriteLine("Luu y: Khong nhap cac so bang nhau");
            Console.Write("Nhap so a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap so b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap so c = ");
            int c = int.Parse(Console.ReadLine());
            //kiem tra gia tri lon nhat
            if (a < b)
            {
                if (b < c)
                    Console.WriteLine($"{c} la so lon nhat");
                else
                    Console.WriteLine($"{b} la so lon nhat");
            }
            else
            {
                if (a > c)
                    Console.WriteLine($"{a} la so lon nhat");
            }
        }
        public static void Question_03()
        //kiểm tra tọa độ (x,y) thuộc góc phần tư thứ mấy
        {
            Console.Write("Nhap toa do x = ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhap toa do y = ");
            int y = int.Parse(Console.ReadLine());
            if (x > 0 && y > 0) //x lớn hơn 0 y lớn hơn 0 => (x,y) thuộc góc phần tư thứ Nhất
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
            else if (x == 0 && y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin.");
            }
            else if (x == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the Y axis.");
            }
            else if (y == 0)
            {
                Console.WriteLine($"The coordinate point ({x},{y}) lies on the X axis.");
            }
        }
            public static void Question_1()
        //kiem tra tam giac
        {
            Console.Write("Nhap canh a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("Nhap canh c = ");
            int c = int.Parse(Console.ReadLine());
            //kiểm tra xem 3 cạnh có tạo thành tam giác hay không 
            if (a < b + c && b < a + c && c < a + b)
            {
                if (a == b || b == c || c == a) //kiem tra ket qua
                {
                    if (a == b && b == c)
                        Console.WriteLine("Day la tam giac deu");
                    else
                        Console.WriteLine("Day la tam giac can");
                }
                else
                {
                    Console.WriteLine("Day la tam giac thuong");
                }
            }
            else Console.WriteLine("Day khong phai la tam giac");   
        }
        public static void Question_2()
        //tinh trung binh cong va tong
        {
            int[] numbers = new int[10];
            int sum = 0;

            Console.WriteLine("Nhap lan luot 10 so");

            // Đọc 10 số được nhập
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Number {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
                sum += numbers[i];
            }

            // Tính trung bình
            double average = sum / 10.0;

            // In ra tổng và trung bình
            Console.WriteLine($"\nTong cua 10 so = {sum}");
            Console.WriteLine($"Trung binh cong cua 10 so = {average}");
        }
        public static void Question_3()
        //Hien thi bang cuu chuong cua 1 so 
        {
            Console.WriteLine("Chon bang cuu chuong <1..9>");
            int num = int.Parse(Console.ReadLine());
            //tính bảng cửu chương
            for (int i = 0; i <= 10; i++)
            {
                int result = num * i;
                Console.WriteLine($"{num} x {i} = {result}");
            }
        }
        public static void Question_8()
        //kiểm tra xem 1 số có phải là số nguyên tố hay không
        {
            Console.Write("Nhap so can kiem tra (x > 1): ");
            int num = int.Parse(Console.ReadLine());
            if (IsPrime(num))
            {
                Console.WriteLine($"{num} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{num} khong phai la so nguyen to.");
            }
        }
        // Hàm kiểm tra số nguyên tố
        static bool IsPrime(int num)
        {
            for (int i = 2; i <= Math.Sqrt(num); i++) // Kiểm tra ước của num từ 2 đến căn bậc hai của num
            {
                if (num % i == 0)
                {
                    return false; // Nếu tìm thấy ước của num, thì num không phải là số nguyên tố
                }
            }
            return true; // Nếu không tìm thấy ước nào, thì num là số nguyên tố
        }
        public static void Question_6()
        //Nhập số n và trả về tổng của dãy vô hạn Harmonic 1 + 1/2 +......+ 1/n
        {
            Console.Write("Enter number n: ");
            int n = int.Parse(Console.ReadLine());
            double sum = 0;
            Console.Write("Harmonic series: ");
            for (int i = 1; i <= n; i++)
            {
                Console.Write($" 1/{i} ");
                if (i < n)
                    Console.Write("+");
                sum += 1.0 / i; // sum += nghĩa là sum' = sum + 1/i
            }    
            Console.WriteLine();
            Console.WriteLine($"Sum of the series = {sum}");
        }
        public static void Question_7()
        //Tìm ra số hoàn hảo trong một khoảng cho trước
        {
           //Nhập giá trị bắt đầu và giá trị kết thúc của khoảng
            Console.Write("Nhap so bat dau cua khoang: ");
            int Start = int.Parse(Console.ReadLine());
            Console.Write("Nhap so ket thuc cua khoang: ");
            int End = int.Parse(Console.ReadLine());
            Console.WriteLine($"Cac so hoan hao trong khoang tu {Start} den {End}: ");
            //kiểm tra từng giá trị i trong khoảng
            for (int n = Start; n <= End; n++) //với mỗi giá trị n thuộc khoảng
                                               //nếu hàm IsPerfect đúng thì xuất ra màn hình giá trị n
            {
                if (IsPerfect(n))
                    Console.WriteLine(n);
            }
        }
        static bool IsPerfect(int num) //Hàm IsPerfect để kiểm tra 
        {
            int sum = 1;
            for (int i = 2; i < num; i++) 
            {
                if (num % i == 0)
                    sum += i;
            }
            return sum == num;     //hàm trả về true nếu sum = num
        }
        public static void Question_4_1()
        //Hàm in ra các pattern của số
        //Pattern 1
        {
            Console.Write("Nhap so ket thuc cua day: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++) //lặp lại theo chiều dọc
            {
                for (int j = 1; j <= i; j++) //lặp theo chiều ngang
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }    
        }
        public static void Question_4_2()
        //Pattern 2
        {
            Console.Write("Nhap so bat dau: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Nhap so dong cua mau: ");
            int rows = int.Parse(Console.ReadLine());
            for (int i = 1; i <= rows; i++) //lặp lại rows lần theo chiều dọc
            {
                for (int j = 1; j <= i; j++) //lặp theo chiều ngang
                {
                    Console.Write($"{n} ");
                    n++;
                }  
                Console.WriteLine();
            }    
        }
        public static void Question_4_3()
        //Pattern 3
        {
            int n = 1;
            int rows = 4;
            for (int i = 1; i <= rows; i++)
            {
                for (int s = 1; s <= rows - i; s++) //In khoảng trắng cho mỗi dòng
                                                    //số khoảng trắng ở dòng thứ i giảm 1
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{n} ");
                    n++;
                }
                Console.WriteLine();
            }
        }
    }

}
    





