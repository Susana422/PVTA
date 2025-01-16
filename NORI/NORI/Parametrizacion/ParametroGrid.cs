using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NORI.Parametrizacion
{
    public class ParametroGrid
    {
        public int id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public bool Oculto { get; set; }
        public bool Desactivado { get; set; }
    }
}
