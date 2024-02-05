using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;
using System.Text;

namespace ConfigHelper.PrivateString
{
    public partial class PrivateString : Form
    {
        public PrivateString()
        {
            InitializeComponent();

            btnPrivateKey.Tag = txtPrivateKeyFile;
            btnPublicKey.Tag = txtPublicKeyFile;
            txtPrivateKeyFile.Tag = btnDecrypt;
            txtPublicKeyFile.Tag = btnEncrypt;

            RegisterEvents();
        }

        private void RegisterEvents()
        {
            txtPublicKeyFile.TextChanged += CheckFileExistence;
            btnPublicKey.Click += OpenFile;
            txtPrivateKeyFile.TextChanged += CheckFileExistence;
            btnPrivateKey.Click += OpenFile;
            btnEncrypt.Click += (s, e) => txtCipheredText.Text = Encrypt(txtPlainText.Text);
            btnDecrypt.Click += (s, e) => txtPlainText.Text = Decrypt(txtCipheredText.Text);
        }

        private void CheckFileExistence(object? sender, EventArgs e)
        {
            if (sender is TextBox txt)
            {
                var btn = ((Button)txt.Tag);
                btn.Enabled = File.Exists(txt.Text);
                SearchCorrespondingPair(txt);
            }
        }

        private void SearchCorrespondingPair(TextBox txt)
        {
            var folder = Path.GetDirectoryName(txt.Text);
            var fileSelected = Path.GetFileName(txt.Text);
            if (folder != null)
            {
                if (txt == txtPublicKeyFile && txt.Text.Contains(".pub.pem"))
                {
                    var fileToSearch = Path.Combine(folder, fileSelected.Replace(".pub.pem", ".pvt.pem"));
                    if (File.Exists(fileToSearch) && txtPrivateKeyFile.Text != fileToSearch)
                    {
                        if (MessageBox.Show("It looks there is a corresponding private key in the same directory. Do you want to load it?", "Search Pair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            txtPrivateKeyFile.Text = fileToSearch;
                    }
                }
                else if (txt == txtPrivateKeyFile && txt.Text.Contains(".pvt.pem"))
                {
                    var fileToSearch = Path.Combine(folder, fileSelected.Replace(".pvt.pem", ".pub.pem"));
                    if (File.Exists(fileToSearch) && txtPublicKeyFile.Text != fileToSearch)
                    {
                        if (MessageBox.Show("It looks there is a corresponding public key in the same directory. Do you want to load it?", "Search Pair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            txtPublicKeyFile.Text = fileToSearch;
                    }
                }
            }
        }

        private void OpenFile(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                var txt = (TextBox)btn.Tag;
                var dlg = new OpenFileDialog
                {
                    Filter = "All Files|*.*",
                    Title = "Select a file",
                    FileName = txt.Text
                };

                if (dlg.ShowDialog() == DialogResult.OK)
                    txt.Text = dlg.FileName;
            }
        }

        private string Encrypt(string plainText)
        {
            try
            {
                var publicKey = GetPublicKey();
                if (publicKey != null)
                    return Encrypt(publicKey, plainText);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data or key.", "Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return string.Empty;
        }

        private string Decrypt(string cipheredText)
        {
            try
            {
                var privateKey = GetPrivateKey();
                if (privateKey != null)
                    return Decrypt(privateKey, cipheredText);
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid data or key.", "Encrypt", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return string.Empty;
        }

        private string Encrypt(string xmlStringKey, string data)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xmlStringKey);
            var encryptedData = rsa.Encrypt(Encoding.UTF8.GetBytes(data), false);
            return Convert.ToBase64String(encryptedData);
        }

        private string Decrypt(string xmlStringKey, string data)
        {
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();
            rsa.FromXmlString(xmlStringKey);
            var decryptedData = rsa.Decrypt(Convert.FromBase64String(data), false);
            return Encoding.UTF8.GetString(decryptedData);
        }

        private string? GetPublicKey()
        {
            if (File.Exists(txtPublicKeyFile.Text))
            {
                var publicKeyFileContent = File.ReadAllText(txtPublicKeyFile.Text, Encoding.UTF8);
                var rsa = RSA.Create();
                rsa.ImportFromPem(publicKeyFileContent.ToCharArray());
                return rsa.ToXmlString(false);
            }
            else
                return null;
        }

        private string? GetPrivateKey()
        {
            if (File.Exists(txtPrivateKeyFile.Text))
            {
                var privateKeyFileContent = File.ReadAllText(txtPrivateKeyFile.Text);
                var rsa = RSA.Create();

                rsa.ImportFromPem(privateKeyFileContent.ToCharArray());
                return rsa.ToXmlString(true);
            }
            else
                return null;
        }

        private void btnNewKeyPair_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog
            {
                Filter = "PEM Files|*.pem",
                Title = "Select a file",
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                var rsa = RSA.Create();
                var filename = Path.GetFileNameWithoutExtension(dlg.FileName);
                var folder = Path.GetDirectoryName(dlg.FileName)!;

                var publicKeyFile = Path.Combine(folder, $"{filename}.pub.pem");
                var privateKeyFile = Path.Combine(folder, $"{filename}.pvt.pem");

                if (CanWritePemFile(publicKeyFile) && CanWritePemFile(privateKeyFile))
                {
                    ExportPublicKeyPemFile(publicKeyFile, rsa);
                    txtPublicKeyFile.Text = publicKeyFile;

                    ExportPrivateKeyPemFile(privateKeyFile, rsa);
                    txtPrivateKeyFile.Text = privateKeyFile;

                    MessageBox.Show("Key pair created.", "New Key Pair", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Files not written.", "New Key Pair", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool CanWritePemFile(string fileName)
        {
            if (File.Exists(fileName))
                return MessageBox.Show($"File {fileName} already exists. Do you want to overwrite it?", "File Exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes;
            else
                return true;
        }

        private void ExportPublicKeyPemFile(string fileName, RSA rsa)
        {
            var publicKey = rsa.ExportRSAPublicKey();
            var content = Convert.ToBase64String(rsa.ExportSubjectPublicKeyInfo());

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("-----BEGIN PUBLIC KEY-----");
            int pos = 0;
            do
            {
                string line;
                if (content.Length - pos > 64)
                    line = content.Substring(pos, 64);
                else
                    line = content.Substring(pos, content.Length - pos);
                builder.AppendLine(line);
                pos += line.Length;
            } while (pos < content.Length);
            builder.AppendLine("-----END PUBLIC KEY-----");

            File.WriteAllText(fileName, builder.ToString());
        }

        private void ExportPrivateKeyPemFile(string fileName, RSA rsa)
        {
            var privateKey = rsa.ExportRSAPrivateKey();
            var content = Convert.ToBase64String(rsa.ExportPkcs8PrivateKey());

            StringBuilder builder = new StringBuilder();
            builder.AppendLine("-----BEGIN PRIVATE KEY-----");
            int pos = 0;
            do
            {
                string line;
                if (content.Length - pos > 64)
                    line = content.Substring(pos, 64);
                else
                    line = content.Substring(pos, content.Length - pos);
                builder.AppendLine(line);
                pos += line.Length;
            } while (pos < content.Length);
            builder.AppendLine("-----END PRIVATE KEY-----");

            File.WriteAllText(fileName, builder.ToString());
        }

        private void txtPlainText_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                if (item != null)
                    BuildString(item.Text);
            }
        }

        private void txtCipheredText_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data != null && e.Data.GetDataPresent(typeof(ListViewItem)))
            {
                var item = (ListViewItem)e.Data.GetData(typeof(ListViewItem));
                if (item != null)
                {
                    var stringValue = BuildString(item.Text);
                    if (stringValue != null)
                        txtCipheredText.Text = Encrypt(stringValue);
                    else
                        txtCipheredText.Text = string.Empty;
                }
            }
        }

        private string? BuildString(string builderName)
        {
            switch (builderName)
            {
                case "Connection String":
                    return CreateNewConnectionString();
                default:
                    return null;
            }
        }

        private static string? CreateNewConnectionString()
        {
            MSDASC.DataLinks dataLinks = new MSDASC.DataLinks();
            var connection = dataLinks.PromptNew();
            string connectionString = connection.ConnectionString;
            if (string.IsNullOrEmpty(connectionString))
                return null;
            else
                return connectionString;
        }

        private void listView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            listView1.DoDragDrop(e.Item, DragDropEffects.Copy);
        }

        private void listView1_DragEnter(object sender, DragEventArgs e)
        {
            //if (e.Data != null)
            //    e.Effect = e.Data.GetDataPresent(typeof(ListViewItem)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void txtCipheredText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null)
                e.Effect = (e.Data.GetDataPresent(typeof(ListViewItem)) && File.Exists(txtPublicKeyFile.Text)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void txtPlainText_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data != null)
                e.Effect = e.Data.GetDataPresent(typeof(ListViewItem)) ? DragDropEffects.Copy : DragDropEffects.None;
        }

        private void btnTerminal_Click(object sender, EventArgs e)
        {
            TerminalInstructions dlg = new TerminalInstructions();
            dlg.ShowDialog();
        }

        private void btnOpenPlainText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtPlainText.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void btnOpenCipheredText_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtCipheredText.Text = File.ReadAllText(dlg.FileName);
            }
        }

        private void btnCopyPlainText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtPlainText.Text);
        }

        private void btnCopyCipheredText_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtCipheredText.Text);
        }
    }
}
