using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class CalificacionAlumno
    {
        private int? calificacionId;
        private string matricula;
        private string nombreCompleto;
        private float calificacionValor;

        public int? CalificacionId { get { return calificacionId; } set { calificacionId = value; } }
        public string Matricula { get { return matricula; } set { matricula = value; } }
        public string NombreCompleto { get { return nombreCompleto; } set {  nombreCompleto = value; } }
        public float CalificacionValor { get { return calificacionValor; } set { calificacionValor = value; } }
    }
}
