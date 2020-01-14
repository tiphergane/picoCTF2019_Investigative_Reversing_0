using System;
using System.Text;

namespace PicoCTF_Investigative_Reversing_0
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] BaseFlag = 
            {
                0x70, 0x69, 0x63, 0x6F, 0x43, 0x54, 0x4B, 0X80, 0x6B, 0x35, 0x7A, 0x73, 0x69, 
                0x64, 0x36, 0x71, 0x5F, 0x35, 0x37, 0x64, 0x30, 0x64, 0x34, 0x37, 0x63, 0x7D 
            };

            //BaseFlag = Encoding.ASCII.GetBytes("picoCTKçk5zsid6q_57d0d47c}"); 
            int i;
            for (i = 6; i < 0xf; i++)
            {
                BaseFlag[i] -= 0x5;
            }
            //BaseFlag[7] = 0x7b; // to fix the problem who take the wrong ASCII char
            BaseFlag[i] += 0x3;

            for (int j = 0x10; j < 0x1a; j++)
            {
                BaseFlag[j] = BaseFlag[j];
            }
            string s = Encoding.UTF8.GetString(BaseFlag);
            Console.WriteLine("Flag is : {0}", s);
            Console.WriteLine("Press Enter to quit");
            while (Console.ReadKey().Key != ConsoleKey.Enter) ;
        }
    }
}
