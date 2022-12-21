using provoda;
using System.Diagnostics;

namespace provoda
{
    internal class papka
    {
        public static string[] nick(string name1, int form)
        {
            int pol = 0;
            int add = 2;
            Console.Clear();
            Console.SetCursorPosition(25, 0);
            Console.WriteLine("Выбор файла");
            Console.SetCursorPosition(83, 3);
            Console.WriteLine("F1 - Cоздать файл");
            Console.SetCursorPosition(83, 5);
            Console.WriteLine("F2 - Cоздать папку");
            Console.SetCursorPosition(83, 7);
            Console.WriteLine("F3 - Удалить");
            Console.SetCursorPosition(82, 8);
            if (Directory.Exists(name1))
            {
                string[] User = Directory.GetDirectories(name1);
                foreach (string nick in User)
                {
                    Console.SetCursorPosition(2, add);
                    Console.WriteLine(nick);
                    Console.SetCursorPosition(50, add);
                    Console.WriteLine(Directory.GetCreationTime(nick));
                    add++;
                }
                string[] files = Directory.GetFiles(name1);
                foreach (string file in files)
                {
                    Console.SetCursorPosition(2, add);
                    Console.WriteLine(file);
                    Console.SetCursorPosition(50, add);
                    Console.WriteLine(Directory.GetCreationTime(file));
                    add++;
                }
                string[] many = new string[files.Length + User.Length];
                foreach (string file in User)
                {
                    many[pol++] = file;
                }
                foreach (string file in files)
                {
                    many[pol++] = file;
                }
                return many;
            }
            else
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = name1,
                    UseShellExecute = true
                });
                string[] i = new string[1];
                return i;
            }
        }
    }
}
