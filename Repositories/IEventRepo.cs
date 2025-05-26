using System.Collections.Generic;
using Eksamensgruppe_7___ClassLibrary.Models;

//BY KEVIN
namespace Eksamensgruppe_7___ClassLibrary.Repositories
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