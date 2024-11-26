using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_08
    {
        private static void Main(string[] args)
        {
            //char[] st = { 'h', 'e', '1', 'l', 'o' };
            //string s1 = "hello";
            //s1 = "world";
            //string? s2 = null; //Không cần kiểm tra
            string s = "Enumerates    and transforms a    sequence, and procedures an immutable" + 
                "sorted dictionary of its contents by using the   specified key and value comparers.";
            int len = CountWords(s);
            Console.WriteLine(len);
        }
        static int CountWords(string s)
        {
            int count = 1;
            //Bỏ khoảng trắng thừa có trong chuỗi
            s = s.Trim(); //bỏ khoảng trắng ở đầu và cuối chuỗi
            while (s.IndexOf("  ") != -1)
            {
                s = s.Replace("  ", " ");
            } 
            //đếm
            foreach (char c in s) 
                if (c == ' ')
                    count++;
            return count;
        }
    }
}
