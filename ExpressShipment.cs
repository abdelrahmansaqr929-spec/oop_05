using oop;
using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        public decimal ExtraFee { get; private set; }

        public ExpressShipment(string trackingCode) : base(trackingCode)
        {
            ExtraFee = 30;
        }

        public ExpressShipment(string trackingCode, string description, decimal weight,
                               decimal deliveryFee, DeliveryAddress destination, decimal extraFee)
            : base(trackingCode, description, weight, deliveryFee, destination)
        {
            if (extraFee >= 0) ExtraFee = extraFee;
        }

        public override decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5) + ExtraFee; }
        }

        public override void PrintShipment()
        {
            Console.WriteLine("Express Shipment");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}