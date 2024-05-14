using System;
using propgramaproekt;
class Program
{
    static void Main()
    {
        City city = new City("Москва", 12678079);
        Village village = new Village("Майский", 100);

        Console.WriteLine("Информация о городе:");
        city.inf();
        city.citygorod();

        Console.WriteLine("\nИнформация о деревне:");
        village.inf();
        village.IsVillage();
    }
}
