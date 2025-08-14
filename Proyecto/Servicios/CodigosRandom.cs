using System;
using System.Text;

namespace Servicios.RandomPass
{
    public static class RandomPass
    {
        /// <summary>
        /// Clase para armar contraseñas o códigos numéricos aleatorios de longitud variable.
        /// </summary>
        public static class Aleatorios
        {
            /// <summary>
            /// Genera una contraseña aleatoria.
            /// </summary>
            /// <param name="EsCaracteres">True si es alfanumérico, false si es solo numérico.</param>
            /// <param name="Cant">Cantidad de caracteres totales.</param>
            /// <param name="CantCaractEspeciales">Cantidad de caracteres especiales (si es alfanumérico).</param>
            /// <returns>Contraseña generada.</returns>
            public static string Armar(bool EsCaracteres, int Cant, int CantCaractEspeciales = 0)
            {
                if (!EsCaracteres)
                {
                    string numeros = "0123456789";
                    StringBuilder resultado = new StringBuilder();
                    Random random = new Random();

                    for (int i = 0; i < Cant; i++)
                    {
                        resultado.Append(numeros[random.Next(numeros.Length)]);
                    }

                    return resultado.ToString();
                }
                else
                {
                    // Incluye letras, números y caracteres especiales
                    string letras = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
                    string numeros = "0123456789";
                    string especiales = "!@#$%^&*";

                    string todos = letras + numeros;
                    StringBuilder resultado = new StringBuilder();
                    Random random = new Random();

                    // Agrega caracteres normales
                    for (int i = 0; i < Cant - CantCaractEspeciales; i++)
                    {
                        resultado.Append(todos[random.Next(todos.Length)]);
                    }

                    // Agrega caracteres especiales
                    for (int i = 0; i < CantCaractEspeciales; i++)
                    {
                        resultado.Append(especiales[random.Next(especiales.Length)]);
                    }

                    // Mezcla los caracteres para mayor aleatoriedad
                    return new string(resultado.ToString().ToCharArray().OrderBy(x => random.Next()).ToArray());
                }
            }
        }
    }
}
