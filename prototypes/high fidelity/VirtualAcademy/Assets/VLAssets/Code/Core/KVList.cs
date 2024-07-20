using System;
using System.Collections.Generic;

namespace virtual_academy.core
{
	[Serializable]
	public class KVList<T, V>
	{
		public List<KVPair<T, V>> data=new List<KVPair<T, V>>();
		public Dictionary<T, V> ToMap()
		{
			Dictionary<T, V> _data = new Dictionary<T, V>();
			foreach (var item in data)
			{
				_data.Add(item.Key, item.Value);
			}
			return _data;
		}
	}
}