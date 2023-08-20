namespace DispatchGame.Types.Resources;

public sealed class Building
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ResourceType ResourceType { get; set; }
    public List<Vehicle> AssignedVehicles { get; set; }
}