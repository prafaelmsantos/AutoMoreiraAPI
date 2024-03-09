﻿namespace AutoMoreira.Core.Domains
{
    public class Vehicle : EntityBase
    {
        public int ModelId { get; private set; }
        public virtual Model Model { get; private set; } = null!;

        public string? Version { get; private set; }
        public FUEL FuelType { get; private set; }
        public double Price { get; private set; }
        public double Mileage { get; private set; }
        
        public int Year { get; private set; }
        public string Color { get; private set; } = null!;
        public int Doors { get; private set; }
        public TRANSMISSION Transmission { get; private set; }
        public int EngineSize { get; private set; }
        public int Power { get; private set; }
        public string? Observations { get; private set; }
        public bool Opportunity { get; private set; } = false;
        public bool Sold { get; private set; } = false;
        public DateTime? SoldDate { get; private set; }

        public virtual ICollection<VehicleImage> VehicleImages { get; private set; }


        public Vehicle() 
        {
            VehicleImages = new List<VehicleImage>();
        }

        public Vehicle(int id, int modelId, string version, FUEL fuelType, 
            double price, double mileage, int year, string color, int doors, TRANSMISSION transmission, 
            int engineSize, int power, string observations, bool opportunity)
        {
            Id = id;
            ModelId = modelId;
            Version = version;
            FuelType = fuelType;
            Price = price;
            Mileage = mileage;
            Year = year;
            Color = color;
            Doors = doors;
            Transmission = transmission;
            EngineSize = engineSize;
            Power = power;
            Observations = observations;
            Opportunity = opportunity;
            Sold = false;

            VehicleImages = new List<VehicleImage>();
        }

        public Vehicle(int modelId, string? version, FUEL fuelType, double price, double mileage, int year, string color, int doors, 
            TRANSMISSION transmission, int engineSize, int power, string? observations, bool opportunity, bool sold, DateTime? soldDate)
        {
            ModelId = modelId;
            Version = version;
            FuelType = fuelType;
            Price = price;
            Mileage = mileage;
            Year = year;
            Color = color;
            Doors = doors;
            Transmission = transmission;
            EngineSize = engineSize;
            Power = power;
            Observations = observations;
            Opportunity = opportunity;
            Sold = sold;
            SoldDate = soldDate ?? (sold ? DateTime.UtcNow : null);

            VehicleImages = new List<VehicleImage>();
        }

        public void UpdateVehicle(int modelId, string? version, FUEL fuelType, double price, double mileage, int year, string color, int doors,
            TRANSMISSION transmission, int engineSize, int power, string? observations, bool opportunity, bool sold, DateTime? soldDate)
        {
            ModelId = modelId;
            Version = version;
            FuelType = fuelType;
            Price = price;
            Mileage = mileage;
            Year = year;
            Color = color;
            Doors = doors;
            Transmission = transmission;
            EngineSize = engineSize;
            Power = power;
            Observations = observations;
            Opportunity = opportunity;
            Sold = sold;
            SoldDate = soldDate ?? (sold ? DateTime.UtcNow : null);

            VehicleImages = new List<VehicleImage>();
        }

        public void SetVehicleImages(List<VehicleImage> vehicleImages)
        {
            VehicleImages.Clear();
            VehicleImages = vehicleImages;
        }

    }
}
