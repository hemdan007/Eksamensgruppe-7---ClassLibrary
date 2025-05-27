using Eksamensgruppe_7___ClassLibrary.Models;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

//BY KEVIN

namespace Eksamensgruppe_7___ClassLibrary.Repositories
{
    public class BookingRepo
    {
        private const string FileName = "bookings.json";
        private readonly string _path;
        private List<Booking> _bookings;

        public BookingRepo()
        {
            _path = Path.Combine(Directory.GetCurrentDirectory(), "Data", FileName);
            if (!File.Exists(_path))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(_path));
                File.WriteAllText(_path, "[]");
            }

            var json = File.ReadAllText(_path);
            _bookings = JsonSerializer.Deserialize<List<Booking>>(json) ?? new List<Booking>();
        }

        private void SaveChanges()
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var json = JsonSerializer.Serialize(_bookings, options);
            File.WriteAllText(_path, json);
        }

        public List<Booking> GetAll() => _bookings;

        public void Add(Booking booking)
        {
            _bookings.Add(booking);
            SaveChanges();
        }
    }
}
