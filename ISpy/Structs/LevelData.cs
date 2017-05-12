using System;
using System.Collections.Generic;

namespace ISpy
{
	public struct LevelData
	{
		public string ImagePath;
		public List<SpyableObjectData> Data;

		public LevelData(string image_path, List<SpyableObjectData> spyable_objects)
		{
			ImagePath = image_path;
			Data = spyable_objects;
		}
	}
}
