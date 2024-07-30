using System.Collections.Generic;
using System.Collections;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;

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
            HashSet<string> words = new HashSet<string>(array);


            var dic = new Dictionary<string, int>();
            foreach (string s in words)
            {
                int count = 0;
                foreach (string s1 in array)
                {
                    if (s1 == s) count++; 
                }
                dic.Add(s, count);
            }
            
            List<int> list = new List<int>();
            foreach (var item in dic) list.Add(item.Value);
            list.Sort();
            list.Reverse();


            int i = 0;
            foreach (var item in list)
            {
                i++;
                string word = "";
                foreach (var item2 in dic) 
                {
                    if (item2.Value == item)
                    {
                        word = item2.Key;
                        break;
                    }
                }
                if (i % 10 == 2 || i % 10 == 3 || i % 10 == 4)
                {
                    Console.WriteLine($"{i}-е в списке самых часто повторяющихся в списке слов это \"{word}\", повторено {item} раза");
                }
                else
                {
                    Console.WriteLine($"{i}-е в списке самых часто повторяющихся в списке слов это \"{word}\", повторено {item} раз");
                }
                if (i == 10) break;
            }

        }
    }
}
