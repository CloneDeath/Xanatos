using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Xanatos.Data
{
	public class Unit : DataItem
	{
		[DataMember]
		[Category("Unit Info")]
		[Description("Maximum Health of this Unit")]
		[DisplayName("Max Health")]
		public int MaxHealth { get; set; }

		[DataMember]
		[Category("Unit Info")]
		[Description("Number of tiles this unit can move per turn.")]
		[DisplayName("Movement Speed")]
		public double Speed { get; set; }
	}
}
