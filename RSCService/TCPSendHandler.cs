using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace RSCService
{
    public partial class RSCService : ServiceBase
    {
        

        private void TCPSendHandler(TcpIpSendTraceData traceData)
        {
            LogToFile(

                "TCPSend," +
                traceData.saddr.ToString() + "," +
                traceData.sport.ToString() + "," +
                traceData.daddr.ToString() + "," +
                traceData.dport.ToString() + "," +
                traceData.ProcessName + "," +
                traceData.TimeStamp + "," +
                traceData.size);
        }
    }
}
