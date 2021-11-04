using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
namespace Topicos.NetCore.NorthWnd.BL.Logic.AccessBD
{
    public class Order
    {
        //Lista de ordenes por nombre aproximado del empleado (considerando nombre y apellidos)
        public IList<Model.MyModels.Order> BuscarPorNombreAproxEmpleado (string nombreAproxEmpleado)
        {
            IList<Model.MyModels.Order> resultado;
            using(var elContexto = new Model.MyModels.NORTHWNDContext())
            {
                var laConsulta = elContexto.Orders.Include(o => o.Employee.FullName.Contains(nombreAproxEmpleado));
                resultado = laConsulta.ToList();
            }
            return resultado;
        }
        //Lista de ordenes nombres aproximado del cliente
        public IList<Model.MyModels.Order> BuscarPorNombreAproxCliente(string nombreAproxCliente)
        {
            IList<Model.MyModels.Order> resultado;
            using (var elContexto = new Model.MyModels.NORTHWNDContext())
            {
                var laConsulta = elContexto.Orders.Include(o => o.Customer.ContactName.Contains(nombreAproxCliente));
                resultado = laConsulta.ToList();
            }
            return resultado;
        }
    }
}
