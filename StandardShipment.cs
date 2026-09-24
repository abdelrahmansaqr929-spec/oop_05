using oop;
using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class StandardShipment : Shipment, ITrackable, IInsurable
    {
        public StandardShipment(string trackingCode) : base(trackingCode) { }

        public StandardShipment(string trackingCode, string description, decimal weight,
                                decimal deliveryFee, DeliveryAddress destination)
            : base(trackingCode, description, weight, deliveryFee, destination) { }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Standard Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m;
        }
    }
}
  
