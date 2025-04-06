using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticadeCampo2
{
    public class Productos
    {
        public int IdProducto { get; set; }
        public String Descripcion { get; set; }
        public int Stock { get; set; }
        public double Precio { get; set; }
        public bool Estado { get; set; }

        public Productos(int idProducto, string descripcion, int stock, double precio, bool estado)
        {
            IdProducto = idProducto;
            Descripcion = descripcion;
            Stock = stock;
            Precio = precio;
            Estado = estado;
        }
    }
}
