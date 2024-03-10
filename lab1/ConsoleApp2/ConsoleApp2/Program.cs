using ConsoleApp2.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Products milk = new Products("Blagoda", 20);
            Products bread = new Products("Bely", 5);
            Products chocolate = new Products("Milka", 15);
            List<Products> products = new List<Products>();
            products.Add(milk);
            products.Add(bread);
            products.Add(chocolate);
            products = Products.SortByPrice(products);
            foreach (Products p in products)
            {
                Console.WriteLine(p.Price + " " + p.Name);
            }
            Console.WriteLine();
            Console.WriteLine();
            
            LinkedListNode1.LinkedListNode12();
            Console.WriteLine();
            Console.WriteLine();

            Queues first = new Queues("Bob", " pizza and Pepsi");
            Queues second = new Queues("Andrew", "Corndog and Sprite");
            Queues third = new Queues("Dina", "Salat and water");
            Queue<Queues> list = new Queue<Queues>();
            list.Enqueue(first);
            list.Enqueue(second);
            list.Enqueue(third);
            Queues.Queuee(list);
            Console.WriteLine();
            Console.WriteLine();

            Books book1 = new Books("Mumu", "Turgenev");
            Books book2 = new Books("Harry Potter", "Rowling");
            Books book3 = new Books("Ark", "Remark");
            Stack<Books> stack = new Stack<Books>();
            stack.Push(book1);
            stack.Push(book2);
            stack.Push(book3);
            Books.StackOfBooks(stack);
            Console.WriteLine();
            Console.WriteLine();

            Countries russia = new Countries("Russia", "Norilsk, Moscow, Voronezh");
            Countries moldova = new Countries("Moldova", "Cishinev, Soroki");
            Countries ukrain = new Countries("Ukrain", "Kiev, Odessa");
            Dictionary<string,string> dic = new Dictionary<string,string>();
            dic.Add(russia.Title, russia.Cities);
            dic.Add(moldova.Title, moldova.Cities);
            dic.Add(ukrain.Title, ukrain.Cities);
            Countries.Countriesss(dic);
            Console.WriteLine();
            Console.WriteLine();

            ObservableCollection<Person> people = new ObservableCollection<Person>();

            people.CollectionChanged += People_CollectionChanged;

            // Добавляем несколько людей в коллекцию
            people.Add(new Person("Иван", 25));
            people.Add(new Person("Мария", 30));

            // Меняем возраст у одного из людей
            people[0].Age = 26;
            Console.WriteLine();
            Console.WriteLine();

            TextFile tds = new TextFile();
            tds.Search();
            Console.WriteLine();
            Console.WriteLine();

            MailSearch mailSearch = new MailSearch("dwidwidj232ncidcijc343432cnsnis989898");
            mailSearch.MailIndexSearch(mailSearch.MyText);
            Console.WriteLine();
            Console.WriteLine();

            RegexReplace regexReplace = new RegexReplace("Делу время, а потехе час");
            Console.WriteLine(Ex2(regexReplace.Text));
            
        }
        private static void People_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            if (e.NewItems != null)
            {
                foreach (Person person in e.NewItems)
                {
                    person.AgeChanged += Person_AgeChanged;
                }
            }

            if (e.OldItems != null)
            {
                foreach (Person person in e.OldItems)
                {
                    person.AgeChanged -= Person_AgeChanged;
                }
            }
        }

        private static void Person_AgeChanged(object sender, EventArgs e)
        {
            Person person = (Person)sender;
            Console.WriteLine($"Имя: {person.Name}, Новый возраст: {person.Age}");
        }
        static string Ex2(string str)
        {
            Regex regex = new Regex(@"\b(\w)(\w*?)(\w)\b");

            string replacement(Match match)
            {
                char first = match.Groups[1].Value[0];
                char last = match.Groups[3].Value[0];

                return last + match.Groups[2].Value + first;
            }

            string result = regex.Replace(str, replacement);

            return result;
        }

    }

}
