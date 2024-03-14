using Tamagochi.Models;

namespace Tamagochi.Resources;

public static class PetEventResource
{
    private static readonly Dictionary<PetEvent, string> Ascii = new()
    {
        {
            PetEvent.Hungry,
            """
              ("`-''-/").___..--''"`-._
               `6_ 6  )   `-.  (     ).`-.__.`)
               (_Y_.)'  ._   )  `._ `. ``-..-'
             _..`--'_..-_/  /--'_.' ,'
            (il).-''  (li).'  ((!.-'
            """
        },
        {
            PetEvent.Slept,
            """
             |\__/,|   (`\
             |_ _  |.--.) )
             ( T   )     /
            (((^_(((/(((_>
            """
        },
        {
            PetEvent.Played,
            """
               _.-|   |          |\__/,|   (`\
              {   |   |          |o o  |__ _) )
               "-.|___|        _.( T   )  `  /
                .--'-`-.     _((_ `^--' /_<  \
              .+|______|__.-||__)`-'(((/  (((/
            """
        },
        {
            PetEvent.Tired,
            """
             _,,/|
             \o o'
             =_~_=
             /   \ (\
            (////_)//
            ~~~
            """
        },
        {
            PetEvent.Gluttony,
            """
             /\___/\
            ( o   o )
            (  =^=  )
            (        )
            (         )
            (          )))))))))))
            """
        },
        {
            PetEvent.Cheerful,
            """
               /\     /\
              {  `---'  }
              {  O   O  }
            ~~|~   V   ~|~~
               \  \|/  /
                `-----'__
                /     \  `^\_
               {       }\ |\_\_   W
               |  \_/  |/ /  \_\_( )
                \__/  /(_E     \__/
                  (  /
                   MM
            """
        },
        {
            PetEvent.Ate,
            """
                        |\__/,|   (`\
                        |o o  |__ _) )
                      _.( T   )  `  /
            n n._    ((_ `^--' /_<  \
            <" _ }=- `` `-'(((/  (((/
            """
        },
        {
            PetEvent.Dead,
            """
                   .^----^.
                  (= x  X =)
                   (___V__)
                    _|==|_
               ___/' |--| |
              / ,._| |  | '
             | \__ |__}-|__}
              \___)`
            """
        }
    };

    /// <summary>
    /// Преобразует тип события питомца в Ascii рисунок
    /// </summary>
    /// <param name="petEvent">Тип события питомца</param>
    public static string ToAscii(this PetEvent petEvent)
    {
        return Ascii.GetValueOrDefault(petEvent, """
                                                   |\_._/|
                                                   | o o |
                                                   (  T  )
                                                  .^`-^-'^.
                                                  `.  ;  .'
                                                  | | | | |
                                                 ((_((|))_))
                                                 """);
    }
}