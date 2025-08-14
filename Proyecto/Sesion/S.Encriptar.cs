﻿using System.Security.Cryptography;
using System.Text;

namespace Servicios.Encriptacion
{
    public class Encriptacion
    {
        public string Encriptar(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder builder = new StringBuilder();
                foreach (var b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
    }
}