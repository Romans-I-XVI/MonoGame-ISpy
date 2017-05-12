using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Nez;

namespace ISpy
{
	public static class Levels
	{
		public static LevelData LivingRoom
		{
			get
			{
				var image_path = Content.Pictures.livingRoom;
				var data = new List<SpyableObjectData>
				{
					new SpyableObjectData(new Rectangle(314, 115, 523, 303), "Monitor", Content.Sounds.yay),
					new SpyableObjectData(new Rectangle(878, 471, 97, 63), "Mouse", Content.Sounds.yay),
					new SpyableObjectData(new Rectangle(287, 451, 53, 21), "Apple Logo", Content.Sounds.yay),
					new SpyableObjectData(new Rectangle(945, 0, 260, 179), "Lamp Shade", Content.Sounds.yay)
				};

				return new LevelData(image_path, data);
			}
		}
	}
}
