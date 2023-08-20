using DispatchGame.Types.Resources;

namespace DispatchGame.Types.Events;

public sealed class Event
{
    public Event()
    {
        Id = Guid.NewGuid();
        Created = DateTime.Now;
    }
    
    public Guid Id { get; set; }
    public DateTime Created { get; set; }
    public string Icon { get; set; }
    public float Latitude { get; set; }
    public float Longitude { get; set; }
    public string Location { get; set; }
    public EventData EventData { get; set; }
    public List<Person> PersonsAttending { get; set; }
    public List<Vehicle> VehiclesAttending { get; set; }
    public bool IsCompleted { get; set; }
}