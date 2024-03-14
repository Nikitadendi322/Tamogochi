namespace Tamagochi.Models;

/// <summary>
/// Питомец
/// </summary>
public class Pet
{
    /// <summary>
    /// Имя питомца
    /// </summary>
    public string Name { get; }
    
    private int _health;
    private int _hunger;
    private int _fatigue;

    /// <summary>
    /// Инициализирует экземпляр типа <see cref="Pet" />.
    /// </summary>
    /// <param name="name">Имя питомца.</param>
    public Pet(string name)
    {
        if (string.IsNullOrWhiteSpace(name))
        {
            throw new ArgumentNullException(nameof(name), "Имя питомца не может быть null или пустой строкой.");
        }
        
        Name = name;
        Health = 10;
        Fatigue = 0;
        Hunger = 0;
        LastEvent = PetEvent.Born;
    }

    /// <summary>
    /// Последнее событие питомца
    /// </summary>
    public PetEvent LastEvent { get; private set; }
    
    /// <summary>
    /// Уровень здоровья
    /// </summary>
    public int Health 
    {
        get => _health;
        private set
        {
            switch (value)
            {
                case >= 10:
                {
                    _health = 10;
                    LastEvent = PetEvent.Healthy;
                    break;
                }
                case <= 0:
                {
                    _health = 0;
                    LastEvent = PetEvent.Dead;
                    break;
                }
                default:
                {
                    _health = value;
                    break;
                }
            }
        }
    }
    
    
    /// <summary>
    /// Уровень голода
    /// </summary>
    public int Hunger
    {
        get => _hunger;
        private set
        {
            switch (value)
            {
                case > 10:
                {
                    _hunger = 10;
                    LastEvent = PetEvent.Hungry;
                    Health--;
                    break;
                }
                case 10:
                {
                    _hunger = value;
                    LastEvent = PetEvent.Hungry;
                    break;
                }
                case 0:
                {
                    _hunger = value;
                    LastEvent = PetEvent.WellFed;
                    break;
                }
                case < 0:
                {
                    _hunger = 0;
                    LastEvent = PetEvent.Gluttony;
                    Health--;
                    break;
                }
                default:
                {
                    _hunger = value;
                    break;
                }
            }
        }
    }

    /// <summary>
    /// Уровень усталости
    /// </summary>
    public int Fatigue
    {
        get => _fatigue;
        private set
        {
            switch (value)
            {
                case > 10:
                {
                    _fatigue = 10;
                    LastEvent = PetEvent.Tired;
                    Health--;
                    Hunger++;
                    break;
                }
                case <= 0:
                {
                    _fatigue = 0;
                    LastEvent = PetEvent.Cheerful;
                    Health++;
                    break;
                }
                default:
                {
                    _fatigue = value;
                    break;
                }
            }
        }
    }

    /// <summary>
    /// Уровень счастья
    /// </summary>
    public int Happiness => (int)Math.Round(((double)_health + (10 - _hunger) + (10 - _fatigue))/3, MidpointRounding.ToZero);

    /// <summary>
    /// Покормить
    /// </summary>
    public void Eat()
    {
        LastEvent = PetEvent.Ate;
        Hunger--;
    }

    /// <summary>
    /// Поиграть
    /// </summary>
    public void Play()
    {
        LastEvent = PetEvent.Played;
        Fatigue++;
    }

    /// <summary>
    /// Поспать
    /// </summary>
    public void Sleep()
    {
        LastEvent = PetEvent.Slept;
        Fatigue -= 10;
    }

    /// <summary>
    /// Полечить
    /// </summary>
    public void Heal()
    {
        Health += 2;
        Fatigue++;
        Hunger++;
    }
}