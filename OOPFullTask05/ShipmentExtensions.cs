using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal static class ShipmentExtensions
    {
        public static string GetSummary(this Shipment shipment)
        {
            if (shipment == null)
            {
                return "Invalid Shipment";
            }
            return $"{shipment.TrackingCode}, {shipment.Description}, {shipment.Weight}kg | {shipment.TrackingStatus} ";
        }

        public static bool IsDelivered(this Shipment shipment)
        {
            if (shipment == null)
            {
                return false;
            }
            string summary = shipment.GetSummary();
            return summary.Contains("Delivered", StringComparison.OrdinalIgnoreCase);
        }
    }
} 