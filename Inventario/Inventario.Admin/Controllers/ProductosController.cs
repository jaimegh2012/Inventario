using Inventario.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Admin.Controllers
{
    public class ProductosController : Controller
    {
        ProductoBL _productoBL;
        MarcaBL _marcaBL;
        ProveedorBL _proveedorBL;
        ZonaBL _zonaBL;
        PresentacionBL _presentacionBL;
        List<Producto> listaProductos;
        public ProductosController()
        {
            _productoBL = new ProductoBL();
            listaProductos = new List<Producto>();
            _marcaBL = new MarcaBL();
            _proveedorBL = new ProveedorBL();
            _zonaBL = new ZonaBL();
            _presentacionBL = new PresentacionBL();
        }

        // GET: Productos
        public ActionResult Index()
        {
            listaProductos = _productoBL.obtenerProductos();
            return View(listaProductos);
        }

        public ActionResult Crear()
        {
            var nuevoProducto = new Producto();

            var proveedores = _proveedorBL.obtenerProveedores();
            var zonas = _zonaBL.obtenerZonas();
            var marcas = _marcaBL.obtenerMarcas();
            var presentaciones = _presentacionBL.obtenerPresentaciones();


            ViewBag.IdProveedor = new SelectList(proveedores, "Id", "Descripcion");
            ViewBag.IdZona = new SelectList(zonas, "Id", "Descripcion");
            ViewBag.IdMarca = new SelectList(marcas, "Id", "Descripcion");
            ViewBag.IdPresentacion = new SelectList(presentaciones, "Id", "Descripcion");

            return View(nuevoProducto);
        }

        [HttpPost]
        public ActionResult Crear(Producto producto)
        {
            var proveedores = _proveedorBL.obtenerProveedores();
            var zonas = _zonaBL.obtenerZonas();
            var marcas = _marcaBL.obtenerMarcas();
            var presentaciones = _presentacionBL.obtenerPresentaciones();

            if (ModelState.IsValid)
            {

                _productoBL.guardarProducto(producto);
                return RedirectToAction("Index");
            }

            ViewBag.IdProveedor = new SelectList(proveedores, "Id", "Descripcion");
            ViewBag.IdZona = new SelectList(zonas, "Id", "Descripcion");
            ViewBag.IdMarca = new SelectList(marcas, "Id", "Descripcion");
            ViewBag.IdPresentacion = new SelectList(presentaciones, "Id", "Descripcion");

            return View(producto);
        }

        public ActionResult Editar(int id)
        {
            var producto = _productoBL.obtenerProducto(id);

            var proveedores = _proveedorBL.obtenerProveedores();
            var zonas = _zonaBL.obtenerZonas();
            var marcas = _marcaBL.obtenerMarcas();
            var presentaciones = _presentacionBL.obtenerPresentaciones();

            ViewBag.IdProveedor = new SelectList(proveedores, "Id", "Descripcion");
            ViewBag.IdZona = new SelectList(zonas, "Id", "Descripcion");
            ViewBag.IdMarca = new SelectList(marcas, "Id", "Descripcion");
            ViewBag.IdPresentacion = new SelectList(presentaciones, "Id", "Descripcion");

            return View(producto);
        }

        [HttpPost]
        public ActionResult Editar(Producto producto)
        {
            var proveedores = _proveedorBL.obtenerProveedores();
            var zonas = _zonaBL.obtenerZonas();
            var marcas = _marcaBL.obtenerMarcas();
            var presentaciones = _presentacionBL.obtenerPresentaciones();

            if (ModelState.IsValid)
            {
                _productoBL.guardarProducto(producto);
                return RedirectToAction("Index");
            }
            return View(producto);
        }

        public ActionResult Detalle(int id)
        {
            var producto = _productoBL.obtenerProducto(id);

            return View(producto);
        }

        public ActionResult Eliminar(int id)
        {
            var producto = _productoBL.obtenerProducto(id);
            return View(producto);
        }

        [HttpPost]
        public ActionResult Eliminar(Producto producto)
        {

            _productoBL.eliminarProducto(producto.Id);

            return RedirectToAction("Index");
        }
    }
}