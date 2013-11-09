using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.GameState.Overworld.Entities;
using Xanatos.GameState.Overworld;

namespace Xanatos.Scripting
{
	static class IronGame
	{
		public static Dictionary<string, Entity> Entities
		{
			get
			{
				return Entity.Entities;
			}
		}

		public static Building GetBuilding(string Name)
		{
			if (Entities.ContainsKey(Name)) {
				if (Entities[Name] is Building) {
					return Entities[Name] as Building;
				} else {
					throw new Exception("Tried to receive '" + Name + "' as a Building, when it is really a " + Entities[Name].GetType().Name + ".");
				}
			} else {
				Building ret = new Building();
				Entities[Name] = ret;
				return ret;
			}
		}

		public static Gameboard Battlefield
		{
			get
			{
				return GameInfo.Battlefield;
			}
		}
	}
}
