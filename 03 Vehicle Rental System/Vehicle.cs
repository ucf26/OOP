using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Vehicle_Rental_System
{
    internal class Vehicle
    {
        public string VehicleId { get; private set; }
        public string Make { get; private set; }
        public string VehicleModel { get; private set; }
        public int Year { get; private set; }
        public float DailyRate { get; private set; }
        public bool IsAvailable { get; private set; }


        public Vehicle(string id, string make, string model, int year, float dailyrate)
        {
            VehicleId = id;
            Make = make;
            VehicleModel = model;
            Year = year;
            DailyRate = dailyrate;
            IsAvailable = true;
        }
        // getVehicleInfo(): Returns formatted vehicle information
        public string GetVehicleInfo()
        {
            string status = IsAvailable ? "Available" : "Rented";
            return $"{VehicleId} - {Year} {Make} {VehicleModel} - ${DailyRate:f2}/day - {status}";
        }

        //rent() : Marks vehicle as unavailable

        public void Rent()
        {
            if (this.IsAvailable)
            {
                IsAvailable = false;
            }
            else
            {
                throw new Exception("This vehicle is already Rent !!");
            }

        }


        public void ReturnVehicle()
        {
            if (!IsAvailable)
            {
                IsAvailable = true;
            }
            else
            {
                throw new Exception("This vehicle is already Free !!");
            }
        }

        // calculateRentalCost(days): Calculates total cost for rental period
        public double CalculateRentalCost(int days)
        {
            return days * DailyRate;
        }
    }
}
