namespace DispatchGame.Types.Resources;

public sealed class Specialisations
{
    public struct Police
    {
        public const string DETECTIVE = "Detective";
        public const string TRAFFIC_OFFICER = "Traffic Officer";
        public const string DOG_HANDLER = "Dog Handler";
        public const string ARMED_RESPONSE = "Armed Response";
    }

    public struct Ambulance
    {
        public const string RAPID_RESPONDER = "Rapid Responder";
        public const string AIR_AMBULANCE = "Air Ambulance";
    }

    public struct Fire
    {
        public const string SEARCH_AND_RESCUE = "Search and Rescue";
    }
}