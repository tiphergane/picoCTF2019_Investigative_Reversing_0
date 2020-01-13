using System;
using System.Text;

namespace PicoCTF_Investigative_Reversing_0
{
    class Program
    {
        static void Main(string[] args)
        {
            byte[] BaseFlag = new byte[32];
            byte[] Buffer = new byte[32];

            BaseFlag = Encoding.ASCII.GetBytes("picoCTKçk5zsid6q_57d0d47c}"); 
            int i;
            for (i = 6; i < 0xf; i++)
            {
                BaseFlag[i] -= 0x5;
            }
            BaseFlag[7] = 0x7b; // to fix the problem who take the wrong ASCII char
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
