using SistemaEducativo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Sesion
{
    public class SesionUsuario
    {
        private static SesionUsuario _instancia;

        public string Matricula { get; private set; }
        public string NombreUsuario { get; private set; }
        public string Rol { get; private set; }

        private SesionUsuario() { }

        public static SesionUsuario Instancia
        {
            get
            {
                if (_instancia == null)
                {
                    _instancia = new SesionUsuario();
                }
                return _instancia;
            }
        }

        public void IniciarSesion(Usuario usuario)
        {
            Matricula = usuario.Matricula;
            NombreUsuario = usuario.Nombre;
            Rol = usuario.Rol;
        }

        public void CerrarSesion()
        {
            Matricula = null;
            NombreUsuario = null;
            Rol = null;
        }
    }

}
