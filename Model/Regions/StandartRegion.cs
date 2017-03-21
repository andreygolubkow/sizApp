using System;

namespace Model.Regions
{
    public class StandartRegion:IRegion
    {
        private int _id;
        private string _name;
        private IZone _zone;

        public StandartRegion(int id)
        {
            Id = id;
        }

        #region Implementation of IRegion

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                if ( value < 0 )
                {
                    throw new ArgumentOutOfRangeException("Неверный идентификатор");
                }
                _id = value;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if ( value.Length == 0 )
                {
                    throw new ArgumentException("Неверное название региона");
                }
                _name = value;
            }
        }

        public IZone Zone
        {
            get
            {
                return _zone;
            }
            set
            {
                _zone = value;
            }
        }

        #endregion
    }
}