using System;
using System.Collections.Generic;
using System.Text;

namespace SinCity
{
   

internal class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

class Citizen : Person
{
    public Citizen(string name) : base(name)
    {

    }
}

class Thief : Person
{
    public Thief(string name) : base(name)
    {

    }


}

class Police : Person
{
    public Police(string name) : base(name)
    {

    }


}
}

