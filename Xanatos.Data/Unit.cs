using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Xanatos.Data
{
	public class Unit : DataItem
	{
		[DataMember]
		public int MaxHealth { get; set; }

		[DataMember]
		public double Speed { get; set; }
	}
}
