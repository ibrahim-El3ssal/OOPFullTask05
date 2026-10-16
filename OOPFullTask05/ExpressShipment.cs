using OOPFullTask05;
using OOPFullTask05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal class ExpressShipment : Shipment , ITrackable , IInsurable
    {
        private decimal _extraFee;
        public ExpressShipment(decimal extraFee, string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            ExtraFee = extraFee;
        }

        public decimal ExtraFee
        {
            get
            {
                return _extraFee;
            }
            set
            {
                if (value >= 0)
                {
                    _extraFee = value;
                }
            }
        }

        //public override decimal EstimatedCost 
        //{

        //    get { return DeliveryFee + (Weight * 5) + ExtraFee;  }
        //}
        //public override void PrintShipment()
        //{
        //    Console.WriteLine("Express Shipment\n");
        //    Console.WriteLine($"Tracking Code : {TrackingCode}");
        //    Console.WriteLine($"Extra Fee     : {ExtraFee} EGP");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        //    Console.WriteLine("--------------------------------------------------");
        //}

        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} has been Delivered.";
        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.08m;
        }
    }
}