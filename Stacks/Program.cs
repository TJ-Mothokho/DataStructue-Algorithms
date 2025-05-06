using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<User> userHistory = new Stack<User>();

            // Push users (simulate navigation or actions)
            userHistory.Push(new User("alice", "alice@example.com"));
            userHistory.Push(new User("bob", "bob@example.com"));
            userHistory.Push(new User("charlie", "charlie@example.com"));

            Console.WriteLine("Users pushed to stack (e.g., visited profiles):");
            PrintStack(userHistory);

            Console.WriteLine();

            //Peek lastest user
            Console.WriteLine("=============Last user to login=============");
            Console.WriteLine(userHistory.Peek());

            Console.WriteLine();

            Console.WriteLine("=============Removed Last user=============");
            userHistory.Pop();
            PrintStack(userHistory);

            Console.WriteLine();

            Console.WriteLine("=============Size=============");
            Console.WriteLine($"The stack now has {userHistory.Count()} users.");

            Console.ReadLine();
        }

        static void PrintStack(Stack<User> stack)
        {
            foreach (var user in stack)
            {
                Console.WriteLine(user);
            }
        }
    }
}
