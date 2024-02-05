namespace ConfigHelper.PrivateString
{
    partial class TerminalInstructions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TerminalInstructions));
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            txtKeyValuePairName = new TextBox();
            txtPublicKeyCmd = new TextBox();
            txtPrivateKeyCmd = new TextBox();
            lklCmd = new LinkLabel();
            label1 = new Label();
            label10 = new Label();
            txtCheckVersionCmd = new TextBox();
            label11 = new Label();
            lklOpenSsl = new LinkLabel();
            btnCopyCheckVersionCmd = new Button();
            btnCopyPrivateKeyCmd = new Button();
            btnCopyPublicKeyCmd = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 82);
            label2.Name = "label2";
            label2.Size = new Size(48, 48);
            label2.TabIndex = 0;
            label2.Text = "02";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(66, 82);
            label3.Name = "label3";
            label3.Size = new Size(221, 48);
            label3.TabIndex = 0;
            label3.Text = "Choose a name for your key value pair";
            // 
            // label4
            // 
            label4.BackColor = Color.Gray;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(12, 155);
            label4.Name = "label4";
            label4.Size = new Size(48, 48);
            label4.TabIndex = 0;
            label4.Text = "03";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(66, 9);
            label5.Name = "label5";
            label5.Size = new Size(221, 48);
            label5.TabIndex = 0;
            label5.Text = "Open a session of Windows Terminal or Cmd";
            // 
            // label6
            // 
            label6.BackColor = Color.Gray;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(12, 228);
            label6.Name = "label6";
            label6.Size = new Size(48, 48);
            label6.TabIndex = 0;
            label6.Text = "04";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(66, 242);
            label7.Name = "label7";
            label7.Size = new Size(221, 23);
            label7.TabIndex = 0;
            label7.Text = "Create private key";
            // 
            // label8
            // 
            label8.BackColor = Color.Gray;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(12, 301);
            label8.Name = "label8";
            label8.Size = new Size(48, 48);
            label8.TabIndex = 0;
            label8.Text = "05";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(66, 301);
            label9.Name = "label9";
            label9.Size = new Size(221, 48);
            label9.TabIndex = 0;
            label9.Text = "Use private key to create the public key";
            // 
            // txtKeyValuePairName
            // 
            txtKeyValuePairName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtKeyValuePairName.Location = new Point(293, 93);
            txtKeyValuePairName.Name = "txtKeyValuePairName";
            txtKeyValuePairName.Size = new Size(220, 29);
            txtKeyValuePairName.TabIndex = 1;
            txtKeyValuePairName.Text = "sample";
            txtKeyValuePairName.TextChanged += txtKeyValuePairName_TextChanged;
            txtKeyValuePairName.Enter += txtKeyValuePairName_Enter;
            // 
            // txtPublicKeyCmd
            // 
            txtPublicKeyCmd.BackColor = Color.Black;
            txtPublicKeyCmd.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPublicKeyCmd.ForeColor = Color.White;
            txtPublicKeyCmd.Location = new Point(293, 301);
            txtPublicKeyCmd.Multiline = true;
            txtPublicKeyCmd.Name = "txtPublicKeyCmd";
            txtPublicKeyCmd.Size = new Size(456, 48);
            txtPublicKeyCmd.TabIndex = 1;
            txtPublicKeyCmd.Text = "openssl rsa -in sample.pvt.pem -pubout -out sample.pub.pem";
            // 
            // txtPrivateKeyCmd
            // 
            txtPrivateKeyCmd.BackColor = Color.Black;
            txtPrivateKeyCmd.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrivateKeyCmd.ForeColor = Color.White;
            txtPrivateKeyCmd.Location = new Point(293, 228);
            txtPrivateKeyCmd.Multiline = true;
            txtPrivateKeyCmd.Name = "txtPrivateKeyCmd";
            txtPrivateKeyCmd.Size = new Size(456, 48);
            txtPrivateKeyCmd.TabIndex = 1;
            txtPrivateKeyCmd.Text = "openssl genrsa -out sample.pvt.pem 2048";
            // 
            // lklCmd
            // 
            lklCmd.AutoSize = true;
            lklCmd.Location = new Point(293, 28);
            lklCmd.Name = "lklCmd";
            lklCmd.Size = new Size(220, 15);
            lklCmd.TabIndex = 2;
            lklCmd.TabStop = true;
            lklCmd.Text = "... or you can click here to open cmd.exe";
            lklCmd.LinkClicked += lklCmd_LinkClicked;
            // 
            // label1
            // 
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(48, 48);
            label1.TabIndex = 0;
            label1.Text = "01";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.Location = new Point(66, 155);
            label10.Name = "label10";
            label10.Size = new Size(221, 48);
            label10.TabIndex = 0;
            label10.Text = "Check if OpenSSL 3.2.1 version or greater is installed";
            // 
            // txtCheckVersionCmd
            // 
            txtCheckVersionCmd.BackColor = Color.Black;
            txtCheckVersionCmd.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtCheckVersionCmd.ForeColor = Color.White;
            txtCheckVersionCmd.Location = new Point(293, 158);
            txtCheckVersionCmd.Name = "txtCheckVersionCmd";
            txtCheckVersionCmd.Size = new Size(456, 23);
            txtCheckVersionCmd.TabIndex = 1;
            txtCheckVersionCmd.Text = "openssl --version";
            // 
            // label11
            // 
            label11.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(293, 184);
            label11.Name = "label11";
            label11.Size = new Size(456, 23);
            label11.TabIndex = 0;
            label11.Text = "> OpenSSL 3.2.1 30 Jan 2024 (Library: OpenSSL 3.2.1 30 Jan 2024)";
            // 
            // lklOpenSsl
            // 
            lklOpenSsl.AutoSize = true;
            lklOpenSsl.Location = new Point(293, 207);
            lklOpenSsl.Name = "lklOpenSsl";
            lklOpenSsl.Size = new Size(298, 15);
            lklOpenSsl.TabIndex = 2;
            lklOpenSsl.TabStop = true;
            lklOpenSsl.Text = "If don't, click here to go to download page and install it";
            lklOpenSsl.LinkClicked += lklOpenSsl_LinkClicked;
            // 
            // btnCopyCheckVersionCmd
            // 
            btnCopyCheckVersionCmd.FlatAppearance.BorderSize = 0;
            btnCopyCheckVersionCmd.FlatStyle = FlatStyle.Flat;
            btnCopyCheckVersionCmd.Image = Properties.Resources.page_copy;
            btnCopyCheckVersionCmd.Location = new Point(755, 159);
            btnCopyCheckVersionCmd.Name = "btnCopyCheckVersionCmd";
            btnCopyCheckVersionCmd.Size = new Size(24, 22);
            btnCopyCheckVersionCmd.TabIndex = 4;
            btnCopyCheckVersionCmd.UseVisualStyleBackColor = true;
            btnCopyCheckVersionCmd.Click += btnCopyCheckVersionCmd_Click;
            // 
            // btnCopyPrivateKeyCmd
            // 
            btnCopyPrivateKeyCmd.FlatAppearance.BorderSize = 0;
            btnCopyPrivateKeyCmd.FlatStyle = FlatStyle.Flat;
            btnCopyPrivateKeyCmd.Image = Properties.Resources.page_copy;
            btnCopyPrivateKeyCmd.Location = new Point(755, 228);
            btnCopyPrivateKeyCmd.Name = "btnCopyPrivateKeyCmd";
            btnCopyPrivateKeyCmd.Size = new Size(24, 48);
            btnCopyPrivateKeyCmd.TabIndex = 4;
            btnCopyPrivateKeyCmd.UseVisualStyleBackColor = true;
            btnCopyPrivateKeyCmd.Click += btnCopyPrivateKeyCmd_Click;
            // 
            // btnCopyPublicKeyCmd
            // 
            btnCopyPublicKeyCmd.FlatAppearance.BorderSize = 0;
            btnCopyPublicKeyCmd.FlatStyle = FlatStyle.Flat;
            btnCopyPublicKeyCmd.Image = Properties.Resources.page_copy;
            btnCopyPublicKeyCmd.Location = new Point(755, 301);
            btnCopyPublicKeyCmd.Name = "btnCopyPublicKeyCmd";
            btnCopyPublicKeyCmd.Size = new Size(24, 48);
            btnCopyPublicKeyCmd.TabIndex = 4;
            btnCopyPublicKeyCmd.UseVisualStyleBackColor = true;
            btnCopyPublicKeyCmd.Click += btnCopyPublicKeyCmd_Click;
            // 
            // TerminalInstructions
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 367);
            Controls.Add(btnCopyPublicKeyCmd);
            Controls.Add(btnCopyPrivateKeyCmd);
            Controls.Add(btnCopyCheckVersionCmd);
            Controls.Add(lklOpenSsl);
            Controls.Add(lklCmd);
            Controls.Add(txtCheckVersionCmd);
            Controls.Add(txtPrivateKeyCmd);
            Controls.Add(txtPublicKeyCmd);
            Controls.Add(txtKeyValuePairName);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "TerminalInstructions";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create a PEM key pair using Windows Terminal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox txtKeyValuePairName;
        private TextBox txtPublicKeyCmd;
        private TextBox txtPrivateKeyCmd;
        private LinkLabel lklCmd;
        private Label label1;
        private Label label10;
        private TextBox txtCheckVersionCmd;
        private Label label11;
        private LinkLabel lklOpenSsl;
        private Button btnCopyCheckVersionCmd;
        private Button btnCopyPrivateKeyCmd;
        private Button btnCopyPublicKeyCmd;
    }
}