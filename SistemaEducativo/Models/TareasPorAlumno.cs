﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class TareasPorAlumno
    {
        private int id;
        private string nombreAlumno;
        private string pathArchivoTarea;
        private DateTime fechaEntregada;
        private string estado;

        public int ID { get { return id; } set { id = value; } }
        public string NombreAlumno { get { return nombreAlumno; } set { nombreAlumno = value; } }
        public string PathArchivoTarea { get { return pathArchivoTarea; } set { pathArchivoTarea = value; } }
        public DateTime FechaEntregada { get { return fechaEntregada; } set { fechaEntregada = value; } }
        public string Estado { get { return estado; } set { estado = value; } }
    }
}
