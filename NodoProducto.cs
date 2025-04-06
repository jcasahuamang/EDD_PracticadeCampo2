using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo2
{
    public class NodoProducto
    {
        public Productos info { get; set; }
        public NodoProducto sig { get; set; }
        public NodoProducto ant { get; set; }
    }
}
