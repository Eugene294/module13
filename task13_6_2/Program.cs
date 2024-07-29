using System.Collections.Generic;
using System.Collections;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace task13_6_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = Path.Combine(@"C:\\Users\\Евгений\\Desktop\\курс\\module13\\task13_6_1\\", "Text1.txt");

            string text = File.ReadAllText(path);

            var noPunctuationText = new string(text.Where(c => !char.IsPunctuation(c)).ToArray());
            string[] array = noPunctuationText.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            var most = array.GroupBy(item => item).OrderByDescending(c => c.Count()).Select(grp => new { Word = grp.Key, Count = grp.Count() });

            var dic = new SortedDictionary<string, int>();


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
