using Eksamensgruppe_7___ClassLibrary.Models;
using Eksamensgruppe_7___ClassLibrary.Repositories;
// By Kevin..
namespace Eksamensgruppe_7___ClassLibrary.Service
{
    public class AnimalService
    {
        private readonly IAnimalRepo _repo;

        public AnimalService(IAnimalRepo repo)
        {
            _repo = repo;
        }

        public List<Animal> GetAllAnimals() => _repo.GetAll();
        public Animal GetAnimalById(int id) => _repo.GetById(id);
        public void CreateAnimal(Animal a) => _repo.Add(a);
        public void UpdateAnimal(Animal a) => _repo.Update(a);
        public void DeleteAnimal(int id) => _repo.Remove(id);
    }
}


