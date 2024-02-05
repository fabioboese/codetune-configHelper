namespace ConfigHelper;

partial class ConfigHelper
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigHelper));
        toolStrip1 = new ToolStrip();
        tsbPrivateString = new ToolStripButton();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // toolStrip1
        // 
        toolStrip1.ImageScalingSize = new Size(64, 64);
        toolStrip1.Items.AddRange(new ToolStripItem[] { tsbPrivateString });
        toolStrip1.Location = new Point(0, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(800, 86);
        toolStrip1.TabIndex = 0;
        toolStrip1.Text = "toolStrip1";
        // 
        // tsbPrivateString
        // 
        tsbPrivateString.Image = Properties.Resources.StringEncryption;
        tsbPrivateString.ImageTransparentColor = Color.Magenta;
        tsbPrivateString.Name = "tsbPrivateString";
        tsbPrivateString.Size = new Size(81, 83);
        tsbPrivateString.Text = "Private String";
        tsbPrivateString.TextImageRelation = TextImageRelation.ImageAboveText;
        tsbPrivateString.Click += tsbPrivateString_Click;
        // 
        // ConfigHelper
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 612);
        Controls.Add(toolStrip1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        IsMdiContainer = true;
        Name = "ConfigHelper";
        Text = "Config Helper";
        WindowState = FormWindowState.Maximized;
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ToolStrip toolStrip1;
    private ToolStripButton tsbPrivateString;
}
