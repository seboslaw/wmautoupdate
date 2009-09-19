namespace WmAutoUpdate
{
  partial class Notification
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.MainMenu mainMenu1;

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
      this.mainMenu1 = new System.Windows.Forms.MainMenu();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.appname_label = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.progressBar1 = new System.Windows.Forms.ProgressBar();
      this.button1 = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.version_label = new System.Windows.Forms.Label();
      this.panel1 = new System.Windows.Forms.Panel();
      this.panel2 = new System.Windows.Forms.Panel();
      this.message_textbox = new System.Windows.Forms.TextBox();
      this.panel1.SuspendLayout();
      this.panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(104, 19);
      this.label1.Text = "A new version of";
      // 
      // label2
      // 
      this.label2.Dock = System.Windows.Forms.DockStyle.Top;
      this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(240, 32);
      this.label2.Text = "UPDATE AVAILABLE";
      this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      // 
      // appname_label
      // 
      this.appname_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
      this.appname_label.Location = new System.Drawing.Point(3, 19);
      this.appname_label.Name = "appname_label";
      this.appname_label.Size = new System.Drawing.Size(233, 20);
      this.appname_label.Text = "Application Name";
      // 
      // label4
      // 
      this.label4.Location = new System.Drawing.Point(3, 59);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(233, 36);
      this.label4.Text = "is available. It is being downloaded and installed now.";
      // 
      // progressBar1
      // 
      this.progressBar1.Dock = System.Windows.Forms.DockStyle.Top;
      this.progressBar1.Location = new System.Drawing.Point(0, 0);
      this.progressBar1.Name = "progressBar1";
      this.progressBar1.Size = new System.Drawing.Size(240, 20);
      // 
      // button1
      // 
      this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.button1.Location = new System.Drawing.Point(0, 26);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(240, 41);
      this.button1.TabIndex = 5;
      this.button1.Text = "Cancel";
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // label5
      // 
      this.label5.Location = new System.Drawing.Point(3, 39);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(56, 20);
      this.label5.Text = "Version:";
      // 
      // version_label
      // 
      this.version_label.Location = new System.Drawing.Point(66, 39);
      this.version_label.Name = "version_label";
      this.version_label.Size = new System.Drawing.Size(170, 20);
      this.version_label.Text = "1.0.0.0";
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.message_textbox);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.version_label);
      this.panel1.Controls.Add(this.appname_label);
      this.panel1.Controls.Add(this.label4);
      this.panel1.Controls.Add(this.label5);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.panel1.Location = new System.Drawing.Point(0, 32);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(240, 236);
      // 
      // panel2
      // 
      this.panel2.Controls.Add(this.progressBar1);
      this.panel2.Controls.Add(this.button1);
      this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.panel2.Location = new System.Drawing.Point(0, 201);
      this.panel2.Name = "panel2";
      this.panel2.Size = new System.Drawing.Size(240, 67);
      // 
      // message_textbox
      // 
      this.message_textbox.Location = new System.Drawing.Point(4, 99);
      this.message_textbox.Multiline = true;
      this.message_textbox.Name = "message_textbox";
      this.message_textbox.ReadOnly = true;
      this.message_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
      this.message_textbox.Size = new System.Drawing.Size(232, 64);
      this.message_textbox.TabIndex = 11;
      // 
      // Notification
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
      this.AutoScroll = true;
      this.ClientSize = new System.Drawing.Size(240, 268);
      this.ControlBox = false;
      this.Controls.Add(this.panel2);
      this.Controls.Add(this.panel1);
      this.Controls.Add(this.label2);
      this.Menu = this.mainMenu1;
      this.MinimizeBox = false;
      this.Name = "Notification";
      this.Text = "Update";
      this.panel1.ResumeLayout(false);
      this.panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label appname_label;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label version_label;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox message_textbox;

  }
}