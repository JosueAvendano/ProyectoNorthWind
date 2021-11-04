using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.NorthWnd.BL.Logic.AccessBD
{
    public class Product
    {
        /*
        private static Model.MyModels.NORTHWNDContext elContexto = new Model.MyModels.NORTHWNDContext();
        
        //Declaro la variable de elContexto como static para que no se "apague"
        private static Model.MyModels.NORTHWNDContext elContexto;
        //Constructor que me genera un unico contexto
        public Product()
        {
            elContexto = new Model.MyModels.NORTHWNDContext();
        }
        */
        //Lista de todos los productos descontinuados por rango de precio
        public IList<Model.MyModels.Product> BuscarPorDescontinuados(Boolean descontinuado)
        {
            IList<Model.MyModels.Product> resultadoDisc;
            using (var elContexto = new Model.MyModels.NORTHWNDContext())
            {
                //resultadoDisc = elContexto.Products.Where(p => p.Discontinued.Contains(descontinuado)).OrderBy(p => p.UnitPrice);
            }

            return null /*resultadoDisc*/;
        }

        //Lista de todos productos por nombre aproximado del proveedor
        public IList<Model.MyModels.Product> BuscarPorNombreAproxProveedor(string nombreAproxProveedor)
        {
            IList<Model.MyModels.Product> resultadoSup;
            using (var _elContexto = new Model.MyModels.NORTHWNDContext())
            {
                var laConsulta = _elContexto.Products.Include(p => p.Supplier.CompanyName.Contains(nombreAproxProveedor));
                resultadoSup = laConsulta.ToList();
            }
            return resultadoSup;
        }

        //Lista de todos los productos por nombre aproximado de la categoria
        public IList<Model.MyModels.Product> BuscarPorNombreAproxCategoria(string nombreAproxCategory)
        {
            IList<Model.MyModels.Product> resultadoCat;
            using(var _elContexto = new Model.MyModels.NORTHWNDContext())
            {
                var laConsulta = _elContexto.Products.Include(p => p.Category.CategoryName.Contains(nombreAproxCategory));
                resultadoCat = laConsulta.ToList();
            }
            return resultadoCat;
        }
    }
}
