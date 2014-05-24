using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Xanatos.Data
{
	public class VariableValue
	{
		public VariableValue()
		{
			Value = 0;
		}

		public object Value { get; set; }

		public override string ToString()
		{
			return Value.ToString();
		}
	}
}
