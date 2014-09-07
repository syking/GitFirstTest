using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TravelWeb.Models
{
    public class Package
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Validity { get; set; }
        public string Includes { get; set; }
        public string TermAndConditions { get; set; }

    }
    public class Hotel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }
    }

    public class PackageHotel
    {
        public Guid PackageId { get; set; }
        public Guid HotelId { get; set; }
    }

    public class Room
    {
        public Guid Id { get; set; }

        public Guid HotelId{get;set;}
        public string Name { get; set; }

    }

    public class RoomRates {
        public Guid Id { get; set; }
        public Guid RoomId { get; set; }
        public string Date { get; set; }
        public decimal Fifth { get; set; }
        public decimal FifthExt { get; set; }
        public decimal QAD { get; set; }
        public decimal QADExt { get; set; }
        public decimal TRP { get; set; }
        public decimal TRPExt { get; set; }
        public decimal TWN { get; set; }
        public decimal TWNExt { get; set; }
        public decimal CWB { get; set; }
        public decimal CWBExt { get; set; }
        public decimal CNB { get; set; }
        public decimal CNBExt { get; set; }

    }
}