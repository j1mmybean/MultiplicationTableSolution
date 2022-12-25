using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplicationTableConsoleApp
{
    internal class outputMultiplicationTable
    {
        /// <summary>
        /// 輸出九九乘法表
        /// </summary>
        /// <param name="args"></param>

        static void Main(string[] args)
        {
            for (int i = 2; i < 10; i++)
            {
                string result = string.Empty;
                for (int j = 1; j< 10; j++)
                {
                    result +=  $"{i}*{j} = " + $"{i*j}".PadLeft(2) + "\n";
                }
                Console.WriteLine(result);
            }
        }
    }
}
