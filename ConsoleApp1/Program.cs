using System.ComponentModel.DataAnnotations;

int hjälteHp = 100;
int skurkHp = 100;
int slag = 1;
Console.WriteLine("Peter och Kalle bråkar på skolgården och det bryter ut ett slagsmål, tryck på valfri knapp för att fortsätta");
Console.ReadKey();

while(hjälteHp > 0 && skurkHp > 0)
{
    Console.WriteLine($"\n----- ===== SLAG {slag} ===== -----");
    Console.WriteLine($"Peter: {hjälteHp} HP  Kalle: {skurkHp} HP\n");
    slag += 1;
    int hjälteskada = Random.Shared.Next(20);

if (hjälteskada == 0)
{
    Console.WriteLine("Peter missade sitt slag");
}
else
{
    skurkHp -= hjälteskada;
    skurkHp = Math.Max(skurkHp, 0);
    Console.WriteLine($"Peter gör {hjälteskada} skada på Kalle");
}
    int skurkskada = Random.Shared.Next(20);

if (skurkskada == 0)
{
    Console.WriteLine("Kalle missade sitt slag");
}
else
{
    hjälteHp -= skurkskada;
    hjälteHp = Math.Max(hjälteHp, 0);
    Console.WriteLine($"Kalle gör {skurkskada} skada på Peter");
    Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
    Console.ReadKey();
   } 
}

Console.WriteLine("\n----- ===== SLAGSMÅLET ÄR SLUT ===== -----");

if (hjälteHp == 0 && skurkHp == 0)
{
  Console.WriteLine("OAVGJORT");
}
else if (hjälteHp == 0)
{
  Console.WriteLine("Kalle vann!");
}
else
{
  Console.WriteLine("Peter vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();
