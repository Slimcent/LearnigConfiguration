
using Microsoft.Extensions.Configuration;

Console.WriteLine("Hello, World!");

// load the configuration file.
IConfigurationRoot configBuilder = new ConfigurationBuilder().
   AddJsonFile("appsettings.json").Build();

// get the section to read
IConfigurationSection configSection = configBuilder.GetSection("AppSettings");

// get the configuration values in the section.
var client_id = configSection["client_id"] ?? null;

var client_secret = configSection["client_secret"] ?? null;

Console.WriteLine($"\nClent Secret : {client_secret}\n");

Console.WriteLine($"Client Id : {client_id}");
