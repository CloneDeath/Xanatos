using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;
using Lidgren.Network;
using Lidgren.Messages;

namespace Xanatos.GameState
{
	class Hosting : IGameState
	{
		Label Status;
		public void Initialize()
		{
			Status = new Label(MainCanvas.Instance);
			Status.SetPosition(10, 10);
			Status.SetText("Waiting for opponent...");
			Status.MakeColorBright();

			Button cancel = new Button(MainCanvas.Instance);
			cancel.SetText("Cancel");
			cancel.SetPosition(10, 40);
			cancel.Clicked += delegate(Base sender, ClickedEventArgs args) {
				Program.SwitchState(new MainMenu());
			};

			NetPeerConfiguration Configuration = new NetPeerConfiguration("Xanatos");
			Configuration.Port = 54987;
			Configuration.MaximumConnections = 1;
			Program.Connection = new NetServer(Configuration);
			Program.Connection.Start();
			Message.RegisterServer(Program.Connection);
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
			if (Program.Connection.Connections.Count != 0) {
				Program.SwitchState(new Game());
			}
		}
	}
}
