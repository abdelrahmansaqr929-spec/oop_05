using oop;
using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            string type = shipment.GetType().Name.Replace("Shipment", "");
            return $"{shipment.TrackingCode} | {type} | {shipment.Weight} KG | {shipment.TrackingStatus}";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            return shipment.TrackingStatus.Equals("Delivered", StringComparison.OrdinalIgnoreCase);
        }
    }
}