
using Microsoft.Extensions.Configuration;

var currentEnvironment = Environment.GetEnvironmentVariable("ENVIRONMENT_NAME") ?? "local";


var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
            .AddJsonFile($"appsettings.{currentEnvironment}.json", optional: true)
            .AddEnvironmentVariables();
var config = builder.Build();

var subject = config["Subject:Name"];

Console.WriteLine($"Hello, {subject}");
