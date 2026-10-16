using OOPFullTask05;
using OOPFullTask05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal class StandardShipment : Shipment, ITrackable , IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination) : base(trackingCode, description, weight, deliveryFee, destination) { }
        //public override void PrintShipment()
        //{
        //    Console.WriteLine("Standard Shipment\n");
        //    Console.WriteLine($"Tracking Code : {TrackingCode}");
        //    Console.WriteLine($"Description   : {Description}");
        //    Console.WriteLine($"Weight        : {Weight} KG");
        //    Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
        //    Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
        //    Console.WriteLine("--------------------------------------------------");
        //}

        //public override decimal EstimatedCost 
        //{
        //    get{ return DeliveryFee + (Weight * 5); }
        //}
        public string GetTrackingStatus()
        {
            return $"Shipment {TrackingCode} is Ready." ;
        }
        public decimal CalculateInsurance()
        {
            return EstimatedCost * 0.05m ; 
        }
    }
}