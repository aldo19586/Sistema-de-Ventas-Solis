using CapaDatos;
using CapaEntidad;
using CapaEntity;
using FireSharp.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaData
{
    public class CD_IngresoProductos
    {
        CD_Conexion conexion = new CD_Conexion();
        CD_Procedimientos procedimientos = new CD_Procedimientos();
        CD_Presentaciones presentaciones = new CD_Presentaciones();

        public void agregarIngresoProductos(IngresoProductos ingresoProductos)
        {
            var client = conexion.Abrir();
            // Obtener una referencia a la ubicación donde deseas almacenar los productos
            FirebaseResponse response = client.Push("ingresoProductos", ingresoProductos);

        }
        public void anularIngresoProductos(IngresoProductos ingresoProductos,string idIngreso)
        {

            var client = conexion.Abrir();
            string rutaProducto = $"ingresoProductos/{idIngreso}";
            client.Set(rutaProducto, ingresoProductos);
        }
        public List<VistaIngresoProductos> mostrarDatosIngreso()
        {

            var ingresoProductos = procedimientos.cargarDatos<IngresoProductos>("ingresoProductos");


            var detalleIngresos = procedimientos.cargarDatos<DetalleIngresos>("detalleIngresos");


            List<VistaIngresoProductos> ListIngresoProductos = new List<VistaIngresoProductos>();

            // Iterar sobre cada producto para encontrar su categoría correspondiente
            foreach (var ingresoProducto in ingresoProductos)
            {
                // Encontrar la categoría correspondiente al producto
                var detalleProducto= detalleIngresos.FirstOrDefault(c => c.idIngreso == ingresoProducto.idIngreso);

                // Si se encuentra la categoría, combinar el producto y la categoría en una nueva estructura de datos
                if (detalleProducto != null)
                {
                    // Llama a la función y almacena el resultado en una variable
                    string nombreProveedor = obtenerNombreProveedorPorId(ingresoProducto.idProveedor);

                  
                    ListIngresoProductos.Add(new VistaIngresoProductos
                    {
                        idIngreso = ingresoProducto.id,
                        numIngreso = ingresoProducto.numIngreso,

                        nombrePve = nombreProveedor,
                        fechaIngreso = ingresoProducto.fechaIngreso,
                        comprobante = ingresoProducto.comprobante,
                        montoTotal = ingresoProducto.montoTotal,
                        estado = ingresoProducto.estado // Agregar el nombre de la categoría
                    }) ; 
                }
            }
            return ListIngresoProductos;
        }
        public List<VistaAnularProductos> mostrarDatosIngresoXid(string idIngreso)
        {
            // Cargar datos de ingreso y detalles
            var ingresos = procedimientos.cargarDatos<IngresoProductos>("ingresoProductos");
            var detalles = procedimientos.cargarDatos<DetalleIngresos>("detalleIngresos");

            List<VistaAnularProductos> listaAnularIngreso = new List<VistaAnularProductos>();
            // Combinar las listas basándose en el campo idIngreso
            var resultado = ingresos.Join(
                detalles,
                ingreso => ingreso.idIngreso,
                detalle => detalle.idIngreso,
                (ingreso, detalle) => new VistaAnularProductos
                {
                    idIngreso = ingreso.id,
                    idProducto = detalle.idProducto,
                    nombrePro = detalle.nombrePro,
                    cantidadPro = detalle.cantidadPro,
                    costoUnitarioPro = detalle.costoUnitario,
                    presentacionPro = presentaciones.obtenerPresentacionPorIdProducto(detalle.idProducto), // Agrega aquí la propiedad de presentación según tus necesidades
                    subTotal = (Convert.ToDecimal(detalle.cantidadPro) * Convert.ToDecimal(detalle.costoUnitario)).ToString()
                }); 

            // Filtrar los resultados por idIngreso
            var resultadoFiltrado = resultado.Where(r => r.idIngreso == idIngreso);


            // Acceder a los datos combinados
            foreach (var item in resultadoFiltrado)
            {
                // Crear un nuevo objeto vistaAnularProductos en cada iteración
                VistaAnularProductos vistaAnularProductos = new VistaAnularProductos();

                vistaAnularProductos.idIngreso = item.idIngreso;
                vistaAnularProductos.idProducto = item.idProducto;
                vistaAnularProductos.nombrePro = item.nombrePro;
                vistaAnularProductos.cantidadPro = item.cantidadPro;
                vistaAnularProductos.costoUnitarioPro = item.costoUnitarioPro;
                vistaAnularProductos.presentacionPro = item.presentacionPro;
                vistaAnularProductos.subTotal = item.subTotal;

                listaAnularIngreso.Add(vistaAnularProductos);

            }
          

            return listaAnularIngreso;
        }
        public string obtenerNombreProveedorPorId(string idProveedor)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("proveedores")
                .ResultAs<Dictionary<string, Proveedor>>();

            foreach (var proveedor in response)
            {
                if (proveedor.Key == idProveedor)
                {
                    return proveedor.Value.nombrePve; // Ajuste aquí
                }
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }
        public string obtenerIdProveedorPorNombre(string nombreProveedor)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("proveedores")
                .ResultAs<Dictionary<string, Proveedor>>();

            foreach (var proveedor in response)
            {
                if (proveedor.Value.nombrePve == nombreProveedor)
                {
                    return proveedor.Key; // Ajuste aquí
                }
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }
        public string obtenerIdIngresoProductoPorId(string idIngreso)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("ingresoProductos")
                .ResultAs<Dictionary<string, IngresoProductos>>();

            foreach (var ingresoProducto in response)
            {
                if (ingresoProducto.Key == idIngreso)
                {
                    return ingresoProducto.Value.idIngreso; // Ajuste aquí
                }else if(ingresoProducto.Value.idIngreso == idIngreso)
                {
                    return ingresoProducto.Key;
                }
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }
        public string obtenerTipoCargoProductoPorCodigo(string codigoPro)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("productos")
                .ResultAs<Dictionary<string, Producto>>();

            foreach (var producto in response)
            {
                if (producto.Value.codigoPro == codigoPro)
                {
                    return producto.Value.tipoCargoPro; // Ajuste aquí
                }
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }

        public string obtenerCodigoProductoPorId(string idPro)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("productos")
                .ResultAs<Dictionary<string, Producto>>();

            foreach (var producto in response)
            {
                if (producto.Key == idPro)
                {
                    return producto.Value.codigoPro; // Ajuste aquí
                }
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }
        public string obtenerPrecioVentaProductoPorId(string idPro)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("productos")
                .ResultAs<Dictionary<string, Producto>>();

            foreach (var producto in response)
            {
                if (producto.Key == idPro)
                {
                    return producto.Value.precioVentaPro; // Ajuste aquí
                }
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }
        public string obtenerCantidadProPorCodigoPro(string codigoPro)
        {
            var client = conexion.Abrir();
            var response = client
                .Get("inventario")
                .ResultAs<Dictionary<string, Inventario>>();

            foreach (var producto in response)
            {
                if (producto.Value.codigoPro== codigoPro)
                {
                    return producto.Value.cantidad; // Ajuste aquí
                }
            }

            return null; // Manejo del caso donde no se encuentra ningún proveedor con el ID dado
        }
        public async Task<List<VistaIngresoProductos>> BuscarIngresoProductoPorNombre(string nombreIngreso)
        {
            try
            {
                // Cargar datos
                List<VistaIngresoProductos> ingresoProductosEncontrados = mostrarDatosIngreso();



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(nombreIngreso))
                {
                    // Si es así, retornar la lista completa de productos
                    return ingresoProductosEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                ingresoProductosEncontrados = ingresoProductosEncontrados
                    .Where(p => p.nombrePve.StartsWith(nombreIngreso, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return ingresoProductosEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<VistaIngresoProductos>();
            }
        }
        public async Task<List<VistaIngresoProductos>> BuscarIngresoProductoPorFecha(string fechaIngreso)
        {
            try
            {
                // Cargar datos
                List<VistaIngresoProductos> ingresoProductosEncontrados = mostrarDatosIngreso();



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(fechaIngreso))
                {
                    // Si es así, retornar la lista completa de productos
                    return ingresoProductosEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                ingresoProductosEncontrados = ingresoProductosEncontrados
                    .Where(p => p.fechaIngreso.StartsWith(fechaIngreso, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return ingresoProductosEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<VistaIngresoProductos>();
            }
        }
        public async Task<List<VistaIngresoProductos>> BuscarIngresoProductoPorComprobante(string comprobanteIngreso)
        {
            try
            {
                // Cargar datos
                List<VistaIngresoProductos> ingresoProductosEncontrados = mostrarDatosIngreso();



                // Verificar si el nombre de producto es nulo o una cadena vacía
                if (string.IsNullOrWhiteSpace(comprobanteIngreso))
                {
                    // Si es así, retornar la lista completa de productos
                    return ingresoProductosEncontrados;
                }

                // Filtrar los productos por nombre que comience con la cadena proporcionada
                ingresoProductosEncontrados = ingresoProductosEncontrados
                    .Where(p => p.comprobante.StartsWith(comprobanteIngreso, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                return ingresoProductosEncontrados;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al buscar producto: {ex.Message}");
                return new List<VistaIngresoProductos>();
            }
        }
    }
}
