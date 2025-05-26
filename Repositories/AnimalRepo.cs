using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Eksamensgruppe_7___ClassLibrary.Models;

// BY KEVIN

namespace Eksamensgruppe_7___ClassLibrary.Repositories
{
    public class AnimalRepo : IAnimalRepo
    {
        private const string FileName = "animals.json";      // JSON file name
        private readonly string _path;                        // Full path to Data/animals.json
        private List<Animal> _animals;                        // In-memory list of Animal objects

        public AnimalRepo()
        {
            // Build file path relative to project folder
            _path = Path.Combine(Directory.GetCurrentDirectory(), "Data", FileName);

            // If file doesn't exist, create directory and an empty JSON array
            if (!File.Exists(_path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_path));
                File.WriteAllText(_path, "[]");
            }

            // Read JSON content and deserialize into _animals list
            var json = File.ReadAllText(_path);
            _animals = JsonSerializer.Deserialize<List<Animal>>(json) ?? new List<Animal>();
        }

        // Write the current _animals list back to the JSON file
        private void SaveChanges()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };  // Pretty-print JSON
            var json = JsonSerializer.Serialize(_animals, options);
            File.WriteAllText(_path, json);
        }

        // Return all animals
        public List<Animal> GetAll() => _animals;

        // Find a single animal by its ID
        public Animal GetById(int id) => _animals.FirstOrDefault(a => a.Id == id);

        // Add a new animal, assigning a unique ID, then save
        public void Add(Animal animal)
        {
            animal.Id = _animals.Any() ? _animals.Max(a => a.Id) + 1 : 1;
            _animals.Add(animal);
            SaveChanges();
        }

        // Update existing animal's properties, then save
        public void Update(Animal animal)
        {
            var existing = GetById(animal.Id);
            if (existing != null)
            {
                existing.Name = animal.Name;
                existing.Size = animal.Size;
                existing.ChipNumber = animal.ChipNumber;
                existing.Race = animal.Race;
                existing.Characteristics = animal.Characteristics;
                existing.Picture = animal.Picture;
                existing.Avaliability = animal.Avaliability;
                existing.Defect = animal.Defect;
                SaveChanges();
            }
        }

        // Remove an animal by ID, then save
        public void Remove(int id)
        {
            var existing = GetById(id);
            if (existing != null)
            {
                _animals.Remove(existing);
                SaveChanges();
            }
        }
    }
}