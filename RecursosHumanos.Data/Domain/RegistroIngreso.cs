using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursosHumanos.Core.Domain
{

    public partial class RegistroIngreso
    {
        [Key]
        [Display(Name = "Id Registro")]
            public int IdRegistro { get; set; }
        [Display(Name="Nombre Registro")]
            public string NombreRegistro { get; set; }
        [Display(Name ="Hora Ingreso")]
            public DateTime? HoraEntrada { get; set; }
        [Display(Name ="Hora Salida")]
            public DateTime HoraSalida { get; set; }

            public int IdHorario { get; set; }
            public int IdUsuario { get; set; }

            public virtual Horario IdHorarioNavigation { get; set; }
            public virtual Usuario IdUsuarioNavigation { get; set; }
        }
    }

