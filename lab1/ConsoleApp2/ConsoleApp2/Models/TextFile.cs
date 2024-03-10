using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
//IEnumerable и IEnumerator, yield:
//Создайте класс, реализующий интерфейс IEnumerable<string>.
//Используя yield, верните строки из текстового файла.
//Реализуйте метод, который выводит строки, содержащие определенное ключевое слово.

namespace ConsoleApp2.Models
{
    public class TextFile : IEnumerable<string>
    {
        List<string> text = new List<string>
        {
            "sddwdwdwd",
            "ecececece",
            "dwwdwdwdw",
            "ecewcwccd"
        };

        public IEnumerator<string> GetEnumerator()
        {
            foreach (string str in text)
            {
                yield return str;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Search()
        {
            string substring = "ec";
            foreach (string str in text)
            {
                if (str.Contains(substring))
                {
                    Console.WriteLine($"Подстрока {substring} содержится в строке {str}");
                }
            }
        }
    }
}
