using System.Security.Cryptography;
using System.Text;

namespace AuthServiceIN6BV.Application.Services;

public class UuIdGenerator
{
    private static readonly string Alphabet = "123456789ABCDEFGHJKMNPQRSTUVWXYZabcdefghijkmnpqrstuvwxyz";

    public static string GenerateShortUUID(int length = 10)
    {
        using var rng = RandomNumberGenerator.Create();
        var bytes = new byte[12];
        rng.GetBytes(bytes);

        
    }
}