namespace OOPFullTask05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions

            #endregion

            #region In Main 
            ///1  Object Copying
            DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir St.", 10);
            Shipment shipment1 = new Shipment("SH-101", "Electronics", 2.5m, 100.0m, address1);

            Console.WriteLine("1.Demonstrating Reference Assignment\n");

            Console.WriteLine($" before modifying : {shipment1.Description}");

            Shipment shipment2 = shipment1;

            shipment2.Description = "Laptops";

            Console.WriteLine($"shipment1 after modifying : {shipment1.Description}");
            Console.WriteLine($"shipment2 after modifying : {shipment2.Description}");

            //2  Shallow Copy
            Console.WriteLine("\n2.Demonstrating ShallowCopy()\n");

            Shipment shipment3 = shipment1.ShallowCopy();
            shipment3.Description = "Smartphones";

            Console.WriteLine($"shipment1 after modifying : {shipment1.Description}");
            Console.WriteLine($"shipment3 after modifying : {shipment3.Description}");


            shipment3.Destination.City = "Alexandria";
            Console.WriteLine($"\nshipment1 after modifying : {shipment1.Destination.City}");
            Console.WriteLine($"shipment2 after modifying : {shipment2.Destination.City}");
            Console.WriteLine($"shipment3 after modifying : {shipment3.Destination.City}");

            //2  Shallow Copy
            Console.WriteLine("\n2.Demonstrating DeepCopy()\n");

            Shipment shipment4 = shipment1.DeepCopy();
            shipment4.Destination.City = "Giza";
            shipment1.Destination.City = "aswan";

            Console.WriteLine($"\nshipment1 before modifying : {shipment1.Destination.City}");
            Console.WriteLine($"shipment2   before modifying : {shipment2.Destination.City}");
            Console.WriteLine($"shipment3   before modifying : {shipment3.Destination.City}");
            Console.WriteLine($"shipment4   before modifying : {shipment4.Destination.City}");

            bool isSameAddressObject = object.ReferenceEquals(shipment1.Destination, shipment4.Destination);
            Console.WriteLine($"Same Address object?\t{isSameAddressObject}\t\t{isSameAddressObject}");


            #endregion

            Console.ReadLine();
        }
    }
}
