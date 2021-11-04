using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.NorthWnd.BL.Logic.AccessBD
{
    public class Employee
    {
        //Lista de todos los empleados por nombre aproximado de la jefatura
        public IList<Model.MyModels.Employee> BuscarPorNombreAproximadoDeJefatura(string nombreAproxJefatura)
        {
            IList<Model.MyModels.Employee> temporal;
            using (var elContexto = new Model.MyModels.NORTHWNDContext())
            {
                temporal = elContexto.Employees.ToList().Where(e => e.FullName.Contains(nombreAproxJefatura)).ToList();
            }
            var resultado = temporal;
            return resultado;
        }
        //Lista de todos los empleados por rango de edad en años
        /*
        public IList<Model.MyModels.Employee> BuscarPorRangoDeEdad(int edadEmpleado)
        {
            IList<Model.MyModels.Employee> resultado;
            using (var elContexto = new Model.MyModels.NORTHWNDContext())
            {
                var laConsulta = elContexto.Employees.ToList().Where(e => e.BirthDate);
            }

            return resultado;
        }
        */
        //Lista de todos los empleados por rango de antigüedad en años
        /*
        public IList<Model.MyModels.Employee> BuscarTiempoDeServicio(int tiempoDeServicio)
        {
            IList<Model.MyModels.Employee> resultado;
            using (var elContexto = new Model.MyModels.NORTHWNDContext())
            {
                var laConsulta = elContexto.Employees.ToList().Where(e => e.HireDate);
            }

            return resultado;
        }
        */
        //Lista de todos los empleados por nombre aproximado de la descripción del territorio
        public IList<Model.MyModels.Employee> BuscarPorNombreAproximadoDelTerritorio(string nombreAproxDescripcionTerritorio)
        {
            IList<Model.MyModels.Employee> resultado;
            using (var elContexto = new Model.MyModels.NORTHWNDContext())
            {
                var laConsulta = elContexto.Employees.Include(e => e.EmployeeTerritories).ThenInclude(et => et.Territory).Where(e => e.EmployeeTerritories.Any(et => et.Territory.TerritoryDescription.Contains(nombreAproxDescripcionTerritorio)));
                resultado = laConsulta.ToList();
            }
            return resultado;
        }
    }
}
