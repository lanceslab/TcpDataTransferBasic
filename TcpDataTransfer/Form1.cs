using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.IO;

namespace TcpDataTransfer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_start_server_Click(object sender, EventArgs e)
        {
            label2.Text = "Server Started...";
            TCPServer obj_server = new TCPServer();
            System.Threading.Thread obj_thread = new System.Threading.Thread(obj_server.StartServer);
            obj_thread.Start();
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            //TcpClient tc = new TcpClient("127.0.0.1", 11000);
            TcpClient tc = new TcpClient("127.0.0.1", 6868);
            NetworkStream ns = tc.GetStream();
            byte[] data_tosend = CreateDataPacket(Encoding.UTF8.GetBytes(tx_data_send.Text));
            ns.Write(data_tosend, 0, data_tosend.Length);
        }


        private byte[] CreateDataPacket(byte[] data)
        {
            byte[] initialize = new byte[1];
            initialize[0] = 2;
            byte[] separator = new byte[1];
            separator[0] = 4;
            byte[] dataLength = Encoding.UTF8.GetBytes(Convert.ToString(data.Length));
            MemoryStream ms = new MemoryStream();
            ms.Write(initialize, 0, initialize.Length);
            ms.Write(dataLength, 0, dataLength.Length);
            ms.Write(separator, 0, separator.Length);
            ms.Write(data, 0, data.Length);
            return ms.ToArray();
        }

    }



    class TCPServer
    {
        TcpListener obj_server;
        public TCPServer()
        {
            //obj_server = new TcpListener(IPAddress.Any, 11000);
            obj_server = new TcpListener(IPAddress.Any, 6868);
        }

        public void StartServer()
        {
            obj_server.Start();
            while (true)
            {
                TcpClient tc = obj_server.AcceptTcpClient();
                NetworkStream ns = tc.GetStream();
                if(ns.ReadByte() == 2)
                {
                    byte[] recv_data = ReadStream(ns);
                    // To access the form UserInterface. We need this!
                    Form1.ActiveForm.Invoke(new MethodInvoker(delegate
                    {
                        ((TextBox)Form1.ActiveForm.Controls.Find("tx_recv_data", true)[0]).Text = Encoding.UTF8.GetString(recv_data);//tx_data_send//tx_recv_data

                    }));
                }
            }          
        }


        public byte[] ReadStream(NetworkStream ns)
        {
            // Convert java code into C# !!!!!!!!!!!!!

            byte[] data_buff = null;

            int b = 0;
            String buff_length = "";
            while((b = ns.ReadByte()) != 4)
            {
                buff_length += (char)b;
            }
            int data_length = Convert.ToInt32(buff_length);
            data_buff = new byte[data_length];
            int byte_read = 0;
            int byte_offset = 0;
            while(byte_offset < data_length)
            {
                byte_read = ns.Read(data_buff, byte_offset, (data_length - byte_offset));

                byte_offset += byte_read;
            }

            return data_buff;
        }



    }




}

