using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp
{
    class Arrival
    {
        
        public string destinationName;
        public string lineid;
        public string timeToStation;
        
        public Arrival(string whereTo, string busNumber, string whenArrives)
        {
            this.destinationName = whereTo;
            this.lineid = busNumber;
            this.timeToStation = whenArrives;

        }

    }
}
