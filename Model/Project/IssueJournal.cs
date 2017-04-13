namespace Model.Project
{
    using System;
    using System.Collections.Generic;

    using Model.Employee;
    using Model.Professions;

    [Serializable]
    public class IssueJournal
    {

        public IssueJournal()
        {
            
        }

        public IEmployee Employee { get; set; }

        public IList<IProfession> Professions { get; set; }

        public IList<Resource> Resources { get; set; }


    }
}