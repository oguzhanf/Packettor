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
using System.Security.Cryptography;

namespace Packettor
{
    public partial class Form1 : Form
    {
        int sizeSent, sizeReceived, numSent, numReceived;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            sizeSent = 0;
            sizeReceived = 0;
            numSent = 0;
            numReceived = 0;
           

        }

        TraceEventSession kernelsession;
        void StartSession()
        {
            kernelsession.EnableKernelProvider(KernelTraceEventParser.Keywords.NetworkTCPIP);
            kernelsession.Source.Kernel.TcpIpSend += Kernel_TcpIpSend;
            kernelsession.Source.Kernel.TcpIpRecv += Kernel_TcpIpRecv;
            kernelsession.Source.Process();
        }


        private void Kernel_TcpIpRecv(TcpIpTraceData obj)
        {        
            Invoke(new dlgReceivePacketUpdate(ReceivePacketUpdateUI), new object[] { obj });
        }
        

        private void Kernel_TcpIpSend(TcpIpSendTraceData obj)
        {
            Invoke(new dlgSendPacketUpdate(SendPacketUpdateUI), new object[] { obj });
        }

        private delegate void dlgSendPacketUpdate(TcpIpSendTraceData obj);
        private delegate void dlgReceivePacketUpdate(TcpIpTraceData obj);
        System.Threading.Thread thr;
        private void btnStartMon_Click(object sender, EventArgs e)
        {
            thr = new System.Threading.Thread(new System.Threading.ThreadStart(StartSession));
            kernelsession = new TraceEventSession(KernelTraceEventParser.KernelSessionName);
            thr.Start();
        }

        private void btnStopMon_Click(object sender, EventArgs e)
        {
            kernelsession.Stop();
            thr.Abort();
                
        }

        void SendPacketUpdateUI(TcpIpSendTraceData obj)
        {
            sizeSent += obj.size;
            ++numSent;
            lblNumPacketsSent.Text = numSent.ToString();
            lblSizeSent.Text = sizeSent.ToString();
            textBox1.AppendText("SENT: " +
                                "Dest: " + obj.daddr.ToString() +
                                "Src: " + obj.saddr.ToString() +
                                "SPort: " + obj.sport.ToString() +
                                "DPort: " + obj.dport.ToString() +
                                "Size: " + obj.size.ToString() + 
                                "Seq: " + obj.seqnum.ToString() + 
                                "Process: " + obj.ProcessName +
                                "Hash: " + obj.GetHashCode().ToString() +
                                Environment.NewLine
                                );
            this.Text = kernelsession.EventsLost.ToString();
        }

        void ReceivePacketUpdateUI(TcpIpTraceData obj)
        {
            sizeReceived += obj.size;
            ++numReceived;
            lblNumPacketsReceived.Text = numReceived.ToString();
            lblSize.Text = sizeReceived.ToString();
            textBox1.AppendText("RECEIVED: " +
                                "\tDest: " + obj.daddr.ToString() +
                                "\tSrc: " + obj.saddr.ToString() +
                                "\tSPort: " + obj.sport.ToString() +
                                "\tDPort: " + obj.dport.ToString() +
                                "\tSize: " + obj.size.ToString() +
                                "\tSeq: " + obj.seqnum.ToString() +
                                "\tProcess: " + obj.ProcessName +
                                "\tHash: " + obj.Dump(true, false) + 
                                Environment.NewLine
                                );
            this.Text = kernelsession.EventsLost.ToString();
        }

        public static string CreateMD5(byte[] input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                //byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(input);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

    }
}
