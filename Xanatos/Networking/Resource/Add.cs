using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lidgren.Messages;
using Xanatos.GameState.Overworld;

namespace Xanatos.Networking.Resource
{
	class Add : Message
	{
		string Name;

		public Add() { }
		public Add(string name)
		{
			this.Name = name;
		}

		protected override void ExecuteMessage()
		{
			ResourceManager.Resources.Add(Name, new GameState.Overworld.Resource(Name));
		}
	}
}
