using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RecursosHumanos.Core.Domain
{
    public partial class Usuario
    {
        [Key]
        [Display(Name = "Id Usuario")]
        public int IdUsuario { get; set; }
        
        [Display(Name = "N° Documento")]
        public int? NDocumento { get; set; }

        [Display(Name = "Primer Nombre")]
        public String PrimerNombre { get; set; }
        [Display(Name = "Segundo Nombre")]
        public string SegundoNombre { get; set; }
        [Display(Name = "Primer Apellido")]
        public string PrimerApellido { get; set; }
        [Display(Name = "Segundo Apellido")]
        public string SegundoApellido { get; set; }
        [StringLength(10, ErrorMessage = "El {0} debe ser de {2}", MinimumLength = 10)]
        public int Telefono { get; set; }
        [Display(Name = " Dirección")]
        public char Direccion { get; set; }
        public char Correo { get; set; }
    }
}
