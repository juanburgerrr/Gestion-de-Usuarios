using System;
using Datos.Registro;
using Datos.Legajo;
using Datos.DTO;
using Servicios.Hash256;

namespace Logica.Registro
{
    public class PersonalLogica
    {
        private readonly DRegistro _registro;
        private readonly DLegajo _legajo;

        public PersonalLogica()
        {
            _registro = new DRegistro();
            _legajo = new DLegajo();
        }

        public bool RegistrarNuevoPersonal(
            string nombre,
            string apellido,
            char sexo,
            string genero,
            DateTime fechaNacimiento,
            string tipoDocDescripcion,
            int nroDoc,
            string cuil,
            string correo,
            int telefono,
            string localidad,
            string calle,
            int nro,
            int? piso,
            string depto,
            string nombreUsuario,
            string password,
            string rolDescripcion
        )
        {
            try
            {
                UsuarioDTO dto = new UsuarioDTO
                {
                    Nombre = nombre,
                    Apellido = apellido,
                    Sexo = sexo,
                    GeneroDescripcion = genero,
                    FechaNacimiento = fechaNacimiento,
                    TipoDocDescripcion = tipoDocDescripcion,
                    NroDoc = nroDoc,
                    Cuil = cuil,
                    Correo = correo,
                    Telefono = telefono,
                    LocalidadDescripcion = localidad,
                    Calle = calle,
                    Nro = nro,
                    Piso = piso,
                    Depto = depto,
                    NombreUsuario = nombreUsuario,
                    Password = password,
                    Rol = rolDescripcion
                };

                dto.Legajo = _legajo.ObtenerSiguienteLegajo();


                string passHash = Hashing.HashUserPassword(dto.NombreUsuario, dto.Password);

                return _registro.RegistrarPersonalYUsuario(
                    dto.Legajo,
                    dto.Nombre,
                    dto.Apellido,
                    dto.Sexo.ToString(),
                    dto.GeneroDescripcion,
                    dto.FechaNacimiento,
                    dto.TipoDocDescripcion,
                    dto.NroDoc,
                    dto.Cuil,
                    dto.Correo,
                    dto.Telefono,
                    dto.LocalidadDescripcion,
                    dto.Calle,
                    dto.Nro,
                    dto.Piso,
                    dto.Depto,
                    dto.NombreUsuario,
                    passHash, 
                    dto.Rol
                );
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error en la lógica de registro de personal: {ex.Message}");
                return false;
            }
        }
    }
}
