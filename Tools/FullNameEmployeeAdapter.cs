using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            var adaptList = new List<FullNameEmployeeAdapter>();
            foreach (var emp in list)
            {
                var adapter = new FullNameEmployeeAdapter();
                adapter.Employee = emp;
                adaptList.Add(adapter);                
            }
            return adaptList;
        }

    }
}
