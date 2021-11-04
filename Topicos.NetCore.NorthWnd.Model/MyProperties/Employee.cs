using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topicos.NetCore.NorthWnd.Model.MyModels
{
    public partial class Employee
    {
        [NotMapped]
        public string FullName { 
            get {
                var elTitleOfCurtesy = this.TitleOfCourtesy + " ";
                var elFirstName = this.FirstName + " ";
                var elLastName = this.LastName + " ";
                //Nombre de Jefatura
                var elTitle = this.Title + " ";

                var elResultado = $"{elTitleOfCurtesy}{elFirstName}{elLastName}{elTitle}";
                return elResultado;
                
            } set { } 
        }
    }
}
