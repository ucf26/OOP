using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace _03_Vehicle_Rental_System
{
    internal class Rental
    {
        public string RentalId { get; set; }
        public Vehicle Vehicle { get; set; }
        public Customer Customer { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }


        //public Rental(string id, Vehicle vehicle, Customer customer, DateTime startdate, DateTime enddate)
        //{
        //    RentalID = id;
        //    Vehicle = vehicle;
        //    Customer = customer;
        //    StartDate = startdate;
        //    EndDate = enddate;
        //}

        public Rental(string id, Vehicle vehicle, Customer customer, int days)
        {
            //RentalId = vehicle.VehicleId + customer.CustomerId;
            RentalId = id;
            Vehicle = vehicle;
            Customer = customer;
            StartDate = DateTime.Now;
            EndDate = StartDate.AddDays(days);
            Vehicle.Rent();
            IsActive = true;
        }

        //getRentalDuration() : Returns number of rental days
        public TimeSpan GetRentalDuration()
        {
            return EndDate - StartDate;
        }

        //getTotalCost(): Calculates total rental cost
        public double GetTotalCost()
        {
            return Vehicle.CalculateRentalCost(GetRentalDuration().Days);
        }

        //completeRental(): Marks rental as completed and returns vehicle
        public void CompleteVehicleRental()
        {
            IsActive = false;
            Vehicle.ReturnVehicle();
        }

        //getRentalInfo(): Returns formatted rental information
        public string GetRentalInfo()
        {
            StringBuilder S1 = new StringBuilder();
            S1.Append($"Rental ID : {RentalId}\n");
            S1.Append($"Customer  : {Customer.Name}\n");
            S1.Append($"Vehicle   : {Vehicle.Year} {Vehicle.Make} {Vehicle.VehicleModel}\n");
            S1.Append($"Duration  : {(EndDate - StartDate).Days}\n");
            S1.Append($"Total Cost: {GetTotalCost()}\n");
            //return $"Rental ID: {RentalId}, Customer: {Customer.Name}, Vehicle: {Vehicle.VehicleModel}";
            return S1.ToString();
        }
    }
}
