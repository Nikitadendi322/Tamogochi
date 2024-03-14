namespace Tamagochi.Models;

/// <summary>
/// Состояния питомца
/// </summary>
public enum PetEvent
{
    /// <summary>
    /// Сытый
    /// </summary>
    WellFed = 1,
    
    /// <summary>
    /// Голодный
    /// </summary>
    Hungry,
    
    /// <summary>
    /// Переел
    /// </summary>
    Gluttony,
    
    /// <summary>
    /// Бодрый
    /// </summary>
    Cheerful,
    
    /// <summary>
    /// Уставший
    /// </summary>
    Tired,
    
    /// <summary>
    /// Здоров
    /// </summary>
    Healthy,
    
    /// <summary>
    /// Родился
    /// </summary>
    Born,
    
    /// <summary>
    /// Поиграл
    /// </summary>
    Played,
    
    /// <summary>
    /// Поел
    /// </summary>
    Ate,
    
    /// <summary>
    /// Поспал
    /// </summary>
    Slept,
    
    /// <summary>
    /// Умер
    /// </summary>
    Dead = 99
}