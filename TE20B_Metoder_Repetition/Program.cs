using System;

// Console.WriteLine("Hello");

// string n = Console.ReadLine();

// string n = GetName();

int dmg = Attack(99, 500);



Console.ReadLine();


static string GetName()
{
  Console.WriteLine("Skriv ditt namn:");
  string name = Console.ReadLine();

  return name;
}

static int Attack(int minDmg, int maxDmg)
{
  Random generator = new Random();
  int damage = generator.Next(minDmg, maxDmg);
  Console.WriteLine($"You do {damage} damage!");

  return damage;
}