namespace ConfigHelper.PrivateString
{
    partial class PrivateString
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            ListViewItem listViewItem1 = new ListViewItem("Connection String", 0);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrivateString));
            txtPublicKeyFile = new TextBox();
            btnPublicKey = new Button();
            btnPrivateKey = new Button();
            txtPrivateKeyFile = new TextBox();
            spcTexts = new SplitContainer();
            txtPlainText = new TextBox();
            panel1 = new Panel();
            btnCopyPlainText = new Button();
            label3 = new Label();
            btnOpenPlainText = new Button();
            btnEncrypt = new Button();
            txtCipheredText = new TextBox();
            panel2 = new Panel();
            btnOpenCipheredText = new Button();
            btnDecrypt = new Button();
            label4 = new Label();
            btnCopyCipheredText = new Button();
            label1 = new Label();
            label2 = new Label();
            btnNewKeyPair = new Button();
            listView1 = new ListView();
            ilStringBuilders = new ImageList(components);
            label5 = new Label();
            label6 = new Label();
            toolTip1 = new ToolTip(components);
            btnTerminal = new Button();
            ((System.ComponentModel.ISupportInitialize)spcTexts).BeginInit();
            spcTexts.Panel1.SuspendLayout();
            spcTexts.Panel2.SuspendLayout();
            spcTexts.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // txtPublicKeyFile
            // 
            txtPublicKeyFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPublicKeyFile.Location = new Point(86, 12);
            txtPublicKeyFile.Name = "txtPublicKeyFile";
            txtPublicKeyFile.Size = new Size(522, 23);
            txtPublicKeyFile.TabIndex = 0;
            // 
            // btnPublicKey
            // 
            btnPublicKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPublicKey.FlatAppearance.BorderSize = 0;
            btnPublicKey.FlatStyle = FlatStyle.Flat;
            btnPublicKey.Image = Properties.Resources.folder_key;
            btnPublicKey.ImageAlign = ContentAlignment.MiddleLeft;
            btnPublicKey.Location = new Point(614, 12);
            btnPublicKey.Name = "btnPublicKey";
            btnPublicKey.Size = new Size(63, 23);
            btnPublicKey.TabIndex = 1;
            btnPublicKey.Text = "Open";
            btnPublicKey.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnPublicKey, "Open an existing PEM public key");
            btnPublicKey.UseVisualStyleBackColor = true;
            // 
            // btnPrivateKey
            // 
            btnPrivateKey.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPrivateKey.FlatAppearance.BorderSize = 0;
            btnPrivateKey.FlatStyle = FlatStyle.Flat;
            btnPrivateKey.Image = Properties.Resources.folder_key;
            btnPrivateKey.ImageAlign = ContentAlignment.MiddleLeft;
            btnPrivateKey.Location = new Point(614, 40);
            btnPrivateKey.Name = "btnPrivateKey";
            btnPrivateKey.Size = new Size(63, 23);
            btnPrivateKey.TabIndex = 4;
            btnPrivateKey.Text = "Open";
            btnPrivateKey.TextAlign = ContentAlignment.MiddleRight;
            toolTip1.SetToolTip(btnPrivateKey, "Open an existing private key");
            btnPrivateKey.UseVisualStyleBackColor = true;
            // 
            // txtPrivateKeyFile
            // 
            txtPrivateKeyFile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtPrivateKeyFile.Location = new Point(86, 41);
            txtPrivateKeyFile.Name = "txtPrivateKeyFile";
            txtPrivateKeyFile.Size = new Size(522, 23);
            txtPrivateKeyFile.TabIndex = 3;
            // 
            // spcTexts
            // 
            spcTexts.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            spcTexts.Location = new Point(12, 70);
            spcTexts.Name = "spcTexts";
            // 
            // spcTexts.Panel1
            // 
            spcTexts.Panel1.Controls.Add(txtPlainText);
            spcTexts.Panel1.Controls.Add(panel1);
            // 
            // spcTexts.Panel2
            // 
            spcTexts.Panel2.Controls.Add(txtCipheredText);
            spcTexts.Panel2.Controls.Add(panel2);
            spcTexts.Size = new Size(812, 450);
            spcTexts.SplitterDistance = 402;
            spcTexts.TabIndex = 6;
            // 
            // txtPlainText
            // 
            txtPlainText.AllowDrop = true;
            txtPlainText.Dock = DockStyle.Fill;
            txtPlainText.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtPlainText.Location = new Point(0, 26);
            txtPlainText.Multiline = true;
            txtPlainText.Name = "txtPlainText";
            txtPlainText.ScrollBars = ScrollBars.Both;
            txtPlainText.Size = new Size(402, 424);
            txtPlainText.TabIndex = 1;
            txtPlainText.WordWrap = false;
            txtPlainText.DragDrop += txtPlainText_DragDrop;
            txtPlainText.DragEnter += txtPlainText_DragEnter;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnCopyPlainText);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(btnOpenPlainText);
            panel1.Controls.Add(btnEncrypt);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(402, 26);
            panel1.TabIndex = 0;
            // 
            // btnCopyPlainText
            // 
            btnCopyPlainText.Dock = DockStyle.Left;
            btnCopyPlainText.FlatAppearance.BorderSize = 0;
            btnCopyPlainText.FlatStyle = FlatStyle.Flat;
            btnCopyPlainText.Image = Properties.Resources.page_copy;
            btnCopyPlainText.Location = new Point(24, 0);
            btnCopyPlainText.Name = "btnCopyPlainText";
            btnCopyPlainText.Size = new Size(24, 26);
            btnCopyPlainText.TabIndex = 9;
            btnCopyPlainText.UseVisualStyleBackColor = true;
            btnCopyPlainText.Click += btnCopyPlainText_Click;
            // 
            // label3
            // 
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(24, 0);
            label3.Name = "label3";
            label3.Size = new Size(355, 26);
            label3.TabIndex = 1;
            label3.Text = "PLAIN";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnOpenPlainText
            // 
            btnOpenPlainText.Dock = DockStyle.Left;
            btnOpenPlainText.FlatAppearance.BorderSize = 0;
            btnOpenPlainText.FlatStyle = FlatStyle.Flat;
            btnOpenPlainText.Image = Properties.Resources.folder_page;
            btnOpenPlainText.Location = new Point(0, 0);
            btnOpenPlainText.Name = "btnOpenPlainText";
            btnOpenPlainText.Size = new Size(24, 26);
            btnOpenPlainText.TabIndex = 4;
            btnOpenPlainText.UseVisualStyleBackColor = true;
            btnOpenPlainText.Click += btnOpenPlainText_Click;
            // 
            // btnEncrypt
            // 
            btnEncrypt.Dock = DockStyle.Right;
            btnEncrypt.FlatAppearance.BorderSize = 0;
            btnEncrypt.FlatStyle = FlatStyle.Flat;
            btnEncrypt.Image = Properties.Resources.arrow_right_red_r16x16;
            btnEncrypt.Location = new Point(379, 0);
            btnEncrypt.Name = "btnEncrypt";
            btnEncrypt.Size = new Size(23, 26);
            btnEncrypt.TabIndex = 8;
            btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // txtCipheredText
            // 
            txtCipheredText.AllowDrop = true;
            txtCipheredText.Dock = DockStyle.Fill;
            txtCipheredText.Font = new Font("Consolas", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            txtCipheredText.Location = new Point(0, 26);
            txtCipheredText.Multiline = true;
            txtCipheredText.Name = "txtCipheredText";
            txtCipheredText.ScrollBars = ScrollBars.Both;
            txtCipheredText.Size = new Size(406, 424);
            txtCipheredText.TabIndex = 2;
            txtCipheredText.WordWrap = false;
            txtCipheredText.DragDrop += txtCipheredText_DragDrop;
            txtCipheredText.DragEnter += txtCipheredText_DragEnter;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnOpenCipheredText);
            panel2.Controls.Add(btnDecrypt);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(btnCopyCipheredText);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(406, 26);
            panel2.TabIndex = 1;
            // 
            // btnOpenCipheredText
            // 
            btnOpenCipheredText.Dock = DockStyle.Right;
            btnOpenCipheredText.FlatAppearance.BorderSize = 0;
            btnOpenCipheredText.FlatStyle = FlatStyle.Flat;
            btnOpenCipheredText.Image = Properties.Resources.folder_page;
            btnOpenCipheredText.Location = new Point(358, 0);
            btnOpenCipheredText.Name = "btnOpenCipheredText";
            btnOpenCipheredText.Size = new Size(24, 26);
            btnOpenCipheredText.TabIndex = 10;
            btnOpenCipheredText.UseVisualStyleBackColor = true;
            btnOpenCipheredText.Click += btnOpenCipheredText_Click;
            // 
            // btnDecrypt
            // 
            btnDecrypt.Dock = DockStyle.Left;
            btnDecrypt.FlatAppearance.BorderSize = 0;
            btnDecrypt.FlatStyle = FlatStyle.Flat;
            btnDecrypt.Image = Properties.Resources.arrow_left_green_r16x16;
            btnDecrypt.Location = new Point(0, 0);
            btnDecrypt.Name = "btnDecrypt";
            btnDecrypt.Size = new Size(23, 26);
            btnDecrypt.TabIndex = 9;
            btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Dock = DockStyle.Fill;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(382, 26);
            label4.TabIndex = 4;
            label4.Text = "CIPHERED";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnCopyCipheredText
            // 
            btnCopyCipheredText.Dock = DockStyle.Right;
            btnCopyCipheredText.FlatAppearance.BorderSize = 0;
            btnCopyCipheredText.FlatStyle = FlatStyle.Flat;
            btnCopyCipheredText.Image = Properties.Resources.page_copy;
            btnCopyCipheredText.Location = new Point(382, 0);
            btnCopyCipheredText.Name = "btnCopyCipheredText";
            btnCopyCipheredText.Size = new Size(24, 26);
            btnCopyCipheredText.TabIndex = 3;
            btnCopyCipheredText.UseVisualStyleBackColor = true;
            btnCopyCipheredText.Click += btnCopyCipheredText_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 7;
            label1.Text = "Public Key:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Green;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 7;
            label2.Text = "Private Key:";
            // 
            // btnNewKeyPair
            // 
            btnNewKeyPair.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewKeyPair.FlatAppearance.BorderSize = 0;
            btnNewKeyPair.FlatStyle = FlatStyle.Flat;
            btnNewKeyPair.Image = Properties.Resources.key_add;
            btnNewKeyPair.ImageAlign = ContentAlignment.TopCenter;
            btnNewKeyPair.Location = new Point(683, 12);
            btnNewKeyPair.Name = "btnNewKeyPair";
            btnNewKeyPair.Size = new Size(75, 52);
            btnNewKeyPair.TabIndex = 8;
            btnNewKeyPair.Text = "New Pair";
            btnNewKeyPair.TextAlign = ContentAlignment.BottomCenter;
            toolTip1.SetToolTip(btnNewKeyPair, "Create a new pair of PEM keys");
            btnNewKeyPair.UseVisualStyleBackColor = true;
            btnNewKeyPair.Click += btnNewKeyPair_Click;
            // 
            // listView1
            // 
            listView1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1 });
            listView1.LargeImageList = ilStringBuilders;
            listView1.Location = new Point(12, 555);
            listView1.Name = "listView1";
            listView1.Size = new Size(812, 95);
            listView1.TabIndex = 9;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.ItemDrag += listView1_ItemDrag;
            listView1.DragEnter += listView1_DragEnter;
            // 
            // ilStringBuilders
            // 
            ilStringBuilders.ColorDepth = ColorDepth.Depth32Bit;
            ilStringBuilders.ImageStream = (ImageListStreamer)resources.GetObject("ilStringBuilders.ImageStream");
            ilStringBuilders.TransparentColor = Color.Transparent;
            ilStringBuilders.Images.SetKeyName(0, "connectionString-w96.png");
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(12, 526);
            label5.Name = "label5";
            label5.Size = new Size(152, 26);
            label5.TabIndex = 10;
            label5.Text = "STRING BUILDERS";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Gray;
            label6.Location = new Point(299, 533);
            label6.Name = "label6";
            label6.Size = new Size(522, 15);
            label6.TabIndex = 11;
            label6.Text = "Drag a string builder over PLAIN or CIPHERED textboxes to start wizzard ana have your string built";
            // 
            // btnTerminal
            // 
            btnTerminal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnTerminal.FlatAppearance.BorderSize = 0;
            btnTerminal.FlatStyle = FlatStyle.Flat;
            btnTerminal.Image = Properties.Resources.terminal_w24;
            btnTerminal.ImageAlign = ContentAlignment.TopCenter;
            btnTerminal.Location = new Point(764, 11);
            btnTerminal.Name = "btnTerminal";
            btnTerminal.Size = new Size(60, 52);
            btnTerminal.TabIndex = 12;
            btnTerminal.Text = "Terminal";
            btnTerminal.TextAlign = ContentAlignment.BottomCenter;
            btnTerminal.UseVisualStyleBackColor = true;
            btnTerminal.Click += btnTerminal_Click;
            // 
            // PrivateString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(836, 662);
            Controls.Add(btnTerminal);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(listView1);
            Controls.Add(btnNewKeyPair);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(spcTexts);
            Controls.Add(btnPrivateKey);
            Controls.Add(txtPrivateKeyFile);
            Controls.Add(btnPublicKey);
            Controls.Add(txtPublicKeyFile);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "PrivateString";
            Text = "Private String";
            spcTexts.Panel1.ResumeLayout(false);
            spcTexts.Panel1.PerformLayout();
            spcTexts.Panel2.ResumeLayout(false);
            spcTexts.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)spcTexts).EndInit();
            spcTexts.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPublicKeyFile;
        private Button btnPublicKey;
        private Button btnPrivateKey;
        private TextBox txtPrivateKeyFile;
        private SplitContainer spcTexts;
        private Panel panel1;
        private Panel panel2;
        private TextBox txtPlainText;
        private Label label3;
        private Button btnOpenPlainText;
        private TextBox txtCipheredText;
        private Label label4;
        private Button btnCopyCipheredText;
        private Button btnEncrypt;
        private Button btnDecrypt;
        private Button btnCopyPlainText;
        private Button btnOpenCipheredText;
        private Label label1;
        private Label label2;
        private Button btnNewKeyPair;
        private ListView listView1;
        private ImageList ilStringBuilders;
        private Label label5;
        private Label label6;
        private ToolTip toolTip1;
        private Button button1;
        private Button btnTerminal;
    }
}