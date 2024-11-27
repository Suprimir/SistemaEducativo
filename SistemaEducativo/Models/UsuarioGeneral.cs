using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class UsuarioGeneral
    {
        private int id;
        private string matricula;
        private string pass;
        private string nombreCompleto;
        private string correo;
        private string rol;

        public int Id { get { return id; } set { id = value; } } 
        public string Matricula { get { return matricula; } set { matricula = value; } }
        public string Pass { get { return pass; } set { pass = value; } }
        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }
        public string Correo { get { return correo; } set { correo = value; } }
        public string Rol { get { return rol; } set { rol = value; } }
    }
}
