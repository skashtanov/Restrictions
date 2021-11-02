namespace Restrictions
{
    public interface IRestriction
    {
        public bool Satisfied { get; }
    }

    public interface IRestriction<T>
    {
        public bool SatisfiedBy(T value);
    }
}
