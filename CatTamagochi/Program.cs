// See https://aka.ms/new-console-template for more information

using Tamagochi.Abstractions;
using Tamagochi.Pages;

IPage page = new StartGame();

do
{
    if (page.NextPage != null)
    {
        page = page.NextPage;
    }
    
    page.Draw();
    page.GetKey();
}
while (page.GetType() != typeof(GameOver));