using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security;
using System.Diagnostics;
using System.Windows.Forms;
using System.IO.Pipes;
using System.IO;
using System.Threading;

namespace EnvVarsManager
{
  /// <summary>
  /// Class that make real work.
  /// Tries to execute command from the current process and if there are not enough privileges
  /// spawn child process with more privileges and delegate execution to it.
  /// </summary>
  public class Worker
  {
    private const string kServerName = ".";
    private const string kPipeName = "EnvVarsManagerPipe";

    /// <summary>
    /// Trivial cmd name/params delimiter
    /// </summary>
    public const string kCmdDelimiter = "@@@";

    /// <summary>
    /// Child worker process
    /// </summary>
    private Process mChildWorker = null;

    /// <summary>
    /// Server-side pipe
    /// </summary>
    private NamedPipeServerStream mPipeServer = null;
    /// <summary>
    /// Client-side pipe
    /// </summary>
    private NamedPipeClientStream mPipeClient = null;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="cmd"></param>
    /// <returns></returns>
    public bool DoCommand(string cmd)
    {
      bool result = false;

      try
      {
        result = DoCommandPrivate(cmd);
      }
      catch (SecurityException)
      {
        // delegate command to the child process
        result = DoCommandDelegate(cmd);
      }
      catch (Exception)
      {
      }

      return result;
    }

    public void RunCommandClient()
    {
      if (!SetupClientPipe())
        return;

      StreamString streamString = new StreamString(mPipeClient);

      while (true)
      {
        try
        {
          // Read command
          string cmd = streamString.ReadString();
          if (cmd == null)
            break;

          if (cmd == "QUIT")
            break;

          // Execute command
          bool result = false;
          try
          {
            result = DoCommandPrivate(cmd);
          }
          catch (Exception)
          {
          }

          // Send the result back
          streamString.WriteString(result ? "true" : " false");
        }
        catch (Exception)
        {
          break;
        }

        Thread.Sleep(50);
      }
    }

    private static bool DoCommandPrivate(string cmd)
    {
      string[] tokens = cmd.Split(new string[] { kCmdDelimiter }, StringSplitOptions.None);
      if (tokens.Length == 0)
        return false;

      if (tokens[0] == "SetEnvironmentVariable")
      {
        string name = tokens.Length > 0 ? tokens[1] : null;
        string value = tokens.Length > 1 ? tokens[2] : null;
        EnvironmentVariableTarget target = (tokens.Length > 2 && tokens[3] == "Machine") ? EnvironmentVariableTarget.Machine : EnvironmentVariableTarget.User;
        Environment.SetEnvironmentVariable(name, value, target);
      }

      return true;
    }

    private bool DoCommandDelegate(string cmd)
    {
      if (!SetupServerPipe())
        return false;
      if (!SpawnChildProcess(false))
        return false;

      if (!mPipeServer.IsConnected)
      {
        mPipeServer.WaitForConnection();
        Debug.WriteLine("Child process connected.");
      }

      bool result = false;
      try
      {
        result = ExecuteCommandViaPipe(cmd);
      }
      catch (Exception e)
      {
        Debug.WriteLine("ERR: {0}", e.Message);
      }

      return result;
    }

    private bool ExecuteCommandViaPipe(string cmd)
    {
      StreamString streamString = new StreamString(mPipeServer);

      // Send command.
      streamString.WriteString(cmd);

      // Wait for cmd read
      mPipeServer.WaitForPipeDrain();

      // Read response
      string resultStr = streamString.ReadString();

      return resultStr == "true";
    }

    private bool SpawnChildProcess(bool force)
    {
      if (force && mChildWorker != null)
      {
        mChildWorker.Kill();
        mChildWorker = null;
      }

      if (mChildWorker != null && !mChildWorker.HasExited)
        return true;

      // Launch itself as administrator
      mChildWorker = new Process();
      mChildWorker.StartInfo.Arguments = "/worker";
      mChildWorker.StartInfo.UseShellExecute = true;
      mChildWorker.StartInfo.WorkingDirectory = Environment.CurrentDirectory;
      mChildWorker.StartInfo.FileName = Application.ExecutablePath;
      mChildWorker.StartInfo.Verb = "runas";

      try
      {
        mChildWorker.Start();
      }
      catch
      {
        // The user refused the elevation.
        // Do nothing and return directly ...
        Debug.WriteLine("ERR: Child process creation error.");

        return false;
      }

      Debug.WriteLine("Child process created.");

      return true;
    }

    private bool SetupServerPipe()
    {
      if (mPipeServer != null)
        return true;

      mPipeServer = new NamedPipeServerStream(kPipeName, PipeDirection.InOut, NamedPipeServerStream.MaxAllowedServerInstances, PipeTransmissionMode.Message);

      Debug.WriteLine("NamedPipeServerStream object created.");

      return true;
    }

    private bool SetupClientPipe()
    {
      if (mPipeClient != null)
        return true;

      mPipeClient = new NamedPipeClientStream(kServerName, kPipeName, PipeDirection.InOut);
      Debug.WriteLine("NamedPipeClientStream object created.");

      mPipeClient.Connect();
      Debug.WriteLine("Connected to pipe.");

      Debug.WriteLine("There are currently {0} pipe server instances open.", mPipeClient.NumberOfServerInstances);

      return true;
    }
  }
}
