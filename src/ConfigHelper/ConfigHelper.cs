using ConfigHelper.PrivateString;

namespace ConfigHelper;

public partial class ConfigHelper : Form
{
    public ConfigHelper()
    {
        InitializeComponent();
    }

    private void tsbPrivateString_Click(object sender, EventArgs e)
    {
        PrivateString.PrivateString frm = new PrivateString.PrivateString();
        frm.MdiParent = this;
        frm.Show();
    }
}
