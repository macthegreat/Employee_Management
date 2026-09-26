static bool IsMaintenanceRequired(int engineHour) => engineHour >= 1000 ? true : false;
Console.WriteLine(IsMaintenanceRequired(10000));

static decimal CalculateDistancePerDay(decimal kilometers, decimal days) => kilometers / days;


static string GetMaintenanceMessage(decimal engineHours)
{
    if (engineHours >= 1000)
    {
        return "Maintenance Required";
    }
    else if (engineHours >= 750)
    {
        return "Maintenance Due Soon";
    }
    else
    {
        return "Normal";
    }
}

static int Add(params int[] numbers)
{
    int total = 0;
    foreach (int number in numbers)
    {
        total += number;
    }

    return total;
}

static (string name, decimal hours) GetVehicle()
{
    return ("CAT 320", 1250);
}


static void UpdateEngineHours(ref int enginHours)
{
    enginHours += 250;
}
int hours = 1000;

UpdateEngineHours(ref hours);

Console.WriteLine($"this is {hours}");

int[] numbers = { 250, 500, 750, 1000 };

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

string[] vehicles1 = [
"Toyota Hilux",
"CAT 320",
"Isuzu NPR",
"Volvo FH"
];

foreach (string vehicle in vehicles1)
{
    Console.WriteLine($"Vehicle: {vehicle}");
}

List<int> numbersList = new()
{
   250, 500, 750
};
numbersList.Add(1000);
numbersList.Remove(500);
numbersList.RemoveAt(0);
numbersList.Contains(750);

foreach (int num in numbersList)
{
    Console.WriteLine(num);
}


List<string> vehiclesList = new()
{
   " Toyota Hilux",
"CAT 320",
"Volvo FH"
};

vehiclesList.Add("Isuzu NPR");
vehiclesList.Remove("CAT 320");
Console.WriteLine(vehiclesList.Count);

foreach (string cats in vehiclesList)
{
    Console.WriteLine($"vehicle: {cats}");
}


Dictionary<int, string> dumbTrucks = new()
{
    {1 , "Toyota Hilux"},
    {2, "CAT 320"},
    {3,"Volvo FH"}
};

Console.WriteLine(dumbTrucks[2]);

dumbTrucks.Add(4, "Isuzu NPR");

Console.WriteLine(dumbTrucks.Count());

dumbTrucks[2] = "CAT 336";
dumbTrucks.Remove(3);

bool existvalue = dumbTrucks.ContainsKey(4);
Console.WriteLine(existvalue);

foreach (var trucks in dumbTrucks)
{
    Console.WriteLine($"ID: {trucks.Key}, Vehicle: {trucks.Value}");

}

Dictionary<string, decimal> engineHours = new()
{
    {"ET-1001" , 1250},
{"ET-1002" , 750},
{"ET-1003 ", 1500}
};

if (engineHours.TryGetValue("ET-1002", out decimal hour))
{
    Console.WriteLine($"Engine Hours: {hour}");
}
else
{
    Console.WriteLine("Vehicle not found");
}

List<string> vehicles = new()
{
   " Toyota Hilux",
"CAT 320",
"Volvo FH",
"Isuzu NPR"
};

foreach (string vehicle in vehicles)
{
    Console.WriteLine(vehicle);
}

for (int i = 0; i < vehicles.Count; i++)
{
    Console.WriteLine($"{i}: {vehicles[i]}");
}

foreach (string vehicle in vehicles)
{
    if (vehicle == "CAT 320")
    {
        continue;
    }
}

foreach (string vehicle in vehicles)
{
    if (vehicle == "Volvo FH")
    {
        break;
    }
}

int engineHours1 = 0;

while (engineHours1 < 1000)
{
    engineHours1 += 250;
    Console.WriteLine(engineHours1);
}

foreach (string vehicle in vehicles)
{
    Console.WriteLine(vehicle.ToUpper());

}


VehiclesCls vehicle1 = new()
{
    Name = "Toyota Hilux",

    PlateNumber = "ET-1001",
    EngineHours = 1250,
    DistanceKm = 45000
};

VehiclesCls vehicle2 = new()
{
    Name= "CAT 320",
PlateNumber= "ET-1002",
EngineHours= 750,
DistanceKm= 28000
};

Console.WriteLine(vehicle2.Name);

vehicle1.DisplayInfo();
vehicle2.DisplayInfo();

class VehiclesCls
{
    public string? Name;
    public string? PlateNumber;
    public decimal EngineHours;
    public decimal DistanceKm;

    public void DisplayInfo()
    {
        Console.WriteLine(Name);
        Console.WriteLine(PlateNumber);
        Console.WriteLine(EngineHours);
        Console.WriteLine(DistanceKm);

    }

}




