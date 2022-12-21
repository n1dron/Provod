using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provoda
{
    public class dobavka
    {
        public static void dobav(string path)
        {
            Console.SetCursorPosition(83, 9);
            string name = Console.ReadLine();
            File.Create(path + "\\" + name);
        }
        public static void dobav2(string path)
        {
            Console.SetCursorPosition(83, 9);
            string name = Console.ReadLine();
            Directory.CreateDirectory(path + "\\" + name);
        }
        public static void dobav3(string path)
        {
            if (Directory.Exists(path))
            {
                Directory.Delete(path);
            }
            else
            {
                File.Delete(path);
            }
        }
    }
}
