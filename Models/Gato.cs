
namespace PetAdopta.Models
{
    public class Gato : Animal
    {
        // Características particulares del gato
        public string Color { get; set; } = string.Empty;

        public bool EsInterior { get; set; }

        // Implementación del método abstracto
        public override string ObtenerDescripcion()
        {
            string tipo = EsInterior
                ? "Gato de interior"
                : "Gato con acceso al exterior";

            return $"{Nombre} es un gato de color {Color}. {tipo}.";
        }
    }
}
