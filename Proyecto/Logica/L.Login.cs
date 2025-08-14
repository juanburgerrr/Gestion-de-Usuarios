using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Login;
using Servicios.Encriptacion;

namespace Logica.Login
{
    public class LLogin
    {
        private readonly Datos.Login.DSP_ValidarLogin _login;
        private readonly Encriptacion _encriptar;
        public LLogin()
        {
            _login = new Datos.Login.DSP_ValidarLogin();
            _encriptar = new Encriptacion();
        }
        public (string? estado, int? idUsuario) Validar(string usuario, string password)
        {

            string passwordHash = _encriptar.Encriptar(usuario + password);
            return _login.ValidarLogin(usuario, passwordHash);
        }

    }
}