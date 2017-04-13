namespace Model.Project
{
    using System;
    using System.Runtime.InteropServices;

    using Model.Regions;
    using Model.Zones;

    [Serializable]
    public class Information
    {
        public string OrganizationFullName { get; set; }

        public string OrganizaionShortName { get; set; }

        public string LeaderFullName { get; set; }

        public string LeaderPosition { get; set; }

        /// <summary>
        /// Ответственный.
        /// </summary>
        public string HeadPerson { get; set; }

        public string City {get; set; }

        public IRegion Region { get; set; }

    }
}