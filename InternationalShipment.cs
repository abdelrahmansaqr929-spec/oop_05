using oop;
using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace opp__04
{
    public class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public string DestinationCountry { get; private set; }
        public decimal CustomsFee { get; private set; }

        public InternationalShipment(string trackingCode) : base(trackingCode)
        {
            DestinationCountry = "Unknown";
            CustomsFee = 100;
        }

        public InternationalShipment(string trackingCode, string description, decimal weight,
                                     decimal deliveryFee, DeliveryAddress destination,
                                     string destinationCountry, decimal customsFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (!string.IsNullOrWhiteSpace(destinationCountry)) DestinationCountry = destinationCountry;
            if (customsFee >= 0) CustomsFee = customsFee;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + CustomsFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("International Shipment");
            Console.WriteLine($"Tracking Code       : {TrackingCode}");
            Console.WriteLine($"Destination Country : {DestinationCountry}");
            Console.WriteLine($"Estimated Cost      : {EstimatedCost} EGP");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m;
        }
    }
}