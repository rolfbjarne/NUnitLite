using System;
using System.Collections.Generic;

namespace System.Collections {
	internal class ArrayList : List<object> {
		public ArrayList ()
		{
		}

		public ArrayList (int capacity)
			: base (capacity)
		{
		}

		public ArrayList (IEnumerable<object> collection)
			: base (collection)
		{
		}

		public object [] ToArray (Type type)
		{
			if (type == typeof (string))
				return (string[]) base.ToArray ();

			throw new NotImplementedException ();
		}
	}
}

