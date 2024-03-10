using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Stack
namespace ConsoleApp2.Models
{
    public class Books
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public Books(string title, string author)
        {
            Title = title;
            Author = author;
        }
        public static void StackOfBooks(Stack<Books> stack)
        {
            while (stack.Count > 0)
            {
                var obj = stack.Pop();
                Console.WriteLine($"У вас в руках книга {obj.Title} от автора {obj.Author}");
            }
            Console.WriteLine("Книги в стопке закончились");
        }
    }
}
