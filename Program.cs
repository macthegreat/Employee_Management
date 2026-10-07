using System.Data.Common;
using System.Runtime.CompilerServices;
using Vehicle;
using VehcleInc;
using VehicleStatic;
using VehicleEncap_1;
using VehicleEnum;
using System.Net;
using Employee;
using Notifications;
using Shipping;
using AbNotify;
using EmployeeAb;
using Payments;
using Payments;
using IntNotify;


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
    Name = "CAT 320",
    PlateNumber = "ET-1002",
    EngineHours = 750,
    DistanceKm = 28000
};

Console.WriteLine(vehicle2.Name);

vehicle1.DisplayInfo();
vehicle2.DisplayInfo();


vehicleProp vehicleProp = new()
{
    Id = 1,
    Name = "Toyota Hilux king cap",
    PlateNumber = "ET-1001",

    DistanceKm = 45000
};
vehicleProp.AddEngineHours(250);

////

VehicleOnly vehicleImp = new(1, "AAA-1234", "BYD", 1243, 345);

Console.WriteLine(vehicleImp.Name);
Console.WriteLine($"plate number is {vehicleImp.PlateNumber}");
Console.WriteLine($"this is working Hours {vehicleImp.EngineHours}");
Console.WriteLine($"this is distance in Km {vehicleImp.DistanceKm}");
Console.WriteLine($"Vehicle status {vehicleImp.NeedsMaintenance}");
vehicleImp.AddEngineHours(230);

////
/// 
VehicleInc vehicleinc = new()
{
    Name = "CAT 320",
    PlateNumber = "ET-1002"
};

Console.WriteLine($"this is a test from vehicleINc {vehicleinc.Name}");
Console.WriteLine(vehicleinc.PlateNumber);

vehicleinc.AddEngineHours(250);
vehicleinc.AddEngineHours(-100);
vehicleinc.AddEngineHours(700);
vehicleinc.AddEngineHours(-300);


Console.WriteLine($"this is my test {vehicleinc.EngineHours}");
///

VehicleEncap vehicleEncap = new(1, "Honda", "AAA-1221");

Console.WriteLine($"Encap Vehicle name {vehicleEncap.Name}");
Console.WriteLine($"this is encap Id {vehicleEncap.Id}");
Console.WriteLine($"encap Plate {vehicleEncap.Platenumber}");

vehicleEncap.AddKiloMeter(1212);
vehicleEncap.AddEnginehour(240);
vehicleEncap.AddKiloMeter(-870);
vehicleEncap.AddKiloMeter(1000);
vehicleEncap.AddEnginehour(-120);
vehicleEncap.AddEnginehour(100);
vehicleEncap.AddEnginehour(750);
Console.WriteLine($"Engine Hours: {vehicleEncap.EngineHours}");
Console.WriteLine($"Distance: {vehicleEncap.DistanceKm}");
Console.WriteLine($"Needs Maintenance:  {vehicleEncap.NeedsMaintenance}");

///


VehicleStat vehicleStat1 = new("CAT 320", "ET-1001");
VehicleStat vehicleStat2 = new("Toyota Hilux", "ET-1002");
VehicleStat vehicleStat3 = new("Volvo FH", "ET-1003");
VehicleStat vehicleStat4 = new("BYD E2", "ET-4403");


vehicleStat1.AddEngineHours(500);

Console.WriteLine("-------------");

vehicleStat1.AddEngineHours(-100);
vehicleStat2.AddEngineHours(1000);
vehicleStat3.AddEngineHours(750);
vehicleStat4.AddEngineHours(5);
Console.WriteLine($"Vehicle Name: {vehicleStat1.Name}");
Console.WriteLine($"Plate Number: {vehicleStat1.PlateNumber}");
Console.WriteLine($"Engine Hour: {vehicleStat1.EngineHours}");

Console.WriteLine("-------------");
Console.WriteLine($"Vehicle Name: {vehicleStat2.Name}");
Console.WriteLine($"Plate Number: {vehicleStat2.PlateNumber}");
Console.WriteLine($"Engine Hour: {vehicleStat2.EngineHours}");
Console.WriteLine("-------------");

