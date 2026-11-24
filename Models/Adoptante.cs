
namespace PetAdopta.Models
{
    public class Adoptante
    {
        public int IdAdoptante { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Apellidos { get; set; } = string.Empty;
        public string Telefono { get; set; } = string.Empty;
        public string Correo { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public DateTime FechaRegistro { get; set; }
        // Propiedad calculada
        public string NombreCompleto =>
            $"{Nombre} {Apellidos}";
    }
}
