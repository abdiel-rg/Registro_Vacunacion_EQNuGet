using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Registro_Vacunacion_EQNuGet.Models
{
    public partial class Vacunas
    {
        public Vacunas()
        {
            Personas = new HashSet<Personas>();
        }

        public int Id { get; set; }
        public string Marca { get; set; }
        public int Cantidad { get; set; }

        public virtual ICollection<Personas> Personas { get; set; }
    }
}
