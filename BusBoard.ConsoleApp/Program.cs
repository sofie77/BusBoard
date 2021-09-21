using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;

namespace BusBoard.ConsoleApp
{
  class Program
  {

       
        static void Main(string[] args)
    {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            var client = new RestClient("https://api.tfl.gov.uk/");
            

            var request = new RestRequest("StopPoint/490008660N/Arrivals", Method.GET);
            request.AddHeader("app_key", "41c57b07716140dc953617f2dab194a7");
            var response = client.Execute<List<Arrival>>(request).Data;
            
            //foreach(seconds in timeToStation)

                foreach (var bus in response)
            {
                    if (bus.timeToStation >= 0)
                    {
                        TimeSpan t = TimeSpan.FromSeconds(bus.timeToStation);
                        string answer.Sort = t.ToString(@"hh\:mm\:s");

                    Console.WriteLine($"Bus destination: {bus.destinationName}, bus number: {bus.lineId}, time to arrival: {answer}");
                    }
               
                
            }
            
                    

                
            
            Console.Read();


            
            //TODO: method to convert seconds into minutes, and to put the data into soonest arrival for the earliest 5
            




        }
       
  }
}
