namespace DispatchGame.Types.Resources;

public sealed class Person
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public ResourceType ResourceType { get; set; }
    public string Role { get; set; }
    public string Rank { get; set; }
    public List<string> Specialisations { get; set; }
    public List<string> TrainingCourses { get; set; }
    public int EventsAttended { get; set; }
    public Guid AssignedBuilding { get; set; }
    public Guid AssignedVehicle { get; set; }
}