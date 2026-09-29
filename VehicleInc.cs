namespace VehcleInc;
class VehicleInc
{
    public int Id {get; set;}
    public string Name {get; set;}
    public string PlateNumber {get; set;}
    public decimal EngineHours {get; private set;}

    private bool IsValidEngineHours(decimal hours)
    {
      return hours > 0;
    }

    public void AddEngineHours(decimal hours)
    {
        if (!IsValidEngineHours(hours))
        {
            return;
        }

        EngineHours += hours;
    }

}