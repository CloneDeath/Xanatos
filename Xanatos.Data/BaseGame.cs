﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.IO;

namespace Xanatos.Data
{
	[DataContract]
	public class BaseGame
	{
		public string Name;

		public List<Unit> Units = new List<Unit>();
		public List<Resource> Resources = new List<Resource>();



		[IgnoreDataMember]
		private static DataContractSerializer serializer = new DataContractSerializer(typeof(BaseGame),
				new List<Type>() {
					// Extra Types
				},
				0x7FFF /*maxItemsInObjectGraph*/,
				false /*ignoreExtensionDataObject*/,
				true /*preserveObjectReferences : this is where the magic happens */,
				null /*dataContractSurrogate*/);

		public static BaseGame Load(string filename)
		{
			using (FileStream file = File.OpenRead(filename)) {
				return (BaseGame)serializer.ReadObject(file);
			}
		}

		public void Save(string filename)
		{
			using (FileStream file = File.Create(filename)) {
				serializer.WriteObject(file, this);
			}
		}
	}
}
