using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Registro_Vacunacion_EQNuGet.Models
{
    public partial class Personas
    {
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Phone]
        [Required]
        public string Telefono { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FechaNacimiento { get; set; }

        [Required]
        public int VacunaRecibida { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime FechaPrimeraDosis { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime? FechaSegundaDosis { get; set; }

        [Required]
        public int Provincia { get; set; }

        public virtual Provincias ProvinciaNavigation { get; set; }

        public virtual Vacunas VacunaRecibidaNavigation { get; set; }
    }
}
