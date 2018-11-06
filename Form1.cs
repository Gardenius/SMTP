using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Windows.Forms;

namespace SMTP
{
    public partial class Form1 : Form
    {
        public NetworkStream NetStrm;
        public StreamReader RdStrm;
        public TcpClient SmtpServ;

        public Form1()
        {
            InitializeComponent();
            SMTPServ.Text = "smtp.poczta.onet.pl";
            Port.Text = "25";
            From.Text = "testpop_3@onet.pl";
            To.Text = "testpop_3@onet.pl";
            Pass.Text = "Testowaniepop3";
        }

        private void Send_btn_Click(object sender, EventArgs e)
        {
            bool error = false;

            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(From.Text);
            string Login = System.Convert.ToBase64String(plainTextBytes);

            var plainTextBytes2 = System.Text.Encoding.UTF8.GetBytes(Pass.Text);
            string Password = System.Convert.ToBase64String(plainTextBytes2);

            Status.Items.Clear();

            string Data;
            byte[] szData;
            string CRLF = "\r\n";
            try
            {
                SmtpServ = new TcpClient(SMTPServ.Text, Int32.Parse(Port.Text));
                NetStrm = SmtpServ.GetStream();
                RdStrm = new StreamReader(SmtpServ.GetStream());
                Status.Items.Add(RdStrm.ReadLine());
            }
            catch
            {
                Status.Items.Clear();
                error = true;
                Status.Items.Add("Connection error.");
            }


            if(!error)
            {
                Data = "HELO Server" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());
            }

            if(!error)
            {
                Data = "AUTH LOGIN" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());

                Data = Login + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());

                Data = Password + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                string line = RdStrm.ReadLine();
                if (!line.StartsWith("2"))
                {
                    Status.Items.Clear();
                    error = true;
                    Status.Items.Add("Wrong email or password.");
                }
            }

            if (!error)
            {
                Data = "MAIL FROM:" + "<" + From.Text + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());

                Data = "RCPT TO:" + "<" + To.Text + ">" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                string line = RdStrm.ReadLine();
                if (!line.StartsWith("2"))
                {
                    Status.Items.Clear();
                    error = true;
                    Status.Items.Add("Wrong recipient.");
                }
            }

            if (!error)
            {
                Data = "DATA" + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());

                Data = "SUBJECT: " + Subject.Text + CRLF + Message.Text + CRLF + "." + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());

                Data = "QUIT " + CRLF;
                szData = System.Text.Encoding.ASCII.GetBytes(Data.ToCharArray());
                NetStrm.Write(szData, 0, szData.Length);
                Status.Items.Add(RdStrm.ReadLine());

                NetStrm.Close();
                RdStrm.Close();
                Status.Items.Add("Close connection.");
            }
            



            
            
        }
    }
}
