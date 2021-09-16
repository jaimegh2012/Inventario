using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class DatosDeInicio: CreateDatabaseIfNotExists<Contexto>
    {
        protected override void Seed(Contexto contexto)
        {
            var Proveedor1 = new Proveedor();
            Proveedor1.Descripcion = "Proveedor 1";
            contexto.Proveedores.Add(Proveedor1);
            base.Seed(contexto);

            var Proveedor2 = new Proveedor();
            Proveedor2.Descripcion = "Proveedor 2";

            contexto.Proveedores.Add(Proveedor2);
            base.Seed(contexto);


            var zona1 = new Zona();
            zona1.Descripcion = "Zona 1";
            contexto.Zona.Add(zona1);
            base.Seed(contexto);

            var zona2 = new Zona();
            zona2.Descripcion = "Zona 2";
            contexto.Zona.Add(zona2);
            base.Seed(contexto);

            var marca1 = new Marca();
            marca1.Descripcion = "Marca 1";
            contexto.Marcas.Add(marca1);
            base.Seed(contexto);

            var marca2 = new Marca();
            marca2.Descripcion = "Marca 2";
            contexto.Marcas.Add(marca2);
            base.Seed(contexto);

            var presentacion1 = new Presentacion();
            presentacion1.Descripcion = "Presentacion 1";
            contexto.Presentaciones.Add(presentacion1);
            base.Seed(contexto);


            var presentacion2 = new Presentacion();
            presentacion2.Descripcion = "Presentacion 2";
            contexto.Presentaciones.Add(presentacion2);
            base.Seed(contexto);




        }
    }
}
