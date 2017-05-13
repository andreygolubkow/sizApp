using System;
using System.Collections.Generic;

using Model.Equipments;
using Model.Project;
using Model.Zones;

namespace Tools
{
    public class ResourceAdapter
    {
        private Resource _resource;
        private IZone _zone;

        public ResourceAdapter()
        {
            
        }

        public ResourceAdapter(Resource resource, IZone zone)
        {
            _resource = resource;
            _zone = zone;
        }

        public string Name
        {
            get => _resource.Equipment.Name;
        }

        public DateTime StartDateTime
        {
            get => _resource.IssueDate;
        }

        public DateTime EndDateTime
        {
            get
            {
                if (_resource.Equipment is ByZoneEquipment)
                {
                    var equipment = (ByZoneEquipment)_resource.Equipment;
                    double count = 0;
                    foreach (KeyValuePair<IZone, double> zone in equipment.CountByZone)
                    {
                        if (zone.Key.Id == _zone.Id)
                        {
                            count = zone.Value;
                            break;
                        }
                    }

                    double days = 365 / count;
                    DateTime startDateTime = Convert.ToDateTime(StartDateTime);
                    DateTime endDateTime = startDateTime.AddDays(days);
                    return endDateTime;
                }

                var yearEquipment = _resource.Equipment as PerYearEquipment;
                if ( yearEquipment == null )
                {
                    return (Convert.ToDateTime(StartDateTime)).AddYears(1000);
                }
                {
                    var equipment = yearEquipment;
                    double count = equipment.CountPerYear;
                    double days = 365 / count;
                    DateTime startDateTime = Convert.ToDateTime(StartDateTime);
                    DateTime endDateTime = startDateTime.AddDays(days);
                    return endDateTime;
                }
            }
        }

       

    }
}
