namespace Model.Project
{
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class Project:IProject
    {

        public Project()
        {
            ProjectInformation = new Information();
            ProjectJournal = new List<IssueRecord>();
        }

        public Information ProjectInformation { get; set; }

        public List<IssueRecord> ProjectJournal { get; set; }

        #region Implementation of IProject

        public string OrganizationName => ProjectInformation.OrganizationFullName;

        #endregion
    }
}