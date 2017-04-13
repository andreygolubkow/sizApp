namespace Model.Project
{
    using System;

    [Serializable]
    public class Project:IProject
    {

        public Project()
        {
            ProjectInformation = new Information();
            ProjectJournal = new IssueJournal();
        }

        public Information ProjectInformation { get; set; }

        public IssueJournal ProjectJournal { get; set; }

        #region Implementation of IProject

        public string OrganizationName => ProjectInformation.OrganizationFullName;

        #endregion
    }
}