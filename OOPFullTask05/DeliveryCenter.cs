using OOPFullTask05;
using OOPFullTask05.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace OOPFullTask05
{
    internal class DeliveryCenter
    {
        public string CenterName { get; set; }
        public Driver AssignedDriver { get; set; }
        private Shipment[] _shipments;

        //ctor
        public DeliveryCenter(string centerName)
        {
            CenterName = centerName;
            _shipments = new Shipment[20];
        }

        public Shipment this[int index]
        {
            get
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                {
                    return _shipments[index];
                }
                return default;
            }
            set
            {
                if (_shipments != null && index >= 0 && index < _shipments.Length)
                {
                    _shipments[index] = value;
                }
            }
        }

        public Shipment this[string trackingCode]
        {
            get
            {
                if (_shipments != null && !string.IsNullOrWhiteSpace(trackingCode))
                {
                    for (int i = 0; i < _shipments.Length; i++)
                    {
                        if (_shipments[i] != null && _shipments[i].TrackingCode == trackingCode)
                        {
                            return _shipments[i];
                        }
                    }
                }
                return default;
            }
        }

        public bool AddShipment(Shipment shipment)
        {
            if (shipment == null) return false;
            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] == null || _shipments[i].TrackingCode == "UNKNOWN")
                {
                    _shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipmentByTrackingCode(string trackingCode)
        {
            if (string.IsNullOrWhiteSpace(trackingCode)) return false;

            for (int i = 0; i < _shipments.Length; i++)
            {
                if (_shipments[i] != null && _shipments[i].TrackingCode == trackingCode)
                {
                    _shipments[i] = null;
                    return true;
                }
            }
            return false;
        }

        public void PrintAllShipments()
        {
            Console.WriteLine("==================================================");
            Console.WriteLine($"Delivery Center ");
            Console.WriteLine("==================================================");
            if (_shipments != null)
            {
                for (int i = 0; i < _shipments.Length; i++)
                {
                    if (_shipments[i] != null)
                    {
                        _shipments[i].PrintShipment();
                    }
                }
            }
        }
        public void PrintTrackingStatuses()
        {
            if (_shipments != null)
            {
                foreach (ITrackable t in _shipments)
                {
                    if (t != null)
                    {
                        Console.WriteLine(t.GetTrackingStatus());
                    }
                }
            }
        }

    }


}
