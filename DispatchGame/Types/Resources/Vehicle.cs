namespace DispatchGame.Types.Resources;

public sealed class Vehicle
{
    public Guid Id { get; set; }
    public ResourceType Type { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public string Image { get; set; }
    public string Icon { get; set; }
    public decimal MilesDriven { get; set; }
    public StatusType Status { get; set; }
    public bool IsInService { get; set; }
    public bool IsBrokenDown { get; set; }
}