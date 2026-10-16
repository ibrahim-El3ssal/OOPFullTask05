using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal class Shipment
    {
        private string _trackingCode;
        private string _description;
        private decimal _weight;
        private decimal _deliveryFee;
        public static int TotalShipmentsCreated;
        public DeliveryAddress Destination { get; set; }

        public string TrackingCode
        {
            get { return _trackingCode; }
        }

        public string Description
        {
            get { return _description; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                {
                    _description = value;
                }
            }
        }

        public decimal Weight
        {
            get { return _weight; }
            set
            {
                if (value > 0)
                {
                    _weight = value;
                }
            }
        }

        public decimal DeliveryFee
        {
            get { return _deliveryFee; }
            private set
            {
                if (value > 0)
                {
                    _deliveryFee = value;
                }
            }
        }

        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee, DeliveryAddress destination)
        {
            _trackingCode = !string.IsNullOrWhiteSpace(trackingCode) ? trackingCode : "UNKNOWN";
            _description = !string.IsNullOrWhiteSpace(description) ? description : "Unknown";
            _weight = weight > 0 ? weight : 1.0m;
            _deliveryFee = deliveryFee > 0 ? deliveryFee : 50.0m;

            Destination = destination;
            TotalShipmentsCreated++;
        }

        public Shipment(string trackingCode) : this(trackingCode, "Unknown", 1.0m, 50.0m, new DeliveryAddress("Cairo", "Main St.", 1)) { }

        public decimal EstimatedCost
        {
            get { return DeliveryFee + (Weight * 5); }
        }


        public void UpdateDeliveryFee(decimal newFee)
        {
            if (newFee > 0)
            {
                DeliveryFee = newFee;
            }
        }

        public void UpdateWeight(decimal newWeight)
        {
            if (newWeight > 0)
            {
                Weight = newWeight;
            }
        }
        public void UpdateWeight(decimal baseWeight, decimal extraPackingWeight)
        {
            if (baseWeight > 0 && extraPackingWeight >= 0)
            {
                Weight = baseWeight + extraPackingWeight;
            }
        }
        public void PrintShipment()
        {
            Console.WriteLine("Standard Shipment\n");
            Console.WriteLine($"Tracking Code : {TrackingCode}");
            Console.WriteLine($"Description   : {Description}");
            Console.WriteLine($"Weight        : {Weight} KG");
            Console.WriteLine($"Delivery Fee  : {DeliveryFee} EGP");
            Console.WriteLine($"Estimated Cost: {EstimatedCost} EGP");
            Console.WriteLine("--------------------------------------------------");
        }

        public Shipment CopyShipment()
        {
            return new Shipment(
                this.TrackingCode,
                this.Description,
                this.Weight,
                this.DeliveryFee,
                new DeliveryAddress(this.Destination.City, this.Destination.Street, this.Destination.BuildingNumber)
            );
        }

        public Shipment ShallowCopy()
        {
            return (Shipment)this.MemberwiseClone();
        }

        public Shipment DeepCopy()
        {
            DeliveryAddress newAddress = new DeliveryAddress(
            this.Destination.City,
            this.Destination.Street,
            this.Destination.BuildingNumber
                );
            return new Shipment(
                this.TrackingCode,
                this.Description,
                this.Weight,
                this.DeliveryFee,
                newAddress
            );
        }
    }


}
