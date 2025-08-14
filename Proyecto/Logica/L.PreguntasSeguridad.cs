using Datos.PreguntasSeguridad;
using System;
using System.Data;

namespace Logica
{
    public class LPreguntasSeguridad
    {
        private readonly PreguntasSeguridad _preguntasDatos;

        public LPreguntasSeguridad()
        {
            _preguntasDatos = new PreguntasSeguridad();
        }

        public DataTable ObtenerPreguntasDisponibles()
        {
            try
            {
                return _preguntasDatos.ObtenerPreguntasSeguridad();
            }
            catch (Exception ex)
            {
                // Log del error
                Console.WriteLine("Error en lógica al obtener preguntas: " + ex.Message);
                throw new Exception("No se pudieron cargar las preguntas de seguridad. Por favor intente más tarde.");
            }
        }

        public string RegistrarRespuestasUsuario(int idUsuario,
        int id1, string r1, int id2, string r2, int id3, string r3, int id4, string r4,
        int id5, string r5, int id6, string r6, int id7, string r7, int id8, string r8)
        {
            // Validaciones mínimas
            string[] respuestas = { r1, r2, r3, r4, r5, r6, r7, r8 };
            if (respuestas.Any(r => string.IsNullOrWhiteSpace(r)))
                return "ERROR_RESPUESTAS_VACIAS";

            if (respuestas.Any(r => r.Length < 3))
                return "ERROR_RESPUESTAS_CORTAS";

            var ids = new HashSet<int> { id1, id2, id3, id4, id5, id6, id7, id8 };
            if (ids.Count < 8)
                return "ERROR_PREGUNTAS_REPETIDAS";

            try
            {
                return _preguntasDatos.GuardarRespuestasSeguridad(idUsuario, id1, r1, id2, r2, id3, r3, id4, r4, id5, r5, id6, r6, id7, r7, id8, r8);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar respuestas: " + ex.Message);
                return "ERROR_SERVIDOR";
            }
        }

    }
}