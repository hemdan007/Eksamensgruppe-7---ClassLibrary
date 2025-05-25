using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using Eksamensprojekt___Gruppe_7.Models;

//BY KEVIN
namespace Eksamensprojekt___Gruppe_7.Repositories
{
    public class EventRepo : IEventRepo
    {
        private const string FileName = "events.json";       // File name where events are stored
        private readonly string _path;                        // Full path to the file
        private List<Event> _events;                          // List of events loaded from file

        public EventRepo()
        {
            // Create file if it doesn't exist
            _path = Path.Combine(Directory.GetCurrentDirectory(), "Data", FileName);
            if (!File.Exists(_path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_path));
                File.WriteAllText(_path, "[]");
            }

            // Load events from JSON file
            var json = File.ReadAllText(_path);
            _events = JsonSerializer.Deserialize<List<Event>>(json) ?? new List<Event>();
        }

        // Saves the current _events list to file
        private void SaveChanges()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            File.WriteAllText(_path, JsonSerializer.Serialize(_events, options));
        }

        // Returns all events
        public List<Event> GetAll() => _events;

        // Returns a specific event by its ID
        public Event GetById(int id) => _events.FirstOrDefault(e => e.Id == id);

        // Adds a new event to the list and saves
        public void Add(Event ev)
        {
            ev.Id = _events.Any() ? _events.Max(x => x.Id) + 1 : 1;
            _events.Add(ev);
            SaveChanges();
        }

        // Updates an existing event's properties
        public void Update(Event ev)
        {
            var existing = GetById(ev.Id);
            if (existing == null) return;
            existing.Name = ev.Name;
            existing.Description = ev.Description;
            existing.Date = ev.Date;
            SaveChanges();
        }

        // Removes an event by ID
        public void Remove(int id)
        {
            var existing = GetById(id);
            if (existing == null) return;
            _events.Remove(existing);
            SaveChanges();
        }
    }
}