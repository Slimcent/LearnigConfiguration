using Microsoft.Extensions.Configuration;

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

Console.WriteLine("\nGetting the first section\n");
Console.WriteLine($"{section1.Value}");

