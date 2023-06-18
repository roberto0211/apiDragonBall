
namespace Interface.Characters
{
    public interface ICharacter<T>
    {
        Task<T> ListCharacter(string name);
    }
}
