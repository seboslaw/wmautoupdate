using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
using System.Threading;

namespace WmAutoUpdate
{ 
  public partial class Notification : Form
  {
    public delegate void StartUpdate();
    public delegate void FormLoaded();
    public delegate void StopUpdate();
    public delegate void AbortUpdate();
    public event FormLoaded NotificationFormReady;
    public event StartUpdate StartUpdateEvent;
    public event StopUpdate StopUpdateEvent;
    public event AbortUpdate AbortUpdateEvent;

    private readonly Assembly callingAssembly;
    public TransferManager.TransferProgress trans;
    private volatile bool updateStarted = false;

    public Notification(String name, String message, String version, Assembly callingAssem, Updater updater)
    {
      InitializeComponent();
      this.appname_label.Text = name;
      this.version_label.Text = version;
      this.message_textbox.Text = message;
      this.callingAssembly = callingAssem;
      trans = new TransferManager.TransferProgress(UpdateProgressBar);
      updater.UpdateDoneEvent +=new Updater.UpdateDone(updater_UpdateDoneEvent);
      if (NotificationFormReady != null)
        NotificationFormReady();
    }

    void updater_UpdateDoneEvent()
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new Updater.UpdateDone(updater_UpdateDoneEvent), null);
        return;
      }
      button1.Visible = false;
      button2.Visible = false;
      progressBar1.Visible = false;
      buttonRestart.Visible = true;
      button1.Dock = DockStyle.None;
      button2.Dock = DockStyle.None;
      progressBar1.Dock = DockStyle.None;
      buttonRestart.Dock = DockStyle.Top;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      if (updateStarted)
      {
        if (AbortUpdateEvent != null)
          AbortUpdateEvent();
      }
      this.DialogResult = DialogResult.No;
      this.Visible = false;
    }

    public void UpdateProgressBar(int status)
    {
      if (this.InvokeRequired)
      {
        if (!this.IsDisposed)
        {
          this.BeginInvoke(new TransferManager.TransferProgress(UpdateProgressBar), status);
        }
        return;
      }
      progressBar1.Value = (int)status;
    }

    private void button2_Click(object sender, EventArgs e)
    {
      if (StartUpdateEvent != null)
      {
        Button button = (Button)sender;
        button.Visible = false;
        button.Dock = DockStyle.None;
        progressBar1.Dock = DockStyle.Top;
        progressBar1.Visible = true;
        StartUpdateEvent();
        updateStarted = true;
      }
    }

    private void buttonRestart_Click(object sender, EventArgs e)
    {
      if (updateStarted)
      {
        this.DialogResult = DialogResult.Yes;
        this.Visible = false;
      }
    }

  }
}