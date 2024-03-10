using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
//(Count)Написать функцию, которая определяет количество
// входящих в заданную строку почтовых индексов
// (почтовый индекс состоит из 6 цифр).
namespace ConsoleApp2.Models
{
    internal class MailSearch
    {
        public string MyText { get; set; }

        public MailSearch(string myText) => MyText = myText;

        public void MailIndexSearch(string myText)
        {
            Regex _regex = new Regex(@"\d{6}");
            Console.WriteLine("Mail index:");
            MatchCollection matches = _regex.Matches(myText);
            if (matches.Count > 0)
            {
                foreach (Match match in matches)
                {
                    Console.WriteLine(match.Value);
                }
            }
        }
    }
}
