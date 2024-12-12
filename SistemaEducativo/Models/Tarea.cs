using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Tarea
    {
        private int? id;
        private int? semestre;
        private int parcial;
        private string titulo;
        private string descripcion;
        private DateTime fecha_Limite;
        private string? materiaNombre;

        public int? ID { get { return id; } set { id = value; } }
        public int? Semestre { get { return semestre; } set { semestre = value; } }
        public int Parcial { get { return parcial; } set { parcial = value; } }
        public string Titulo { get { return titulo; } set { titulo = value; } }
        public string Descripcion { get { return descripcion; } set { descripcion = value; } }
        public DateTime Fecha_Limite { get { return fecha_Limite; } set { fecha_Limite = value; } }
        public string? MateriaNombre { get { return materiaNombre; } set { materiaNombre = value; } }

        public override string ToString()
        {
            return Titulo;
        }
    }
}
