using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace SinCity
{
   

internal class Person
{
        public int X { get; set; }
        public int Y { get; set; }
    public string Name { get; set; }
    public string Appearance { get; set; }
    
    public Person(string name, string appearance)
    {
        Name = name;
        Appearance = appearance;
        
    }
}

class Citizen : Person
{
    public Citizen(string name, string appearance) : base(name, appearance)
    {
            appearance = "C";
    }
}

class Thief : Person
{
    public Thief(string name, string appearance) : base(name, appearance)
    {
            appearance = "T";
    }
    
}
            
class Police : Person
{
    public Police(string name, string appearance) : base(name, appearance)
    {
            appearance = "P";
    }


}
}
            
        
            



