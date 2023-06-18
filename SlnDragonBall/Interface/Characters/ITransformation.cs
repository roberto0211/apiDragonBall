namespace Interface.Characters
{
    public interface ITransformation<T>
    {
        Task<List<T>> ListTransformations(int idCharacter);
    }
}
