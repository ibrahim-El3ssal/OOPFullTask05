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

            // استدعاء الدالة مباشرة باسم الكلاس بدون إنشاء كائن
            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion

            Console.ReadLine();
        }
    }
}
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

            // استدعاء الدالة مباشرة باسم الكلاس بدون إنشاء كائن
            Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");

            #endregion

            Console.ReadLine();
        }
    }
}
