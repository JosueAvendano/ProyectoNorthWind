using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topicos.NetCore.NorthWnd.BL;

namespace Topicos.NetCore.ConsoleApp
{
    public class LogicaPrincipal
    {
        //Constructor para las Consultas Generales
        public void Consultas()
        {
            ConsultaPorNombreAproxProveedor();
            ConsultaPorNombreAproxCategoria();
            ConsultaPorNombreAproxJefatura();
            ConsultaPorNombreAproxDescripcionTerritorio();
            ConsultaPorNombreAproxCliente();
        }

        //Consultas de Products
        private void ConsultaPorNombreAproxProveedor()
        {
            var elNombreAproxProv = "de";
            var elServicio = new Topicos.NetCore.NorthWnd.BL.Logic.AccessBD.Product();
            var elResultado = elServicio.BuscarPorNombreAproxProveedor(elNombreAproxProv);
            ImprimirProductsPorProveedor(elResultado);
        }
        private void ConsultaPorNombreAproxCategoria()
        {
            var elNombreAproxCat = "Con";
            var elServicio = new Topicos.NetCore.NorthWnd.BL.Logic.AccessBD.Product();
            var elResultado = elServicio.BuscarPorNombreAproxCategoria(elNombreAproxCat);
            ImprimirProductsPorCategoria(elResultado);
        }

        //Consultas de Employees
        private void ConsultaPorNombreAproxJefatura()
        {
            var elNombreAproxJef = "sales";
            var elServicio = new Topicos.NetCore.NorthWnd.BL.Logic.AccessBD.Employee();
            var elResultado = elServicio.BuscarPorNombreAproximadoDeJefatura(elNombreAproxJef);
            ImprimirEmployeesPorJefatura(elResultado);
        }

        private void ConsultaPorNombreAproxDescripcionTerritorio()
        {
            var elNombreAproxTerr = "sa";
            var elServicio = new Topicos.NetCore.NorthWnd.BL.Logic.AccessBD.Employee();
            var elResultado = elServicio.BuscarPorNombreAproximadoDeJefatura(elNombreAproxTerr);
            ImprimirEmployeesPorDescripcionTerritorio(elResultado);
        }

        //Consultas de Order
        private void ConsultaPorNombreAproxCliente()
        {
            var elNombreAproxCliente = "an";
            var elServicio = new Topicos.NetCore.NorthWnd.BL.Logic.AccessBD.Order();
            var elResultado = elServicio.BuscarPorNombreAproxCliente(elNombreAproxCliente);
            ImprimirOrdersPorNombreCliente(elResultado);
        }

        //Muestra en Consola los Queries de Products
        private void ImprimirProductsPorProveedor(IList<NetCore.NorthWnd.Model.MyModels.Product> elResultado)
        {
            if(elResultado == null)
            {
                Console.WriteLine("La lista no tiene elementos. Intentelo de nuevo!");
                return;
            }
            foreach(var product in elResultado)
            {
                Console.WriteLine($"Nombre del Producto: {product.ProductName} - Nombre del Proveedor: {product.Supplier.CompanyName}");
            }
        }

        private void ImprimirProductsPorCategoria(IList<NetCore.NorthWnd.Model.MyModels.Product> elResultado)
        {
            if (elResultado == null)
            {
                Console.WriteLine("La lista no tiene elementos. Intentelo de nuevo!");
                return;
            }
            foreach (var product in elResultado)
            {
                Console.WriteLine($"Nombre del Producto: {product.ProductName} - Nombre del Proveedor: {product.Category.CategoryName}");
            }
        }

        //Muestra en Consola los Queries de Employees
        private void ImprimirEmployeesPorJefatura(IList<NetCore.NorthWnd.Model.MyModels.Employee> elResultado)
        {

            if (elResultado == null)
            {
                Console.WriteLine("La lista no tiene elementos. Intentelo de nuevo!");
                return;
            }
            foreach (var employee in elResultado)
            {
                Console.WriteLine($"Nombre del Empleado: {employee.FullName} - Nombre de la Jefatura: {employee.Title}");
            }
        }
        private void ImprimirEmployeesPorDescripcionTerritorio(IList<NetCore.NorthWnd.Model.MyModels.Employee> elResultado)
        {
            if (elResultado == null)
            {
                Console.WriteLine("La lista no tiene elementos. Intentelo de nuevo!");
                return;
            }
            foreach (var employee in elResultado)
            {
                Console.WriteLine($"Nombre del Empleado: {employee.FullName}");
                Console.WriteLine("Territorios:");

                foreach (var territorios in employee.EmployeeTerritories) 
                {
                    Console.WriteLine($"Descripcion del Territorio: {territorios.Territory.TerritoryDescription}");
                }
            }
        }

        //Muestra por Consola los Queries de Orders
        private void ImprimirOrdersPorNombreCliente(IList<NetCore.NorthWnd.Model.MyModels.Order> elResultado)
        {
            if (elResultado == null)
            {
                Console.WriteLine("La lista no tiene elementos. Intentelo de nuevo!");
                return;
            }
            foreach (var order in elResultado)
            {
                Console.WriteLine($"ID de la Orden: {order.OrderId} - Fecha de la Orden Emitida: {order.OrderDate} - Fecha del envio de la Orden: {order.ShippedDate} - Nombre del Cliente: {order.Customer.ContactName}");
            }
        }

    }
}
