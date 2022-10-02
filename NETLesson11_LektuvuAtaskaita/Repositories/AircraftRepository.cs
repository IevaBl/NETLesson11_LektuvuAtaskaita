using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETLesson11_LektuvuAtaskaita.Models;

namespace NETLesson11_LektuvuAtaskaita.Repositories
{
    internal class AircraftRepository
    {
        List<Aircraft> Aircrafts;

        public AircraftRepository()
        {
            Aircrafts = new List<Aircraft>();
            Aircrafts.Add(new Aircraft("777", "Shipment"));
            Aircrafts.Add(new Aircraft("888", "Travel"));
            Aircrafts.Add(new Aircraft("999", "Military"));
            Aircrafts.Add(new Aircraft("666", "Private"));
        }

        public List<Aircraft> Retrieve()
        {
            return Aircrafts;
        }

        public Aircraft Retrieve(string tailNumber)
        {
            return Aircrafts.Where(c => c.TailNumber == tailNumber).FirstOrDefault();
        }

    }
}
