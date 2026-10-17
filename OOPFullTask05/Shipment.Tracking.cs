using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal partial class Shipment
    {
        private string _trackingStatus;

        public string TrackingStatus
        {
            get { return _trackingStatus; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _trackingStatus = value;
                }
            }
        }

        // GetTrackingStatus Method
        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        // UpdateTrackingStatus Method
        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                TrackingStatus = newStatus;
                Console.WriteLine($"Tracking status updated to: {TrackingStatus}");
            }
        }
    }
}