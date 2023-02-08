using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Online4.Classes;

internal class Logger
{
    public string MessageError { get; private set; }

    public string MessageWarning { get; private set; }

    
    public Logger()
    {
        MessageError = "";
        MessageWarning = "";
    }

    public void Log(LogType type, string message)
    {
        switch (type)
        {
            case LogType.Error:
                LogWarning(message);
                break;
            case LogType.Info:
                break;
            case LogType.Warning:
                LogWarning(message);
                break;
            default:
                break;
        }
    }

    public void LogError(string message)
    {
        MessageError += message;
    }

    public void LogWarning(string message)
    {
        MessageWarning += message;
    }
}
