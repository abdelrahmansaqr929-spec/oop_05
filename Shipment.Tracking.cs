using oop;
using System;
using System.Collections.Generic;
using System.Text;

using System;

namespace oop
{
    public partial class Shipment
    {
        private string trackingStatus = "In Transit";

        public string TrackingStatus
        {
            get { return trackingStatus; }
            private set { if (!string.IsNullOrWhiteSpace(value)) trackingStatus = value; }
        }

        public string GetTrackingStatus()
        {
            if (TrackingStatus.Equals("Delivered", StringComparison.OrdinalIgnoreCase))
                return $"Shipment {TrackingCode} has been {TrackingStatus}.";
            return $"Shipment {TrackingCode} is {TrackingStatus}.";
        }

        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                TrackingStatus = newStatus;
                OnTrackingStatusChanged(newStatus);
            }
        }

        partial void OnTrackingStatusChanged(string newStatus);
    }
}



   