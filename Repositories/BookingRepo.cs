using Eksamensgruppe_7___ClassLibrary.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Eksamensgruppe_7___ClassLibrary.Models;

// BY KEVIN

namespace Eksamensgruppe_7___ClassLibrary.Repositories
{
    public class BookingRepo
    {
        // The name of the file where bookings are saved
        private const string FileName = "bookings.json";

        // The path to the bookings.json file
        private readonly string _path;

        // A list that holds all bookings
        private List<Booking> _bookings;

        public BookingRepo()
        {
            // Combine folder and filename into one path
            _path = Path.Combine(Directory.GetCurrentDirectory(), "Data", FileName);

            // If the file doesn't exist, create folder and file
            if (!File.Exists(_path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_path));
                File.WriteAllText(_path, "[]");
            }

            // Read from the file and turn the JSON text into a list of Booking objects
            var json = File.ReadAllText(_path);
            _bookings = JsonSerializer.Deserialize<List<Booking>>(json) ?? new List<Booking>();
        }

        // Saves the current list of bookings back to the JSON file
        private void SaveChanges()
        {
            var options = new JsonSerializerOptions { WriteIndented = true }; // makes the file easy to read
            var json = JsonSerializer.Serialize(_bookings, options);
            File.WriteAllText(_path, json);
        }

        // Returns list of all bookings
        public List<Booking> GetAll() => _bookings;

        // Adds a new booking and saves it to the file
        public void Add(Booking booking)
        {
            _bookings.Add(booking);   // Add booking to the list
            SaveChanges();            // Save the updated list to the file
        }
    }
}
