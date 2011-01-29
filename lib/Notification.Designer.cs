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
        this.components = new System.ComponentModel.Container();
        this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
        this.label1 = new System.Windows.Forms.Label();
        this.label2 = new System.Windows.Forms.Label();
        this.appname_label = new System.Windows.Forms.Label();
        this.progressBar1 = new System.Windows.Forms.ProgressBar();
        this.button1 = new System.Windows.Forms.Button();
        this.label5 = new System.Windows.Forms.Label();
        this.version_label = new System.Windows.Forms.Label();
        this.panel1 = new System.Windows.Forms.Panel();
        this.message_textbox = new System.Windows.Forms.TextBox();
        this.panel2 = new System.Windows.Forms.Panel();
        this.button2 = new System.Windows.Forms.Button();
        this.buttonRestart = new System.Windows.Forms.Button();
        this.panel1.SuspendLayout();
        this.panel2.SuspendLayout();
        this.SuspendLayout();
        // 
        // label1
        // 
        this.label1.Location = new System.Drawing.Point(3, 0);
        this.label1.Name = "label1";
        this.label1.Size = new System.Drawing.Size(104, 19);
        this.label1.TabIndex = 12;
        this.label1.Text = "A new version of";
        // 
        // label2
        // 
        this.label2.Dock = System.Windows.Forms.DockStyle.Top;
        this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
        this.label2.Location = new System.Drawing.Point(0, 0);
        this.label2.Name = "label2";
        this.label2.Size = new System.Drawing.Size(240, 29);
        this.label2.TabIndex = 2;
        this.label2.Text = "UPDATE AVAILABLE";
        this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
        // 
        // appname_label
        // 
        this.appname_label.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
        this.appname_label.Location = new System.Drawing.Point(113, -1);
        this.appname_label.Name = "appname_label";
        this.appname_label.Size = new System.Drawing.Size(126, 20);
        this.appname_label.TabIndex = 14;
        this.appname_label.Text = "Application Name";
        // 
        // progressBar1
        // 
        this.progressBar1.Location = new System.Drawing.Point(0, 0);
        this.progressBar1.Name = "progressBar1";
        this.progressBar1.Size = new System.Drawing.Size(240, 33);
        this.progressBar1.TabIndex = 7;
        this.progressBar1.Visible = false;
        // 
        // button1
        // 
        this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.button1.Location = new System.Drawing.Point(0, 34);
        this.button1.Name = "button1";
        this.button1.Size = new System.Drawing.Size(240, 33);
        this.button1.TabIndex = 5;
        this.button1.Text = "Cancel";
        this.button1.Click += new System.EventHandler(this.button1_Click);
        // 
        // label5
        // 
        this.label5.Location = new System.Drawing.Point(3, 19);
        this.label5.Name = "label5";
        this.label5.Size = new System.Drawing.Size(56, 20);
        this.label5.TabIndex = 16;
        this.label5.Text = "Version:";
        // 
        // version_label
        // 
        this.version_label.Location = new System.Drawing.Point(113, 19);
        this.version_label.Name = "version_label";
        this.version_label.Size = new System.Drawing.Size(123, 20);
        this.version_label.TabIndex = 13;
        this.version_label.Text = "1.0.0.0";
        // 
        // panel1
        // 
        this.panel1.Controls.Add(this.message_textbox);
        this.panel1.Controls.Add(this.label1);
        this.panel1.Controls.Add(this.version_label);
        this.panel1.Controls.Add(this.appname_label);
        this.panel1.Controls.Add(this.label5);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        this.panel1.Location = new System.Drawing.Point(0, 29);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(240, 205);
        this.panel1.TabIndex = 1;
        // 
        // message_textbox
        // 
        this.message_textbox.Location = new System.Drawing.Point(4, 42);
        this.message_textbox.Multiline = true;
        this.message_textbox.Name = "message_textbox";
        this.message_textbox.ReadOnly = true;
        this.message_textbox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
        this.message_textbox.Size = new System.Drawing.Size(232, 87);
        this.message_textbox.TabIndex = 11;
        // 
        // panel2
        // 
        this.panel2.Controls.Add(this.button1);
        this.panel2.Controls.Add(this.button2);
        this.panel2.Controls.Add(this.progressBar1);
        this.panel2.Controls.Add(this.buttonRestart);
        this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
        this.panel2.Location = new System.Drawing.Point(0, 167);
        this.panel2.Name = "panel2";
        this.panel2.Size = new System.Drawing.Size(240, 67);
        this.panel2.TabIndex = 0;
        // 
        // button2
        // 
        this.button2.Dock = System.Windows.Forms.DockStyle.Top;
        this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
        this.button2.Location = new System.Drawing.Point(0, 0);
        this.button2.Name = "button2";
        this.button2.Size = new System.Drawing.Size(240, 33);
        this.button2.TabIndex = 6;
        this.button2.Text = "Install";
        this.button2.Click += new System.EventHandler(this.button2_Click);
        // 
        // buttonRestart
        // 
        this.buttonRestart.Location = new System.Drawing.Point(0, 0);
        this.buttonRestart.Name = "buttonRestart";
        this.buttonRestart.Size = new System.Drawing.Size(240, 67);
        this.buttonRestart.TabIndex = 8;
        this.buttonRestart.Text = "Restart";
        this.buttonRestart.Visible = false;
        this.buttonRestart.Click += new System.EventHandler(this.buttonRestart_Click);
        // 
        // Notification
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
        this.AutoScroll = true;
        this.BackColor = System.Drawing.SystemColors.Control;
        this.ClientSize = new System.Drawing.Size(240, 234);
        this.Controls.Add(this.panel2);
        this.Controls.Add(this.panel1);
        this.Controls.Add(this.label2);
        this.Menu = this.mainMenu1;
        this.MinimizeBox = false;
        this.Name = "Notification";
        this.Text = "AutoUpdate";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        this.panel2.ResumeLayout(false);
        this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label appname_label;
    private System.Windows.Forms.ProgressBar progressBar1;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Label version_label;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel panel2;
    private System.Windows.Forms.TextBox message_textbox;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button buttonRestart;

  }
}