using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class GrupoProfesor : Grupo
    {
        private string materia;

        public string Materia { get { return materia; } set { materia = value; } }
    }
}
