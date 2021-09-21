using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RestSharp.Authenticators;
using System.Net;
using MarkEmbling.PostcodesIO;

namespace BusBoard.ConsoleApp
{
  class Program
  {

       
        static void Main(string[] args)
    {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            Console.Write("insert postcode ");
            string postcode = Console.ReadLine();
            string cleanPostcode = postcode.Replace(" ", "");
            Console.WriteLine(cleanPostcode);

            //API call to postcodes.io

            var baseURL = new PostcodesIOClient();
            var postcodeRequest = baseURL.Lookup(cleanPostcode);
            
            Console.WriteLine($"lat: {postcodeRequest.Latitude}, lon: {postcodeRequest.Longitude}");

            //API call to Tfl
            //var client = new RestClient("https://api.tfl.gov.uk/");




            //var request = new RestRequest($"StopPoint/{stopcode}/Arrivals", Method.GET);
            //request.AddHeader("app_key", "41c57b07716140dc953617f2dab194a7");
            //var response = client.Execute<List<Arrival>>(request).Data;
            //var SortedList = response.OrderBy(x => x.timeToStation).ToList();
            //var limitedSortedList = SortedList.GetRange(0, 5);
            

            //    foreach (var bus in limitedSortedList)
            //{
            //        if (bus.timeToStation >= 0)
            //        {
            //            TimeSpan t = TimeSpan.FromSeconds(bus.timeToStation);
            //            string answer = t.ToString(@"hh\:mm\:ss");
                    

            //        Console.WriteLine($"Bus destination: {bus.destinationName}, bus number: {bus.lineId}, time to arrival: {answer}");
            //        }
               
                
            //}
            
                    

                
            
            Console.Read();


            
            //TODO: method to convert seconds into minutes, and to put the data into soonest arrival for the earliest 5
            




        }
       
  }
}
