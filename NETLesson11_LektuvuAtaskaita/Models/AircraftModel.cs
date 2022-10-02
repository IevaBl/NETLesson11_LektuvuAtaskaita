using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson11_LektuvuAtaskaita.Models
{
    public struct AircraftModel
    {
        public int TailNumber { get; set; }
        public string Number { get; set; }
        public string Description { get; set; }

        public AircraftModel(int tailNumber, string number, string description)
        {
            TailNumber = tailNumber;
            Number = number;
            Description = description;
        }

    }
}
