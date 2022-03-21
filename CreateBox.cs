using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Box
{
    internal class CreateBox
    {
        public static string Square(int a)
        {
            if (a == 1)
            {
                Console.WriteLine("1");
                return "";
            }
            if (a > 1)
            {
                int n = 2;
                int u = 0;
                if (a % 2 != 0)
                {

                    for (int i = 0; i < a / 2; i++)
                    {
                        Console.WriteLine(string.Concat(Enumerable.Repeat("0", i)) + "1" +
                            string.Concat(Enumerable.Repeat("0", a - n)) + "1" + string.Concat(Enumerable.Repeat("0", i)));
                        n += 2;
                        u = i;
                    }
                    Console.WriteLine(string.Concat(Enumerable.Repeat("0", a / 2)) + "1"
                        + string.Concat(Enumerable.Repeat("0", a / 2)));
                    n -= 2;
                    for (int i = u; i > -1; i--)
                    {
                        Console.WriteLine(string.Concat(Enumerable.Repeat("0", i)) + "1" + string.Concat(Enumerable.Repeat("0", a - n)) + "1" + string.Concat(Enumerable.Repeat("0", i)));
                        n -= 2;
                    }
                }
                if (a % 2 == 0)
                {
                    for (int i = 0; i < a / 2; i++)
                    {
                        Console.WriteLine(string.Concat(Enumerable.Repeat("0", i)) + "1" +
                            string.Concat(Enumerable.Repeat("0", a - n)) + "1" + string.Concat(Enumerable.Repeat("0", i)));
                        n += 2;
                        u = i;
                    }
                    n -= 2;
                    for (int i = u; i > -1; i--)
                    {
                        Console.WriteLine(string.Concat(Enumerable.Repeat("0", i)) + "1" + string.Concat(Enumerable.Repeat("0", a - n)) + "1" + string.Concat(Enumerable.Repeat("0", i)));
                        n -= 2;
                    }
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод");
            }
            return "";
        }
    }
}

//1001
//0110
//0110
//1001

//100001
//010010
//001100
//001100
//010010
//100001
