using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class MarcaBL
    {
        Contexto _contexto;
        List<Marca> lista;

        public MarcaBL()
        {
            _contexto = new Contexto();
            lista = new List<Marca>();
        }

        public List<Marca> obtenerMarcas()
        {
            lista = _contexto.Marcas.ToList();
           return lista;
        }

    }
}
