using Tamagochi.Abstractions;
using Tamagochi.Models;

namespace Tamagochi.Pages;

public sealed class StartGame : IPage
{
    private const string Header = """
                                  88888888888                                                         888      d8b 
                                      888                                                             888      Y8P 
                                      888                                                             888          
                                      888   8888b.  88888b.d88b.   8888b.   .d88b.   .d88b.   .d8888b 88888b.  888 
                                      888      "88b 888 "888 "88b     "88b d88P"88b d88""88b d88P"    888 "88b 888 
                                      888  .d888888 888  888  888 .d888888 888  888 888  888 888      888  888 888 
                                      888  888  888 888  888  888 888  888 Y88b 888 Y88..88P Y88b.    888  888 888 
                                      888  "Y888888 888  888  888 "Y888888  "Y88888  "Y88P"   "Y8888P 888  888 888 
                                                                            888                                
                                                                       Y8b d88P                                
                                                                        "Y88P"                                 
                                     
                                    ___   ______ __     __  ______                ___
                                   |__ |\ |||__ |__)   |__)|__  |    |\ | /\ |\/||__       
                                   |___| \|||___|  \   |   |___ |    | \|/~~\|  ||___
                                  """;

    private const int NamePositionLeft = 56;
    private const int NamePositionTop = 14;
    
    public void Draw()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write(Header);
        Console.WriteLine();
        Console.WriteLine();
    }

    public void GetKey()
    {
        Console.SetCursorPosition(NamePositionLeft, NamePositionTop);
        var petName = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(petName))
        {
            petName = "unnamed";
        }

        if (petName.Length > 20)
        {
            Console.Clear();
            Console.WriteLine("Max length of name - 20 symbols");
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
            return;
        }

        NextPage = new Playing(new Pet(petName));
    }

    public IPage? NextPage { get; private set; }
}