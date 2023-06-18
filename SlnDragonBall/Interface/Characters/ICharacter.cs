
namespace Interface.Characters
{
    public interface ICharacter<T>
    {
        Task<T> GetCharacter(string name);
    }
}
