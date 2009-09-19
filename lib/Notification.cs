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
using Ionic.Zip;
using System.Threading;

namespace WmAutoUpdate
{
  
  public partial class Notification : Form
  {
    public delegate void FormLoaded();
    public event FormLoaded NotificationFormReady;

    private readonly Assembly callingAssembly;
    private TransferManager.TransferProgress trans;

    public Notification(String name, String message, String version, String url, Assembly callingAssem)
    {
      InitializeComponent();
      this.appname_label.Text = name;
      this.version_label.Text = version;
      this.message_textbox.Text = message;
      this.callingAssembly = callingAssem;
      trans = new TransferManager.TransferProgress(UpdateProgressBar);
      if (NotificationFormReady != null)
      {
        NotificationFormReady();
      }
      ThreadPool.QueueUserWorkItem(new WaitCallback(startUpdate), url);
    }

    protected void startUpdate(object _url)
    {
      string url = (string) _url;

      String fullAppName = callingAssembly.GetName().CodeBase;
      String appPath = Path.GetDirectoryName(fullAppName);
      String updateDir = appPath + "\\update";
      String updateFilename = getFilename(url);
      string updateZip = updateDir + "\\" + updateFilename;
      // Create directory to store update files
      Directory.CreateDirectory(updateDir);
      TransferManager tm = new TransferManager();
      Stream s;

      tm.downloadFile(url, out s, updateZip, trans);
      s.Close();

      using (ZipFile zip1 = ZipFile.Read(updateZip))
      {
        foreach (ZipEntry e in zip1)
        {
          e.Extract(updateDir, ExtractExistingFileAction.OverwriteSilently);
        }
      }

      File.Delete(updateZip);
      string backupDir = appPath + "\\backup";
      Directory.Delete(backupDir,true);
      Directory.CreateDirectory(backupDir);
      foreach (string filepath in Directory.GetFiles(updateDir))
      {
        string originalFile = appPath + "\\" +getFilenameFromPath(filepath);
        if (File.Exists(originalFile))
        {
          string backupFilepath = backupDir + "\\" + getFilenameFromPath(filepath);
          File.Move(originalFile, backupFilepath);
          File.Move(filepath, originalFile);
        }
      }


      this.DialogResult = DialogResult.OK;
      this.Visible = false;
    }

    private void button1_Click(object sender, EventArgs e)
    {
      this.DialogResult = DialogResult.No;
      this.Visible = false;
    }

    private string getFilename(String url)
    {
      char[] delim = { '/' };
      string[] a = url.Split(delim);
      return a[a.Length - 1];
    }
   
    private string getFilenameFromPath(String path)
    {
      char[] delim = { '\\' };
      string[] a = path.Split(delim);
      return a[a.Length - 1];
    }

    public void UpdateProgressBar(int status)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new TransferManager.TransferProgress(UpdateProgressBar), status);
        return;
      }

      progressBar1.Value = (int)status;
    }

    //protected void NotificationForm_loadingStart()
    //{
    //}

    //protected void NotificationForm_loadingFinished()
    //{
    //}
    //protected void NotificationForm_loadingProcess(int process)
    //{
    //}
  }
}