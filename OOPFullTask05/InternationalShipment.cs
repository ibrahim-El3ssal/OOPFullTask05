using OOPFullTask05;
using OOPFullTask05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal class InternationalShipment : Shipment, ITrackable , IInsurable
    {
        private string _destinationCountry;
        public string DestinationCountry
        {
            get { return _destinationCountry; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _destinationCountry = value;
                }
            }
        }

        private decimal _customsFee;
        public decimal CustomsFee
        {
            get { return _customsFee; }
            set
            {
                if (value >= 0)
                    _customsFee = value;
            }
        }
        //public override decimal EstimatedCost 
        //{
        //    get{ return DeliveryFee + (Weight * 5) + CustomsFee; }
        //}



        public InternationalShipment(string destinationCountry, decimal customsFee, string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }

        //public override void PrintShipment()
        //{
        //    Console.WriteLine("International Shipment\n");
        //    //base.PrintShipment();
        //    Console.WriteLine($"Tracking Code : {TrackingCode}");
        //    Console.WriteLine($"Destination Country : {DestinationCountry}");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            
        //    Console.WriteLine("--------------------------------------------------");
        //}


        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Out for Delivery.";

        }

        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.12m ; 
        }
    }
}
