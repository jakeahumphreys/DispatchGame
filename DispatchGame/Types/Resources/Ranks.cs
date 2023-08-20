namespace DispatchGame.Types.Resources;

public sealed class Ranks
{
    public struct Police
    {
        public const string CONSTABLE = "Constable";
        public const string SPECIAL_CONSTABLE = "Special Constable";
        public const string SERGEANT = "Sergeant";
        public const string SPECIAL_SERGEANT = "Special Sergeant";
        public const string INSPECTOR = "Inspector";
        public const string SPECIAL_INSPECTOR = "Special Inspector";
        public const string CHIEF_INSPECTOR = "Chief Inspector";
        public const string SUPERINTENDENT = "Superintendent";
        public const string CHIEF_SUPERINTENDENT = "Chief Superintendent";
    }

    public struct Ambulance
    {
        public const string TECHNICIAN = "Technician";
        public const string PARAMEDIC = "Paramedic";
        public const string SPECIALIST_PARAMEDIC = "Specialist Paramedic";
        public const string ADVANCED_PARAMEDIC = "Advanced Paramedic";
    }

    public struct Fire
    {
        public const string FIRE_FIGHTER = "Fire Fighter";
        public const string CREW_MANAGER = "Crew Manager";
        public const string WATCH_MANAGER = "Watch Manager";
        public const string STATION_MANAGER = "Station Manager";
        public const string GROUP_MANAGER = "Group Manager";
    }

    public struct Generic
    {
        public const string HIGHWAYS_OFFICER = "Highways";
        public const string UTILITY_OPERATOR = "Utility Operator";
    }
}