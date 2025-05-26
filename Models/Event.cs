using System;
using System.Collections.Generic;

//BY KEVIN
namespace Eksamensgruppe_7___ClassLibrary.Models
{
    public class Event
    {
        public int Id { get; set; }                    // Unique identifier for each event
        public string Name { get; set; }               // Name of the activity/event
        public string Description { get; set; }        // Details about what happens in the event
        public DateTime Date { get; set; }             // When the event takes place

        // List of people who have signed up
        public List<Participant> Participants { get; set; } = new List<Participant>();
    }

    // Participant model to capture signup info
    public class Participant
    {
        public string Name { get; set; }               // Name of the customer or vet
        public string Email { get; set; }              // Email address for contact
        public string PhoneNumber { get; set; }        // Phone number for contact
    }
}