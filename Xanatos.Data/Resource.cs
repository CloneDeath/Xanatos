using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Xanatos.Data
{
	public class Resource : DataItem
	{
		[Category("Resource Attributes")]
		[DisplayName("Initial Value")]
		[Description("Initial Value of this Attribute")]
		public int Value { get; set; }
	}
}
