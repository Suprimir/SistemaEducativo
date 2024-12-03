using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class TareaPorAlumno
    {
        private int? id;
        private int alumnoID;
        private string pathArchivoTarea;
        private DateTime fechaEntregada;
        private string estado;

        public int? ID { get { return id; } set { id = value; } }
        public int AlumnoID { get { return alumnoID; } set { alumnoID = value; } }
        public string PathArchivoTarea { get { return pathArchivoTarea; } set { pathArchivoTarea = value; } }
        public DateTime FechaEntregada { get { return fechaEntregada; } set { fechaEntregada = value; } }
        public string Estado { get { return estado; } set { estado = value; } }

        public override string ToString()
        {
            return "Hola";
        }
    }
}
