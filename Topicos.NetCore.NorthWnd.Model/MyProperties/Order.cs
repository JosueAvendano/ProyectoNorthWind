using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.NorthWnd.Model.MyModels
{
    public partial class Order
    {
        //Cantidad de dias que duro la Orden en ser Fabricada
        [NotMapped]
        public DateTime FabricationDateRange { 
            get{
                var StartDate = (DateTime)OrderDate;
                var EndDate = (DateTime)ShippedDate;
                //var DateDiff = EndDate - StartDate;
                //TimeSpan DateDiff = ((TimeSpan)((DateTime)EndDate - StartDate));
                //TimeSpan DateDiff = EndDate.Substract((DateTime)StartDate);
                //double DateDiff = Convert.ToDouble((EndDate - StartDate).TotalDays);
                TimeSpan DateDiff = EndDate - StartDate;
                var days = DateDiff.TotalDays;
                return days;
                
            } set { } 
        }
    }
}
