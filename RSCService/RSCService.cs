using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

using System.Diagnostics.Tracing;
using System.Drawing;





using Microsoft.Diagnostics.Symbols;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using Microsoft.Diagnostics.Tracing.Session;
using System.Security.Cryptography;


namespace RSCService
{
    public partial class RSCService : ServiceBase
    {
        TraceEventSession kernelsession;
        public RSCService()
        {
            InitializeComponent();
        }



        protected override void OnStart(string[] args)
        {
            try
            {
                kernelsession.EnableKernelProvider(KernelTraceEventParser.Keywords.NetworkTCPIP);
                kernelsession.Source.Kernel.TcpIpSend += TCPIPSendHandler;
                kernelsession.Source.Kernel.TcpIpRecv += TCPIPReceiveHandler;
                kernelsession.Source.Kernel.UdpIpRecv += UdpIpReceiveHandler;
                kernelsession.Source.Kernel.UdpIpSend += UdpIpSendHandler;
                kernelsession.Source.Process();
                //Create or re-use log file
            }
            catch (Exception InitializationError)
            {
                throw new Exception("Initialization failed: " + InitializationError);
            }
        }

    

        protected override void OnStop()
        {
            kernelsession.Stop();   
        }
       
    }
}
