using System;

namespace dipapel.ConsoleApp 
{
    public class Person 
    {
        
        public string Name { get; set; }
     
        public Person(string name)
        {
            Name = name;
        }
        
        public string Greeting()
        {
            return $"Olá meu nome é { Name }";            
        }
    }
    
}