namespace VehicleEncap_1;

class VehicleEncap
{
    private decimal _engineHours;
    private decimal _distanceKm;

    public int Id {get; set;}
    public string Name {get; set;}
   
    public string Platenumber {get;set;}
    public decimal EngineHours => _engineHours;
    public decimal DistanceKm => _distanceKm;


    public VehicleEncap(int id,string name,string plateNumber)
    {
        Id =id;
        Name =name;
        Platenumber =plateNumber;
    }
    public void AddEnginehour(decimal hours)
    {
        if (!IsValidEngineHour(hours))
        {
            return;
        }
        _engineHours += hours;
    }
    public bool IsValidEngineHour(decimal hours)
    {
        return hours > 0;
    }

    public void AddKiloMeter(decimal kiloMeter)
    {
        if (!IsValidKilometer(kiloMeter))
        {
            return;
        }
        _distanceKm +=kiloMeter;

    }

    public bool IsValidKilometer(decimal kilometer)
    {
        return kilometer > 0;
    }

    public bool NeedsMaintenance => EngineHours >=1000;


}


    