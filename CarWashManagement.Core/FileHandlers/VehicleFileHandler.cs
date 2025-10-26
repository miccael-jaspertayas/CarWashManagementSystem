using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarWashManagement.Core.FileHandlers
{
    public class VehicleFileHandler : IFileHandler<Vehicle>
    {
        private readonly string filePath = FilePathManager.VehiclesFilePath;

        public List<Vehicle> Load()
        {
            List<Vehicle> vehicles = new List<Vehicle>();

            if (!File.Exists(filePath))
            {
                return vehicles;
            }

            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                try
                {
                    string[] parts = line.Split('|');

                    if (parts.Length == 4)
                    {
                        Vehicle vehicle = new Vehicle
                        {
                            Name = parts[0],
                            BaseFee = decimal.Parse(parts[1]),
                            OwnerShare = decimal.Parse(parts[2]),
                            EmployeeShare = decimal.Parse(parts[3])
                        };
                        vehicles.Add(vehicle);
                    }
                } catch (Exception ex)
                {
                    Console.WriteLine($"Error parsing vehicle file line: {line}. Error: {ex.Message}");
                }
            }
            return vehicles;
        }

        public void Save(List<Vehicle> vehicles)
        {
            List<string> lines = new List<string>();

            foreach (Vehicle vehicle in vehicles)
            {
                string line = String.Join("|",
                    vehicle.Name,
                    vehicle.BaseFee,
                    vehicle.OwnerShare,
                    vehicle.EmployeeShare);

                lines.Add(line);
            }

            File.WriteAllLines(filePath, lines);
        }
    }
}
