using System;
using System.Collections.Generic;
using UnityEngine;
using virtual_academy.VAEnv;

namespace virtual_academy.core.Data
{
	[Serializable]
	public class MapMetadata
	{
		public string Name;
		public int SkyboxID;
		public int BaseMapID;
	}
	[Serializable]
	public class MapData
	{
		public List<PlacedObject> placedObjects;
	}
	public struct FLOAT3
	{
		public float x;
		public float y;
		public float z;

		public FLOAT3(float x, float y, float z)
		{
			this.x = x;
			this.y = y;
			this.z = z;
		}

		public static implicit operator FLOAT3(Vector3 v)
		{
			return new FLOAT3(v.x, v.y, v.z);
		}
		public static implicit operator Vector3(FLOAT3 v)
		{
			return new Vector3(v.x, v.y, v.z);
		}
	}
	public struct FLOAT4
	{
		public float x;
		public float y;
		public float z;
		public float w;

		public FLOAT4(float x, float y, float z, float w)
		{
			this.x = x;
			this.y = y;
			this.z = z;
			this.w = w;
		}

		public static implicit operator FLOAT4(Quaternion v)
		{
			return new FLOAT4(v.x, v.y, v.z, v.w);
		}
		public static implicit operator Quaternion(FLOAT4 v)
		{
			return new Quaternion(v.x, v.y, v.z, v.w);
		}
	}
}
