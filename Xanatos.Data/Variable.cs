using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Xanatos.Data
{
	public class Variable
	{
		public Variable()
		{
			Name = "";
			Value = new VariableValue();
		}

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public VariableValue Value { get; set; }
	}
}
