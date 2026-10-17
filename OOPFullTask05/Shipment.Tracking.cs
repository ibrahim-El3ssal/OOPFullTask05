using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal partial class Shipment
    {
        private string _trackingStatus;

        // 1. الإعلان عن الـ Partial Method (Declaration)
        partial void OnTrackingStatusChanged(string newStatus);

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

        public string GetTrackingStatus()
        {
            return TrackingStatus;
        }

        // 2. الاستدعاء من UpdateTrackingStatus()
        public void UpdateTrackingStatus(string newStatus)
        {
            if (!string.IsNullOrWhiteSpace(newStatus))
            {
                // استدعاء الدالة الجزئية (التي تم تنفيذها في Shipment.cs)
                OnTrackingStatusChanged(newStatus);

                TrackingStatus = newStatus;
            }
        }
    }
}

