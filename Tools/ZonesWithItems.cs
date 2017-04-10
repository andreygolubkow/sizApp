
namespace Tools
{
    using Model.Zones;

    public class ZonesWithItems
    {
        private IZone _zone;
        private double _count;

        public string ZoneString
        {
            get
            {
                return _zone.AsString;
            }
        }

        public double Count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public void SetZone(IZone zone)
        {
            _zone = zone;
        }

        public IZone GetZone()
        {
            return _zone;
        }
    }
}