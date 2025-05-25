using System.Collections.Generic;
using Eksamensprojekt___Gruppe_7.Models;

//BY KEVIN
namespace Eksamensprojekt___Gruppe_7.Repositories
{
    public interface IEventRepo
    {
        List<Event> GetAll();                    // Returns all events
        Event GetById(int id);                   // Returns one event by ID
        void Add(Event ev);                      // Adds new event
        void Update(Event ev);                   // Updates event info
        void Remove(int id);                     // Deletes event
    }
}