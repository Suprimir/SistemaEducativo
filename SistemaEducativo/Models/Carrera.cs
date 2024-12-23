﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Carrera
    {
        private int? id;
        private string nombreCarrera;
        private string descripcion;
        private int totalSemestres;

        public int? Id { get { return id; } set { id = value; } }

        public string NombreCarrera { get { return nombreCarrera; } set { nombreCarrera = value; } }

        public string Descripcion { get { return descripcion; } set { descripcion = value; } }

        public int TotalSemestres { get { return totalSemestres; } set { totalSemestres = value; } }

        public override string ToString()
        {
            return NombreCarrera;
        }
    }
}
