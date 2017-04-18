using System.Windows.Forms;

namespace SizView.Controls
{
    using System.Collections.Generic;
    using System.ComponentModel;

    using Model.Project;

    public partial class SizListControl : UserControl
    {
        private List<IssueRecord> _issueRecords;

        public SizListControl()
        {
            InitializeComponent();

        }

        [DefaultValue(null)]
        public List<IssueRecord> IssueRecords
        {
            set
            {
                if ( value == null )
                {
                    _issueRecords = new List<IssueRecord>();
                }
                else
                {
                    _issueRecords = value;
                }
                InitGridView();
            }
            get
            {
                return _issueRecords;
            }
        }


        private void InitGridView()
        {
            issueRecordBindingSource.DataSource = _issueRecords;
        }
    }
}
