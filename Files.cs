using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provoda
{
    internal class Files
    {
        public int[] palka(int x)
        {
            int[] result = new int[2];
            int z = 2;
            int c = z;
            Console.SetCursorPosition(0, z);
            Console.WriteLine("->");
            ConsoleKeyInfo Clavisha = Console.ReadKey();
            while (true)
            {
                if (Clavisha.Key == ConsoleKey.UpArrow)
                {
                    z--;
                    if (z <= 2)
                    {
                        z = x + 1;
                    }
                }
                if (Clavisha.Key == ConsoleKey.DownArrow)
                {
                    z++;
                    if (z >= x + 1)
                    {
                        z = 2;
                    }
                }
                result[0] = z;
                if (Clavisha.Key == ConsoleKey.Enter)
                {
                    return result;
                }
                if (Clavisha.Key == ConsoleKey.Escape)
                {
                    result[1] = -1;
                    return result;
                }
                if (Clavisha.Key == ConsoleKey.F1)
                {
                    result[1] = -2;
                    return result;
                }
                if (Clavisha.Key == ConsoleKey.F2)
                {
                    result[1] = -3;
                    return result;
                }
                if (Clavisha.Key == ConsoleKey.F3)
                {
                    result[1] = -4;
                    return result;
                }
                Console.SetCursorPosition(0, c);
                Console.WriteLine("  ");
                Console.SetCursorPosition(0, z);
                Console.WriteLine("->");
                Clavisha = Console.ReadKey();
                c = z;
            }
        }
    }
}