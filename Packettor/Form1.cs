using System;
using System.Diagnostics.Tracing; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Diagnostics.Symbols;
using Microsoft.Diagnostics.Tracing;
using Microsoft.Diagnostics.Tracing.Parsers;
using Microsoft.Diagnostics.Tracing.Parsers.Kernel;
using Microsoft.Diagnostics.Tracing.Session;

namespace Packettor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //if (!(TraceEventSession.IsElevated() == false))
            //{
            //    MessageBox.Show("Restart as administrator to run this application.");
            //    Environment.Exit(2);
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            sizeSent = 0;
            sizeReceived = 0;
            numSent = 0;
            numReceived = 0;
            System.Threading.Thread thr = new System.Threading.Thread(new System.Threading.ThreadStart(startSession));
            thr.Start();
            
        }
        void startSession()
        {
            using (var kernelsession = new TraceEventSession(KernelTraceEventParser.KernelSessionName))
            {
                kernelsession.EnableKernelProvider(KernelTraceEventParser.Keywords.NetworkTCPIP);
                kernelsession.Source.Kernel.TcpIpSend += Kernel_TcpIpSend;
                kernelsession.Source.Kernel.TcpIpRecv += Kernel_TcpIpRecv;
                
                kernelsession.Source.Process();
            }
        }
        int sizeSent, sizeReceived, numSent, numReceived;
        private void Kernel_TcpIpRecv(TcpIpTraceData obj)
        {
            sizeReceived += obj.size;
            ++numReceived;
            Invoke(new dlgUpdateui(updateui));
        }

        private void Kernel_TcpIpSend(TcpIpSendTraceData obj)
        {
            sizeSent += obj.size;
            ++numSent;
            Invoke(new dlgUpdateui(updateui));
        }
        delegate void dlgUpdateui();
        void updateui()
        {
            lblNumPacketsReceived.Text = numReceived.ToString();
            lblSize.Text = sizeReceived.ToString();
            lblNumPacketsSent.Text = numSent.ToString();
            lblSizeSent.Text = sizeSent.ToString();
        }
    }
}
