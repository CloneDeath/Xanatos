using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace Xanatos.Data
{
	public class VariableValue
	{
		public VariableValue()
		{
			Value = 0;
		}

		[DataMember]
		public object Value { get; set; }

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
