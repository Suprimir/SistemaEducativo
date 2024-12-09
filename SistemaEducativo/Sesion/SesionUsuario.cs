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

        public int? Id { get; private set; }
        public string Matricula { get; private set; }
        public string Carrera { get; private set; }
        public int? GrupoID { get; private set; }
        public string NombreUsuario { get; private set; }
        public string Rol { get; private set; }
        public string PathImagen { get; private set; }

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
            Id = usuario.Id;
            Matricula = usuario.Matricula;
            Carrera = usuario.Carrera;
            GrupoID = usuario.GrupoId;
            NombreUsuario = usuario.Nombre;
            Rol = usuario.Rol;
            PathImagen = usuario.PathFotoPerfil;
        }

        public void CerrarSesion()
        {
            Id = null;
            Matricula = null;
            Carrera = null;
            GrupoID = null;
            NombreUsuario = null;
            Rol = null;
            PathImagen = null;
        }
    }

}
