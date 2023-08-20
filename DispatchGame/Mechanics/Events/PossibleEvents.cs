using DispatchGame.Types.Events;
using DispatchGame.Types.Resources;

namespace DispatchGame.Mechanics.Events;

public static class PossibleEvents
{
    private static EventDataBuilder _newEventData = new EventDataBuilder();

    public static List<EventData> GetData()
    {
        var possibleEventsData = new List<EventData>();
        possibleEventsData.AddRange(ForAllResources());
        possibleEventsData.AddRange(ForPolice());
        return possibleEventsData;
    }

    private static List<EventData> ForAllResources()
    {
        return new List<EventData>
        {
            _newEventData.WithName("Abandoned 999 Call").AvailableToAllFirstResponders().WithCompletionCredits(100).BuildData()
        };
    }
    
    private static List<EventData> ForPolice()
    {
        return new List<EventData>
        {
            _newEventData.WithName("Suspicious Person").AvailableTo(ResourceType.Police).WithCompletionCredits(200).BuildData(),
        };
    }
}