namespace CommonLib.Abstractions;

/// <summary>
/// Generic repository interface defining basic CRUD operations.
/// </summary>
/// <typeparam name="T">The type of the entity.</typeparam>
public interface IRepository<T>
{
    /// <summary>
    /// Retrieves an entity by its unique identifier.
    /// </summary>
    T? GetById(Guid id);

    /// <summary>
    /// Retrieves all entities.
    /// </summary>
    IEnumerable<T> GetAll();

    /// <summary>
    /// Adds a new entity to the data source.
    /// </summary>
    void Add(T entity);

    /// <summary>
    /// Updates an existing entity.
    /// </summary>
    void Update(T entity);

    /// <summary>
    /// Deletes an entity by its unique identifier.
    /// </summary>
    void Delete(Guid id);
}
