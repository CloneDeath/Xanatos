using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Drawing;

namespace Xanatos.Data
{
	public class MapInfo
	{
		[DataMember]
		[Category("Map Information")]
		[Description("Public name of this map")]
		[DisplayName("Map Name")]
		public string Name { get; set; }

		[DataMember]
		[Category("Map Information")]
		[Description("Size of the map")]
		[DisplayName("Map Size")]
		public Size Size { get; set; }
	}
}
