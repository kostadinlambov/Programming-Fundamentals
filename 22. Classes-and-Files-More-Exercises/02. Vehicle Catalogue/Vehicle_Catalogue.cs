using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.Vehicle_Catalogue
{

    public class Vehicle
    {
        public string TypeOfVehicle { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public string HorsePower { get; set; }

    }

    public class Vehicle_Catalogue
    {
        public static void Main()
        {
            var listOfVehicles = new List<Vehicle>();

            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var token = inputLine
                    .Trim()
                    .Split(' ')
                    .ToArray();

                var typeOfVehicle = token[0].ToLower();
                var model = token[1];
                var color = token[2];
                var horsePower = token[3];

                var vehicle = new Vehicle()
                {
                    TypeOfVehicle = typeOfVehicle,
                    Model = model,
                    Color = color,
                    HorsePower = horsePower
                };

                listOfVehicles.Add(vehicle);

                inputLine = Console.ReadLine();
            }

            var modelsOFVehicle = Console.ReadLine();

            while (modelsOFVehicle != "Close the Catalogue")
            {
                var vehicleToPrint = listOfVehicles
                    .Where(x => x.Model == modelsOFVehicle)
                    .ToArray();

                var type = vehicleToPrint[0].TypeOfVehicle;

                var typeCharArr = type.ToCharArray();
                typeCharArr[0] = char.ToUpper(typeCharArr[0]);

                type = string.Join("", typeCharArr);

                var model = vehicleToPrint[0].Model;
                var color = vehicleToPrint[0].Color;
                var horsePower = vehicleToPrint[0].HorsePower;

                Console.WriteLine($"Type: {type}");
                Console.WriteLine($"Model: {model}");
                Console.WriteLine($"Color: {color}");
                Console.WriteLine($"Horsepower: {horsePower}");

                modelsOFVehicle = Console.ReadLine();
            }

            var averageHorsePowerCars = 0d;

            try
            {
                averageHorsePowerCars = listOfVehicles
                    .Where(x => x.TypeOfVehicle == "car")
                    .Select(x => x.HorsePower)
                    .Select(long.Parse)
                    .Average(x => x);
            }
            catch
            {
                averageHorsePowerCars = 0.0;
            }

            var averageHorsePowerTrucks = 0d;

            try
            {
                averageHorsePowerTrucks = listOfVehicles
                   .Where(x => x.TypeOfVehicle == "truck")
                   .Select(x => x.HorsePower)
                   .Select(long.Parse)
                   .Average(x => x);
            }
            catch
            {
                averageHorsePowerTrucks = 0.0;
            }

            Console.WriteLine($"Cars have average horsepower of: {averageHorsePowerCars:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageHorsePowerTrucks:f2}.");
        }
    }
}
