using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Ucenje
{
    internal class E07Z1
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesi cijeli broj");
            int broj = int.Parse(Console.ReadLine());

            for (int i = 0; i < broj; i++)
                if (i % 2 == 0)
                {
                    int sum = 0;
                    for (int i = 1; i <= broj; i++)
                    {
                        sum += i;
                    }
                    Console.WriteLine(sum);

                }
                else
                {
                    for (int j = 1; j <= broj; j++)
                    {
                        if (j % 2 == 1)
                        {
                            Console.WriteLine(j);
                        }
                    }
                }

        }


















    

