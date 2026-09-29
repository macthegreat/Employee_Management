

namespace VehicleEnum;


enum VehicleStatus
{
    Active,
    Inactive,
    Working,
    Idle,
    Maintenance,
    Offline,

}

class VehiclesSatatus
{
    public string Name {get; set;}
    public string PlateNumber {get; set;}
    public VehicleStatus Status {get; set;}

   public VehiclesSatatus(string name, string plateNumber, VehicleStatus status)
    {
        Name=name;
        PlateNumber=plateNumber;
        Status =status;

    }
    
    
}