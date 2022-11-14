using Microsoft.VisualBasic.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;


namespace RSCService
{
    public partial class RSCService : ServiceBase
    {
        
        StreamWriter sw;
        private void prepLogFile() 
        { 
            sw = new StreamWriter(logFileNameWPath, true);
            sw.AutoFlush= true;
            
        }
        int fileCursor = 0;
        int maxCursor = 1024 * 1024 * 1024;
        private void LogToFile(string message)
        {
            if (fileCursor > maxCursor) { fileCursor = 0; }
            sw.BaseStream.Seek(fileCursor, SeekOrigin.Begin);
            message += "::" + fileCursor.ToString() + "\r\n";
            sw.Write(message, 0, message.Length);
            fileCursor += message.Length ;
        }
    }
}
