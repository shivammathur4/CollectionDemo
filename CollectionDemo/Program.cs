using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collections Demo!");
            ListImplementation();
            StackImplementation();
            QueueImplementation();
            DictionaryImplementation();
        }

        private static void ListImplementation()
        {
            Console.WriteLine("Creating a List");
            List<string> list = new List<string>();

            list.Add("Ramya");
            list.Add("Siri");
            list.Add("Raksh");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }
        }

        private static void StackImplementation()
        {
            Console.WriteLine("Stack implementation");

            Stack<string> stack = new Stack<string>();

            stack.Push("Rina");
            stack.Push("Tina");
            stack.Push("Mina");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("Popped element: " + pop);
        }

        private static void QueueImplementation()
        {
            //creating queue
            Queue<string> queue = new Queue<string>();

            queue.Enqueue("Lily");
            queue.Enqueue("Rose");
            queue.Enqueue("Daisy");

            foreach (var element in queue)
            {
                Console.WriteLine(element);
            }
        }

        private static void DictionaryImplementation()
        {
            //creating dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            dictionary.Add(70, "Randy");
            dictionary.Add(90, "Max");
            dictionary.Add(80, "Caroline");
        }

        private static void SetImplementation()
        {
            //creating set variable
            var set = new HashSet<string>();

            set.Add("Lucifer");
            set.Add("Morningstar");
            set.Add("Decker");
        }
    }
}
