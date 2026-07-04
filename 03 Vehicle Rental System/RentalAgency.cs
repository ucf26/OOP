using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Vehicle_Rental_System
{
    internal class RentalAgency
    {
        public string AgencyName { get; private set; }
        public List<Vehicle> Vehicles { get; private set; }
        public List<Customer> Customers { get; private set; }
        public List<Rental> Rentals { get; private set; }

        public RentalAgency(string name)
        {
            AgencyName = name;
            Vehicles = new List<Vehicle>();
            Customers = new List<Customer>();
            Rentals = new List<Rental>();
        }
        //addVehicle(vehicle) : Adds vehicle to fleet
        public void AddVehicle(Vehicle vehicle) 
        {
            Vehicles.Add(vehicle);
        }
        //registerCustomer(customer): Registers a new customer
        public void RegisterCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
        //getAvailableVehicles(): Returns list of available vehicles
        public List<Vehicle> GetAvailableVehicles()
        {
            List<Vehicle> AvailableVehicles = new List<Vehicle>();

            foreach(Vehicle v in Vehicles)
            {
                if (v.IsAvailable)
                {
                    AvailableVehicles.Add(v);
                }
            }
            return AvailableVehicles;
        }
        //createRental(customer, vehicle, days): Creates new rental
        public Rental CreateRental(string id, Customer customer, Vehicle vehicle, int days)
        {
            if (vehicle.IsAvailable)
            {
                Rental r = new Rental(id, vehicle, customer, days);
                Rentals.Add(r);
                Console.WriteLine(r.GetRentalInfo());
                return r;
            }
            throw new Exception("The Vehicle is Already Rent !!");
            return null;
            
        }

        //completeRental(rentalId): Completes a rental and calculates final cost
        public void CompleteRental(string rentalid)
        {
            //Rental Tmp = (Rental)Rentals.Where(v => v.RentalId == rentalid);

            Rental Tmp = Rentals.FirstOrDefault(r => r.RentalId == rentalid);
            if(null == Tmp)
            {
                throw new Exception("No Rental with this ID !!");
            }
            Tmp.CompleteVehicleRental();
        }
        //getActiveRentals(): Returns all active rentals
        public List<Rental> GetActiveRentals()
        {
            List<Rental> ActiveRentals = new List<Rental>();

            foreach (Rental rental in Rentals)
            {
                if (rental.IsActive)
                {
                    ActiveRentals.Add(rental);
                }
            }
            return ActiveRentals;
        }
        //getCustomerRentals(customerId): Returns customer's rental history
        public List<Rental> GetCustomerRentals(string customerid)
        {
            List<Rental> CustomerRentals = new List<Rental>();
            foreach(Rental R in Rentals)
            {
                if(R.Customer.CustomerId == customerid)
                {
                    CustomerRentals.Add(R);
                }
            }
            return CustomerRentals;
        }

        //displayFleet() : Shows all vehicles and their status
        public void DisplayFleet()
        {
            foreach(Vehicle V in Vehicles)
            {
                Console.WriteLine(V.GetVehicleInfo());
            }
        }
    }
}
