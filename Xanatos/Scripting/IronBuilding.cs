using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xanatos.GameState.Overworld.Entities;
using Xanatos.GameState.Overworld;

namespace Xanatos.Scripting
{
	public class IronBuilding : IronEntity
	{
		internal Building Building
		{
			get
			{
				return this.Entity as Building;
			}
			set
			{
				this.Entity = (Entity)value;
			}
		}

		public IronBuilding(Building reference) : base(reference)
		{
		}
	}
}
