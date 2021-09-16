using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class ZonaBL
    {
        Contexto _contexto;
        List<Zona> lista;

        public ZonaBL()
        {
            _contexto = new Contexto();
            lista = new List<Zona>();
        }

        public List<Zona> obtenerZonas()
        {
            lista = _contexto.Zona.ToList();
            return lista;
        }
    }
}
