using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace BusBoard.ConsoleApp
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var client = new RestClient("https://api.tfl.gov.uk");

            var request = new RestRequest("StopPoint/Mode/bus/Disruption");

            var response = client.Execute(request).Content;

            Console.WriteLine(response);
            Console.ReadLine();
        }
    }
}