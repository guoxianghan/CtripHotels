using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flypeachTicketServer
{

    public class flypeachflightResults
    {
        public string flightId { get; set; }
        public string flightNumber { get; set; }
        public string originCode { get; set; }
        public string destinationCode { get; set; }
        public string departureTimezone { get; set; }
        public string arrivalTimezone { get; set; }
        public string flightDuration { get; set; }
        public string taxAdult { get; set; }
        public string taxChild { get; set; }
        public int taxInfant { get; set; }
        public string departureTime { get; set; }
        public string arrivalTime { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public Fares fares { get; set; }
    }

    public class Happlus
    {
        public string fareId { get; set; }
        public string fareCode { get; set; }
        public string bookingClass { get; set; }
        public int fare { get; set; }
        public object isSale { get; set; }
        public string bookingType { get; set; }
        public int seat { get; set; }
    }

    public class Happy
    {
        public string fareId { get; set; }
        public string fareCode { get; set; }
        public string bookingClass { get; set; }
        public int fare { get; set; }
        public object isSale { get; set; }
        public string bookingType { get; set; }
        public int seat { get; set; }
    }

    public class Prime
    {
        public string fareId { get; set; }
        public string fareCode { get; set; }
        public string bookingClass { get; set; }
        public int fare { get; set; }
        public object isSale { get; set; }
        public string bookingType { get; set; }
        public int seat { get; set; }
    }

    public class Fares
    {
        public Happlus happlus { get; set; }
        public Happy happy { get; set; }
        public Prime prime { get; set; }
    }

}
