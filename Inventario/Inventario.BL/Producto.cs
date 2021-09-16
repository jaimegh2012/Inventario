using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class Producto
    {
        public int Id { get; set; }
        public Marca Marca { get; set; }
        public int IdMarca { get; set; }
        public Presentacion Presentacion { get; set; }
        public int IdPresentacion { get; set; }
        public Proveedor Proveedor { get; set; }
        public int IdProveedor { get; set; }
        public Zona Zona { get; set; }
        public int IdZona { get; set; }
        public string Codigo { get; set; }
        public string DescripcionProducto { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public decimal IVA { get; set; }
        public decimal Peso { get; set; }
    }
}
