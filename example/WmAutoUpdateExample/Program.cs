using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using WmAutoUpdate;

namespace WmAutoUpdateExample
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [MTAThread]
    static void Main()
    {
      Updater updater = new Updater("http://www.myupdateurl.com/update.xml");
      updater.CheckForNewVersion();

      Application.Run(new Form1());
    }
  }
}