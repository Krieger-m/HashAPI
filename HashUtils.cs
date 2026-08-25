using Microsoft.VisualBasic;
using System.Security.Cryptography;
using System.Text;

namespace HashAPI.Utils;

class HashUtils
{
    public static string HexHash(int number)
    {
        var sha_hash = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(number.ToString());
        var hashed_bytes = sha_hash.ComputeHash(bytes);
        string hashed_string = Convert.ToHexString(hashed_bytes);
        return hashed_string;
    }

    public static string Base64Hash(int number)
    {
        var sha_hash = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(number.ToString());
        var hashed_bytes = sha_hash.ComputeHash(bytes);
        string hashed_string = Convert.ToBase64String(hashed_bytes);
        return hashed_string;
    }
}