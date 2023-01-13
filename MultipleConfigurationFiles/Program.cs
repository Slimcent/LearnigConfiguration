using Microsoft.Extensions.Configuration;
using MultipleConfigurationFiles;

IConfiguration config = new ConfigurationBuilder()
 .SetBasePath(Directory.GetCurrentDirectory())
 .AddJsonFile("appsettings.json", true, true)
 .Build();

Console.Write($"My car object is a {config["Car:Color"]} \n");
Console.WriteLine($"{config["Car:Make"]} named {config["Car:PetName"]}");

IConfigurationSection section = config.GetSection("Car");
IConfigurationSection section1 = config.GetSection("CarName");

Console.WriteLine("\nGetting it with section\n");
Console.Write($"My car object is a {section["Color"]} \n");
Console.WriteLine($"{section["Make"]} named {section["PetName"]}\n");

Console.WriteLine("Getting the first section\n");
Console.WriteLine($"{section1.Value}");


//var c = new Car();
//section.Bind(c);
//Console.Write($"My car object is a {c.Color} ");
//Console.WriteLine($"{c.Make} named {c.PetName}");


var carFromGet = config.GetSection(nameof(Car)).Get(typeof(Car)) as Car;
//Console.Write($"My car object (using Get()) is a {carFromGet.Color} ");
//Console.WriteLine($"{carFromGet.Make} named {carFromGet.PetName}");


//Returns a Car instance, Using Generics method
var carFromGet2 = config.GetSection(nameof(Car)).Get<Car>();
Console.Write($"My Generic car object (using Get()) is a {carFromGet.Color} ");
Console.WriteLine($"{carFromGet.Make} named {carFromGet.PetName}");