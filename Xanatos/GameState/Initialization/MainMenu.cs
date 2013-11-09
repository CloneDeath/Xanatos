using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gwen.Control;

namespace Xanatos.GameState
{
	class MainMenu : IGameState
	{
		
		public void Initialize()
		{
			Base MainPage = new Base(MainCanvas.Instance);
			MainPage.Dock = Gwen.Pos.Fill;
			
			Label Title = new Label(MainPage);
			Title.Font = new Gwen.Font(MainCanvas.Renderer, "Consolas", 144);
			Title.Text = "Xanatos";
			Title.MakeColorBright();

			Button StartServer = new Button(MainPage);
			StartServer.SetPosition(10, 300);
			StartServer.Text = "Start Server";
			StartServer.Clicked += delegate(Base sender, ClickedEventArgs args) {
				Program.SwitchState(new GameState.Hosting());
			};

			Button Connect = new Button(MainPage);
			Connect.SetPosition(10, 330);
			Connect.Text = "Connect";
			Connect.Clicked += delegate(Base sender, ClickedEventArgs args) {
				Program.SwitchState(new GameState.Connect());
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
