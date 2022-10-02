using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson11_LektuvuAtaskaita.Models
{
    public struct Aircraft
    {
        public string TailNumber { get; set; }
        public string Description { get; set; }
        
        public Aircraft(string tailNumber, string description)
        {
            TailNumber = tailNumber;
            Description = description;
        }


    }
}
