﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Network;
using System.Reflection;
using System.Diagnostics;

namespace Lidgren.Messages
{
	public abstract partial class Message
	{
		static HostType ConnectionType;
		static NetPeer Connection;
		static NetConnection LastReceivedSender;

		static bool CanReply
		{
			get
			{
				return LastReceivedSender != null;
			}
		}

		public static void RegisterServer(NetPeer server)
		{
			ConnectionType = HostType.Server;
			Connection = server;
		}

		public static void RegisterClient(NetPeer client)
		{
			ConnectionType = HostType.Client;
			Connection = client;
		}

		public static void WaitForConnection()
		{
			while (Connection.Status != NetPeerStatus.Running) {
				Update();
			}
		}

		#region Reply
		public void Reply(NetDeliveryMethod method)
		{
			if (CanReply) {
				this.Send(LastReceivedSender, method);
			} else {
				throw new Exception("Can only reply in 'Execute' method of a Message."); //It's the only way we know who to reply to.
			}
		}
		public void Reply()
		{
			this.Reply(NetDeliveryMethod.ReliableUnordered);
		}
		#endregion

		#region Send
		public void Send()
		{
			this.Send(NetDeliveryMethod.ReliableOrdered);
		}

		public void Send(NetDeliveryMethod method)
		{
			this.Send(Connection, Connection.Connections, method);
		}

		private void Send(NetPeer peer, List<NetConnection> clients, NetDeliveryMethod method)
		{
			foreach (NetConnection conn in clients) {
				Send(peer, conn, method);
			}
		}

		private void Send(NetConnection destination)
		{
			this.Send(Connection, destination, NetDeliveryMethod.ReliableOrdered);
		}
		#endregion

		protected virtual int InitialMessageSize()
		{
			return 16;
		}

		private void Send(NetPeer peer, NetConnection destination, NetDeliveryMethod method)
		{
			NetOutgoingMessage nom = peer.CreateMessage(InitialMessageSize());
			nom.Write(this.GetType().FullName);
			this.WriteData(nom);
			peer.SendMessage(nom, destination, method);
		}

		private void Send(NetConnection destination, NetDeliveryMethod method)
		{
			this.Send(destination.Peer, destination, method);
		}

		public void Receive(NetIncomingMessage Message)
		{
			ReadData(Message);

			LastReceivedSender = Message.SenderConnection;
			ExecuteMessage();
			LastReceivedSender = null;
		}

		/// <summary>
		/// Sends the message to everyone EXCEPT the person who you would reply to.
		/// 
		/// Thus, this is a server only command. Sending it as a client does nothing.
		/// </summary>
		internal void Forward()
		{
			if (ConnectionType == HostType.Client) {
				//Do nothing
			} else {
				List<NetConnection> Replyto = new List<NetConnection>(
					Connection.Connections.Where((c) => { return c != LastReceivedSender; }
				));
				this.Send(Connection, Replyto, NetDeliveryMethod.ReliableUnordered);
			}
		}

		const BindingFlags AllFlags = BindingFlags.Instance | BindingFlags.FlattenHierarchy | BindingFlags.Public | BindingFlags.NonPublic;

		private void WriteData(NetOutgoingMessage Message)
		{
			MessageSerializer.Write(this, AllFlags, Message);
		}

		private void ReadData(NetIncomingMessage Message)
		{
			MessageSerializer.Read(this, AllFlags, Message);
		}

		static List<NetIncomingMessage> Messages = new List<NetIncomingMessage>();
		static Stopwatch timeout = new Stopwatch();
		public static int TimeoutMilliseconds = 100;
		public static void Update()
		{
			timeout.Restart();
			if (Connection != null) {
				Connection.ReadMessages(Messages);
				while (Messages.Count != 0 && timeout.ElapsedMilliseconds < TimeoutMilliseconds) {
					NetIncomingMessage msg = Messages[0];
					Messages.RemoveAt(0);

					Message.Handle(msg);
				}
			}
		}

		protected abstract void ExecuteMessage();
	}
}
