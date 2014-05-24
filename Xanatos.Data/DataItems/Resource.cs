using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Xanatos.Data
{
	public class Resource : DataItem
	{
		[DataMember]
		[Category("Resource Attributes")]
		[DisplayName("Initial Value")]
		[Description("Initial Value of this Attribute")]
		public int Value { get; set; }
	}
}
