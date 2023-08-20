using System.Drawing;

namespace DispatchGame.Utility;

public static class GeoHelper
{
    public static PointF ConvertLatLongToPoint(double latitude, double longitude)
    {
        double earthRadius = 6371000; // Earth's radius in meters (approximate)

        double x = earthRadius * Math.Cos(latitude * Math.PI / 180) * Math.Cos(longitude * Math.PI / 180);
        double y = earthRadius * Math.Cos(latitude * Math.PI / 180) * Math.Sin(longitude * Math.PI / 180);

        return new PointF((float)x, (float)y);
    }
}