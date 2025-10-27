using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWashManagement.Core.FileHandlers;
using CarWashManagement.Core.Enums;

namespace CarWashManagement.Core.Managers
{
    // This manager handles all business logic related to vehicles and services
    public class CarManager
    {
        private readonly IFileHandler<Vehicle> vehicleFileHandler;
        private readonly IFileHandler<Service> serviceFileHandler;

        public CarManager(IFileHandler<Vehicle> vehicleFileHandler, IFileHandler<Service> serviceFileHandler)
        {
            this.vehicleFileHandler = vehicleFileHandler;
            this.serviceFileHandler = serviceFileHandler;

            // Create default data if the vehicles.txt and services.txt is empty.
            InitializeDefaultVehicles();
            InitializeDefaultServices();
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

        // Method to ensure there is default data for services.
        private void InitializeDefaultServices()
        {
            List<Service> services = serviceFileHandler.Load();

            if (!services.Any())
            {
                List<Service> defaults = new List<Service>
                {
                    new Service("Wax", 0.00m, ServicePricingType.VehicleBaseFeeMultiplier, 1),
                    new Service("Acid Rain Remover", 0.00m, ServicePricingType.ManualInput),
                    new Service("Buffing", 0.00m, ServicePricingType.ManualInput),
                    new Service("Back to Zero", 0.00m, ServicePricingType.ManualInput)
                };

                serviceFileHandler.Save(defaults);
            }
        }

        // Method to get the list of vehicles.
        public List<Vehicle> GetVehicles()
        {
            return vehicleFileHandler.Load();
        }

        // Method to get the list of services.
        public List<Service> GetServices()
        {
            return serviceFileHandler.Load();
        }
    }
}
