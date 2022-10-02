using NETLesson11_LektuvuAtaskaita.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NETLesson11_LektuvuAtaskaita
{
    internal class HTMLGenerator
    {
        public string GenerateHtml(List<ReportItem> listAircraft)
        {
            string ataskaitaEuropa = "<html><body>" + "<h1>";
            foreach (ReportItem item in listAircraft)
            {
                ataskaitaEuropa = ataskaitaEuropa + "<span style=\"" + getColor(item.plainInES) + "\">"+ ("Aircraft Tail Number:" + item.Tailnumber) +
                    (" Model Number: " + item.ModelNumber) +
                    (" Model Description: " + item.Modeldescription) +
                    (" Owner Company Name: " + item.CompanyName) +
                    (" Company Country Code: " + item.CountryCode) +
                    (" Company Country Name: " + item.CountryName) + "</span></br>";
                    
            }
            ataskaitaEuropa += "/<body>/<html>" + "</h1>";
            return ataskaitaEuropa;
        }


        private String getColor(bool plainInES)
        {
            if (plainInES) return "background-color:powderblue;";
            else return "background-color:tomato;";
        }

    }
}
