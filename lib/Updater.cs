using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Reflection;
using System.Xml;
using System.Windows.Forms;
using System.Diagnostics;

namespace WmAutoUpdate
{
  public class Updater
  {
    private readonly String URL;
    private readonly String updateFilePath;
    private readonly String appPath;
    private readonly Assembly callingAssembly;

    public Updater(String url)
    {
      this.URL = url;
      Debug.Assert(url != null);
      callingAssembly = System.Reflection.Assembly.GetCallingAssembly();
      String fullAppName = callingAssembly.GetName().CodeBase;
      appPath = Path.GetDirectoryName(fullAppName);
      updateFilePath = Path.Combine(appPath, "test.xml");
    }

    public void CheckForNewVersion()
    {
      Stream s;
      TransferManager tm = new TransferManager();
      if (tm.downloadFile(URL, out s, updateFilePath, null))
      {
        s.Close();
        this.performUpdate(s);

        this.removeFile(updateFilePath);
      }
    }

    protected bool performUpdate(Stream file)
    {
      Version currentVersion = callingAssembly.GetName().Version;
      XmlDocument xDoc = new XmlDocument();
      xDoc.Load(updateFilePath);
      XmlNodeList modules = xDoc.GetElementsByTagName("download");
      XmlNodeList versions = xDoc.GetElementsByTagName("version");
     
      Version newVersion = new Version(
        int.Parse(versions[0].Attributes["maj"].Value),
        int.Parse(versions[0].Attributes["min"].Value),
        int.Parse(versions[0].Attributes["bld"].Value));

      if (currentVersion.CompareTo(newVersion) < 0)
      {
        Logger.Instance.log("New Version available: " + newVersion.ToString());
        XmlNodeList messages = xDoc.GetElementsByTagName("message");
        XmlNodeList links = xDoc.GetElementsByTagName("link");
        String name = modules[0].Attributes["name"].Value;
        String link = links[0].InnerText;
        String message = messages[0].InnerText;
        Notification n = new Notification(name, message, newVersion.ToString(), link, callingAssembly);

        Logger.Instance.log("Version: " + newVersion);
        Logger.Instance.log("Message: " + message);
        Logger.Instance.log("Link: " + link);

        if (n.ShowDialog() == DialogResult.No)
        {
          n.Dispose();
          return false;
        }
        else
        {
          n.Dispose();
          return true;
        }
        
      }
      return true;
      //XmlReaderSettings settings = new XmlReaderSettings();
      //settings.ConformanceLevel = ConformanceLevel.Fragment;
      //settings.IgnoreWhitespace = true;
      //settings.IgnoreComments = true;
      //using (XmlReader reader = XmlReader.Create(file, settings))
      //{
      //  while (reader.Read())
      //  {
      //    if (reader.IsStartElement())
      //    {
      //      if (reader.IsEmptyElement)
      //        Logger.Instance.log(reader.Name);
      //      else
      //      {
      //        Logger.Instance.log(reader.Name);
      //        reader.Read(); // Read the start tag.
      //        if (reader.IsStartElement())  // Handle nested elements.
      //          Logger.Instance.log("\r\n"+ reader.Name);
      //        Logger.Instance.log(reader.ReadString());  //Read the text content of the element.
      //      }
      //    }
      //  }
      //}

    }

    #region Remove File
    protected bool removeFile(string FileName)
    {
      bool Ret = false;
      try
      {
        if (File.Exists(FileName) == false) { return true; }
        File.Delete(FileName);
        Ret = true;
      }
      catch (Exception) { throw; }
      return Ret;
    }
    #endregion

  }
}
