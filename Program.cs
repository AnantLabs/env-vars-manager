using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using RJH.CommandLineHelper;
using System.Threading;

namespace EnvVarsManager
{

  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Parser parser = new Parser(System.Environment.CommandLine);
      parser.AddSwitch("worker", "Worker run mode");
      parser.Parse();

      if (parser["worker"] != null)
      {
        Thread.Sleep(5000);

        // run as child worker process
        Worker worker = new Worker();
        worker.RunCommandClient();
      }
      else
      {
        // run as primary gui app
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new MainForm());
      }
    }
  }
}
