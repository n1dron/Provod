using provoda;
namespace Program
{
    internal class Kall
    {
        public static void Main()
        {
            int x = 0; 
            Console.SetCursorPosition(15, 0);
            Console.WriteLine("Выбор диска: ");
            DriveInfo[] drives = DriveInfo.GetDrives();
            foreach (DriveInfo drivers in drives)
            {
                Console.Write("\t" + drivers.Name);
                Console.WriteLine(" " + drivers.TotalFreeSpace / 1073741824 + " ГБ свободно из " + drivers.TotalSize / 1073741824 + " ГБ");
                x++;
            }
            List<string> Listik = new List<string>();
            string[] many;
            Files arrow = new Files();
            int[] y = arrow.palka(x);
            many = papka.nick(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
            Listik.Add(Convert.ToString(drives[y[0] - 2]));
            while (true)
            {
                y = arrow.palka(many.Length);
                if (y[1] < -1)
                {
                    if (y[1] == -2)
                    {
                        dobavka.dobav(Listik[Listik.Count - 1]);
                    }
                    else if (y[1] == -3)
                    {
                        dobavka.dobav2(Listik[Listik.Count - 1]);
                    }
                    else if (y[1] == -4)
                    {
                        dobavka.dobav3(many[y[0] - 2]);
                    }
                    Console.Clear();
                    Listik.Clear();
                    x = 0;
                    Console.SetCursorPosition(15, 0);
                    Console.WriteLine("Выбор диска");
                    foreach (DriveInfo drivers in drives)
                    {
                        Console.Write("\t" + drivers.Name);
                        Console.WriteLine(" " + drivers.TotalFreeSpace / 1073741824 + " ГБ свободно из " + drivers.TotalSize / 1073741824 + " ГБ");
                        x++;
                    }
                    y = arrow.palka(x);
                    many = papka.nick(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                    Listik.Add(Convert.ToString(drives[y[0] - 2]));
                }
                if (y[1] == -1)
                {
                    if (Listik.Count == 1)
                    {
                        Console.Clear();
                        x = 0;
                        Console.SetCursorPosition(15, 0);
                        Console.WriteLine("Выбор диска");
                        foreach (DriveInfo drivers in drives)
                        {
                            Console.Write("\t" + drivers.Name);
                            Console.WriteLine(" " + drivers.TotalFreeSpace / 1073741824 + " ГБ свободно из " + drivers.TotalSize / 1073741824 + " ГБ");
                            x++;
                        }
                        y = arrow.palka(x);
                        many = papka.nick(Convert.ToString(drives[y[0] - 2]), y[0] - 2);
                        Listik.Add(Convert.ToString(drives[y[0] - 2]));
                    }
                    else
                    {
                        Listik.RemoveAt(Listik.Count - 1);
                        many = papka.nick(Listik[Listik.Count - 1], 0);
                    }
                }
                else
                {
                    Listik.Add(Convert.ToString(many[y[0] - 2]));
                    many = papka.nick(Convert.ToString(many[y[0] - 2]), y[0] - 2);
                }
            }
        }
    }
}