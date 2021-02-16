using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos.Core.Domain
{
    public partial class Suministro
    {
        public Suministro()
        { }
        [Key]
        public int IdSuministro { get; set; }
        [Display(Name ="Nombre Suministro")]
        public int NombreSuministro { get; set; }
        public virtual Solicitud IdSolicitudNavigation { get; set; }
    }
}