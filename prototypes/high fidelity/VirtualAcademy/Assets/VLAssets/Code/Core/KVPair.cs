using System;

namespace virtual_academy.core
{
	[Serializable]
	public class KVPair<T, V>
	{
		public T Key;
		public V Value;
	}
}