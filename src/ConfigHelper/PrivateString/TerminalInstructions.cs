using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfigHelper.PrivateString
{
    public partial class TerminalInstructions : Form
    {
        public TerminalInstructions()
        {
            InitializeComponent();
        }

        private void lklOpenSsl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://slproweb.com/products/Win32OpenSSL.html") { UseShellExecute = true });
        }

        private void txtKeyValuePairName_Enter(object sender, EventArgs e)
        {
            txtKeyValuePairName.SelectAll();
        }

        private void lklCmd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("cmd.exe");
        }

        private void txtKeyValuePairName_TextChanged(object sender, EventArgs e)
        {
            txtPrivateKeyCmd.Text = $"openssl genrsa -out {txtKeyValuePairName.Text}.pvt.pem 2048";
            txtPublicKeyCmd.Text = $"openssl rsa -in {txtKeyValuePairName.Text}.pvt.pem -pubout -out {txtKeyValuePairName.Text}.pub.pem";
        }

        private void btnCopyCheckVersionCmd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCheckVersionCmd.Text);
        }

        private void btnCopyPrivateKeyCmd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPrivateKeyCmd.Text);
        }

        private void btnCopyPublicKeyCmd_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPublicKeyCmd.Text);
        }
    }
}
