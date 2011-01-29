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
      String path = Path.GetDirectoryName(fullAppName);
      if (path.StartsWith("file:\\")) path = path.Substring(6);
      String logFile = Path.Combine(path, "update-log.txt");
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

