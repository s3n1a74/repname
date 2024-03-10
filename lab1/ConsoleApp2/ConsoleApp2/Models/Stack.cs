using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Models
{
    public static class LinkedListNode1
    {
         public static void LinkedListNode12()
        {
            LinkedList<int> list = new LinkedList<int>(new[] { 1, 2, 3, 4 });
            var currentNode = list.First;
            while (currentNode != null)
            {
                currentNode.Value *= 2;
                Console.Write(currentNode.Value + "  ");
                currentNode = currentNode.Next;
            }
        }
    }
}
