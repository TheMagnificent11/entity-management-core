namespace EntityManagement.Abstractions
{
    /// <summary>
    /// Entity Interface
    /// </summary>
    /// <typeparam name="TId">ID type</typeparam>
    public interface IEntity<TId>
    {
        /// <summary>
        /// Gets the entity ID
        /// </summary>
        TId Id { get; }
    }
}
