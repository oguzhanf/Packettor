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
        

        private void UDPSendHandler(UdpIpTraceData obj)
        {
            LogToFile(

                "UDPSend," +
                obj.saddr.ToString() + "," +
                obj.sport.ToString() + "," +
                obj.daddr.ToString() + "," +
                obj.dport.ToString() + "," +
                obj.ProcessName + "," +
                obj.TimeStamp + "," +
                obj.size);
        }


    }
}
