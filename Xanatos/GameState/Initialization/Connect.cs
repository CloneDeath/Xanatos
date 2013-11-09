using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;
using Lidgren.Network;
using System.Threading;
using Lidgren.Messages;
using Xanatos.Networking.Initialization;

namespace Xanatos.GameState
{
	class Connect : IGameState
	{
		public void Initialize()
		{
			TextBox IP = new TextBox(MainCanvas.Instance);
			IP.Text = "127.0.0.1";
			IP.SetPosition(10, 10);

			NumericUpDown Port = new NumericUpDown(MainCanvas.Instance);
			Port.Max = ushort.MaxValue;
			Port.Min = 0;
			Port.Value = 54987;
			Port.SetPosition(10, 40);

			Button Connect = new Button(MainCanvas.Instance);
			Connect.Text = "Connect";
			Connect.SetPosition(10, 70);
			Connect.Clicked += delegate(Base sender, ClickedEventArgs args) {
				NetPeerConfiguration config = new NetPeerConfiguration("Xanatos");
				Program.Connection = new NetClient(config);
				Program.Connection.Start();
				Program.Connection.Connect(IP.Text, (int)Port.Value);

				while (((NetClient)Program.Connection).ConnectionStatus != NetConnectionStatus.Connected) {
					Thread.Sleep(500);
					Program.Connection.ReadMessages(new List<NetIncomingMessage>());
				}
				Message.RegisterClient(Program.Connection);

				new PlayerJoining().Send();
			};
		}

		public void Uninitialize()
		{
			MainCanvas.Instance.DeleteAllChildren();
		}

		public void Draw2D(float dt)
		{
		}

		public void Update(float dt)
		{
		}
	}
}
