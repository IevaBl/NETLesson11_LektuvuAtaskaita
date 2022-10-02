using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NETLesson11_LektuvuAtaskaita.Models;

namespace NETLesson11_LektuvuAtaskaita.Repositories
{
    internal class AircraftModelRepository
    {
        List<AircraftModel> AircraftModels { get; set; }

        public AircraftModelRepository()
        {
            AircraftModels = new List<AircraftModel>();
            AircraftModels.Add(new AircraftModel(777,"AGE-36", "WizzAir"));
            AircraftModels.Add(new AircraftModel(888,"MI-16", "LOT"));
            AircraftModels.Add(new AircraftModel(999,"JO-958", "Boeing"));
            AircraftModels.Add(new AircraftModel(666, "BL-999", "Baltic AirLines"));
        }
        public List<AircraftModel> Retrieve()
        {
            return AircraftModels;
        }

        public AircraftModel Retrieve(string description)
        {
            return AircraftModels.Where(c => c.Description == description).FirstOrDefault();
        }
    }
}
