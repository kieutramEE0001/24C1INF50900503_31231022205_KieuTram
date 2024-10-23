using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24C1INF50900503_31231022205_KieuTram
{
    internal class Lesson_04
    {
        public static void Main()
            {
                Question_01();
                Console.ReadKey();
            }
            /// <summary>
            /// Game doan so <br/>
            /// May tinh tu nghi ngau nhien 1 so <br/>
            /// Nguoi dung doan so do <br/>
            /// </summary>
            public static void Question_01()
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
                        Console.WriteLine("Ban doan so may? <1...10>");
                        int user_num = int.Parse(Console.ReadLine());
                        //kiem tra ket qua
                        if (user_num == comp_num)
                        {
                            Console.WriteLine("Ban da doan dung! That gioi");
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
    }
}