Console.WriteLine($"Vehicle Name: {vehicleStat3.Name}");
Console.WriteLine($"Plate Number: {vehicleStat3.PlateNumber}");
Console.WriteLine($"Engine Hour: {vehicleStat3.EngineHours}");

Console.WriteLine("-------------");

Console.WriteLine($"Vehicle Name: {vehicleStat4.Name}");
Console.WriteLine($"Plate Number: {vehicleStat4.PlateNumber}");
Console.WriteLine($"Engine Hour: {vehicleStat4.EngineHours}");

Console.WriteLine("-------------");

Console.WriteLine(VehicleStat.TotalVehicles);
Console.WriteLine("-------------");

//


static void ShowStatus(VehiclesSatatus vehicle)
{
    switch (vehicle.Status)
    {
        case VehicleStatus.Working:
            Console.WriteLine($"{vehicle.Name}: Vehicle is working");
            break;

        case VehicleStatus.Maintenance:
            Console.WriteLine($"{vehicle.Name}: Vehicle needs maintenance");
            break;

        case VehicleStatus.Idle:
            Console.WriteLine($"{vehicle.Name}: Vehicle is idle");
            break;
    }
}


VehiclesSatatus vehicleEnum1 = new("VolksWaggen", "ET-1001", VehicleStatus.Working);
VehiclesSatatus vehicleEnum2 = new("Honda Civic", "AAA-0023", VehicleStatus.Maintenance);
VehiclesSatatus vehicleEnum3 = new("Volvo FH", "ET-1003", VehicleStatus.Idle);





Console.WriteLine("**************");
Console.WriteLine(vehicleEnum1.Name);
Console.WriteLine(vehicleEnum1.PlateNumber);
ShowStatus(vehicleEnum1);
Console.WriteLine("**************");

Console.WriteLine("**************");
Console.WriteLine(vehicleEnum2.Name);
Console.WriteLine(vehicleEnum2.PlateNumber);
ShowStatus(vehicleEnum2);
Console.WriteLine("**************");

Console.WriteLine("**************");
Console.WriteLine(vehicleEnum3.Name);
Console.WriteLine(vehicleEnum3.PlateNumber);

ShowStatus(vehicleEnum3);
Console.WriteLine("**************");


//

Console.WriteLine("######################");

Developer developer1 =new(100,"beza",20000,"Nodejs");
Developer developer2 =new(101,"Mekbib",50000,"C#");
Console.WriteLine(developer1.Name);
Console.WriteLine(developer1.ProgrammingLanguage);
developer1.ClockIn();
developer2.ClockOut();
developer1.Work();
developer2.Work();

Manager manager1=new(104,"Sara",70000,8);
Console.WriteLine(manager1.Name);
Console.WriteLine(manager1.TeamSize);
manager1.ClockIn();
manager1.ClockOut();
manager1.Work();

Console.WriteLine("######################");




/// 
Console.WriteLine(vehicleProp.Id);
Console.WriteLine(vehicleProp.Name);
Console.WriteLine(vehicleProp.PlateNumber);
Console.WriteLine(vehicleProp.EngineHours);
Console.WriteLine(vehicleProp.DistanceKm);
Console.WriteLine(vehicleProp.NeedsMaintenance);


Notification Email = new EmailNotification();
Notification Sms = new SmsNotifications();
Notification Push = new PushNotification();

Email.Send();
Sms.Send();
Push.Send(); 

Notification[] notififications =
{
    new EmailNotification(),
    new SmsNotifications(),
    new PushNotification()
};

foreach (Notification notification in notififications)
{
    Console.WriteLine($"Sending notification: {notification.GetType().Name}");
    notification.Send();
}

/// </summary>

///shipping 
Shippings standardShipping = new StandardShipping();
Shippings expressShipping = new ExpressShipping();
Shippings internationalShipping = new InternationalShipping();

