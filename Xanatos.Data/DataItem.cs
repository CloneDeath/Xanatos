﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Xanatos.Data
{
	public class DataItem
	{
		public DataItem()
		{
			CustomValues = new List<Variable>();
		}

		[DataMember]
		[Category("Base Data")]
		[Description("Internal Name of this Data Item")]
		[DisplayName("Name")]
		public string Name { get; set; }

		[DataMember]
		[Category("Base Data")]
		[Description("Public Display Name of this Data Item")]
		[DisplayName("Display Name")]
		public string DisplayName { get; set; }

		[DataMember]
		[Category("Base Data")]
		[Description("List of custom Variables for this Data Item")]
		[DisplayName("Custom Variables")]
		public List<Variable> CustomValues { get; set; }
	}
}
