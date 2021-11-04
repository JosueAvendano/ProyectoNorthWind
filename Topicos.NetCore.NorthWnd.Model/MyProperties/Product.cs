using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.NorthWnd.Model.MyModels
{
    public partial class Product
    {
        //Cantidad de Unidades de Desabastecimiento -> falta de productos
        [NotMapped]
        public int NumberOfStockoutUnits
        { 
            get
            {
                var StockOutUnits = Convert.ToInt32(this.UnitsInStock);
                if (StockOutUnits != 0)
                {
                    Console.WriteLine("We're good");
                }
                return StockOutUnits;
            }
            set { } 
        }
    }
    //Nombre del Proveedor
    public partial class Supplier
    {
        [NotMapped]
        public string SupplierInfo 
        {
            get
            {
                var elSupplierName = this.ContactName;
                var elContactTitle = this.ContactTitle;
                var elCompanyName = this.CompanyName;

                var elResultado = $"{elSupplierName}{elContactTitle}{elCompanyName}";
                return elResultado;

            } set { }
        }
    }
    public partial class Category
    { 
        [NotMapped]
        public string CategoryInfo
        {
            get 
            {
                var elCategoryName = this.CategoryName;
                return elCategoryName;
            }
            set { }
        }
    }
}
