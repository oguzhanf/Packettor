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
using System.IO;
using System.Configuration;
using System.Configuration.Install;
using System.Reflection;

namespace RSCService
{
    public partial class RSCService : ServiceBase
    {
        TraceEventSession kernelsession;
        StreamWriter logwriter;
        System.Threading.Thread thr;
        string logFileLocation;
        string logFileNameWPath;
        public RSCService()
        {
            InitializeComponent();
        }



        protected override void OnStart(string[] args)
        {

            try
            {
                //Create or re-use log file
                logFileLocation = "c:\\networkLogs";
                //create directory if it doesn't exist
                if (Directory.Exists(logFileLocation) == false)
                    Directory.CreateDirectory(logFileLocation);
                logFileNameWPath = logFileLocation + "\\TCPIPTraceData.csv";
                prepLogFile();
                thr = new System.Threading.Thread(new System.Threading.ThreadStart(startMonitoring));
                thr.Start();

            }
            catch (Exception InitializationError)
            {
                throw new Exception("Initialization failed: " + InitializationError);
            }
        }
        private void startMonitoring()
        {
            kernelsession = new TraceEventSession(KernelTraceEventParser.KernelSessionName);
            kernelsession.EnableKernelProvider(KernelTraceEventParser.Keywords.NetworkTCPIP);
            kernelsession.Source.Kernel.TcpIpSend += TCPSendHandler;
            kernelsession.Source.Kernel.TcpIpRecv += TCPReceiveHandler;
            kernelsession.Source.Kernel.UdpIpRecv += UDPReceiveHandler;
            kernelsession.Source.Kernel.UdpIpSend += UDPSendHandler;
            kernelsession.Source.Process();

        }


        protected override void OnStop()
        {
            thr.Abort();
            kernelsession.Stop();
            sw.Close();
        }

    }
}
