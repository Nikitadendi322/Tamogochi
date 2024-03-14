namespace Tamagochi.Abstractions;

/// <summary>
/// Описывает страницу игры
/// </summary>
public interface IPage
{
    /// <summary>
    /// Отрисовывает элементы страницы
    /// </summary>
    public void Draw();

    /// <summary>
    /// Обрабатывает ввод пользователя
    /// </summary>
    public void GetKey();
    
    /// <summary>
    /// Следующая страница игры
    /// </summary>
    public IPage? NextPage { get; } 
}