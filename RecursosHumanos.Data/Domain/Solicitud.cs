using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos.Core.Domain
{
    public partial class Solicitud
    {
        public Solicitud()
        {
            Suministro = new HashSet<Suministro>();
            Usuario = new HashSet<Usuario>();
        }
        [Key]
        public int IdSolicitud { get; set; }
        [Display(Name ="Nombre Solicitud")]
        public string NombreSolicitud { get; set; }

        [Display(Name = "Fecha Creada")]
        public DateTime? FechaCreada { get; set; }
        [Display(Name = "Fecha Respuesta")]

        public string FechaRespuesta { get; set; }
        [Display(Name = "Fecha Creada")]

        public int? IdEstado { get; set; }
        public int? IdUsuario { get; set; }

       // public virtual Estado IdEstadoNavigation { get; set; }
       
        public virtual ICollection<Suministro> Suministro { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
