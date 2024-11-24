using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    public class Generacion
    {
        private int generacionID;
        private int carreraID;
        private string carreraNombre;
        private string nombreGeneracion;
        private int semestreActual;

        public int GeneracionID { get { return generacionID; } set { generacionID = value; } }

        public int CarreraID { get { return carreraID; } set { carreraID = value; } }

        public string NombreGeneracion { get { return nombreGeneracion; } set { nombreGeneracion = value; } }

        public int SemestreActual { get { return semestreActual; } set { semestreActual = value; } }
    }
}
