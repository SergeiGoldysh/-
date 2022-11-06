
using System.Data;
using System.Runtime.InteropServices;
using System.Xml.Linq;

Console.WriteLine("Enter your desired character name:");
string nameHero = Console.ReadLine();

try
{
    if (nameHero != "Artur")
    {
        throw new Exception("The name of the hero does not match the lore of the game");
    }
}
catch (Exception heroName)
{
    Console.WriteLine(heroName);
}

double count = 0;

Console.WriteLine("Enter the hero's health");
//do
//{
while (!double.TryParse(Console.ReadLine(), out count))
{
    Console.WriteLine("Enter health in numbers. According to the rules of the game," +
        " the amount of health of the hero must be 100.");
}
//}while (count != 100);

double hpHero = count;
try
{
    if (hpHero != 100)
    {
        throw new Exception("The health of the hero does not meet the conditions of the game");
    }

    else
    {
        Console.WriteLine($"Congratulations you have created a character {nameHero} with health {hpHero}.");
    }
}
catch (Exception heroHp)
{
    Console.WriteLine(heroHp);
}

//Dragon

Console.WriteLine("Enter the name of the Evil Dragon:");
string nameDragon = Console.ReadLine();

try
{
    if (nameDragon != "Sapfiron")
    {
        throw new Exception("The name of the hero does not match the lore of the game");
    }
}
catch (Exception dragonName)
{
    Console.WriteLine(dragonName);
}

double count1 = 0;

Console.WriteLine("Enter the amount of dragon health");
//do
//{
while (!double.TryParse(Console.ReadLine(), out count1))
{
    Console.WriteLine("Enter health in numbers. According to the rules of the game," +
        " the amount of health of the hero must be 100.");
}
//}while (count != 100);

double hpDragon = count1;
try
{
    if (hpDragon != 500)
    {
        throw new Exception("The health of the hero does not meet the conditions of the game");
    }

    else
    {
        Console.WriteLine($"Congratulations you have created a character {nameDragon} with health {hpDragon}.");
    }
}
catch (Exception dragonHp)
{
    Console.WriteLine(dragonHp);
}



Hero artur = new Hero(nameHero, hpHero);
Dragon sapfiron = new Dragon(nameDragon, hpDragon);

Console.WriteLine(artur.Name);
Console.WriteLine(artur.HP);
Console.WriteLine(sapfiron.Name);
Console.WriteLine(sapfiron.HP);

Weapon e = new Weapon();
e.Name = "Excalibur";
e.Damage = e.Excalibur();

artur.Inventory.Add(e);

double ex = artur.Inventory.Where(x => x.Name == "Excalibur").First().Damage;

artur.Bite(sapfiron);   

sapfiron.Incinerate(artur);

artur.Swordstrike(sapfiron);

sapfiron.Eat(artur);