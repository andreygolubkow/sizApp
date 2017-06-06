using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;

using Model.Project;
using Model.Zones;

namespace SizView.Controls
{
    public partial class ResourceView : UserControl
    {
        private IZone _zone;

        public ResourceView()
        {
            InitializeComponent();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValue(null)]
        public IZone Zone
        {
            set => _zone = value;
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        [EditorBrowsable(EditorBrowsableState.Never)]
        [DefaultValue(null)]
        public IList<Resource> Resources
        {
            set
            {
                if ( value == null )
                {
                    return;
                }
                List<Tools.ResourceAdapter> adapters = value.Select(itemResource => new Tools.ResourceAdapter(itemResource, _zone)).ToList();
                resourceAdapterBindingSource.DataSource = adapters;
            }
        }

        private void ResourceView_Load(object sender, EventArgs e)
        {

        }
    }

  
}
