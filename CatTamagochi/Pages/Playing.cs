using Tamagochi.Abstractions;
using Tamagochi.Models;
using Tamagochi.Resources;

namespace Tamagochi.Pages;

public sealed class Playing(Pet pet) : IPage
{
    public void Draw()
    {
        Console.Clear();
        Console.WriteLine(pet.LastEvent.ToAscii());
        Console.Write("Pet: ");
        Console.WriteLine(pet.Name);
        Console.Write("Health: ");
        Console.WriteLine(pet.Health);
        Console.Write("Hunger: ");
        Console.WriteLine(pet.Hunger);
        Console.Write("Fatigue: ");
        Console.WriteLine(pet.Fatigue);
        Console.Write("Last event: ");
        Console.WriteLine(pet.LastEvent);
        Console.Write("Happiness: ");
        Console.WriteLine(pet.Happiness);
        Console.WriteLine();

        Console.WriteLine("1 - Feed");
        Console.WriteLine("2 - Play");
        Console.WriteLine("3 - Sleep");
        Console.WriteLine("4 - Heal");
    }

    public void GetKey()
    {
        var keyInfo = Console.ReadKey();

        switch (keyInfo.Key)
        {
            case ConsoleKey.D1:
            {
                pet.Eat();
                break;
            }
            case ConsoleKey.D2:
            {
                pet.Play();
                break;
            }
            case ConsoleKey.D3:
            {
                pet.Sleep();
                break;
            }
            case ConsoleKey.D4:
            {
                pet.Heal();
                break;
            }
        }

        if (pet.Health == 0 || pet.LastEvent == PetEvent.Dead)
        {
            NextPage = new GameOver();
        }
    }

    public IPage? NextPage { get; private set; }
}