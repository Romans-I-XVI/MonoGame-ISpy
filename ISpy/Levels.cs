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
		public static LevelData Kitchen
		{
			get
			{
				var image_path = Content.Pictures.kitchen;
				var data = new List<SpyableObjectData>
				{
					new SpyableObjectData(new Rectangle(162, 522, 98, 136), "A Dog", Content.Sounds.Kitchen.a_dog),
					new SpyableObjectData(new Rectangle(584, 126, 39, 45), "An Apple", Content.Sounds.Kitchen.a_apple),
					new SpyableObjectData(new Rectangle(788, 640, 38, 32), "A Cookie", Content.Sounds.Kitchen.a_cookie),
					new SpyableObjectData(new List<Rectangle>() { new Rectangle(414, 163, 44, 53), new Rectangle(917, 245, 33, 49) }, "A Horse", Content.Sounds.Kitchen.a_horsie),
					new SpyableObjectData(new Rectangle(951, 152, 32, 34), "A Muffin", Content.Sounds.Kitchen.a_muffin),
					new SpyableObjectData(new Rectangle(637, 528, 69, 52), "A Tractor", Content.Sounds.Kitchen.a_tractor),
					new SpyableObjectData(new List<Rectangle>() { new Rectangle(520, 303, 95, 76), new Rectangle(294, 277, 39, 41) }, "An Elephant", Content.Sounds.Kitchen.a_elephant),
					new SpyableObjectData(new Rectangle(253, 180, 55, 44), "A Pink Duck", Content.Sounds.Kitchen.a_pink_duck),
					new SpyableObjectData(new Rectangle(697, 238, 55, 61), "A Blue Plate", Content.Sounds.Kitchen.a_blue_plate),
					new SpyableObjectData(new Rectangle(616, 580, 115, 134), "A Faris Wheel", Content.Sounds.Kitchen.a_faris_wheel),
					new SpyableObjectData(new Rectangle(437, 501, 46, 55), "Mario", Content.Sounds.Kitchen.mario),
					new SpyableObjectData(new Rectangle(671, 94, 40, 63), "Two Tacos", Content.Sounds.Kitchen.two_tacos),
					new SpyableObjectData(new Rectangle(388, 259, 62, 55), "M for my mom", Content.Sounds.Kitchen.m_for_my_mom),
				};

				return new LevelData(image_path, data);
			}
		}
	}
}
