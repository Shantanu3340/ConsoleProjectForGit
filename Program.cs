using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleProjectForGit
{
    internal class Program
    {
        public void Add()
        {
            int a = 10, b = 10, c;
            c = a + b;
            Console.WriteLine("add="+c);
        }
            
        static void Main(string[] args)
        {
            Program program = new Program();
            program.Add();
            Console.ReadLine(); 
        }
    }
}
