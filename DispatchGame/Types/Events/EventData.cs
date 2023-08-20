using DispatchGame.Types.Resources;

namespace DispatchGame.Types.Events;

public sealed class EventData
{
    public EventData()
    {
        AvailableToResources = new List<ResourceType>();
        RequiredAdditionalResources = new List<ResourceType>();
        TrainingRequirements = new List<string>();
        SpecialisationRequirements = new List<string>();
    }
    
    public string Name { get; set; }
    public List<ResourceType> AvailableToResources { get; set; }
    public List<ResourceType> RequiredAdditionalResources { get; set; }
    public int CompletionCredits { get; set; }
    public List<string> TrainingRequirements { get; set; }
    public List<string> SpecialisationRequirements { get; set; }
    
    public int TimeRequiredToComplete { get; set; }
}