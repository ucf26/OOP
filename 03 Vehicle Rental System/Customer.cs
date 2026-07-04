using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Vehicle_Rental_System
{
    internal class Customer
    {
        public string CustomerId { get; private set; }
        public string Name { get; private set; }
        public string Phone { get; private set; }
        public string Email { get; private set; }
        public string DriverLicenceNumber { get; private set; }

        public Customer(string id, string name, string phone, string email, string license)
        {
            CustomerId = id;
            Name = name;
            Phone = phone;
            Email = email;
            DriverLicenceNumber = license;
        }

        public string GetCustomerInfo()
        {
            return $"Customer ID: {CustomerId}, Customer Name: {Name}, Phone: {Phone}, Email: {Email}, LicenseNumber: {DriverLicenceNumber}";
        }
    }
}
