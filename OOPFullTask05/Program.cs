
namespace OOPFullTask05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 01 — Theoretical Questions
            /// Q3  Static Members
            // a) What is a static field, and how is it different from an instance field ?
            // Static Field: Belongs to the class itself, not to any object instance , Accessed directly via the class name . 
            // Instance Field: Belongs to a specific object created with new , Accessed using the object reference . 

            /// b) What is a static method? Can a static method directly access instance members?
            /// Static Method: A method that belongs to the class itself rather than any object instance, and is called directly using the class name.
            /// Accessing Instance Members: No, it cannot directly access non-static (instance) fields or methods because it has no this reference and doesn't know which specific object's data to access.
            /// 

            /// c) What is a static constructor, and when is it executed?
            /// Static Constructor: A special constructor used to initialize static data or perform actions needed only once for the class. It cannot take access modifiers . 
            /// When it is executed: Automatically, just once , the first instance of the class is created.
            /// 

            /// d) What is a static class? Can you create an object from a static class?
            /// Static Class: A class marked with the static keyword that can only contain static members, cannot be inherited, and serves as a container for utility or helper methods.
            /// Creating Objects: No, you cannot create an instance (object) of a static class using the new keyword because the compiler prevents it.
            /// 

            /// Q4  Extension Methods 
            /// a) What is an Extension Method? 
            /// Extension Method: A special type of static method that allows you to "add" new methods to an existing type (class or struct) without modifying its original source code or creating a new derived class. It must be defined inside a static class, and its first parameter must use the this keyword followed by the type being extended.
            /// 

            /// b) What keyword must be used in the first parameter of an extension method?
            /// Keyword: The this keyword. It must precede the type being extended in the first parameter to inform the compiler that this method acts as an extension method for that specific type.
            /// 
            /// c) Where must an extension method be declared?
            /// Declaration Location: It must be declared inside a static class as a static method.
            /// 
            /// d) Can an extension method access private members of the class it extends?
            /// Access to Private Members: No, it cannot access private of the class  .
            /// 

            /// Q5  Partial Classes and Partial Methods
            /// a) What is a Partial Class? 
            /// Partial Class: A feature that allows the definition of a single class to be split across multiple files. When compiled, the C# compiler combines all parts into a single class.
            /// 
            /// b) Why would a developer split one class into multiple files?
            /// Separation of Generated Code from Custom Code , Team Collaboration , Code Organization & Readability . 
            /// 
            /// c) What is a Partial Method?
            /// A method whose declaration is defined in one part of a partial type, and its optional implementation can be defined in another part. 
            /// 
            ///d) What happens if a declared partial method has no implementation?
            ///If no implementation is provided by the developer, the compiler removes both the method definition and all calls to it during compilation.



            #endregion

            #region In Main 
       
            Console.WriteLine("==========================================");
            Console.WriteLine("Smart Delivery Management System");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine("==========================================\n");
            Console.WriteLine("Shipment System Initialized");
            Console.WriteLine("\n==========================================");
            Console.WriteLine();


            Console.WriteLine("==========================================");
            Console.WriteLine("Creating Shipments...");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            DeliveryAddress address1 = new DeliveryAddress("Cairo", "Tahrir St.", 10);
            Shipment shipment1 = new Shipment("SH001", "Standard", 3.0m, 50.0m, address1, "In Transit");
            Console.WriteLine("Standard Shipment Created");

            Shipment shipment2 = new Shipment("SH002", "Express", 2.0m, 75.0m, address1, "Out For Delivery");
            Console.WriteLine("Express Shipment Created");

            Shipment shipment3 = new Shipment("SH003", "International", 8.0m, 200.0m, address1, "Delivered");
            Console.WriteLine("International Shipment Created");
            Console.WriteLine();

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Object Copying");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine($"Original Shipment  : {shipment1.TrackingCode}");
            Shipment assignedShipment = shipment1;
            Console.WriteLine($"Assigned Shipment  : {assignedShipment.TrackingCode}");
            Console.WriteLine();

            bool isSameObject = object.ReferenceEquals(shipment1, assignedShipment);
            Console.WriteLine($"Same Object : {isSameObject}");
            Console.WriteLine();

            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Shallow Copy");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            Shipment shallowCopyShipment = shipment1.ShallowCopy();
            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopyShipment.Destination.City}");
            Console.WriteLine();

            Console.WriteLine("Changing copied shipment address...");

            shallowCopyShipment.Destination.City = "Giza";
            Console.WriteLine();

            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {shallowCopyShipment.Destination.City}");
            Console.WriteLine();

            bool isSameAddressInShallow = object.ReferenceEquals(shipment1.Destination, shallowCopyShipment.Destination);
            Console.WriteLine($"Same DeliveryAddress Object : {isSameAddressInShallow}");
            Console.WriteLine();

   
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Deep Copy");
            Console.WriteLine("------------------------------------------");
            Console.WriteLine();

            shipment1.Destination.City = "Cairo";
            Shipment deepCopyShipment = shipment1.DeepCopy();

            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopyShipment.Destination.City}");
            Console.WriteLine();

            Console.WriteLine("Changing copied shipment address...");
            deepCopyShipment.Destination.City = "Giza";
            Console.WriteLine();

            Console.WriteLine($"Original Shipment Address : {shipment1.Destination.City}");
            Console.WriteLine($"Copied Shipment Address   : {deepCopyShipment.Destination.City}");
            Console.WriteLine();

            bool isSameAddressInDeep = object.ReferenceEquals(shipment1.Destination, deepCopyShipment.Destination);
            Console.WriteLine($"Same DeliveryAddress Object : {isSameAddressInDeep}");
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Extension Methods");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.WriteLine($"{shipment1.TrackingCode} | {shipment1.Description} | {shipment1.Weight} KG | {shipment1.GetTrackingStatus()}");
            Console.WriteLine($"{shipment2.TrackingCode} | {shipment2.Description} | {shipment2.Weight} KG | {shipment2.GetTrackingStatus()}");
            Console.WriteLine($"{shipment3.TrackingCode} | {shipment3.Description} | {shipment3.Weight} KG | {shipment3.GetTrackingStatus()}");
            Console.WriteLine();

            Console.WriteLine($"{shipment1.TrackingCode} Is Delivered : {shipment1.IsDelivered()}");
            Console.WriteLine($"{shipment3.TrackingCode} Is Delivered : {shipment3.IsDelivered()}");
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Tracking Status");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            shipment1.UpdateTrackingStatus("Out For Delivery");
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Static Utilities");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            DeliveryUtilities.PrintSeparator();
            DeliveryUtilities.PrintSystemTitle(); 
            DeliveryUtilities.PrintSeparator();
            Console.WriteLine();

            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
            Console.WriteLine();

          
            Console.WriteLine("==========================================");
            Console.WriteLine("Partial Method");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            shipment1.UpdateTrackingStatus("Delivered");
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("Assignment Completed");
            Console.WriteLine("==========================================");

            Console.ReadLine();
            #endregion

            Console.ReadLine();
        }
    }
}

