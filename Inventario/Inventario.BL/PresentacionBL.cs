using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class PresentacionBL
    {
        Contexto _contexto;
        List<Presentacion> lista;

        public PresentacionBL()
        {
            _contexto = new Contexto();
            lista = new List<Presentacion>();
        }

        public List<Presentacion> obtenerPresentaciones()
        {
            lista = _contexto.Presentaciones.ToList();
            return lista;
        }
    }
}
