using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//(Regex.Replace)Дана строка — предложение на русском языке.
//Поменять местами первую и последнюю буквы каждого слова.
namespace ConsoleApp2.Models
{
    internal class RegexReplace
    {
        public string Text { get; set; }

        public RegexReplace(string text) => Text = text;

        public string RegRep(string text)
        {
            Regex regex = new Regex(@"\b(\w) (\w*?) (\w)b");
            string replacement(Match match)
            {
                char first = match.Groups[1].Value[0];
                char last = match.Groups[3].Value[0];
                return last + match.Groups[2].Value + first;
            }
            string result = regex.Replace(text, replacement);
            return result;
        }    
    }
}
//some comment