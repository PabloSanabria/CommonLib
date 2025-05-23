namespace CommonLib.Extensions;

/// <summary>
/// Extension methods for the DateTime type.
/// </summary>
public static class DateTimeExtensions
{
    /// <summary>
    /// Calculates the age in years based on a birth date.
    /// </summary>
    /// <param name="birthDate">The date of birth.</param>
    /// <returns>The calculated age in years.</returns>
    public static int GetAge(this DateTime birthDate)
    {
        var today = DateTime.Today;
        var age = today.Year - birthDate.Year;
        if (birthDate.Date > today.AddYears(-age)) age--;
        return age;
    }
}
