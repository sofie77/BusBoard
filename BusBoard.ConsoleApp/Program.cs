﻿using System;
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
            //client.Authenticator = new HttpBasicAuthenticator("username", "password");

            var request = new RestRequest("StopPoint/490008660N/Arrivals", DataFormat.Json);

            var response = client.Get(request);

            Console.WriteLine(response);

            Console.Read();

            //testing github




        }
  }
}
