using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Client
{
    public partial class Client : Form
    {
        public Client()
        {
            InitializeComponent();
            
               
           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Host = System.Net.Dns.GetHostName();
            string Myip = System.Net.Dns.GetHostByName(Host).AddressList[0].ToString();
            TcpClient Client = new TcpClient(Myip, 7000);
            NetworkStream stream = Client.GetStream();
            byte[] bytes = new byte[256];
            stream.Read(bytes, 0, bytes.Length);
            byte[] bytess = new byte[256];
            stream.Read(bytess, 0, bytess.Length);
            string data = Encoding.ASCII.GetString(bytes);
            //int b = stream.Length;
            textBox1.Text = data;
            label2.Text = "Client connect! " + bytess;
            label1.Text = Myip;
        }
    }
}
