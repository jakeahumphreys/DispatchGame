using DispatchGame.Types.Events;
using DispatchGame.Types.Resources;

namespace DispatchGame.Mechanics.Events;

public class EventDataBuilder
{
    private readonly EventData _event = new EventData();

    public EventDataBuilder WithName(string name)
    {
        _event.Name = name;
        return this;
    }

    public EventDataBuilder WithRequiredAdditionalResource(ResourceType resourceType)
    {
        _event.RequiredAdditionalResources.Add(resourceType);
        return this;
    }

    public EventDataBuilder AvailableTo(ResourceType resourceType)
    {
        _event.AvailableToResources.Add(resourceType);
        return this;
    }

    public EventDataBuilder AvailableToAllFirstResponders()
    {
        _event.AvailableToResources.Add(ResourceType.Police);
        _event.AvailableToResources.Add(ResourceType.Fire);
        _event.AvailableToResources.Add(ResourceType.Ambulance);
        return this;
    }

    public EventDataBuilder WithCompletionCredits(int completionCredits)
    {
        _event.CompletionCredits = completionCredits;
        return this;
    }

    public EventDataBuilder WithTrainingRequirements(List<string> trainingRequirements)
    {
        _event.TrainingRequirements = trainingRequirements;
        return this;
    }

    public EventDataBuilder WithSpecialisationRequirements(List<string> specialisationRequirements)
    {
        _event.SpecialisationRequirements = specialisationRequirements;
        return this;
    }

    public EventDataBuilder WithTimeRequiredToComplete(int timeRequiredToComplete)
    {
        _event.TimeRequiredToComplete = timeRequiredToComplete;
        return this;
    }

    public EventData BuildData()
    {
        return _event;
    }
}