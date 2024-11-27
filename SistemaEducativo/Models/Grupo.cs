using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Grupo
    {
        private int grupoID;
        private string carrera;
        private string nombreGrupo;
        private int semestreActual;
        private DateTime fechaInicio;

        public int GrupoID { get { return grupoID; } set { grupoID = value; } }

        public string Carrera { get { return carrera; } set { carrera = value; } }

        public string NombreGrupo { get { return nombreGrupo; } set { nombreGrupo = value; } }

        public int SemestreActual { get { return semestreActual; } set { semestreActual = value; } }

        public DateTime FechaInicio { get { return fechaInicio; } set { fechaInicio = value; } }
    }
}
