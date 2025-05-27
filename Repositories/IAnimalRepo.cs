using System.Collections.Generic;
using System.Text.Json;
using Eksamensgruppe_7___ClassLibrary.Models;

//BY KEVIN
namespace Eksamensgruppe_7___ClassLibrary.Repositories
{
    public interface IAnimalRepo
    {
        List<Animal> GetAll();                      // Returns a list of all animals
        Animal GetById(int id);                     // Finds and returns animal by ID
        void Add(Animal animal);                    // Adds a new animal to the collection
        void Update(Animal animal);                 // Updates the data of an existing animal
        void Remove(int id);                        // Removes animal by ID
    }
}