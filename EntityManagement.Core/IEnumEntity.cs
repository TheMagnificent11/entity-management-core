using System;

namespace EntityManagement.Abstractions
{
    /// <summary>
    /// Enum Entity Interface
    /// </summary>
    /// <typeparam name="TKey">Enum key type</typeparam>
    public interface IEnumEntity<TKey> : IEntity<TKey>
        where TKey : struct, IConvertible, IComparable
    {
        /// <summary>
        /// Gets the enum item's name
        /// </summary>
        string Name { get; }
    }
}
