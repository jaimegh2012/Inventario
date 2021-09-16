using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario.BL
{
    public class ProductoBL
    {
        Contexto _contexto;
        List<Producto> listaProductos;

        public ProductoBL()
        {
            _contexto = new Contexto();
            listaProductos = new List<Producto>();
        }

        public List<Producto> obtenerProductos()
        {
            listaProductos = _contexto.Productos.Include("Marca").Include("Presentacion").Include("Proveedor").Include("Zona")
                .OrderBy(a => a.DescripcionProducto).ToList(); 
            return listaProductos;
        }

        


        public Producto obtenerProducto(int id)
        {
            var producto = _contexto.Productos.Include("Marca").Include("Presentacion").Include("Proveedor").Include("Zona").FirstOrDefault(a => a.Id == id);
            return producto;
        }

        public void guardarProducto(Producto producto)
        {
            if (producto.Id == 0)
            {
                _contexto.Productos.Add(producto);
            }
            else
            {
                var productoExistente = _contexto.Productos.Find(producto.Id);
                productoExistente.IdMarca = producto.IdMarca;
                productoExistente.IdPresentacion = producto.IdPresentacion;
                productoExistente.IdProveedor = producto.IdProveedor;
                productoExistente.IdZona = producto.IdZona;
                productoExistente.DescripcionProducto = producto.DescripcionProducto;
                productoExistente.Codigo = producto.Codigo;
                productoExistente.IVA = producto.IVA;
                productoExistente.Precio = producto.Precio;
                productoExistente.Stock = producto.Stock;
                productoExistente.Peso = producto.Peso;

            }

            _contexto.SaveChanges();

        }

        public void eliminarProducto(int id)
        {
            var producto = _contexto.Productos.Find(id);
            _contexto.Productos.Remove(producto);
            _contexto.SaveChanges();
        }
    }
}
