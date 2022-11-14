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
        //FileLogTraceListener LogTraceListener;
        StreamWriter sw;
        private void prepLogFile() 
        { 
            //LogTraceListener = new FileLogTraceListener();
            //LogTraceListener.LogFileCreationSchedule = LogFileCreationScheduleOption.Daily;
            //LogTraceListener.MaxFileSize = 1000000;
            //LogTraceListener.Location = LogFileLocation.Custom;
            //LogTraceListener.CustomLocation = logFileLocation;
            //LogTraceListener.DiskSpaceExhaustedBehavior = DiskSpaceExhaustedOption.DiscardMessages;
            //LogTraceListener.AutoFlush = true;  
            //LogTraceListener.IncludeHostName = true;    
            //LogTraceListener.Append = true;
            sw = new StreamWriter(logFileNameWPath);
            sw.AutoFlush= true;
            
        }
        int fileCursor = 0;
        int maxCursor = 1000000;
        private void LogToFile(string message)
        {
            //sw.BaseStream.Seek(fileCursor+256, SeekOrigin.Begin);
            //sw.WriteLine(message);
            if (fileCursor > maxCursor) { fileCursor = 0; }
            sw.BaseStream.Seek(fileCursor, SeekOrigin.Begin);
            message += "\r\n";
            sw.Write(message, 0, message.Length);
            fileCursor += message.Length ;
        }
    }
}
