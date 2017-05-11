using System;
using Microsoft.Xna.Framework;
using Nez;
namespace ISpy
{
	public class ScenePlay : Scene
	{
		public ScenePlay()
		{
            addRenderer(new DefaultRenderer());
			addEntity(new Player());
			addEntity(new SpyableObject(new Rectangle(GameRoot.MinX, GameRoot.MinY, 100, 100)));
		}
	}
}
