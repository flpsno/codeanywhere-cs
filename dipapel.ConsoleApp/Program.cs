using System;

namespace dipapel.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var pessoa = new Person();
            pessoa.Name = "Felipe";
            
            
            Console.WriteLine(pessoa.Greeting());
        }
    }
}
