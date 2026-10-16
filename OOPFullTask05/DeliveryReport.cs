using OOPFullTask05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal class DeliveryReport
    {
        public void PrintShipment(ITrackable shipment)
        {
            Console.WriteLine(shipment.GetTrackingStatus());
        }
        public void PrintInsurance(IInsurable shipment)
        {
            if (shipment != null)
            {
                decimal insuranceCost = shipment.CalculateInsurance();
                Console.WriteLine($"Insurance Cost: {insuranceCost:F2} EGP" );
            }
        }
    }
}
