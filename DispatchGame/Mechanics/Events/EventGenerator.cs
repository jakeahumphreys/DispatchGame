using DispatchGame.Types.Events;

namespace DispatchGame.Mechanics.Events;

public static class EventGenerator
{
    public static Event Generate()
    {
        var possibleEvents = PossibleEvents.GetData();

        return new Event();
    }
}