namespace Model.Project
{
    using System;
    using System.Collections.Generic;

    using Employee;
    using Professions;

    [Serializable]
    public class IssueRecord
    {

        public IssueRecord()
        {
            
        }

        public IEmployee Employee { get; set; }

        public IList<IProfession> Professions { get; set; }

        public IList<Resource> Resources { get; set; }

        public bool Active { get; set; }
    }
}