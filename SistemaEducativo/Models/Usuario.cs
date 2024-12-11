using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Usuario
    {
        private int? id;
        private string matricula;
        private string? carrera;
        private string pass;
        private string nombreCompleto;
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string correo;
        private string rol;
        private int? grupoId;
        private string? pathFotoPerfil;

        public int? Id { get { return id; } set { id = value; } }

        public string Matricula { get { return matricula; } set { matricula = value; } }

        public string? Carrera { get { return carrera; } set { carrera = value; } }

        public string Pass { get { return pass; } set { pass = value; } }

        public string NombreCompleto { get { return nombreCompleto; } set { nombreCompleto = value; } }

        public string Nombre { get { return nombre; } set { nombre = value; } }

        public string ApellidoP { get { return apellidoP; } set { apellidoP = value; } }

        public string ApellidoM { get { return apellidoM; } set { apellidoM = value; } }

        public string Correo { get { return correo; } set { correo = value; } }

        public string Rol { get { return rol; } set { rol = value; } }

        public int? GrupoId { get { return grupoId; } set { grupoId = value; } }

        public string? PathFotoPerfil { get { return pathFotoPerfil; } set {  pathFotoPerfil = value; } }

        public override string ToString()
        {
            return $"{Matricula} - {NombreCompleto}";
        }
    }
}
