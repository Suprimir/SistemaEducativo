using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class Carrera
    {
        private int carreraID;
        private string nombreCarrera;
        private string descripcion;

        public int CarreraID { get { return carreraID; } set { carreraID = value; } }

        public string NombreCarrera { get { return nombreCarrera; } set { nombreCarrera = value; } }

        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
    }
}
