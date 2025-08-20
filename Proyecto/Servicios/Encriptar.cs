using System.Security.Cryptography;
using System.Text;

namespace Servicios.Hash256
{
    public static class Hashing
    {
        public static string SHA256(string input)
        {
            using var sha = SHA256Managed.Create();
            var bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(input));
            var sb = new StringBuilder();
            foreach (var b in bytes) sb.Append(b.ToString("x2"));
            return sb.ToString();
        }

        //concatena usuario + contraseña 
        public static string HashUserPassword(string userName, string plainPassword)
            => SHA256($"{userName}{plainPassword}");
    }
}
