using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState.Overworld.Entities;

namespace Xanatos.Networking.Entity
{
	class AddBuilding : Message
	{
		string Name;

		public AddBuilding() { }
		public AddBuilding(string Name)
		{
			this.Name = Name;
		}

		protected override void ExecuteMessage()
		{
			GameState.Overworld.Entity.Entities[Name] = new Building(Name);
		}
	}
}
