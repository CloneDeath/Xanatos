using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Runtime.Serialization;
using System.ComponentModel;

namespace Xanatos.Data
{
	public class Tile : DataItem
	{
		[DataMember]
		[Category("Tile Info")]
		[Description("Color of the tile")]
		[DisplayName("Tile Color")]
		public Color Color { get; set; }
	}
}
