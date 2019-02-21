using System;

namespace dipapel.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Person("Felipe");
            
            
            Console.WriteLine(pessoa.Greeting());
        }
    }
}
