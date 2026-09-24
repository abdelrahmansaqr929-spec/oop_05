using oop;
using System;
using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.Text;

namespace oop
{
    public class DeliveryCenter
    {
        private List<Shipment> shipments = new List<Shipment>();

        public void AddShipment(Shipment shipment)
        {
            if (shipment != null) shipments.Add(shipment);
        }

        public void PrintAllShipments()
        {
            foreach (Shipment s in shipments)
            {
                s.PrintShipment();
                Console.WriteLine("------------------------------------------");
            }
        }

        public void PrintTrackingStatuses()
        {
            foreach (Shipment s in shipments)
            {
                if (s is ITrackable t)
                    Console.WriteLine(t.GetTrackingStatus());
            }
        }
    }
}