using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class disco
    {
        public string titulo { get; set; }
        public int canciones { get; set; }
        public string imagen { get; set; }
        public estilo estilo { get; set; }
        public Edicion edicion { get; set; }

    }
}
