using CarWashManagement.Core.FileHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.Core.Managers
{
    // This manager handles all business logic related to vehicles and services
    public class CarManager
    {
        private readonly IFileHandler<Vehicle> vehicleFileHandler;
        // private readonly IFileHandler<Service> serviceFileHandler;

        public CarManager(IFileHandler<Vehicle> vehicleFileHandler)
        {
            this.vehicleFileHandler = vehicleFileHandler;

            // Create default data if the vehicle.txt is empty.
            InitializeDefaultVehicles();
        }

        // Method to ensure there is default data for vehicles.
        private void InitializeDefaultVehicles()
        {
            List<Vehicle> vehicles = vehicleFileHandler.Load();

            if (!vehicles.Any())
            {
                List<Vehicle> defaults = new List<Vehicle>
                {
                    new Vehicle("Sedan", 200.00m, 100.00m, 100.00m),
                    new Vehicle("SUV", 250.00m, 150.00m, 100.00m),
                    new Vehicle("Van", 300.00m, 180.00m, 120.00m),
                    new Vehicle("Truck", 350.00m, 200.00m, 150.00m)
                };

                vehicleFileHandler.Save(defaults);
            }
        }

        // Method to get the list of vehicles.
        public List<Vehicle> GetVehicles()
        {
            return vehicleFileHandler.Load();
        }
    }
}
