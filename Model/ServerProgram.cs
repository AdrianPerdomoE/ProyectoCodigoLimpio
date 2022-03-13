﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using ProyectoCodigoLimpioClient.Model;
using ProyectoCodigoLimpioClient.Net.IO;

namespace ProyectoCodigoLimpioServidor
{  
    public class ServerProgram
    {
        public static List<User> _Users;
        private TcpListener Listener;
        public ServerProgram(string ip, int port)
        {
            _Users = new List<User>();
            Listener = new TcpListener(IPAddress.Parse(ip),port);
            Listener.Start();
            while (true)
            {
                var client = new User(Listener.AcceptTcpClient());
                _Users.Add(client);
                BroadcastConnetion();
            }
        
        }
        public  static void BroadcastConnetion()
        {
            foreach ( User user in _Users)
            {
                foreach (User userIterator in _Users)
                {
                    PacketBuilder broadCastPacket = new PacketBuilder();
                    broadCastPacket.WriteOpCode(1);
                    broadCastPacket.WriteString(userIterator.UserName);
                    broadCastPacket.WriteString(userIterator.UserId.ToString());
                    user.ClientSocket.Client.Send(broadCastPacket.GetPacketBytes());
                }
            }
        }
        public static void BroadcastMessage(string message)
        {

            foreach (User user in _Users)
            {
                PacketBuilder messagePacket = new PacketBuilder();
                messagePacket.WriteOpCode(5);
                messagePacket.WriteString(message);
                user.ClientSocket?.Client.Send(messagePacket.GetPacketBytes());
            }
        }
    }
}