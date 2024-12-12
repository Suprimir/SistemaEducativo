using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class Calificacion
    {
        private int id;
        private string materia;
        private int parcial;
        private int semestre;
        private string semestreTexto;
        private double calificacionNumero;
        private bool aprobatorio;

        public int Id { get { return id; } set { id = value; } }
        public string Materia { get { return materia; } set { materia = value; } }
        public int Parcial { get { return parcial; } set { parcial = value; } }
        public int Semestre { get { return semestre; } set { semestre = value; } }
        public string SemestreTexto { get { return semestreTexto; } set { semestreTexto = value; } }
        public double CalificacionNumero { get { return calificacionNumero; } set { calificacionNumero = value; } }
        public bool Aprobatorio { get { return aprobatorio; } set { aprobatorio = value; } }
    }
}