Console.WriteLine($"Standard Shipping Cost: {standardShipping.CalculateCost(5)}");
Console.WriteLine($"Express Shipping Cost: {expressShipping.CalculateCost(5)}");
Console.WriteLine($"International Shipping Cost: {internationalShipping.CalculateCost(5)}");
/// 
Shippings[] shippings =
{
  new StandardShipping(),
  new ExpressShipping(),
  new InternationalShipping()  
};

foreach(Shippings shipping in shippings)
{
    Console.WriteLine($"{shipping.CalculateCost(10)}");
}
/// 

NotificationAb emailAb = new EmailNotificationAb("mekbibk3795@gmail.com");
NotificationAb smsAb=new SmsNotificationAb("091091091");
NotificationAb pushAb=new PushNotificationAb("mekbib");

emailAb.Send();
emailAb.ShowRecipient();
smsAb.Send();
pushAb.Send();


NotificationAb[] notifications =
{
  new EmailNotificationAb("bezalove@gmail.com"),  
  new SmsNotificationAb("0943987854"),
  new PushNotificationAb("bezz")
};
Console.WriteLine("///////////Abstract notification//////////////");
foreach(NotificationAb notification in notifications)
{
    notification.ShowRecipient();
    notification.Send();
}
/// 
/// 
/// 
Console.WriteLine("%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%");

EmployeeAbs employee = new Dev(101,"mekbib",5000);
EmployeeAbs employee1 = new Managers(102,"Dr Abebe",120000);
EmployeeAbs employee2 = new SalesPerson(103,"beza",5000,400);

Console.WriteLine(employee.CalculateSalary());
Console.WriteLine(employee1.CalculateSalary());
Console.WriteLine(employee2.CalculateSalary());

/// 
/// 
EmployeeAbs[] employees =
{
    new Dev(111,"kidu",4300),
    new Managers(112,"ashalew",45000),
    new SalesPerson(113,"kal",1234,700)

};
Console.WriteLine("(((((((())))))))");
foreach(EmployeeAbs employeeAbs in employees)
{
    Console.WriteLine(employeeAbs.CalculateSalary());
}
/// 
Console.WriteLine("##$$$%%%%))(*&&^%%%)");

Payment payment1 =new CreditCardPayment(101,2000,"meron",3400);

Payment[] payments =
{
    new CreditCardPayment(102,2300,"dawit",4000),
    new BankTransferpayment(103,3000,"belete","Dashen Bank"),
    new MobileMoneyPayment(104,500,"henock","0919385189")
};
foreach(Payment payment2 in payments)
{
    payment2.DisplayInfo();
    Console.WriteLine(payment2.ProcessPayment());
}
/// 
/// 
Console.WriteLine("interface style");

INotifications[] notifications2 =
{
    new EmailNotifications1(),
    new SmsNotifications1(),
    new PushNotifications1(),
};

foreach(INotifications inotify in notifications2)
{
   inotify.Send("hello bemni");
}

INotificationInfo[] notificationInfo =
{
    new EmailNotifications1(),
    new SmsNotifications1(),
    new PushNotifications1()
};

foreach(INotificationInfo notificationInf in notificationInfo)
{
    notificationInf.Message("Yabsira");
}

/// 


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
class vehicleProp
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public string PlateNumber { get; set; } = "";
    public decimal EngineHours { get; private set; }
    public decimal DistanceKm { get; set; }

    public void AddEngineHours(decimal hours)
    {
        if (hours > 0)
        {
            EngineHours += hours;
        }

    }
    public bool NeedsMaintenance => EngineHours >= 1000;
}

class VehicleConst
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string PlateNumber { get; set; }
    public decimal EngineHours { get; private set; }
    public decimal DistanceKm { get; set; }

    public void VehicleDs(int id, string name, string plateNumber, decimal engineHours, decimal distanceKm)
    {
        Id = id;
        this.Name = name;
        PlateNumber = plateNumber;
        EngineHours = engineHours;
        DistanceKm = distanceKm;

    }
    public void AddEngineHours(decimal hours)
    {
        if (hours > 0)
        {
            EngineHours += hours;

        }
    }
    public bool NeedsMaintenance => EngineHours >= 1000;
}





