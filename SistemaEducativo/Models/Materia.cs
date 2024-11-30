using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Materia
    {
        private int? id;
        private string nombreCarrera;
        private int semestre;
        private string nombreMateria;
        private string descripcion;

        public int? Id { get { return id; } set { id = value; } }
        public string NombreCarrera { get { return nombreCarrera; } set { nombreCarrera = value; } }
        public int Semestre { get { return semestre; } set { semestre = value; } }
        public string NombreMateria { get { return nombreMateria; } set { nombreMateria = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
    }
}
