using System.Collections.Generic;
using System.Linq;

namespace Tools
{
    using Model.Employee;

    public class FullNameEmployeeAdapter
    {
        public IEmployee Employee { get; set; }

        public string FullName
        {
            get
            {
                return Employee.Surname + " " + Employee.Name + " " + Employee.MiddleName+" №"+Employee.PersonnelNumber;
            }
        }

        public static List<FullNameEmployeeAdapter> AdaptEmployeesList(List<IEmployee> list)
        {
            return list.Select(emp => new FullNameEmployeeAdapter
                                          {
                                              Employee = emp
                                          }).ToList();
        }

    }
}
