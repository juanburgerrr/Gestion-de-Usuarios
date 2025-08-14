using System;
using Datos;

namespace Logica
{
    public class PermisosAsignar
    {
        private readonly Datos.PermisosAsignar _datos;

        public PermisosAsignar()
        {
            _datos = new Datos.PermisosAsignar();
        }

        public void Asignar(int idUsuario, int idPermiso, DateTime fechaVto)
        {
            _datos.AsignarPermiso(idUsuario, idPermiso, fechaVto);
        }
    }
}

