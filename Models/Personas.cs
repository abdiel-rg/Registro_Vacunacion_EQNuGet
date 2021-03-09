using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Registro_Vacunacion_EQNuGet.Models
{
    public partial class Personas
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int VacunaRecibida { get; set; }
        public DateTime FechaPrimeraDosis { get; set; }
        public DateTime? FechaSegundaDosis { get; set; }
        public int Provincia { get; set; }

        public virtual Provincias ProvinciaNavigation { get; set; }
        public virtual Vacunas VacunaRecibidaNavigation { get; set; }
    }
}
