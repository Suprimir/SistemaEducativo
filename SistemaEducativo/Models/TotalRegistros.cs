using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class TotalRegistros
    {
        private int totalGrupos;
        private int totalUsuarios;
        private int totalAlumnos;
        private int totalMaestros;
        private int totalAdmins;
        private int totalMaterias;

        public int TotalGrupos { get { return totalGrupos; } set { totalGrupos = value; } }
        public int TotalUsuarios { get { return totalUsuarios; } set { totalUsuarios = value; } }
        public int TotalAlumnos { get { return totalAlumnos; } set { totalAlumnos = value; } }
        public int TotalMaestros { get { return totalMaestros; } set { totalMaestros = value; } }
        public int TotalAdmins { get { return totalAdmins; } set { totalAdmins = value; } }
        public int TotalMaterias { get { return totalMaterias; } set { totalMaterias = value; } }
    }
}
