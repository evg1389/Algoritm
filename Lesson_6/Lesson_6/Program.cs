using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    class Program
    { 
        static int mKeyRasult(int KeyIn)
        {
            
            int Result;
            int K = KeyIn / 7;

            
            
            int res = KeyIn % 7;
            Result = K + res;
            
            return Result;
        }
    
        static void Main(string[] args)
        {
            
            Console.WriteLine("start");
            char [] s =new char [5] {'f','a','k','о','e'};
            int [] KeyIn=new int[5] {0,0,0,0,0 };
            int res=0;
            for (int i=0;i<s.Length;i++)
            {
                int b = s[i];
                KeyIn[i] = b;
                res += mKeyRasult(KeyIn[i])/2;
            }
            
            Console.WriteLine($"резултат выполнения хеш функции получилось:{res}");
            Console.ReadKey();
        }
    }
}
