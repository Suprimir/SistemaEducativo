using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEducativo.Models
{
    internal class Semestre
    {
        private int semestreId;
        private int generacionId;
        private int nivelSemestral;
        
        public int SemestreId { get { return semestreId; } set { semestreId = value; } }
        public int GeneracionId { get {return generacionId; } set { generacionId = value; } }
        public int NivelSemestral { get { return nivelSemestral; } set { nivelSemestral = value; } }
    }
}
