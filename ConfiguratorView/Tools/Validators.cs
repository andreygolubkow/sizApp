using System.Windows.Forms;

namespace ConfiguratorView.Tools
{
    public class Validators
    {
        public static void DoubleEnterValidate(KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < '0' || e.KeyChar > '9') && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}