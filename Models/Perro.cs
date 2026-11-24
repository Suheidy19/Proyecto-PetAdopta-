
namespace PetAdopta.Models
{
    public class Perro : Animal
    {
        // Características particulares del perro
        public string Raza { get; set; } = string.Empty;

        public string Tamano { get; set; } = string.Empty;

        // Implementación del método abstracto
        public override string ObtenerDescripcion()
        {
            return $"{Nombre} es un perro de raza {Raza} " + $"y tamaño {Tamano}.";
        }
    }
}
