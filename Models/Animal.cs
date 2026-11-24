
using PetAdopta.Enums;

namespace PetAdopta.Models
{
    // Clase abstracta que representa a cualquier animal
    public abstract class Animal
    {
        // Identificador de la mascota
        public int IdMascota { get; set; }

        // Datos generales
        public string Nombre { get; set; } = string.Empty;

        public int Edad { get; set; }

        public SexoAnimal Sexo { get; set; }

        public string Descripcion { get; set; } = string.Empty;

        public string? ImagenUrl { get; set; }

        // Estado de adopción
        public EstadoMascota Estado { get; set; }

        // Fecha de registro
        public DateTime FechaRegistro { get; set; }

        // Método abstracto: cada animal tendrá su propia descripción
        public abstract string ObtenerDescripcion();
    }
    public enum EstadoMascota
    {
        Disponible,
        EnProceso,
        Adoptada
    }

}
