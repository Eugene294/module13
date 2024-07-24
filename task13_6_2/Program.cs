using System.Collections.Generic;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace task13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\\Users\\Евгений\\Desktop\\курс\\module13\\task13_6_1\\Text1.txt";
            StringBuilder text = new StringBuilder();

            StreamReader sr = new StreamReader(path);
            while (!sr.EndOfStream)
            {
                text.Append(sr.ReadLine());
            }
            sr.Close();

            string t = text.ToString();
            var noPunctuationText = new string(t.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] array = noPunctuationText.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var most = array.GroupBy(item => item).OrderByDescending(c => c.Count()).Select(grp => new { Word = grp.Key, Count = grp.Count() });

            int i = 0;
            foreach (var item in most)
            {
                i++;
                if (item.Count % 10 == 2 || item.Count % 10 == 3 || item.Count % 10 == 4)
                {
                    Console.WriteLine($"{i}-е в списке самых часто повторяющихся в списке слов это \"{item.Word}\", повторено {item.Count} раза");
                }
                else
                {
                    Console.WriteLine($"{i}-е в списке самых часто повторяющихся в списке слов это \"{item.Word}\", повторено {item.Count} раз");
                }
                if (i == 10) break;
            }
        }
    }
}
