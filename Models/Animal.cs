using System;
using System.Collections.Generic;

//BY KEVIN

namespace Eksamensgruppe_7___ClassLibrary.Models
{
    public class Animal
    {
        // Unique ID for the animal (assigned by the repository upon add)
        public int Id { get; set; }

        // Name of the animal
        public string Name { get; set; }

        // Birth date of the animal
        public DateTime BirthDate { get; set; }

        // Size of the animal in cm
        public int Size { get; set; }

        // Unique microchip number
        public string ChipNumber { get; set; }

        // Race of the animal
        public string Race { get; set; }

        // Any special characteristics or notes
        public string Characteristics { get; set; }

        // Filename of the animal's picture stored in wwwroot/media
        public string Picture { get; set; }

        // Availability status (true = available for visits/adoption)
        public bool Avaliability { get; set; }

        // List of defects or health notes
        public List<string> Defect { get; set; } = new List<string>();
    }
}