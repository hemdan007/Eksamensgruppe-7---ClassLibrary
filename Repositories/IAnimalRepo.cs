using System.Collections.Generic;
using System.Text.Json;
using Eksamensprojekt___Gruppe_7.Models;

namespace Eksamensprojekt___Gruppe_7.Repositories
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