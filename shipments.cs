using System;
using System.Collections.Generic;
using System.Text;
using System;

namespace oop
{
    public abstract partial class Shipment
    {
        private string trackingCode;
        private string description;
        private decimal weight;
        private decimal deliveryFee;

        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return trackingCode; }
            private set { if (!string.IsNullOrWhiteSpace(value)) trackingCode = value; }
        }

        public string Description
        {
            get { return description; }
            set { if (!string.IsNullOrWhiteSpace(value)) description = value; }
        }

        public decimal Weight
        {
            get { return weight; }
            set { if (value > 0) weight = value; }
        }

        public decimal DeliveryFee
        {
            get { return deliveryFee; }
            private set { if (value > 0) deliveryFee = value; }
        }

        public abstract decimal EstimatedCost { get; }

        public static int TotalShipmentsCreated;

        static Shipment()
        {
            TotalShipmentsCreated = 0;
            Console.WriteLine("Shipment System Initialized");
        }

        public static int GetTotalShipmentsCreated()
        {
            return TotalShipmentsCreated;
        }

        public Shipment(string trackingCode)
        {
            this.trackingCode = "DEFAULT";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;
            Destination = new DeliveryAddress();
            TrackingCode = trackingCode;

            TotalShipmentsCreated++;
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            this.trackingCode = "DEFAULT";
            this.description = "Unknown";
            this.weight = 1;
            this.deliveryFee = 50;

            TrackingCode = trackingCode;
            Description = description;
            Weight = weight;
            DeliveryFee = deliveryFee;
            Destination = destination;

            TotalShipmentsCreated++;
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0) Weight = newWeight;
        }

        public void UpdateWeight(decimal newWeight, decimal extraPackingWeight)
        {
            if (newWeight > 0 && extraPackingWeight >= 0)
                Weight = newWeight + extraPackingWeight;
        }

        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0) DeliveryFee = newFee;
        }

        public abstract void PrintShipment();

        public Shipment CopyShipment()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            Shipment copy = (Shipment)this.MemberwiseClone();
            copy.Destination = new DeliveryAddress(
                this.Destination.City,
                this.Destination.Street,
                this.Destination.Country);
            return copy;
        }

        partial void OnTrackingStatusChanged(string newStatus)
        {
            Console.WriteLine($"Tracking status changed to: {newStatus}");
        }
    }
}
