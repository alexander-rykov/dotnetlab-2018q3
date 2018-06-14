using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosed
{
  //public class Logger
  //{
  //  public void LogToFile(string logText)
  //  {
  //    //save to file
  //  }
  //}

  public class MessageMailer
  {
    public MessageMailer()
    {
    }

    public void SendMessage(string message)
    {
      //send message logic
      File.AppendAllText("log.txt","MessageMailer was sent");
    }

    // solution is to create new ILogger interface for different logging logics and insert them by constryctor, or use abstract classes
  }
}
