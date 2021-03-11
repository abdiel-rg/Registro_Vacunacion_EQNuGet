using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Json;

namespace Registro_Vacunacion_EQNuGet.Data
{
    public class CedulaAPI
    {
        public async static Task<CedulaAPI> GetCedula(string cedula)
        {
            using HttpClient http = new();
            if (string.IsNullOrWhiteSpace(cedula)) cedula = "0";
            return await http.GetFromJsonAsync<CedulaAPI>($"https://api.adamix.net/apec/cedula/{cedula}");
        }

        [JsonPropertyName("Cedula")]
        public string Cedula { get; set; }

        [JsonPropertyName("Nombres")]
        public string Nombres { get; set; }

        [JsonPropertyName("Apellido1")]
        public string Apellido1 { get; set; }

        [JsonPropertyName("Apellido2")]
        public string Apellido2 { get; set; }

        [JsonPropertyName("FechaNacimiento")]
        public string FechaNacimiento { get; set; }

        [JsonPropertyName("LugarNacimiento")]
        public string LugarNacimiento { get; set; }

        [JsonPropertyName("IDCategoria")]
        public int IDCategoria { get; set; }

        [JsonPropertyName("IdSexo")]
        public string IdSexo { get; set; }

        [JsonPropertyName("IdEstadoCivil")]
        public string IdEstadoCivil { get; set; }

        [JsonPropertyName("IdOcupacion")]
        public int IdOcupacion { get; set; }

        [JsonPropertyName("IDNacionalidad")]
        public int IDNacionalidad { get; set; }

        [JsonPropertyName("IDMunicipio")]
        public int IDMunicipio { get; set; }

        [JsonPropertyName("IDColegio")]
        public int IDColegio { get; set; }

        [JsonPropertyName("IDCausaCancelacion")]
        public object IDCausaCancelacion { get; set; }

        [JsonPropertyName("IDEstatus")]
        public string IDEstatus { get; set; }

        [JsonPropertyName("EstatusCedulaAzul")]
        public string EstatusCedulaAzul { get; set; }

        [JsonPropertyName("CedulaAnterior")]
        public string CedulaAnterior { get; set; }

        [JsonPropertyName("mun_ced")]
        public string MunCed { get; set; }

        [JsonPropertyName("seq_ced")]
        public string SeqCed { get; set; }

        [JsonPropertyName("ver_ced")]
        public string VerCed { get; set; }

        [JsonPropertyName("V2004")]
        public int V2004 { get; set; }

        [JsonPropertyName("V2008")]
        public int V2008 { get; set; }

        [JsonPropertyName("V2012")]
        public int V2012 { get; set; }

        [JsonPropertyName("V2016")]
        public int V2016 { get; set; }

        [JsonPropertyName("PLD")]
        public int PLD { get; set; }

        [JsonPropertyName("PRD")]
        public int PRD { get; set; }

        [JsonPropertyName("PRSC")]
        public int PRSC { get; set; }

        [JsonPropertyName("PRM")]
        public int PRM { get; set; }

        [JsonPropertyName("Multiplicador_NombreCompleto")]
        public object MultiplicadorNombreCompleto { get; set; }

        [JsonPropertyName("Multiplicador_Cedula")]
        public object MultiplicadorCedula { get; set; }

        [JsonPropertyName("Simpatia_Descripcion")]
        public object SimpatiaDescripcion { get; set; }

        [JsonPropertyName("Ilocalizable")]
        public object Ilocalizable { get; set; }

        [JsonPropertyName("Apodo")]
        public object Apodo { get; set; }

        [JsonPropertyName("PadronLF")]
        public object PadronLF { get; set; }

        [JsonPropertyName("ok")]
        public bool Ok { get; set; }

        [JsonPropertyName("foto")]
        public string Foto { get; set; }
    }
}
