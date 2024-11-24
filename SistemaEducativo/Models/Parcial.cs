using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class Parcial
    {
        private int parcialId;
        private int semestreId;
        private int nivelParcial;

        public int ParcialId { get { return parcialId; } set { parcialId = value; } }
        public int SemestreId { get {return semestreId; } set { semestreId = value; } }
        public int NivelParcial { get { return nivelParcial; } set { nivelParcial = value; } }
    }
}
