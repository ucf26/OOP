namespace _03_Vehicle_Rental_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create rental agency
            RentalAgency Agency = new RentalAgency("Prime Car Rentals");

            // Add vehicles to fleet
            Vehicle car1 = new Vehicle("V001", "Toyota", "Camry", 2022, 45.00f);
            Vehicle car2 = new Vehicle("V002", "Honda", "Accord", 2023, 50.00f);
            Vehicle car3 = new Vehicle("V003", "Tesla", "Model 3", 2023, 85.00f);

            Agency.AddVehicle(car1);
            Agency.AddVehicle(car2);
            Agency.AddVehicle(car3);

            // Register customers
            Customer customer1 = new Customer("C001", "Alice Johnson", "555-0123", "alice@email.com", "DL123456");
            Customer customer2 = new Customer("C002", "Bob Smith", "555-0456", "bob@email.com", "DL789012");

            Agency.RegisterCustomer(customer1);
            Agency.RegisterCustomer(customer2);

            // Display available vehicles
            Agency.DisplayFleet();

            // Create rentals
            Console.WriteLine("\n================= Creating Rentals =================\n");
            Rental rental1 = Agency.CreateRental("R001", customer1, car1, 5);
            Console.WriteLine("Rental created: " + rental1.RentalId);
            Console.WriteLine("Total Cost: $" + rental1.GetTotalCost());
            Console.WriteLine("");
            Console.WriteLine("");

            Rental rental2 = Agency.CreateRental("R002", customer2, car3, 3);
            Console.WriteLine("Rental created: " + rental2.RentalId);
            Console.WriteLine("Total Cost: $" + rental2.GetTotalCost());
            Console.WriteLine("");
            Console.WriteLine("");



            // Display available vehicles after rentals
            Console.WriteLine("\n\n================= After Rentals =================\n\n");
            Agency.DisplayFleet();

            // Complete a rental
            Agency.CompleteRental(rental1.RentalId);
            Console.WriteLine("Rental " + rental1.RentalId + " completed!");

            // Display customer rental history
            List<Rental> CustomerRentals = new List<Rental>();
            CustomerRentals = Agency.GetCustomerRentals("C001");
            Console.WriteLine("Alice's rental history: " + CustomerRentals.Count + " rental(s)");
        }
    }
}
