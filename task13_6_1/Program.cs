using System.Collections.Generic;
using System.Diagnostics;

namespace task13_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            string path = @"C:\\Users\\Евгений\\Desktop\\курс\\module13\\task13_6_1\\Text1.txt";

            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                list.Add(sr.ReadLine());
            }
            sr.Close();

            LinkedList<string> link = new LinkedList<string>(list);

            Stopwatch sw = new Stopwatch();
            sw.Start();
            list.Insert(13400, "добавленная строка");
            sw.Stop();
            Console.WriteLine($"Скорость вставки в List<T> = {sw.ElapsedTicks} тактов");

            sw.Restart();
            link.AddLast("добавленная строка");
            sw.Stop();
            Console.WriteLine($"Скорость вставки в LinkedList<T> = {sw.ElapsedTicks} тактов");
        }
    }
}
