using System.Collections.Generic;
using System.Text.Json;
using Eksamensgruppe_7___ClassLibrary.Models;

namespace Eksamensgruppe_7___ClassLibrary.Repositories
{
    public interface IAnimalRepo
    {
        List<Animal> GetAll();
        Animal GetById(int id);
        void Add(Animal animal);
        void Update(Animal animal);
        void Remove(int id);
    }
}