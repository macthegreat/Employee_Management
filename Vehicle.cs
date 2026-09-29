
namespace Vehicle;


class VehicleOnly
{
    public int Id {get; set;}
    public string PlateNumber {get; set;}
    public string Name {get; set;}
    public decimal EngineHours {get; set;}
    public decimal DistanceKm {get; set;}
    

    public VehicleOnly(int id,string plateNumber,string name,decimal engineHours, decimal distance)
    {
        Id=id;
        PlateNumber=plateNumber;
        Name = name;
        EngineHours = engineHours;
        DistanceKm = distance;
    } 
    public void AddEngineHours(int hours)
    {
        if (hours > 0)
        {
            EngineHours += hours;
        }
    }

    public bool NeedsMaintenance =>EngineHours >=1000;

}




