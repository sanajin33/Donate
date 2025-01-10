using System.Text.Json;

namespace Donate.Data.Extensions;

public static class ObjectExtensions
{
    public static T? Clone<T>(this object obj) => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(obj));
    public static T? Clone<T>(this T obj) => JsonSerializer.Deserialize<T>(JsonSerializer.Serialize(obj));
}
