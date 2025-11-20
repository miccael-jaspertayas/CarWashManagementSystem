using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarWashManagement.Core.Database.SqlHandlers;
using CarWashManagement.Core.Database;
using CarWashManagement.Core.Enums;

namespace CarWashManagement.Core.Managers
{
    // This manager handles all business logic related to vehicles and services
    public class CarManager
    {
        private readonly ISqlHandler<Vehicle> vehicleSqlHandler;
        private readonly ISqlHandler<Service> serviceSqlHandler;
        private readonly AuditSqlHandler auditSqlHandler;

        private List<Vehicle> vehicles;
        private List<Service> services;

        public CarManager(ISqlHandler<Vehicle> vehicleSqlHandler, ISqlHandler<Service> serviceSqlHandler, AuditSqlHandler auditSqlHandler)
        {
            // Ensure database exists
            DatabaseConnection.EnsureDatabaseExists();
            
            this.vehicleSqlHandler = vehicleSqlHandler;
            this.serviceSqlHandler = serviceSqlHandler;
            this.auditSqlHandler = auditSqlHandler;

            vehicles = vehicleSqlHandler.Load();
            services = serviceSqlHandler.Load();

            // Create default data if the database is empty.
            InitializeDefaultVehicles();
            InitializeDefaultServices();
        }

        // Method to ensure there is default data for vehicles.
        private void InitializeDefaultVehicles()
        {
            if (!vehicles.Any())
            {
                List<Vehicle> defaults = new List<Vehicle>
                {
                    new Vehicle("Sedan", 200.00m, 100.00m, 100.00m),
                    new Vehicle("SUV", 250.00m, 150.00m, 100.00m),
                    new Vehicle("Van", 300.00m, 180.00m, 120.00m),
                    new Vehicle("Truck", 350.00m, 200.00m, 150.00m)
                };

                vehicleSqlHandler.Save(defaults);
                vehicles = defaults;
            }
        }

        // Method to ensure there is default data for services.
        private void InitializeDefaultServices()
        {
            if (!services.Any())
            {
                List<Service> defaults = new List<Service>
                {
                    new Service("Phủ sáp", 0.00m, ServicePricingType.VehicleBaseFeeMultiplier, 1),
                    new Service("Tẩy cặn canxi", 0.00m, ServicePricingType.ManualInput),
                    new Service("Đánh bóng", 0.00m, ServicePricingType.ManualInput),
                    new Service("Khử mùi diệt khuẩn", 0.00m, ServicePricingType.ManualInput)
                };

                serviceSqlHandler.Save(defaults);
                services = defaults;
            }
        }

        // Method to get the list of vehicles.
        public List<Vehicle> GetVehicleTypes()
        {
            return vehicles;
        }

        // Method to get the list of services.
        public List<Service> GetServices()
        {
            return services;
        }

        // Method to get a vehicle by its type.
        public Vehicle GetVehicleByType(string type)
        {
            return vehicles.FirstOrDefault(v => v.Type.Equals(type, StringComparison.OrdinalIgnoreCase));
        }

        // Method to add a new vehicle type and save to the database.
        public bool AddVehicle(Vehicle newVehicle, string loggedInUsername)
        {
            if (GetVehicleByType(newVehicle.Type) != null)
            {
                return false; // Vehicle type already exists
            }

            vehicles.Add(newVehicle);
            vehicleSqlHandler.Save(vehicles);
            auditSqlHandler.LogEvent($"VEHICLE: User '{loggedInUsername}' created new vehicle type '{newVehicle.Type}'.");
            return true;
        }

        // Method to update an existing vehicle type and save to the database.
        public void UpdateVehicle(Vehicle updatedVehicle, string loggedInUsername)
        {
            Vehicle originalVehicle = GetVehicleByType(updatedVehicle.Type);

            if (originalVehicle != null)
            {
                originalVehicle.BaseFee = updatedVehicle.BaseFee;
                originalVehicle.OwnerShare = updatedVehicle.OwnerShare;
                originalVehicle.EmployeeShare = updatedVehicle.EmployeeShare;

                vehicleSqlHandler.Save(vehicles);
                auditSqlHandler.LogEvent($"VEHICLE: User '{loggedInUsername}' updated vehicle type '{updatedVehicle.Type}'.");
            }
        }

        // Method to delete a vehicle type and save the list to the database.
        public void DeleteVehicle(string vehicleType, string loggedInUsername)
        {
            Vehicle vehicleToDelete = GetVehicleByType(vehicleType);

            if (vehicleToDelete != null)
            {
                vehicles.Remove(vehicleToDelete);
                vehicleSqlHandler.Save(vehicles);
                auditSqlHandler.LogEvent($"VEHICLE: User '{loggedInUsername}' deleted vehicle type '{vehicleType}'.");
            }
        }

        // Method to get the service object using its name.
        public Service GetServiceByName(string name)
        {
            return services.FirstOrDefault(s => s.Name.Equals(name,StringComparison.OrdinalIgnoreCase));
        }

        // Method to add a new service and save it to the database.
        public bool AddService(Service newService, string loggedInUsername)
        {
            if (GetServiceByName(newService.Name) != null)
            {
                return false; // Service name already exists
            }

            services.Add(newService);
            serviceSqlHandler.Save(services);
            auditSqlHandler.LogEvent($"SERVICE: User '{loggedInUsername}' created new service '{newService.Name}'.");
            return true;        
        }

        // Method to update an existing service and save to the database.
        public void UpdateService(Service updatedService, string loggedInUsername)
        {
            Service originalService = GetServiceByName(updatedService.Name);

            if (originalService != null)
            {
                originalService.PricingType = updatedService.PricingType;
                originalService.Fee = updatedService.Fee;
                originalService.Name = updatedService.Name;
                originalService.Multiplier = updatedService.Multiplier;

                serviceSqlHandler.Save(services);
                auditSqlHandler.LogEvent($"SERVICE: User '{loggedInUsername}' updated service '{updatedService.Name}'.");
            }
        }

        // Method to delete a service and save the new list to the database.
        public void DeleteService(string serviceName, string loggedInUsername)
        {
            Service serviceToRemove = GetServiceByName(serviceName);

            if (serviceToRemove != null)
            {
                services.Remove(serviceToRemove);
                serviceSqlHandler.Save(services);
                auditSqlHandler.LogEvent($"SERVICE: User '{loggedInUsername}' deleted service '{serviceName}'.");
            }
        }

    }
}
