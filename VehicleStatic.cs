namespace VehicleStatic;

class VehicleStat
{
    public string Name {get; set;}
    public string PlateNumber {get; set;}

    public decimal EngineHours {get; private set;}

    public static int TotalVehicles {get; private set;}

    public VehicleStat(string name, string plateNumber)
    {
        Name=name;
        PlateNumber=plateNumber;
        TotalVehicles++;
    }

    public void AddEngineHours(decimal hours)
    {
        if (!IsValidHour(hours))
        {
            return;
        }
        EngineHours +=hours;
    }
    public bool IsValidHour(decimal hours)
    {
        return hours > 0;
    }

}