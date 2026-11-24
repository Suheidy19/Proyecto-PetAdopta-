
using PetAdopta.Enums;

namespace PetAdopta.Models
{
    public class SolicitudAdopcion
    {
        public int IdSolicitud { get; set; }

        // Identificadores relacionados
        public int IdMascota { get; set; }
        public int IdAdoptante { get; set; }

        // Información de la solicitud
        public DateTime FechaSolicitud { get; set; }
        public EstadoSolicitud Estado { get; set; }
        public string Observaciones { get; set; } = string.Empty;

        // Información relacionada para mostrar en pantalla
        public string NombreMascota { get; set; } = string.Empty;
        public string NombreAdoptante { get; set; } = string.Empty;
    }
}
