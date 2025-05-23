namespace CommonLib.Results;

/// <summary>
/// Represents the result of an operation, indicating success or failure.
/// </summary>
public class Result
{
    /// <summary>
    /// Indicates whether the operation was successful.
    /// </summary>
    public bool Success { get; init; }

    /// <summary>
    /// Contains the error message if the operation failed.
    /// </summary>
    public string? Error { get; init; }

    /// <summary>
    /// Creates a successful result.
    /// </summary>
    public static Result Ok() => new() { Success = true };

    /// <summary>
    /// Creates a failed result with a specified error message.
    /// </summary>
    public static Result Fail(string error) => new() { Success = false, Error = error };
}

/// <summary>
/// Represents the result of an operation that returns a value.
/// </summary>
/// <typeparam name="T">The type of the returned value.</typeparam>
public class Result<T> : Result
{
    /// <summary>
    /// The value returned by the operation if successful.
    /// </summary>
    public T? Value { get; init; }

    /// <summary>
    /// Creates a successful result with a value.
    /// </summary>
    public static Result<T> Ok(T value) => new() { Success = true, Value = value };

    /// <summary>
    /// Creates a failed result with a specified error message.
    /// </summary>
    public static new Result<T> Fail(string error) => new() { Success = false, Error = error };
}
