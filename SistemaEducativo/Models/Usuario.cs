using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class Usuario
    {
        private int id;
        private int matricula;
        private string pass;

        public int Id { get { return id; } set { id = value; } }

        public int Matricula { get { return matricula; } set { matricula = value; } }

        public string Pass { get { return pass; } set { pass = value; } }
    }
}
