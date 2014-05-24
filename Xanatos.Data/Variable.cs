using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Xanatos.Data
{
	public class Variable
	{
		public Variable()
		{
			Name = "";
			Value = new VariableValue();
		}

		public string Name { get; set; }
		public VariableValue Value { get; set; }
	}
}
