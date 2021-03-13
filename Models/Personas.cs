using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DevelopersDo.DataAnnotations;
using FoolProof.Core;

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
        [Cedula]
        public string Cedula { get; set; }

        [Required]
        public string Nombre { get; set; }

        [Required]
        public string Apellido { get; set; }

        [Required]
        [MSISDN]
        public string Telefono { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime? FechaNacimiento { get; set; }

        [RequiredIfEmpty("VacunaRecibida")]
        [Range(1, int.MaxValue)]
        public int? VacunaRecibida { get; set; }

        [RequiredIfNotEmpty("VacunaRecibida")]
        [DataType(DataType.Date)]
        public DateTime? FechaPrimeraDosis { get; set; }

        [DataType(DataType.Date)]
        public DateTime? FechaSegundaDosis { get; set; }

        [Required]
        [Range(1, int.MaxValue)]
        public int Provincia { get; set; }

        public virtual Provincias ProvinciaNavigation { get; set; }
        public virtual Vacunas VacunaRecibidaNavigation { get; set; }
    }
}
