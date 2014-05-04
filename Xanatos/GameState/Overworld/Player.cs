using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xanatos
{
	class Player
	{
		public int ID;
		private int p;

		public Player(int id)
		{
			this.ID = id;
		}

		public bool IsServer { get { return ID == 0; } }
	}
}
