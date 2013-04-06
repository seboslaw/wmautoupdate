using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace WmAutoUpdate
{
  public class Logger
  {
    private static Logger instance;
    private static object syncRoot = new Object();
    private static System.IO.StreamWriter strWr;
    private static TextWriterTraceListener tr1;

    protected Logger()
    {
      Init();
    }

    protected virtual void Init()
    {
      tr1 = new TextWriterTraceListener(System.Console.Out);
      Debug.Listeners.Add(tr1);

      String fullAppName = Assembly.GetExecutingAssembly().GetName().CodeBase;
      String uri = Path.GetDirectoryName(fullAppName);
      if (uri.StartsWith("file:\\"))  uri = uri.Substring(6);
      if (uri.StartsWith("file:///")) uri = uri.Substring(8);
      if (uri.StartsWith("file:")) uri = uri.Substring(5);
      // That could be an absolute linux path - fix it
      if (uri[1] != ':' && uri[0] != '/' && uri[0] != '\\')
        uri = "/"+uri;

      String logFile = Path.Combine(uri, "update-log.txt");
      System.Console.WriteLine(logFile);

      strWr = new System.IO.StreamWriter(logFile, true, System.Text.Encoding.UTF8);
      TextWriterTraceListener tr2 = new TextWriterTraceListener(strWr);
      Debug.Listeners.Add(tr2);
      Debug.AutoFlush = true;
      this.log("----------------------------------------------------------------------------");
      this.log("----------------------------------------------------------------------------");
    }

    ~Logger()
    {
      //Logger.Instance.log("["+DateTime.Now.ToString() + "]: " + "----------------------------------------------------------------------------");
      //strWr.Dispose();
      //tr1.Dispose();
    }

    public static Logger Instance
    {
      get
      {
        if (instance == null)
        {
          lock (syncRoot)
          {
            if (instance == null)
              instance = new Logger();
          }
        }

        return instance;
      }
      set
      {
        instance = value;
      }
    }

    public virtual void log(string message)
    {
      lock (syncRoot)
      {
        Debug.WriteLine("[" + DateTime.Now.ToString() + "]: " + message);
      }
    }
  }

}

