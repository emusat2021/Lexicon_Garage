
using Lexicon_Garage.app;
using Lexicon_Garage.app.UserInterface;
using Lexicon_Garage.app.Utilities;
using Lexicon_Garage.app.Vehicles;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

IConfiguration config = new ConfigurationBuilder()
    .SetBasePath(Environment.CurrentDirectory)
    .AddJsonFile("vehiclesList.json", false, reloadOnChange: true)
    .Build();

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddSingleton<IUI, UI>();
        services.AddSingleton<IGarage<IVehicle>>(new Garage<IVehicle>(2));
        services.AddSingleton<IGarageHandler<IVehicle>, GarageHandler<IVehicle>>();
        services.AddSingleton<Manager>();
    })
    .UseConsoleLifetime()
    .Build();
host.Services.GetRequiredService<Manager>().GarageManager();

Console.WriteLine("Welcome back!");
Console.ReadLine();


