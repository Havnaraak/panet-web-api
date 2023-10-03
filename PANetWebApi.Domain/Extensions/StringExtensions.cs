namespace PANetWebApi.Domain.Extensions;

public static class StringExtensions
{
    public static string OnlyNumbers(this string value)
    {
        return string.IsNullOrEmpty(value) 
            ? value.Trim()
            : string.Concat(value.Trim().Where(char.IsDigit));
    }
}