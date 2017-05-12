using System;
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
			foreach (var spyable_data in level_data.Data)
			{
				addEntity(new SpyableObject(spyable_data));
			}
		}
	}
}
