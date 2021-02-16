
using RecursosHumanos.Core.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos.Core.Domain
{
   public partial class Horario
    {
        public Horario()
        {
            RegistroIngreso = new HashSet<RegistroIngreso>();
            Usuario = new HashSet<Usuario>();
        }
        [Key]
        [Display(Name ="Id Horario")]
        public int IdHorario { get; set; }
        [Display(Name ="Nombre Horario")]
        public string NombreHorario { get; set; }
        [Display(Name ="Hora Ingreso")]
       

        public virtual ICollection<RegistroIngreso> RegistroIngreso { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}

