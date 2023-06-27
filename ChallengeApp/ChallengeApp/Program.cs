using System;
using System.ComponentModel.Design;

var name = "Ewa";
var age = 33;
string sex = "Kobieta";
if (age < 18)
{
    if (sex == "Kobieta")
    {
        Console.WriteLine("Niepełnoletnia kobieta");
    }
    else
    {
        Console.WriteLine("Niepełnoletni mężczyzna");
    }
}
else if (age < 30)
{
    if (sex == "Kobieta")
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
    else
    {
        Console.WriteLine("Mężczyzna poniżej 30 lat");
    }
}
else if (age >= 30 && name != "Ewa")
{
    if (sex == "Kobieta")
    {
        Console.WriteLine("Kobieta 30 lat i więcej");
    }
    else
    {
        Console.WriteLine("Mężczyzna 30 lat i więcej");
    }
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa, lat 33");
}