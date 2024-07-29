using System.Collections.Generic;
using System.Diagnostics;


namespace task13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string path = Path.Combine(@"C:\\Users\\Евгений\\Desktop\\курс\\module13\\task13_6_1\\", "Text1.txt");

            string[] arr = File.ReadAllLines(path);

            List<string> list = new List<string>(arr);
            LinkedList<string> link = new LinkedList<string>(arr);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            list.Add("добавленная строка");
            sw.Stop();
            Console.WriteLine($"Скорость вставки в List<T> = {sw.ElapsedTicks} тактов");

            sw.Restart();
            link.AddLast("добавленная строка");
            sw.Stop();
            Console.WriteLine($"Скорость вставки в LinkedList<T> = {sw.ElapsedTicks} тактов");
        }
    }
}
