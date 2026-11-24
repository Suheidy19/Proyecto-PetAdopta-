
using System.Collections.ObjectModel;
using PetAdopta.Models;

namespace PetAdopta.ViewModels
{
    public class MascotasViewModel
    {
        // Colección de mascotas que mostraremos
        public ObservableCollection<Animal> Mascotas { get; set; }
        public MascotasViewModel()
        {
            Mascotas = new ObservableCollection<Animal>
            {
                new Perro
                {
                    IdMascota = 1,
                    Nombre = "Max",
                    Edad = 3,
                    Raza = "Labrador",
                    Tamano = "Grande"
                },

                new Gato
                {
                    IdMascota = 2,
                    Nombre = "Michi",
                    Edad = 2,
                    Color = "Blanco",
                    EsInterior = true
                },

                new Perro
                {
                    IdMascota = 3,
                    Nombre = "Rocky",
                    Edad = 1,
                    Raza = "Pastor alemán",
                    Tamano = "Mediano"
                }
            };
        }
    }
}
