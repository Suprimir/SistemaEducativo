using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Materia
    {
        private int materiaId;
        private string nombreCarrera;
        private int semestre;
        private string nombreMateria;
        private string descripcion;

        public int MateriaId { get { return materiaId; } set { materiaId = value; } }
        public string NombreCarrera { get { return nombreCarrera; } set { nombreCarrera = value; } }
        public int Semestre { get { return semestre; } set { semestre = value; } }
        public string NombreMateria { get { return nombreMateria; } set { nombreMateria = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
    }
}
