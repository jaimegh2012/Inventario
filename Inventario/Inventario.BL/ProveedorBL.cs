using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class ProveedorBL
    {
        Contexto _contexto;
        List<Proveedor> lista;

        public ProveedorBL()
        {
            _contexto = new Contexto();
            lista = new List<Proveedor>();
        }

        public List<Proveedor> obtenerProveedores()
        {
            lista = _contexto.Proveedores.ToList();
            return lista;
        }

    }
}
