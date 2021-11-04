using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.NorthWnd.Model.MyModels
{
    public partial class OrderDetail
    {
        //Monto Bruto de la Linea
        [NotMapped]
        public decimal GrossAmmount {
            get {
                var elMontoBruto = this.UnitPrice;
                var elResultadoBruto = elMontoBruto;
                return elResultadoBruto;
            } set { }
        }

        //Porcentaje con el signo %
        [NotMapped]
        public decimal DiscountWithSign { 
            get {
                //var NuevoPorcentaje = Convert.ToDecimal(this.Discount) * 100;
                CultureInfo ci_US = new CultureInfo("en-US"); //Formato de % en English - USA
                var NuevoPorcentaje = this.Discount;
                return ((decimal)NuevoPorcentaje);
                
            } set { } 
        }

        //Monto Neto de la Linea
        [NotMapped]
        public decimal NetAmmount { 
            get {

                var Porcentaje = Convert.ToDecimal(this.Discount);
                var ApplyDescuento = this.UnitPrice;
                if (this.Discount != 0)
                {
                    ApplyDescuento *= Porcentaje;
                }

                var ResultadoNeto = ApplyDescuento;
                return ResultadoNeto;
                
            } set { } 
        }
    }
}
