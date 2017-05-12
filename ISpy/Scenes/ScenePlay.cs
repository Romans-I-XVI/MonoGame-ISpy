using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Nez;
namespace ISpy
{
	public class ScenePlay : Scene
	{
		public ScenePlay(LevelData level_data)
		{
            addRenderer(new DefaultRenderer());
			Core.scene = this;

			addEntity(new Player());
			addEntity(new ISpyPicture(level_data.ImagePath));

			var spyable_object_list = new List<SpyableObject>();
			foreach (var spyable_data in level_data.Data)
			{
				var new_spyable_object = new SpyableObject(spyable_data);
				addEntity(new_spyable_object);
				spyable_object_list.Add(new_spyable_object);
			}
			addEntity(new SpyableObjectControl(spyable_object_list));
		}
	}
}
