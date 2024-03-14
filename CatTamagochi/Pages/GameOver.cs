using Tamagochi.Abstractions;
using Tamagochi.Models;
using Tamagochi.Resources;

namespace Tamagochi.Pages;

/// <summary>
/// Экран "Игра окончена"
/// </summary>
public sealed class GameOver : IPage
{
    /// <inheritdoc />
    public void Draw()
    {
        Console.Clear();
        Console.WriteLine(PetEvent.Dead.ToAscii());
        Console.WriteLine("Oh no, the cat has gone");
        Console.WriteLine("Press any key to exit...");
    }

    /// <inheritdoc />
    public void GetKey()
    {
        Console.ReadKey();
        NextPage = new StartGame();
    }

    /// <inheritdoc />
    public IPage? NextPage { get; private set; }
}